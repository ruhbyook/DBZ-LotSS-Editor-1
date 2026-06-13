using HexTools;

namespace DBZ_LotSS_Editor
{
    public partial class Sprite_Flyers : Sprite_Control
    {
        public Sprite_Flyers()
        {
            InitializeComponent();
            InitializeControls();

            HexImage.AutoLoad = false;
        }

        public override HexListBox HexListBox => HexListBox1;

        public override Sprite_Palette[] SpritePalettes => new Sprite_Palette[]
        {
            new Sprite_Palette(HexImage, Palette1, ImportButton1, ExportButton1,
                (item) => item.Palette, (item, value) => item.Palette = (string) value)
        };

        protected override void SelectedIndexChanged()
        {
            if(CurrentDefinition != null)
            {
                var size = CurrentDefinition?.Size;

                HexImage.UnscaledHeight = size;
                HexImage.Length = size;

                HexImage.Load();
            }
        }
    }
}