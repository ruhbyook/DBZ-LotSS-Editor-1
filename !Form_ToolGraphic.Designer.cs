using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DBZ_LotSS_Editor
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form_ToolGraphic : HexTools.HexForm
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && components != null)
                {
                    components.Dispose();
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GraphicsViewerToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.XLabelIcon = new System.Windows.Forms.Label();
            this.YLabelIcon = new System.Windows.Forms.Label();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.HexImage = new HexTools.HexImage();
            this.ControlPanelRight = new System.Windows.Forms.FlowLayoutPanel();
            this.CompressionPanel = new BasicTools.BasicControls.BasicFlowLayoutPanel();
            this.CompressionLabel = new System.Windows.Forms.Label();
            this.Compression = new BasicTools.BasicControls.BasicComboBox();
            this.EncodingPanel = new BasicTools.BasicControls.BasicFlowLayoutPanel();
            this.EncodingLabel = new System.Windows.Forms.Label();
            this.Encoding = new BasicTools.BasicControls.BasicComboBox();
            this.ColorDepthPanel = new BasicTools.BasicControls.BasicFlowLayoutPanel();
            this.ColorDepthLabel = new System.Windows.Forms.Label();
            this.ColorDepth = new BasicTools.BasicControls.BasicComboBox();
            this.ZoomFactorPanel = new BasicTools.BasicControls.BasicFlowLayoutPanel();
            this.ZoomFactorLabel = new System.Windows.Forms.Label();
            this.ZoomFactor = new System.Windows.Forms.TrackBar();
            this.ControlPanelLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.SpriteOffsetPanel = new BasicTools.BasicControls.BasicFlowLayoutPanel();
            this.SpriteOffsetLabel = new System.Windows.Forms.Label();
            this.SpriteOffset = new BasicTools.BasicControls.BasicNumericBox();
            this.SizePanel = new BasicTools.BasicControls.BasicFlowLayoutPanel();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.ByLabel = new System.Windows.Forms.Label();
            this.ImageHeight = new BasicTools.BasicControls.BasicNumericBox();
            this.PaletteOffsetPanel = new BasicTools.BasicControls.BasicFlowLayoutPanel();
            this.PaletteOffsetLabel = new System.Windows.Forms.Label();
            this.PaletteOffset = new BasicTools.BasicControls.BasicNumericBox();
            this.TilesetOffsetPanel = new BasicTools.BasicControls.BasicFlowLayoutPanel();
            this.SpritesetOffsetLabel = new System.Windows.Forms.Label();
            this.TilesetOffset = new BasicTools.BasicControls.BasicNumericBox();
            this.ActionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.ImagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HexImage)).BeginInit();
            this.ControlPanelRight.SuspendLayout();
            this.CompressionPanel.SuspendLayout();
            this.EncodingPanel.SuspendLayout();
            this.ColorDepthPanel.SuspendLayout();
            this.ZoomFactorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomFactor)).BeginInit();
            this.ControlPanelLeft.SuspendLayout();
            this.SpriteOffsetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteOffset)).BeginInit();
            this.SizePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageHeight)).BeginInit();
            this.PaletteOffsetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaletteOffset)).BeginInit();
            this.TilesetOffsetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TilesetOffset)).BeginInit();
            this.ActionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GraphicsViewerToolTip
            // 
            this.GraphicsViewerToolTip.IsBalloon = true;
            // 
            // XLabelIcon
            // 
            this.XLabelIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XLabelIcon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.XLabelIcon.Location = new System.Drawing.Point(90, 7);
            this.XLabelIcon.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.XLabelIcon.Name = "XLabelIcon";
            this.XLabelIcon.Size = new System.Drawing.Size(0, 25);
            this.XLabelIcon.TabIndex = 4;
            this.XLabelIcon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GraphicsViewerToolTip.SetToolTip(this.XLabelIcon, "Width is not a multiple of 16, sprites will likely not render correctly.");
            // 
            // YLabelIcon
            // 
            this.YLabelIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.YLabelIcon.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.YLabelIcon.Location = new System.Drawing.Point(197, 7);
            this.YLabelIcon.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.YLabelIcon.Name = "YLabelIcon";
            this.YLabelIcon.Size = new System.Drawing.Size(0, 25);
            this.YLabelIcon.TabIndex = 5;
            this.YLabelIcon.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GraphicsViewerToolTip.SetToolTip(this.YLabelIcon, "Height is not a multiple of 8, sprites will likely not render correctly.");
            // 
            // ImagePanel
            // 
            this.ImagePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImagePanel.AutoScroll = true;
            this.ImagePanel.Controls.Add(this.HexImage);
            this.ImagePanel.Location = new System.Drawing.Point(27, 13);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(536, 194);
            this.ImagePanel.TabIndex = 14;
            // 
            // HexImage
            // 
            this.HexImage.AutoLoad = false;
            this.HexImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HexImage.DefaultPalette = new System.Drawing.Color[] {
        System.Drawing.Color.Fuchsia,
        System.Drawing.Color.Black,
        System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(2))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(4)))), ((int)(((byte)(4))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(6)))), ((int)(((byte)(6))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(7)))), ((int)(((byte)(7))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(9)))), ((int)(((byte)(9))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(46)))), ((int)(((byte)(46))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(67))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(71)))), ((int)(((byte)(71))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(82)))), ((int)(((byte)(82))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(83))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(87)))), ((int)(((byte)(87))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(95))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(97)))), ((int)(((byte)(97))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(98))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(104)))), ((int)(((byte)(104))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(106)))), ((int)(((byte)(106))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(111)))), ((int)(((byte)(111))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(113)))), ((int)(((byte)(113))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(118)))), ((int)(((byte)(118))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(122)))), ((int)(((byte)(122))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(124))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(125))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(134)))), ((int)(((byte)(134))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(137)))), ((int)(((byte)(137))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(139)))), ((int)(((byte)(139))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(143)))), ((int)(((byte)(143))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(144)))), ((int)(((byte)(144))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(145))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(148))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(149)))), ((int)(((byte)(149))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(152)))), ((int)(((byte)(152))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(154)))), ((int)(((byte)(154))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(162)))), ((int)(((byte)(162))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(164)))), ((int)(((byte)(164))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(165)))), ((int)(((byte)(165))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(167)))), ((int)(((byte)(167))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(172)))), ((int)(((byte)(172))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(178)))), ((int)(((byte)(178))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(179))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(181)))), ((int)(((byte)(181))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(183)))), ((int)(((byte)(183))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(190)))), ((int)(((byte)(190))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(198)))), ((int)(((byte)(198))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(199)))), ((int)(((byte)(199))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(201)))), ((int)(((byte)(201))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(213))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(253)))), ((int)(((byte)(253))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))))};
            this.HexImage.Location = new System.Drawing.Point(0, 0);
            this.HexImage.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.HexImage.Name = "HexImage";
            this.HexImage.Scale = new System.Drawing.Size(4, 4);
            this.HexImage.Single = false;
            this.HexImage.Size = new System.Drawing.Size(512, 192);
            this.HexImage.TabIndex = 0;
            this.HexImage.TabStop = false;
            this.HexImage.UnscaledHeight = 48;
            this.HexImage.UnscaledWidth = 128;
            this.HexImage.SizeChanged += new System.EventHandler(this.HexImage_SizeChanged);
            this.HexImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HexImage_MouseClick);
            // 
            // ControlPanelRight
            // 
            this.ControlPanelRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ControlPanelRight.Controls.Add(this.CompressionPanel);
            this.ControlPanelRight.Controls.Add(this.EncodingPanel);
            this.ControlPanelRight.Controls.Add(this.ColorDepthPanel);
            this.ControlPanelRight.Controls.Add(this.ZoomFactorPanel);
            this.ControlPanelRight.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ControlPanelRight.Location = new System.Drawing.Point(290, 213);
            this.ControlPanelRight.Margin = new System.Windows.Forms.Padding(4);
            this.ControlPanelRight.Name = "ControlPanelRight";
            this.ControlPanelRight.Padding = new System.Windows.Forms.Padding(7);
            this.ControlPanelRight.Size = new System.Drawing.Size(270, 182);
            this.ControlPanelRight.TabIndex = 13;
            // 
            // CompressionPanel
            // 
            this.CompressionPanel.Controls.Add(this.CompressionLabel);
            this.CompressionPanel.Controls.Add(this.Compression);
            this.CompressionPanel.Location = new System.Drawing.Point(10, 10);
            this.CompressionPanel.Name = "CompressionPanel";
            this.CompressionPanel.Size = new System.Drawing.Size(250, 36);
            this.CompressionPanel.TabIndex = 5;
            // 
            // CompressionLabel
            // 
            this.CompressionLabel.AutoSize = true;
            this.CompressionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompressionLabel.Location = new System.Drawing.Point(8, 0);
            this.CompressionLabel.Margin = new System.Windows.Forms.Padding(8, 0, 3, 0);
            this.CompressionLabel.Name = "CompressionLabel";
            this.CompressionLabel.Size = new System.Drawing.Size(113, 33);
            this.CompressionLabel.TabIndex = 0;
            this.CompressionLabel.Text = "Compression:";
            this.CompressionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Compression
            // 
            this.Compression.DisplayMember = "Text";
            this.Compression.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Compression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Compression.Location = new System.Drawing.Point(127, 3);
            this.Compression.Name = "Compression";
            this.Compression.Size = new System.Drawing.Size(120, 27);
            this.Compression.TabIndex = 1;
            this.Compression.ValueMember = "Value";
            this.Compression.SelectedIndexChanged += new System.EventHandler(this.Compression_SelectedIndexChanged);
            // 
            // EncodingPanel
            // 
            this.EncodingPanel.Controls.Add(this.EncodingLabel);
            this.EncodingPanel.Controls.Add(this.Encoding);
            this.EncodingPanel.Location = new System.Drawing.Point(10, 52);
            this.EncodingPanel.Name = "EncodingPanel";
            this.EncodingPanel.Size = new System.Drawing.Size(250, 36);
            this.EncodingPanel.TabIndex = 6;
            // 
            // EncodingLabel
            // 
            this.EncodingLabel.AutoSize = true;
            this.EncodingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncodingLabel.Location = new System.Drawing.Point(30, 0);
            this.EncodingLabel.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.EncodingLabel.Name = "EncodingLabel";
            this.EncodingLabel.Size = new System.Drawing.Size(83, 33);
            this.EncodingLabel.TabIndex = 0;
            this.EncodingLabel.Text = "Encoding:";
            this.EncodingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Encoding
            // 
            this.Encoding.DisplayMember = "Text";
            this.Encoding.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Encoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Encoding.Location = new System.Drawing.Point(119, 3);
            this.Encoding.Name = "Encoding";
            this.Encoding.Size = new System.Drawing.Size(121, 27);
            this.Encoding.TabIndex = 1;
            this.Encoding.ValueMember = "Value";
            this.Encoding.SelectedIndexChanged += new System.EventHandler(this.Encoding_SelectedIndexChanged);
            // 
            // ColorDepthPanel
            // 
            this.ColorDepthPanel.Controls.Add(this.ColorDepthLabel);
            this.ColorDepthPanel.Controls.Add(this.ColorDepth);
            this.ColorDepthPanel.Location = new System.Drawing.Point(10, 94);
            this.ColorDepthPanel.Name = "ColorDepthPanel";
            this.ColorDepthPanel.Size = new System.Drawing.Size(250, 36);
            this.ColorDepthPanel.TabIndex = 7;
            // 
            // ColorDepthLabel
            // 
            this.ColorDepthLabel.AutoSize = true;
            this.ColorDepthLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorDepthLabel.Location = new System.Drawing.Point(12, 0);
            this.ColorDepthLabel.Margin = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.ColorDepthLabel.Name = "ColorDepthLabel";
            this.ColorDepthLabel.Size = new System.Drawing.Size(104, 33);
            this.ColorDepthLabel.TabIndex = 0;
            this.ColorDepthLabel.Text = "Color Depth:";
            this.ColorDepthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorDepth
            // 
            this.ColorDepth.DisplayMember = "Text";
            this.ColorDepth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ColorDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorDepth.Location = new System.Drawing.Point(122, 3);
            this.ColorDepth.Name = "ColorDepth";
            this.ColorDepth.Size = new System.Drawing.Size(121, 27);
            this.ColorDepth.TabIndex = 1;
            this.ColorDepth.ValueMember = "Value";
            // 
            // ZoomFactorPanel
            // 
            this.ZoomFactorPanel.Controls.Add(this.ZoomFactorLabel);
            this.ZoomFactorPanel.Controls.Add(this.ZoomFactor);
            this.ZoomFactorPanel.Location = new System.Drawing.Point(10, 136);
            this.ZoomFactorPanel.Name = "ZoomFactorPanel";
            this.ZoomFactorPanel.Size = new System.Drawing.Size(250, 36);
            this.ZoomFactorPanel.TabIndex = 5;
            // 
            // ZoomFactorLabel
            // 
            this.ZoomFactorLabel.AutoSize = true;
            this.ZoomFactorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZoomFactorLabel.Location = new System.Drawing.Point(13, 7);
            this.ZoomFactorLabel.Margin = new System.Windows.Forms.Padding(13, 7, 3, 0);
            this.ZoomFactorLabel.Name = "ZoomFactorLabel";
            this.ZoomFactorLabel.Size = new System.Drawing.Size(108, 20);
            this.ZoomFactorLabel.TabIndex = 0;
            this.ZoomFactorLabel.Text = "Zoom Factor:";
            this.ZoomFactorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ZoomFactor
            // 
            this.ZoomFactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZoomFactor.LargeChange = 4;
            this.ZoomFactor.Location = new System.Drawing.Point(127, 3);
            this.ZoomFactor.Maximum = 23;
            this.ZoomFactor.Minimum = 1;
            this.ZoomFactor.Name = "ZoomFactor";
            this.ZoomFactor.Size = new System.Drawing.Size(104, 21);
            this.ZoomFactor.TabIndex = 6;
            this.ZoomFactor.Value = 1;
            this.ZoomFactor.Scroll += new System.EventHandler(this.ZoomFactor_ValueChanged);
            // 
            // ControlPanelLeft
            // 
            this.ControlPanelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ControlPanelLeft.Controls.Add(this.SpriteOffsetPanel);
            this.ControlPanelLeft.Controls.Add(this.SizePanel);
            this.ControlPanelLeft.Controls.Add(this.PaletteOffsetPanel);
            this.ControlPanelLeft.Controls.Add(this.TilesetOffsetPanel);
            this.ControlPanelLeft.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ControlPanelLeft.Location = new System.Drawing.Point(12, 212);
            this.ControlPanelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.ControlPanelLeft.Name = "ControlPanelLeft";
            this.ControlPanelLeft.Padding = new System.Windows.Forms.Padding(7);
            this.ControlPanelLeft.Size = new System.Drawing.Size(270, 183);
            this.ControlPanelLeft.TabIndex = 12;
            // 
            // SpriteOffsetPanel
            // 
            this.SpriteOffsetPanel.Controls.Add(this.SpriteOffsetLabel);
            this.SpriteOffsetPanel.Controls.Add(this.SpriteOffset);
            this.SpriteOffsetPanel.Location = new System.Drawing.Point(10, 10);
            this.SpriteOffsetPanel.Name = "SpriteOffsetPanel";
            this.SpriteOffsetPanel.Size = new System.Drawing.Size(250, 36);
            this.SpriteOffsetPanel.TabIndex = 3;
            // 
            // SpriteOffsetLabel
            // 
            this.SpriteOffsetLabel.AutoSize = true;
            this.SpriteOffsetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpriteOffsetLabel.Location = new System.Drawing.Point(17, 0);
            this.SpriteOffsetLabel.Margin = new System.Windows.Forms.Padding(17, 0, 3, 0);
            this.SpriteOffsetLabel.Name = "SpriteOffsetLabel";
            this.SpriteOffsetLabel.Size = new System.Drawing.Size(109, 32);
            this.SpriteOffsetLabel.TabIndex = 0;
            this.SpriteOffsetLabel.Text = "Sprite Offset:";
            this.SpriteOffsetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SpriteOffset
            // 
            this.SpriteOffset.Hexadecimal = true;
            this.SpriteOffset.Location = new System.Drawing.Point(132, 3);
            this.SpriteOffset.MaxLength = 3;
            this.SpriteOffset.Name = "SpriteOffset";
            this.SpriteOffset.Size = new System.Drawing.Size(100, 26);
            this.SpriteOffset.TabIndex = 5;
            this.SpriteOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SpriteOffset.ValueChanged += new System.EventHandler(this.SpriteOffset_ValueChanged);
            // 
            // SizePanel
            // 
            this.SizePanel.Controls.Add(this.SizeLabel);
            this.SizePanel.Controls.Add(this.XLabel);
            this.SizePanel.Controls.Add(this.XLabelIcon);
            this.SizePanel.Controls.Add(this.ByLabel);
            this.SizePanel.Controls.Add(this.ImageHeight);
            this.SizePanel.Controls.Add(this.YLabelIcon);
            this.SizePanel.Location = new System.Drawing.Point(10, 52);
            this.SizePanel.Name = "SizePanel";
            this.SizePanel.Size = new System.Drawing.Size(250, 36);
            this.SizePanel.TabIndex = 7;
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SizeLabel.Location = new System.Drawing.Point(20, 7);
            this.SizeLabel.Margin = new System.Windows.Forms.Padding(20, 7, 3, 0);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(47, 25);
            this.SizeLabel.TabIndex = 0;
            this.SizeLabel.Text = "Size:";
            this.SizeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.XLabel.Location = new System.Drawing.Point(70, 7);
            this.XLabel.Margin = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(20, 25);
            this.XLabel.TabIndex = 1;
            this.XLabel.Text = "X";
            this.XLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ByLabel
            // 
            this.ByLabel.AutoSize = true;
            this.ByLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ByLabel.Location = new System.Drawing.Point(94, 7);
            this.ByLabel.Margin = new System.Windows.Forms.Padding(4, 7, 0, 0);
            this.ByLabel.Name = "ByLabel";
            this.ByLabel.Size = new System.Drawing.Size(17, 25);
            this.ByLabel.TabIndex = 2;
            this.ByLabel.Text = "x";
            this.ByLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ImageHeight
            // 
            this.ImageHeight.Location = new System.Drawing.Point(114, 3);
            this.ImageHeight.MaxLength = 3;
            this.ImageHeight.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.ImageHeight.Name = "ImageHeight";
            this.ImageHeight.Size = new System.Drawing.Size(80, 26);
            this.ImageHeight.TabIndex = 6;
            this.ImageHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ImageHeight.Value = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.ImageHeight.ValueChanged += new System.EventHandler(this.ImageHeight_ValueChanged);
            // 
            // PaletteOffsetPanel
            // 
            this.PaletteOffsetPanel.Controls.Add(this.PaletteOffsetLabel);
            this.PaletteOffsetPanel.Controls.Add(this.PaletteOffset);
            this.PaletteOffsetPanel.Location = new System.Drawing.Point(10, 94);
            this.PaletteOffsetPanel.Name = "PaletteOffsetPanel";
            this.PaletteOffsetPanel.Size = new System.Drawing.Size(250, 36);
            this.PaletteOffsetPanel.TabIndex = 4;
            // 
            // PaletteOffsetLabel
            // 
            this.PaletteOffsetLabel.AutoSize = true;
            this.PaletteOffsetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaletteOffsetLabel.Location = new System.Drawing.Point(11, 0);
            this.PaletteOffsetLabel.Margin = new System.Windows.Forms.Padding(11, 0, 3, 0);
            this.PaletteOffsetLabel.Name = "PaletteOffsetLabel";
            this.PaletteOffsetLabel.Size = new System.Drawing.Size(117, 32);
            this.PaletteOffsetLabel.TabIndex = 0;
            this.PaletteOffsetLabel.Text = "Palette Offset:";
            this.PaletteOffsetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaletteOffset
            // 
            this.PaletteOffset.Hexadecimal = true;
            this.PaletteOffset.Location = new System.Drawing.Point(134, 3);
            this.PaletteOffset.MaxLength = 3;
            this.PaletteOffset.Name = "PaletteOffset";
            this.PaletteOffset.Size = new System.Drawing.Size(100, 26);
            this.PaletteOffset.TabIndex = 6;
            this.PaletteOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PaletteOffset.ValueChanged += new System.EventHandler(this.PaletteOffset_ValueChanged);
            // 
            // TilesetOffsetPanel
            // 
            this.TilesetOffsetPanel.Controls.Add(this.SpritesetOffsetLabel);
            this.TilesetOffsetPanel.Controls.Add(this.TilesetOffset);
            this.TilesetOffsetPanel.Location = new System.Drawing.Point(10, 136);
            this.TilesetOffsetPanel.Name = "TilesetOffsetPanel";
            this.TilesetOffsetPanel.Size = new System.Drawing.Size(250, 36);
            this.TilesetOffsetPanel.TabIndex = 5;
            // 
            // SpritesetOffsetLabel
            // 
            this.SpritesetOffsetLabel.AutoSize = true;
            this.SpritesetOffsetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SpritesetOffsetLabel.Location = new System.Drawing.Point(0, 0);
            this.SpritesetOffsetLabel.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.SpritesetOffsetLabel.Name = "SpritesetOffsetLabel";
            this.SpritesetOffsetLabel.Size = new System.Drawing.Size(132, 32);
            this.SpritesetOffsetLabel.TabIndex = 0;
            this.SpritesetOffsetLabel.Text = "Spriteset Offset:";
            this.SpritesetOffsetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TilesetOffset
            // 
            this.TilesetOffset.Hexadecimal = true;
            this.TilesetOffset.Location = new System.Drawing.Point(136, 3);
            this.TilesetOffset.MaxLength = 3;
            this.TilesetOffset.Name = "TilesetOffset";
            this.TilesetOffset.Size = new System.Drawing.Size(100, 26);
            this.TilesetOffset.TabIndex = 6;
            this.TilesetOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ActionPanel
            // 
            this.ActionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ActionPanel.ColumnCount = 3;
            this.ActionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ActionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ActionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.ActionPanel.Controls.Add(this.Reset_Button, 0, 0);
            this.ActionPanel.Controls.Add(this.Cancel_Button, 0, 0);
            this.ActionPanel.Controls.Add(this.OK_Button, 0, 0);
            this.ActionPanel.Location = new System.Drawing.Point(202, 403);
            this.ActionPanel.Margin = new System.Windows.Forms.Padding(5);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.RowCount = 1;
            this.ActionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ActionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.ActionPanel.Size = new System.Drawing.Size(366, 45);
            this.ActionPanel.TabIndex = 1;
            // 
            // Reset_Button
            // 
            this.Reset_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Reset_Button.Location = new System.Drawing.Point(248, 5);
            this.Reset_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(97, 35);
            this.Reset_Button.TabIndex = 2;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.Location = new System.Drawing.Point(122, 5);
            this.Cancel_Button.Margin = new System.Windows.Forms.Padding(5);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(97, 35);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // OK_Button
            // 
            this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OK_Button.Location = new System.Drawing.Point(9, 5);
            this.OK_Button.Margin = new System.Windows.Forms.Padding(5);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(96, 35);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // Form_ToolGraphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 457);
            this.Controls.Add(this.ImagePanel);
            this.Controls.Add(this.ControlPanelRight);
            this.Controls.Add(this.ControlPanelLeft);
            this.Controls.Add(this.ActionPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(592, 367);
            this.Name = "Form_ToolGraphic";
            this.Normal = new System.Drawing.Rectangle(19, 19, 592, 504);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Graphics Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_ToolImage_Closing);
            this.Load += new System.EventHandler(this.Form_ToolImage_Load);
            this.SizeChanged += new System.EventHandler(this.Form_ToolGraphic_SizeChanged);
            this.ImagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HexImage)).EndInit();
            this.ControlPanelRight.ResumeLayout(false);
            this.CompressionPanel.ResumeLayout(false);
            this.CompressionPanel.PerformLayout();
            this.EncodingPanel.ResumeLayout(false);
            this.EncodingPanel.PerformLayout();
            this.ColorDepthPanel.ResumeLayout(false);
            this.ColorDepthPanel.PerformLayout();
            this.ZoomFactorPanel.ResumeLayout(false);
            this.ZoomFactorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZoomFactor)).EndInit();
            this.ControlPanelLeft.ResumeLayout(false);
            this.SpriteOffsetPanel.ResumeLayout(false);
            this.SpriteOffsetPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteOffset)).EndInit();
            this.SizePanel.ResumeLayout(false);
            this.SizePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageHeight)).EndInit();
            this.PaletteOffsetPanel.ResumeLayout(false);
            this.PaletteOffsetPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaletteOffset)).EndInit();
            this.TilesetOffsetPanel.ResumeLayout(false);
            this.TilesetOffsetPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TilesetOffset)).EndInit();
            this.ActionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal TableLayoutPanel ActionPanel;
        internal Button OK_Button;
        internal Button Cancel_Button;
        internal FlowLayoutPanel ControlPanelLeft;
        internal ToolTip GraphicsViewerToolTip;
        private BasicTools.BasicControls.BasicFlowLayoutPanel SpriteOffsetPanel;
        private Label SpriteOffsetLabel;
        private BasicTools.BasicControls.BasicFlowLayoutPanel PaletteOffsetPanel;
        private Label PaletteOffsetLabel;
        private BasicTools.BasicControls.BasicNumericBox SpriteOffset;
        private BasicTools.BasicControls.BasicNumericBox PaletteOffset;
        private BasicTools.BasicControls.BasicFlowLayoutPanel CompressionPanel;
        private Label CompressionLabel;
        private BasicTools.BasicControls.BasicComboBox Compression;
        internal Button Reset_Button;
        internal FlowLayoutPanel ControlPanelRight;
        private BasicTools.BasicControls.BasicFlowLayoutPanel ZoomFactorPanel;
        private Label ZoomFactorLabel;
        private TrackBar ZoomFactor;
        private BasicTools.BasicControls.BasicFlowLayoutPanel TilesetOffsetPanel;
        private Label SpritesetOffsetLabel;
        private BasicTools.BasicControls.BasicNumericBox TilesetOffset;
        private BasicTools.BasicControls.BasicFlowLayoutPanel EncodingPanel;
        private Label EncodingLabel;
        private BasicTools.BasicControls.BasicComboBox Encoding;
        private BasicTools.BasicControls.BasicFlowLayoutPanel SizePanel;
        private Label SizeLabel;
        private Label XLabel;
        private Label ByLabel;
        private Label XLabelIcon;
        private Label YLabelIcon;
        private BasicTools.BasicControls.BasicFlowLayoutPanel ColorDepthPanel;
        private Label ColorDepthLabel;
        private BasicTools.BasicControls.BasicComboBox ColorDepth;
        private Panel ImagePanel;
        private BasicTools.BasicControls.BasicNumericBox ImageHeight;
        private HexTools.HexImage HexImage;
    }
}