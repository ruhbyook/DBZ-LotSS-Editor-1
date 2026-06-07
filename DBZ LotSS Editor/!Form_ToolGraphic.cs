using BasicTools;
using BasicTools.BasicControls;
using HexTools;
using HexTools.HexEnumerations;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DBZ_LotSS_Editor
{
    public partial class Form_ToolGraphic : HexForm
    {
        public Form_ToolGraphic()
        {
            InitializeComponent();

            HexImage.ViewAddress += HexImage_ViewAddress;
        }

        public bool HaveData
        {
            get
            {
                return HexStorage.IsOpen;
            }
        }

        private void LoadImage()
        {
            if (!HaveData) return;

            HexImage.Load();
        }

        private void InitializeControls()
        {
            ImagePanel.Enabled = HaveData;
            ControlPanelLeft.Enabled = HaveData;
            ControlPanelRight.Enabled = HaveData;

            HexImage.AutoLoad = false;
            SpriteOffset.Value = HexConvert.HexToInt(HexImage.HexOffset);
            PaletteOffset.Value = HexConvert.HexToInt(HexImage.PaletteOffset);
            TilesetOffset.Value = HexConvert.HexToInt(HexImage.SpritesetOffset);
            Compression.SelectedItem = HexImage.Compression.ToString();
            Encoding.SelectedItem = HexImage.Encoding.ToString();
            ColorDepth.SelectedItem = HexImage.ColorDepth.ToString();
            ZoomFactor.Value = (int) HexImage.Zoom.Width;
            HexImage.AutoLoad = true;
            WarningIcon = new Bitmap(SystemIcons.Warning.ToBitmap(), 16, 16);
        }

        private string ControlSpriteOffset;
        private string ControlPaletteOffset;
        private string ControlTilesetOffset;
        private float ControlZoomFactor;
        private CompressionType ControlCompression;
        private ImageEncodingType ControlEncoding;
        private ColorDepthType ControlColorDepth;

        private Bitmap WarningIcon;

        private static int _AddressableMaxMemory;
        private static int AddressableMaxMemory
        {
            get
            {
                if(_AddressableMaxMemory == 0)
                {
                    _AddressableMaxMemory = HexStorage.Memory != null ? 
                        HexStorage.Memory.Length - 0x200
                        : 0x00;
                }
                return _AddressableMaxMemory;
            }
        }

        private void SaveControls()
        {
            ControlSpriteOffset = HexImage.HexOffset;
            ControlPaletteOffset = HexImage.PaletteOffset;
            ControlTilesetOffset = HexImage.SpritesetOffset;
            ControlCompression = HexImage.Compression;
            ControlEncoding = HexImage.Encoding;
            ControlColorDepth = HexImage.ColorDepth;
            ControlZoomFactor = HexImage.Zoom.Width;
        }

        private void LoadControls()
        {
            HexImage.AutoLoad = false;
            SpriteOffset.Value = HexConvert.HexToInt(ControlSpriteOffset);
            PaletteOffset.Value = HexConvert.HexToInt(ControlPaletteOffset);
            TilesetOffset.Value = HexConvert.HexToInt(ControlTilesetOffset);
            Compression.SelectedItem = ControlCompression.ToString();
            Encoding.SelectedItem = ControlEncoding.ToString();
            ColorDepth.SelectedItem = ControlColorDepth.ToString();
            ZoomFactor.Value = (int) ControlZoomFactor;
            HexImage.AutoLoad = true;
        }

        private void ResetControls()
        {
            HexImage.AutoLoad = false;
            SpriteOffset.Value = 0x0;
            PaletteOffset.Value = 0x0;
            TilesetOffset.Value = 0x0;
            Compression.SelectedItem = CompressionType.LZ77_RLE.ToString();
            Encoding.SelectedItem = ImageEncodingType.FormatPlanar4BPP.ToString();
            ColorDepth.SelectedItem = ColorDepthType.FormatRGB555.ToString();
            ZoomFactor.Value = 1;
            HexImage.AutoLoad = true;
            LoadImage();
        }

        private bool PopulateDropdown<T>(BasicComboBox basicComboBox, string groupName = null) where T : Enum
        {
            if (basicComboBox.Items.Count == 0)
            {
                basicComboBox.Items.Clear();
                basicComboBox.Items.AddRange(Enum.GetValues(typeof(T))
                    .Cast<T>()
                    .Where(x => x.HasDisplayGroup(groupName))
                    .Select(Value =>
                        new BasicComboBoxItem(Value.DisplayName(), Value.ToString())
                    ));
                return true;
            }
            return false;
        }

        private void RefreshImageHeight()
        {
            ImageHeight.Maximum = AddressableMaxMemory - SpriteOffset.Value;
            var warningY = HexImage.Original.Height % 8 != 0;
            YLabelIcon.Width = warningY ? 32 : 0;
            YLabelIcon.Image = warningY ? WarningIcon : null;
        }

        private void Form_ToolImage_Load(object sender, EventArgs e)
        {
            SpriteOffset.Maximum = AddressableMaxMemory;
            PaletteOffset.Maximum = AddressableMaxMemory;
            TilesetOffset.Maximum = AddressableMaxMemory;
            HexImage.Load();
            RefreshImageHeight();
            PopulateDropdown<CompressionType>(Compression);
            PopulateDropdown<ImageEncodingType>(Encoding);
            if (PopulateDropdown<ColorDepthType>(ColorDepth, "SNES"))
            {
                InitializeControls();
            }
            SaveControls();
            RedrawSize();
            LoadImage();
        }

        private void Form_ToolImage_Closing(object sender, FormClosingEventArgs e)
        {

        }

        private void SpriteOffset_ValueChanged(object sender, EventArgs e)
        {
            HexImage.HexOffset = HexConvert.IntToHex((int) SpriteOffset.Value);
            RefreshImageHeight();
        }

        private void PaletteOffset_ValueChanged(object sender, EventArgs e)
        {
            HexImage.PaletteOffset = HexConvert.IntToHex((int)PaletteOffset.Value);
        }

        private void Compression_SelectedIndexChanged(object sender, EventArgs e)
        {
            HexImage.Compression = (CompressionType) Enum.Parse(typeof(CompressionType), Compression.SelectedItem.ToString());
        }

        private void Encoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            HexImage.Encoding = (ImageEncodingType) Enum.Parse(typeof(ImageEncodingType), Encoding.SelectedItem.ToString());
        }

        private void ColorDepth_SelectedIndexChanged(object sender, EventArgs e)
        {
            HexImage.ColorDepth = (ColorDepthType) Enum.Parse(typeof(ColorDepthType), ColorDepth.SelectedItem.ToString());
        }

        private void RedrawSize()
        {
            XLabel.Text = (HexImage.UnscaledWidth).ToString();
            var warningX = HexImage.UnscaledWidth % 16 != 0;
            XLabelIcon.Width = warningX ? 32 : 0;
            XLabelIcon.Image = warningX ? WarningIcon : null;
            
            ImageHeight.Value = HexImage.UnscaledHeight;
        }

        private void ImageHeight_ValueChanged(object sender, EventArgs e)
        {
            HexImage.UnscaledHeight = (int) ImageHeight.Value;
            RefreshImageHeight();
        }

        private void ZoomFactor_ValueChanged(object sender, EventArgs e)
        {
            HexImage.Zoom = new SizeF(ZoomFactor.Value, ZoomFactor.Value);
            //HexImage.Width = HexImage.Original.Width * (int) (HexImage.Zoom.Width + HexImage.Scale.Width - 1);
            //HexImage.Height = HexImage.Original.Height * (int)(HexImage.Zoom.Width + HexImage.Scale.Width - 1);
            RedrawSize();
        }

        private void HexImage_ViewAddress(object sender, EventArgs e)
        {
            HexImage.AutoLoad = false;
            ControlSpriteOffset = HexImage.HexOffset;
            SpriteOffset.Value = HexConvert.HexToInt(ControlSpriteOffset);
            HexImage.AutoLoad = true;
        }

        private void HexImage_SizeChanged(object sender, EventArgs e)
        {
            LoadImage();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            LoadControls();
            Close();
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            ResetControls();
        }

        private void HexImage_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var offset = GetOffsetAt(e.Location);
            }
        }

        private int GetOffsetAt(Point point)
        {
            return point.X * HexImage.Width * point.Y / ZoomFactor.Value;
        }

        private void Form_ToolGraphic_SizeChanged(object sender, EventArgs e)
        {
            
        }
    }
}