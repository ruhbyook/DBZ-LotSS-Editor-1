using HexTools;
using BasicTools;

namespace DBZ_LotSS_Editor
{
    public partial class Sprite_Portrait : Sprite_Control
    {
        public Sprite_Portrait()
        {
            InitializeComponent();
            InitializeControls();
        }

        public override HexListBox HexListBox => HexListBox1;

        public override Sprite_Palette[] SpritePalettes => new Sprite_Palette[]
        {
            new Sprite_Palette(HexImage1, Palette1, ImportButton1, ExportButton1,
                (item) => item.Palette1, (item, value) => item.Palette1 = (string) value, 4),
            new Sprite_Palette(HexImage2, Palette2, ImportButton2, ExportButton2,
                (item) => item.Palette2, (item, value) => item.Palette2 = (string) value, 4),
        };

        public override HexPanel ReferenceTable => this.GetControlByFullName("Form_EditorDatabase.TabControl1.TabBattlers." +
            "PanelBattlers.Database_Battlers.BasicListBoxAssociate1.HexPanel3") as HexPanel;

        public override HexListBox[] References => new HexListBox[]
        {
            this.GetControlByFullName("Form_EditorDatabase.TabControl1.TabBattlers.PanelBattlers.Database_Battlers.HexListBox1") as HexListBox,
            this.GetControlByFullName("Form_EditorDatabase.TabControl1.TabItems.PanelItems.Database_Items.HexListBox1") as HexListBox
        };
    }
}