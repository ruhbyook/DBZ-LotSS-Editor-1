using HexTools;
using System;
using System.Text;
using System.Linq;
using BasicTools;
using BasicTools.BasicControls;
using System.Windows.Forms;
using HexTools.HexEnumerations;
using System.ComponentModel;

namespace DBZ_LotSS_Editor
{
    public class Sprite_Control : HexUserControl
    {
        protected void InitializeControls()
        {
            HexStorage.OnDataRetrieve += HexStorage_OnDataRetrieve;
            HexListBox.SelectedIndexChanged += HexListBox_SelectedIndexChanged;
            foreach (var spritePalette in SpritePalettes)
            {
                spritePalette.Import.Click += (sender, args) => spritePalette.Image.Import(sender, args);
                spritePalette.Export.Click += (sender, args) => spritePalette.Image.Export(sender, args);
                spritePalette.Image.ImportConflict += (sender, args) => HexImage_ImportConflict(sender, args);
                spritePalette.Palette.SelectedIndexChanged += (sender, args) => SetPreviewPalette(
                    spritePalette.Palette,
                    spritePalette.Image,
                    spritePalette.Bank,
                    (item) => spritePalette.Getter?.Invoke(item),
                    (item, value) => spritePalette.Setter?.Invoke(item, value)
                );
            }
        }

        ~Sprite_Control()
        {
            HexStorage.OnDataRetrieve -= HexStorage_OnDataRetrieve;
        }

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public virtual HexListBox HexListBox { get; } = null;
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public dynamic CurrentDefinition => HexListBox.GetSelectedDefinition();
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public virtual Sprite_Palette[] SpritePalettes { get; } = new Sprite_Palette[0];

        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public virtual HexPanel ReferenceTable { get; } = null;
        [Browsable(false), EditorBrowsable(EditorBrowsableState.Never)]
        public virtual HexListBox[] References { get; } = new HexListBox[0];

        private void UpdateDependencies(int oldOffset, int newOffset)
        {
            var tableStart = HexConvert.HexToInt(ReferenceTable.HexOffset);
            var tableIndex = HexConvert.HexToInt(ReferenceTable.IndexOffset);

            oldOffset = HexConvert.PCToSnes(HexConvert.IntToHex(oldOffset), false);
            newOffset = HexConvert.PCToSnes(HexConvert.IntToHex(newOffset), true);

            var length = References.Sum(x => x.Items.Count);

            for (int i = 0; i < length; i++)
            {
                var offset = tableStart + tableIndex * i;
                var operation = MemoryLiterator.Read(offset + HexStorage.GlobalOffset, tableIndex);
                var buffer = operation.Buffer;
                Array.Reverse(buffer);
                var result = HexConvert.BytesToInt<int>(buffer);
                if (result == oldOffset)
                {
                    var newBytes = HexConvert.IntToBytes(newOffset, 3);
                    MemoryLiterator.Write(this, new MemoryOperation(operation.Offset, newBytes));
                }
            }

            My.MyProject.Forms.Form_Main.RefreshForm(My.MyProject.Forms.Form_EditorDatabase);
        }

        private void HexStorage_OnDataRetrieve()
        {
            var anyChanges = false;

            foreach (var control in SpritePalettes)
            {
                if (control.Palette.Items.Count == 0)
                {
                    control.Palette.RestockItems();
                    anyChanges = true;
                }
            }

            if (anyChanges) HexListBox_SelectedIndexChanged(null, null);
        }

        protected void SetPreviewPalette(BasicComboBox paletteControl, HexImage imageControl, int bank, Func<dynamic, string> getPaletteOffset, Action<dynamic, string> setPaletteOffset)
        {
            var offset = int.Parse(paletteControl.SelectedItem.ToString());
            StringBuilder hex;
            if (bank >= 0 && offset > 0)
            {
                hex = new StringBuilder(HexConvert.IntToHex(offset, 5));

                var hexBank = bank.ToString().PadLeft(2, '0');
                hex[2] = hexBank[0];
                hex[3] = hexBank[1];
            }
            else
            {
                hex = new StringBuilder(HexConvert.IntToHex(offset, 5));
            }
            var hexOffset = hex.ToString();
            imageControl.PaletteOffset = hexOffset;
            HexListBox.SetSelectedDefinition((item) =>
            {
                string originalPalette = getPaletteOffset(item);
                setPaletteOffset(item, offset > 0 ? HexConvert.HexToAddress(hexOffset) : null);
                return originalPalette != getPaletteOffset(item);
            });
        }

        protected void GetPreviewPalette(BasicComboBox paletteControl, int bank, string paletteHexOffset)
        {
            var palette = HexConvert.AddressToHex(paletteHexOffset);
            if (palette != null)
            {
                var hexOffset = new StringBuilder(palette);
                if(bank >= 0)
                {
                    var hexBank = bank.ToString();

                    hexOffset[2] = '0';
                    hexOffset[3] = '0';
                }
                var paletteOffset = (HexConvert.HexToInt(hexOffset.ToString())).ToString();
                var newIndex = paletteControl.Items.FirstOrDefault(x => x.Value == paletteOffset)?.Index;
                if (newIndex.HasValue)
                {
                    paletteControl.SelectedIndex = newIndex.Value;
                }
            }
            else
            {
                paletteControl.SelectedIndex = paletteControl.Items.Count - 1;
            }
        }

        private void HexListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var palette in SpritePalettes)
            {
                var target = HexListBox.GetSelectedDefinition();
                if(target != null)
                {
                    GetPreviewPalette(palette.Palette, palette.Bank, palette.Getter?.Invoke(target));
                }
            }
            SelectedIndexChanged();
        }

        protected virtual void SelectedIndexChanged() { }

        protected void ResolveConflict(MemoryConflict conflict, MemoryChunk location, bool partial = false)
        {
            conflict.Operation.Offset = (int)location.Address;
            if (conflict.Operation.Offset >= 0)
            {
                conflict.Resolve(this, true);
                HexStorage.UseChunk(location, partial
                    ? conflict.Operation.Buffer.LongLength - conflict.OriginalLength
                    : conflict.Operation.Buffer.LongLength);
                UpdateDependencies(
                    (int)conflict.OriginalOffset,
                    conflict.Operation.Offset
                );
                HexListBox.SetSelectedDefinition((item) =>
                {
                    string originalOffset = item.Offset;
                    item.Offset = HexConvert.IntToAddress(conflict.Operation.Offset);
                    return originalOffset != item.Offset;
                });
            }
        }

        private void HexImage_ImportConflict(object sender, MemoryConflict e)
        {
            var partiallyEmptyChunk = HexStorage.PartialEmptyChunk(e.Operation.Offset + e.Operation.Buffer.LongLength);
            if (partiallyEmptyChunk != null)
            {
                var test = true;
            }

            if (My.Settings.Default.DataManagement == DataManagementType.Manual)
            {
                if (MessageBox.Show("The new image is too large to fit into the space allocated for the original image." +
                Environment.NewLine + Environment.NewLine +
                "Please reduce the file size of the two sprites contained in this portrait entry or use a different address!" +
                Environment.NewLine + Environment.NewLine +
                "Would you like to select an an empty address now?",
                "Import Data Conflict", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    var selected = new Editor_AddressPicker()
                        .ShowAsTool(HexStorage.EmptyChunks(e.Operation.Buffer.LongLength).ToArray())
                        .Selected;
                    ResolveConflict(e, selected);
                }
            }
            else
            {
                ResolveConflict(e, HexStorage.EmptyChunk(e.Operation.Buffer.LongLength));
            }
        }
    }

    public delegate dynamic ControlBindingGetter(dynamic target);
    public delegate void ControlBindingSetter(dynamic target, object value);

    public class Sprite_Palette
    {
        public HexImage Image { get; }
        public BasicButton Import { get; }
        public BasicButton Export { get; }
        public BasicComboBox Palette { get; }
        public ControlBindingGetter Getter { get; }
        public ControlBindingSetter Setter { get; }
        public int Bank { get; }

        public Sprite_Palette(HexImage image, BasicComboBox palette, BasicButton import, BasicButton export, ControlBindingGetter getter, ControlBindingSetter setter, int bank = -1)
        {
            Image = image;
            Palette = palette;
            Import = import;
            Export = export;
            Getter = getter;
            Setter = setter;
            Bank = bank;
        }
    }
}
