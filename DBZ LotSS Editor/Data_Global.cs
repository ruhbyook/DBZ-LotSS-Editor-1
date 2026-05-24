using HexTools;
using System.Linq;

namespace DBZ_LotSS_Editor
{
    public partial class Data_Global : HexUserControl
    {
        public Data_Global()
        {
            InitializeComponent();

            MemoryLiterator.OnWrite += MemoryLiterator_OnWrite;
        }

        ~Data_Global()
        {
            MemoryLiterator.OnWrite -= MemoryLiterator_OnWrite;
        }

        private void MemoryLiterator_OnWrite(object sender, MemoryOperationAction e)
        {
            if (e.Control == ExpandStorage)
            {
                e.Resize(HexPanel1, ExpandStorage.Checked ? 0x400200 : 0x100200);
            }
            else if (e.Control == Character1 || e.Control == Character2)
            {
                var count = new[] { Character1, Character2 }.Count(x => !x.IsNull);
                e.Write(HexPanel1, new MemoryOperation(0x01EAAE + HexStorage.GlobalOffset, new byte[] { (byte) count }));
            }
        }
    }
}