------------------------------------------------------------------------------------------------------------------------
-- dbz.lua - Script pour lua-interface 0.8
-- Auteur      : BahaBulle
-- Jeu         : Dragon Ball Z - Super Saiya Densetsu
-- Description : Decompressor and compressor
------------------------------------------------------------------------------------------------------------------------
-- Historique des versions
--
-- 1.1 - 03/12/2012
-- Add sprite mode
-- 1.0 - 02/06/2012
-- Initialisation
------------------------------------------------------------------------------------------------------------------------

loadmodule "luahandle"
loadmodule "lualibs"

------------------------------------------------------------------------------------------------------------------------

DIRECTORY  = ""
ROM_IN     = "DBZ-16MB-PROPRE.smc"
ROM_OUT    = "DBZ-16MB-PROPRE-OUT.smc"

DECOMP_LOG = "dbz-decomp.log"
COMP_LOG   = "dbz-comp.log"

DEBUG      = false

------------------------------------------------------------------------------------------------------------------------

function ToFile(buf, name)

   local file_out = Output(name)

   file_out:copyfrom(buf)

   file_out:destroy()

end

function DBZDecompData(rom_in, adress)

   if DEBUG then file_log = Output(DECOMP_LOG) end

   rom_in:seek(adress)

   if DEBUG then file_log:write(string.format('Decompression des donnees en 0x%X\n', adress)) end

   local size_out = rom_in:readU16()
   print(string.format('  0x%X octets a decompresser', size_out))
   if DEBUG then file_log:write(string.format('0x%X octets a decompresser\n', size_out)) end

   local buf_out = Buffer(true)
   local pos_out = 0
   while size_out > 0 do
      local header = rom_in:readU8()
      if DEBUG then file_log:write(string.format('\nHeader %08X : %02X - %s\n', rom_in:tell()-1, header, HexToBin(header))) end

      for i = 1, 8 do
         if bit.band(header, 0x01) == 0 then
            local bytes = rom_in:readU16()
            local nb    = bit.band(bytes, 0x0F) + 3
            local back  = bit.rshift(bytes, 4)
            local pos   = pos_out - back

            if DEBUG then file_log:write(string.format('  %d - COMP      : 0x%04X\n', i, bytes)) end
            if DEBUG then file_log:write(string.format('      NB        : %d (0x%02X)\n', nb, nb)) end
            if DEBUG then file_log:write(string.format('      BACK      : 0x%04X\n', back)) end
            if DEBUG then file_log:write(string.format('      POS       : %d (0x%X)\n', pos, pos)) end

            if pos < 0 then
               local val = bit.band(bit.bnot(pos), 0xFF)

               if DEBUG then file_log:write("      WRITE 1   : ") end
               while val >= 0 and nb > 0 do
                  buf_out:writeU8(0)
                  if DEBUG then file_log:write("00 ") end
                  size_out = size_out - 1
                  pos_out  = pos_out + 1
                  val = val - 1
                  nb  = nb - 1
               end
               for j = 1, nb do
                  buf_out:writeU8(buf_out[j-1])
                  if DEBUG then file_log:write(string.format('%02X ', buf_out[pos_out])) end
                  size_out = size_out - 1
                  pos_out  = pos_out + 1
               end
               if DEBUG then file_log:write("\n") end
            else
               if DEBUG then file_log:write("      WRITE 2   : ") end
               for j = 0, nb-1 do
                  buf_out:writeU8(buf_out[pos+j])
                  if DEBUG then file_log:write(string.format('%02X ', buf_out[pos_out])) end
                  size_out = size_out - 1
                  pos_out  = pos_out + 1
               end
               if DEBUG then file_log:write("\n") end
            end
         else
            buf_out:writeU8(rom_in:readU8())
            if DEBUG then file_log:write(string.format('  %d - WRITE     : %02X\n', i, buf_out[pos_out])) end
            size_out = size_out - 1
            pos_out  = pos_out + 1
         end

         header = bit.rshift(header, 1)
         if size_out <= 0 then break end
      end
   end

   if DEBUG then file_log:destroy() end

   return buf_out

end

function HexToBin(val)

   local ret = ""

   for i = 1, 8 do
      if bit.band(val, 0x80) == 0 then
         ret = ret .. "0"
      else
         ret = ret .. "1"
      end

      val = bit.lshift(val, 1)
   end

   return ret

end

function SearchLZ(buf, pos, size)

   local nb = 0
   local nb_save = 0
   local pos_save = 0

   local pos_in = pos - 1

   while pos_in ~= pos - 4095 and nb_save ~= 18 do
      local nb = 0
      while buf[pos_in+nb] == buf[pos+nb] and nb < 18 and pos+nb < size do
         nb = nb + 1
      end

      if nb > nb_save and nb > 2 then
         nb_save = nb
         pos_save = pos_in
      else
         pos_in = pos_in - 1
      end
   end

   return nb_save, pos_save

end

function SearchLZ2(buf, pos)

   local nb = 0
   local nb_save = 0
   local pos_save = 0

   local pos_in = 0
   if pos > 4095 then pos_in = pos - 4095 end

   while pos_in < pos and nb_save ~= 18 do
      local nb = 0
      while buf[pos_in+nb] == buf[pos+nb] and nb < 18 and pos_in < pos do
         nb = nb + 1
      end

      if nb > nb_save and nb > 2 then
         nb_save = nb
         pos_save = pos_in
      else
         pos_in = pos_in + 1
      end
   end

   return nb_save, pos_save

end

function SearchRLE(buf, pos, size)

   local nb = 0
   local pos_in = pos

   if pos < 0x1000 and buf[pos_in] == 0x00 then
      while nb < 18 and buf[pos_in] == 0x00 and pos_in < size do
         nb = nb + 1
         pos_in = pos_in + 1
      end
   end

   if nb >= 3 then
      return nb
   else
      return 0
   end

end

------------------------------------------------------------------------------------------------------------------------

function DBZCompData(buf_in)

   if DEBUG then file_log = Output(COMP_LOG) end

   local comp_max = 18

   local buf_out = Buffer(true)

   local filesize = buf_in:getsize()
   if DEBUG then file_log:write(string.format('0x%X octets a compresser\n\n', filesize)) end

   local dic = {}
   local window = {}
   local nb  = 0

   local pos_in  = 0
   local header = 0
   while pos_in < filesize do
      if DEBUG then file_log:write(string.format('Read %08X : %02X\n', pos_in, buf_in[pos_in])) end

      local nb, pos_lz = FindSuite(buf_in, pos_in, dic, filesize)
      if DEBUG then file_log:write(string.format('  Find %d in 0x%X\n', nb, (pos_lz or -1))) end

      if nb < 3 then
         header = header + bit.lshift(1, #window)
         table.insert(window, { val = buf_in[pos_in] })
         if DEBUG then file_log:write(string.format('  New byte %02X (->%02X)\n', buf_in[pos_in], header)) end
         pos_in = pos_in + 1
      else
         table.insert(window, { from = pos_lz, to = pos_in, nb = nb })
         pos_in = pos_in + nb
      end

      if #window == 8 then
         if DEBUG then file_log:write(string.format('  Write : %02X ', header)) end
         buf_out:writeU8(header)
         for _, entry in pairs(window) do
            if entry.val then
               if DEBUG then file_log:write(string.format('%02X ', entry.val)) end
               buf_out:writeU8(entry.val)
            else
               local bytes = bit.band(bit.bor(entry.nb - 3, bit.lshift(entry.to - entry.from, 4)), 0xFFFF)
               if DEBUG then file_log:write(string.format('%04X ', bytes)) end
               buf_out:writeU16(bytes)
            end
         end
         window = {}
         header = 0
         if DEBUG then file_log:write("\n\n") end
      end
   end

   if DEBUG then file_log:destroy() end

   return buf_out, filesize

end

function FindSuite(buf, pos_in, dic, filesize)

   local nb  = 0
   local pos = pos_in
   local pos_lz
   local limit = 0
   if pos_in >= 0x1000 then limit = pos_in - 0xFFF end

   local byte  = buf[pos]
   local sbyte = string.char(byte)

   while dic[sbyte] and dic[sbyte].pos >= limit and nb < 18 and pos+nb < filesize do
      pos_lz = dic[sbyte].pos

      ListEntry(buf, pos+nb, dic)
      nb = nb + 1

      sbyte = sbyte .. string.char(buf[pos+nb])
   end
   if nb == 0 then ListEntry(buf, pos, dic) end

   return nb, pos_lz

end

function ListEntry(buf, pos_in, dic)

   local pos = pos_in - 17

   if pos < 0 then pos = 0 end

   while pos <= pos_in do
      local suite = ""
      local nb = 1
      for i = pos, pos_in do
         suite = suite .. string.char(buf[i])
         dic[suite] = { pos = pos }
      end
      pos = pos + 1
   end

end

------------------------------------------------------------------------------------------------------------------------

LIST_DATA = {
   { name = "Battle_Gohan_Sprite00.bin" , adr = 0x1D9729-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite01.bin" , adr = 0x1D97F9-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite02.bin" , adr = 0x1D98CE-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite03.bin" , adr = 0x1D99CC-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite04.bin" , adr = 0x1D9AAE-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite05.bin" , adr = 0x1D9B9A-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite06.bin" , adr = 0x1DA33D-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite07.bin" , adr = 0x1DA38D-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite08.bin" , adr = 0x1D9C25-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite09.bin" , adr = 0x1D9DB7-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite0A.bin" , adr = 0x1D9CBC-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite0B.bin" , adr = 0x1D9D41-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite0C.bin" , adr = 0x1D9D9A-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite0D.bin" , adr = 0x1D9DD5-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite0E.bin" , adr = 0x1D9E0E-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite0F.bin" , adr = 0x1DA421-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite10.bin" , adr = 0x1D9E64-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite11.bin" , adr = 0x1D9EB9-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite12.bin" , adr = 0x1D9F47-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite13.bin" , adr = 0x1DA048-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite14.bin" , adr = 0x1D9FE3-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite15.bin" , adr = 0x1DA110-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite16.bin" , adr = 0x1DA151-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite17.bin" , adr = 0x1DA1C4-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite18.bin" , adr = 0x1DA207-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite19.bin" , adr = 0x1DA23E-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite1A.bin" , adr = 0x1DA261-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite1B.bin" , adr = 0x1DA2BF-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite1C.bin" , adr = 0x1DA2FD-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite1D.bin" , adr = 0x1DA3CB-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite1E.bin" , adr = 0x1DA49B-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite1F.bin" , adr = 0x1DA7B7-0x0F0000, mode = "sprite" },
   { name = "Battle_Gohan_Sprite20.bin" , adr = 0x1DAB53-0x0F0000, mode = "sprite" },
}

------------------------------------------------------------------------------------------------------------------------

function dbzdecomp()

   local rom_in = Input(DIRECTORY .. ROM_IN)

   for _, data in ipairs(LIST_DATA) do
      print("Decompression of " .. data.name)
      local buf = DBZDecompData(rom_in, data.adr)

      if data.mode == "sprite" then
         local buf_out = Buffer(true)

         local nb = buf:getsize() / 16

         for i = 0, nb-1 do
            buf_out:writeU8(buf[0+i*16])
            buf_out:writeU8(buf[8+i*16])
            buf_out:writeU8(buf[1+i*16])
            buf_out:writeU8(buf[9+i*16])
            buf_out:writeU8(buf[2+i*16])
            buf_out:writeU8(buf[10+i*16])
            buf_out:writeU8(buf[3+i*16])
            buf_out:writeU8(buf[11+i*16])
            buf_out:writeU8(buf[4+i*16])
            buf_out:writeU8(buf[12+i*16])
            buf_out:writeU8(buf[5+i*16])
            buf_out:writeU8(buf[13+i*16])
            buf_out:writeU8(buf[6+i*16])
            buf_out:writeU8(buf[14+i*16])
            buf_out:writeU8(buf[7+i*16])
            buf_out:writeU8(buf[15+i*16])
         end

         ToFile(buf_out, DIRECTORY .. data.name)

         buf_out:destroy()
      else
         ToFile(buf, DIRECTORY .. data.name)
      end

      buf:destroy()
   end

   rom_in:destroy()

end

function dbzcomp()

   local rom_in  = Input(DIRECTORY .. ROM_IN)
   local rom_out = Buffer(true)
   rom_out:copyfrom(rom_in)

   for _, data in ipairs(LIST_DATA) do
      if exists(DIRECTORY .. data.name) then
         print("Compression de " .. data.name)

         local file_in = Input(DIRECTORY .. data.name)
         local buf_in = Buffer()
         buf_in:copyfrom(file_in)

         local buf, size
         if data.mode == "sprite" then
            local buf_out = Buffer(true)

            local nb = file_in:getsize() / 16

            for i = 0, nb-1 do
               buf_out:writeU8(buf_in[0+i*16])
               buf_out:writeU8(buf_in[2+i*16])
               buf_out:writeU8(buf_in[4+i*16])
               buf_out:writeU8(buf_in[6+i*16])
               buf_out:writeU8(buf_in[8+i*16])
               buf_out:writeU8(buf_in[10+i*16])
               buf_out:writeU8(buf_in[12+i*16])
               buf_out:writeU8(buf_in[14+i*16])
               buf_out:writeU8(buf_in[1+i*16])
               buf_out:writeU8(buf_in[3+i*16])
               buf_out:writeU8(buf_in[5+i*16])
               buf_out:writeU8(buf_in[7+i*16])
               buf_out:writeU8(buf_in[9+i*16])
               buf_out:writeU8(buf_in[11+i*16])
               buf_out:writeU8(buf_in[13+i*16])
               buf_out:writeU8(buf_in[15+i*16])
            end

            buf, size = DBZCompData(buf_out)

            buf_out:destroy()
         else
            buf, size = DBZCompData(buf_in)
         end
         file_in:destroy()
         buf_in:destroy()

         rom_out:wseek(data.adr)
         rom_out:writeU16(size)
         rom_out:copyfrom(buf)

         buf:destroy()
      end
   end

   ToFile(rom_out, DIRECTORY .. ROM_OUT)

   rom_out:destroy()
   rom_in:destroy()

end

------------------------------------------------------------------------------------------------------------------------
