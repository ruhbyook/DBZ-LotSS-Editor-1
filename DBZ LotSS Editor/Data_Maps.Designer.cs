using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DBZ_LotSS_Editor
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Data_Maps : HexTools.HexUserControl
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
            HexTools.HexListBoxItem hexListBoxItem1 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem2 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem3 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem4 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem5 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem6 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem7 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem8 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem9 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem10 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem11 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem12 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem13 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem14 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem15 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem16 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem17 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem18 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem19 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem20 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem21 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem22 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem23 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem24 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem25 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem26 = new HexTools.HexListBoxItem();
            this.ExperimentRawMapData = new BasicTools.BasicExperimentalControl();
            this.UnknownRawMapData = new HexTools.HexTableView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HexTableViewEditorsItem1 = new HexTools.HexTextBoxItemControl();
            this.HexTableViewEditorsItem2 = new HexTools.HexTextBoxItemControl();
            this.HexTableViewEditorsItem3 = new HexTools.HexTextBoxItemControl();
            this.HexTableViewEditorsItem4 = new HexTools.HexTextBoxItemControl();
            this.HexTableViewEditorsItem5 = new HexTools.HexTextBoxItemControl();
            this.HexTableViewEditorsItem6 = new HexTools.HexTextBoxItemControl();
            this.HexTableViewEditorsItem7 = new HexTools.HexTextBoxItemControl();
            this.HexTableViewEditorsItem8 = new HexTools.HexTextBoxItemControl();
            this.HexListBox1 = new HexTools.HexListBox();
            this.BasicListBoxAssociate1 = new BasicTools.BasicControls.BasicListBoxAssociate();
            this.HexPanel1 = new HexTools.HexPanel();
            this.Label6 = new System.Windows.Forms.Label();
            this.Group1 = new HexTools.HexComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Group5 = new HexTools.HexComboBox();
            this.Group2 = new HexTools.HexComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Group4 = new HexTools.HexComboBox();
            this.Group3 = new HexTools.HexComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.BasicListBoxAssociate1.SuspendLayout();
            this.HexPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExperimentRawMapData
            // 
            this.ExperimentRawMapData.Control = this.UnknownRawMapData;
            this.ExperimentRawMapData.Location = new System.Drawing.Point(206, 258);
            this.ExperimentRawMapData.Name = "ExperimentRawMapData";
            this.ExperimentRawMapData.ShowConfirmation = true;
            this.ExperimentRawMapData.Size = new System.Drawing.Size(155, 33);
            this.ExperimentRawMapData.TabIndex = 20;
            // 
            // UnknownRawMapData
            // 
            this.UnknownRawMapData.ColumnActivity = BasicTools.BasicControls.BasicTableView.TableViewColumnActivity.NonClickable;
            this.UnknownRawMapData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5,
            this.ColumnHeader6,
            this.ColumnHeader7,
            this.ColumnHeader8});
            this.UnknownRawMapData.DoubleClickActivation = true;
            this.UnknownRawMapData.Editors.AddRange(new BasicTools.BasicControls.EditableListViewItem[] {
            this.HexTableViewEditorsItem1,
            this.HexTableViewEditorsItem2,
            this.HexTableViewEditorsItem3,
            this.HexTableViewEditorsItem4,
            this.HexTableViewEditorsItem5,
            this.HexTableViewEditorsItem6,
            this.HexTableViewEditorsItem7,
            this.HexTableViewEditorsItem8});
            this.UnknownRawMapData.Enabled = false;
            this.UnknownRawMapData.FullRowSelect = true;
            this.UnknownRawMapData.HexOffsetCount = "&H000008";
            this.UnknownRawMapData.HexOffsetCountType = HexTools.HexEnumerations.OffsetType.Value;
            this.UnknownRawMapData.HexOffsetLength = "&H000008";
            this.UnknownRawMapData.HexOffsetLengthType = HexTools.HexEnumerations.OffsetType.Value;
            this.UnknownRawMapData.HideSelection = false;
            this.UnknownRawMapData.Location = new System.Drawing.Point(15, 300);
            this.UnknownRawMapData.Name = "UnknownRawMapData";
            this.UnknownRawMapData.OwnerDraw = true;
            this.UnknownRawMapData.Size = new System.Drawing.Size(453, 204);
            this.UnknownRawMapData.Style = BasicTools.BasicControls.BasicTableView.TableViewStyles.Columns;
            this.UnknownRawMapData.TabIndex = 42;
            this.UnknownRawMapData.TempTableType = HexTools.HexTableView.TableType.Map;
            this.UnknownRawMapData.UseCompatibleStateImageBehavior = false;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "1";
            this.ColumnHeader1.Width = 39;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "2";
            this.ColumnHeader2.Width = 40;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "3";
            this.ColumnHeader3.Width = 40;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "4";
            this.ColumnHeader4.Width = 40;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "5";
            this.ColumnHeader5.Width = 40;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "6";
            this.ColumnHeader6.Width = 40;
            // 
            // ColumnHeader7
            // 
            this.ColumnHeader7.Text = "7";
            this.ColumnHeader7.Width = 40;
            // 
            // ColumnHeader8
            // 
            this.ColumnHeader8.Text = "8";
            this.ColumnHeader8.Width = 40;
            // 
            // HexTableViewEditorsItem1
            // 
            // 
            // 
            // 
            this.HexTableViewEditorsItem1.Control.Display = HexTools.HexEnumerations.DisplayType.Hex;
            this.HexTableViewEditorsItem1.Control.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.HexTableViewEditorsItem1.Control.Input = HexTools.HexEnumerations.InputType.Hex;
            this.HexTableViewEditorsItem1.Control.Location = new System.Drawing.Point(0, 0);
            this.HexTableViewEditorsItem1.Control.MaxLength = 1;
            this.HexTableViewEditorsItem1.Control.Name = "Column1";
            this.HexTableViewEditorsItem1.Control.OvertypeMode = true;
            this.HexTableViewEditorsItem1.Control.TabIndex = 0;
            // 
            // HexTableViewEditorsItem2
            // 
            // 
            // 
            // 
            this.HexTableViewEditorsItem2.Control.Display = HexTools.HexEnumerations.DisplayType.Hex;
            this.HexTableViewEditorsItem2.Control.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.HexTableViewEditorsItem2.Control.HexOffset = "&H000001";
            this.HexTableViewEditorsItem2.Control.Input = HexTools.HexEnumerations.InputType.Hex;
            this.HexTableViewEditorsItem2.Control.Location = new System.Drawing.Point(0, 0);
            this.HexTableViewEditorsItem2.Control.MaxLength = 1;
            this.HexTableViewEditorsItem2.Control.Name = "Column2";
            this.HexTableViewEditorsItem2.Control.OvertypeMode = true;
            this.HexTableViewEditorsItem2.Control.TabIndex = 0;
            // 
            // HexTableViewEditorsItem3
            // 
            // 
            // 
            // 
            this.HexTableViewEditorsItem3.Control.Display = HexTools.HexEnumerations.DisplayType.Hex;
            this.HexTableViewEditorsItem3.Control.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.HexTableViewEditorsItem3.Control.HexOffset = "&H000002";
            this.HexTableViewEditorsItem3.Control.Input = HexTools.HexEnumerations.InputType.Hex;
            this.HexTableViewEditorsItem3.Control.Location = new System.Drawing.Point(0, 0);
            this.HexTableViewEditorsItem3.Control.MaxLength = 1;
            this.HexTableViewEditorsItem3.Control.Name = "Column3";
            this.HexTableViewEditorsItem3.Control.OvertypeMode = true;
            this.HexTableViewEditorsItem3.Control.TabIndex = 0;
            // 
            // HexTableViewEditorsItem4
            // 
            // 
            // 
            // 
            this.HexTableViewEditorsItem4.Control.Display = HexTools.HexEnumerations.DisplayType.Hex;
            this.HexTableViewEditorsItem4.Control.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.HexTableViewEditorsItem4.Control.HexOffset = "&H000003";
            this.HexTableViewEditorsItem4.Control.Input = HexTools.HexEnumerations.InputType.Hex;
            this.HexTableViewEditorsItem4.Control.Location = new System.Drawing.Point(0, 0);
            this.HexTableViewEditorsItem4.Control.MaxLength = 1;
            this.HexTableViewEditorsItem4.Control.Name = "Column4";
            this.HexTableViewEditorsItem4.Control.OvertypeMode = true;
            this.HexTableViewEditorsItem4.Control.TabIndex = 0;
            // 
            // HexTableViewEditorsItem5
            // 
            // 
            // 
            // 
            this.HexTableViewEditorsItem5.Control.Display = HexTools.HexEnumerations.DisplayType.Hex;
            this.HexTableViewEditorsItem5.Control.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.HexTableViewEditorsItem5.Control.HexOffset = "&H000004";
            this.HexTableViewEditorsItem5.Control.Input = HexTools.HexEnumerations.InputType.Hex;
            this.HexTableViewEditorsItem5.Control.Location = new System.Drawing.Point(0, 0);
            this.HexTableViewEditorsItem5.Control.MaxLength = 1;
            this.HexTableViewEditorsItem5.Control.Name = "Column5";
            this.HexTableViewEditorsItem5.Control.OvertypeMode = true;
            this.HexTableViewEditorsItem5.Control.TabIndex = 0;
            // 
            // HexTableViewEditorsItem6
            // 
            // 
            // 
            // 
            this.HexTableViewEditorsItem6.Control.Display = HexTools.HexEnumerations.DisplayType.Hex;
            this.HexTableViewEditorsItem6.Control.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.HexTableViewEditorsItem6.Control.HexOffset = "&H000005";
            this.HexTableViewEditorsItem6.Control.Input = HexTools.HexEnumerations.InputType.Hex;
            this.HexTableViewEditorsItem6.Control.Location = new System.Drawing.Point(0, 0);
            this.HexTableViewEditorsItem6.Control.MaxLength = 1;
            this.HexTableViewEditorsItem6.Control.Name = "Column6";
            this.HexTableViewEditorsItem6.Control.OvertypeMode = true;
            this.HexTableViewEditorsItem6.Control.TabIndex = 0;
            // 
            // HexTableViewEditorsItem7
            // 
            // 
            // 
            // 
            this.HexTableViewEditorsItem7.Control.Display = HexTools.HexEnumerations.DisplayType.Hex;
            this.HexTableViewEditorsItem7.Control.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.HexTableViewEditorsItem7.Control.HexOffset = "&H000006";
            this.HexTableViewEditorsItem7.Control.Input = HexTools.HexEnumerations.InputType.Hex;
            this.HexTableViewEditorsItem7.Control.Location = new System.Drawing.Point(0, 0);
            this.HexTableViewEditorsItem7.Control.MaxLength = 1;
            this.HexTableViewEditorsItem7.Control.Name = "Column7";
            this.HexTableViewEditorsItem7.Control.OvertypeMode = true;
            this.HexTableViewEditorsItem7.Control.TabIndex = 0;
            // 
            // HexTableViewEditorsItem8
            // 
            // 
            // 
            // 
            this.HexTableViewEditorsItem8.Control.Display = HexTools.HexEnumerations.DisplayType.Hex;
            this.HexTableViewEditorsItem8.Control.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.HexTableViewEditorsItem8.Control.HexOffset = "&H000007";
            this.HexTableViewEditorsItem8.Control.Input = HexTools.HexEnumerations.InputType.Hex;
            this.HexTableViewEditorsItem8.Control.Location = new System.Drawing.Point(0, 0);
            this.HexTableViewEditorsItem8.Control.MaxLength = 1;
            this.HexTableViewEditorsItem8.Control.Name = "Column8";
            this.HexTableViewEditorsItem8.Control.OvertypeMode = true;
            this.HexTableViewEditorsItem8.Control.TabIndex = 0;
            // 
            // HexListBox1
            // 
            this.HexListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.HexListBox1.FormatString = "X2";
            this.HexListBox1.FormattingEnabled = true;
            this.HexListBox1.IndexDisplay = true;
            hexListBoxItem1.HexOffset = null;
            hexListBoxItem1.Text = "Earth Overworld 01 (Ground)";
            hexListBoxItem2.HexOffset = null;
            hexListBoxItem2.Text = "Earth Overworld 01 (Flying?)";
            hexListBoxItem3.HexOffset = null;
            hexListBoxItem3.Text = "Earth Overworld 01 (Caves?)";
            hexListBoxItem4.HexOffset = null;
            hexListBoxItem4.Text = "Earth Overworld 02 (Ground?)";
            hexListBoxItem5.HexOffset = null;
            hexListBoxItem5.Text = "Earth Overworld 02 (Flying?)";
            hexListBoxItem6.HexOffset = null;
            hexListBoxItem6.Text = "Earth Overworld 02 (Caves?)";
            hexListBoxItem7.HexOffset = null;
            hexListBoxItem7.Text = "Namek Overworld 1 (Ground?)";
            hexListBoxItem8.HexOffset = null;
            hexListBoxItem8.Text = "Namek Overworld 1 (Flying?)";
            hexListBoxItem9.HexOffset = null;
            hexListBoxItem9.Text = "Namek Overworld 1 (Caves?)";
            hexListBoxItem10.HexOffset = null;
            hexListBoxItem10.Text = "Namek Overworld 1 (?)";
            hexListBoxItem11.HexOffset = null;
            hexListBoxItem11.Text = "??";
            hexListBoxItem12.HexOffset = null;
            hexListBoxItem12.Text = "??";
            hexListBoxItem13.HexOffset = null;
            hexListBoxItem13.Text = "??";
            hexListBoxItem14.HexOffset = null;
            hexListBoxItem14.Text = "??";
            hexListBoxItem15.HexOffset = null;
            hexListBoxItem15.Text = "??";
            hexListBoxItem16.HexOffset = null;
            hexListBoxItem16.Text = "??";
            hexListBoxItem17.HexOffset = null;
            hexListBoxItem17.Text = "??";
            hexListBoxItem18.HexOffset = null;
            hexListBoxItem18.Text = "??";
            hexListBoxItem19.HexOffset = null;
            hexListBoxItem19.Text = "??";
            hexListBoxItem20.HexOffset = null;
            hexListBoxItem20.Text = "??";
            hexListBoxItem21.HexOffset = null;
            hexListBoxItem21.Text = "??";
            hexListBoxItem22.HexOffset = null;
            hexListBoxItem22.Text = "??";
            hexListBoxItem23.HexOffset = null;
            hexListBoxItem23.Text = "??";
            hexListBoxItem24.HexOffset = null;
            hexListBoxItem24.Text = "??";
            hexListBoxItem25.HexOffset = null;
            hexListBoxItem25.Text = "??";
            hexListBoxItem26.HexOffset = null;
            hexListBoxItem26.Text = "??";
            this.HexListBox1.Items.Add(hexListBoxItem1);
            this.HexListBox1.Items.Add(hexListBoxItem2);
            this.HexListBox1.Items.Add(hexListBoxItem3);
            this.HexListBox1.Items.Add(hexListBoxItem4);
            this.HexListBox1.Items.Add(hexListBoxItem5);
            this.HexListBox1.Items.Add(hexListBoxItem6);
            this.HexListBox1.Items.Add(hexListBoxItem7);
            this.HexListBox1.Items.Add(hexListBoxItem8);
            this.HexListBox1.Items.Add(hexListBoxItem9);
            this.HexListBox1.Items.Add(hexListBoxItem10);
            this.HexListBox1.Items.Add(hexListBoxItem11);
            this.HexListBox1.Items.Add(hexListBoxItem12);
            this.HexListBox1.Items.Add(hexListBoxItem13);
            this.HexListBox1.Items.Add(hexListBoxItem14);
            this.HexListBox1.Items.Add(hexListBoxItem15);
            this.HexListBox1.Items.Add(hexListBoxItem16);
            this.HexListBox1.Items.Add(hexListBoxItem17);
            this.HexListBox1.Items.Add(hexListBoxItem18);
            this.HexListBox1.Items.Add(hexListBoxItem19);
            this.HexListBox1.Items.Add(hexListBoxItem20);
            this.HexListBox1.Items.Add(hexListBoxItem21);
            this.HexListBox1.Items.Add(hexListBoxItem22);
            this.HexListBox1.Items.Add(hexListBoxItem23);
            this.HexListBox1.Items.Add(hexListBoxItem24);
            this.HexListBox1.Items.Add(hexListBoxItem25);
            this.HexListBox1.Items.Add(hexListBoxItem26);
            this.HexListBox1.Location = new System.Drawing.Point(16, 17);
            this.HexListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.HexListBox1.Name = "HexListBox1";
            this.HexListBox1.SelectedItem = hexListBoxItem1;
            this.HexListBox1.Size = new System.Drawing.Size(232, 550);
            this.HexListBox1.TabIndex = 14;
            // 
            // BasicListBoxAssociate1
            // 
            this.BasicListBoxAssociate1.Controls.Add(this.HexPanel1);
            this.BasicListBoxAssociate1.ListBox = this.HexListBox1;
            this.BasicListBoxAssociate1.Location = new System.Drawing.Point(269, 17);
            this.BasicListBoxAssociate1.Margin = new System.Windows.Forms.Padding(4);
            this.BasicListBoxAssociate1.Name = "BasicListBoxAssociate1";
            this.BasicListBoxAssociate1.Padding = new System.Windows.Forms.Padding(4);
            this.BasicListBoxAssociate1.Size = new System.Drawing.Size(495, 550);
            this.BasicListBoxAssociate1.TabIndex = 15;
            this.BasicListBoxAssociate1.TabStop = false;
            this.BasicListBoxAssociate1.Text = "HexListBox1";
            // 
            // HexPanel1
            // 
            this.HexPanel1.Controls.Add(this.Label6);
            this.HexPanel1.Controls.Add(this.UnknownRawMapData);
            this.HexPanel1.Controls.Add(this.Group1);
            this.HexPanel1.Controls.Add(this.Label5);
            this.HexPanel1.Controls.Add(this.Label1);
            this.HexPanel1.Controls.Add(this.Group5);
            this.HexPanel1.Controls.Add(this.Group2);
            this.HexPanel1.Controls.Add(this.Label4);
            this.HexPanel1.Controls.Add(this.Label2);
            this.HexPanel1.Controls.Add(this.Group4);
            this.HexPanel1.Controls.Add(this.Group3);
            this.HexPanel1.Controls.Add(this.Label3);
            this.HexPanel1.Controls.Add(this.ExperimentRawMapData);
            this.HexPanel1.HexOffset = "&H010000";
            this.HexPanel1.IndexOffset = "&H000002";
            this.HexPanel1.Location = new System.Drawing.Point(4, 28);
            this.HexPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.HexPanel1.Name = "HexPanel1";
            this.HexPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.HexPanel1.Pointer = "&H0156EA";
            this.HexPanel1.PointerLength = 2;
            this.HexPanel1.Size = new System.Drawing.Size(487, 514);
            this.HexPanel1.TabIndex = 17;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(16, 266);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(162, 17);
            this.Label6.TabIndex = 43;
            this.Label6.Text = "Unknown Raw Map Data";
            this.Label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // Group1
            // 
            this.Group1.Display = HexTools.HexEnumerations.DisplayType.Hex;
            this.Group1.DisplayMember = "Text";
            this.Group1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Group1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Group1.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.Group1.FormatString = "X2";
            this.Group1.FormattingEnabled = true;
            this.Group1.IntegralHeight = false;
            this.Group1.ItemCollection = "Data_Groups.HexListBox1";
            this.Group1.Location = new System.Drawing.Point(10, 25);
            this.Group1.MaxDropDownItems = 15;
            this.Group1.MaxLength = 1;
            this.Group1.Name = "Group1";
            this.Group1.NullValue = "&HFF";
            this.Group1.Size = new System.Drawing.Size(400, 23);
            this.Group1.TabIndex = 24;
            this.Group1.ValueDisplay = true;
            this.Group1.ValueMember = "Value";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(8, 204);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(68, 17);
            this.Label5.TabIndex = 33;
            this.Label5.Text = "Group #5";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 4);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(68, 17);
            this.Label1.TabIndex = 25;
            this.Label1.Text = "Group #1";
            // 
            // Group5
            // 
            this.Group5.Display = HexTools.HexEnumerations.DisplayType.Hex;
            this.Group5.DisplayMember = "Text";
            this.Group5.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Group5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Group5.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.Group5.FormatString = "X2";
            this.Group5.FormattingEnabled = true;
            this.Group5.HexOffset = "&H000004";
            this.Group5.IntegralHeight = false;
            this.Group5.ItemCollection = "Data_Groups.HexListBox1";
            this.Group5.Location = new System.Drawing.Point(10, 225);
            this.Group5.MaxDropDownItems = 15;
            this.Group5.MaxLength = 1;
            this.Group5.Name = "Group5";
            this.Group5.NullValue = "&HFF";
            this.Group5.Size = new System.Drawing.Size(400, 23);
            this.Group5.TabIndex = 32;
            this.Group5.ValueDisplay = true;
            this.Group5.ValueMember = "Value";
            // 
            // Group2
            // 
            this.Group2.Display = HexTools.HexEnumerations.DisplayType.Hex;
            this.Group2.DisplayMember = "Text";
            this.Group2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Group2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Group2.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.Group2.FormatString = "X2";
            this.Group2.FormattingEnabled = true;
            this.Group2.HexOffset = "&H000001";
            this.Group2.IntegralHeight = false;
            this.Group2.ItemCollection = "Data_Groups.HexListBox1";
            this.Group2.Location = new System.Drawing.Point(10, 75);
            this.Group2.MaxDropDownItems = 15;
            this.Group2.MaxLength = 1;
            this.Group2.Name = "Group2";
            this.Group2.NullValue = "&HFF";
            this.Group2.Size = new System.Drawing.Size(400, 23);
            this.Group2.TabIndex = 26;
            this.Group2.ValueDisplay = true;
            this.Group2.ValueMember = "Value";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(8, 154);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(68, 17);
            this.Label4.TabIndex = 31;
            this.Label4.Text = "Group #4";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(8, 54);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(68, 17);
            this.Label2.TabIndex = 27;
            this.Label2.Text = "Group #2";
            // 
            // Group4
            // 
            this.Group4.Display = HexTools.HexEnumerations.DisplayType.Hex;
            this.Group4.DisplayMember = "Text";
            this.Group4.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Group4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Group4.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.Group4.FormatString = "X2";
            this.Group4.FormattingEnabled = true;
            this.Group4.HexOffset = "&H000003";
            this.Group4.IntegralHeight = false;
            this.Group4.ItemCollection = "Data_Groups.HexListBox1";
            this.Group4.Location = new System.Drawing.Point(10, 175);
            this.Group4.MaxDropDownItems = 15;
            this.Group4.MaxLength = 1;
            this.Group4.Name = "Group4";
            this.Group4.NullValue = "&HFF";
            this.Group4.Size = new System.Drawing.Size(400, 23);
            this.Group4.TabIndex = 30;
            this.Group4.ValueDisplay = true;
            this.Group4.ValueMember = "Value";
            // 
            // Group3
            // 
            this.Group3.Display = HexTools.HexEnumerations.DisplayType.Hex;
            this.Group3.DisplayMember = "Text";
            this.Group3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Group3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Group3.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.Group3.FormatString = "X2";
            this.Group3.FormattingEnabled = true;
            this.Group3.HexOffset = "&H000002";
            this.Group3.IntegralHeight = false;
            this.Group3.ItemCollection = "Data_Groups.HexListBox1";
            this.Group3.Location = new System.Drawing.Point(10, 125);
            this.Group3.MaxDropDownItems = 15;
            this.Group3.MaxLength = 1;
            this.Group3.Name = "Group3";
            this.Group3.NullValue = "&HFF";
            this.Group3.Size = new System.Drawing.Size(400, 23);
            this.Group3.TabIndex = 28;
            this.Group3.ValueDisplay = true;
            this.Group3.ValueMember = "Value";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(8, 104);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(68, 17);
            this.Label3.TabIndex = 29;
            this.Label3.Text = "Group #3";
            // 
            // Data_Maps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BasicListBoxAssociate1);
            this.Controls.Add(this.HexListBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Data_Maps";
            this.Size = new System.Drawing.Size(787, 603);
            this.BasicListBoxAssociate1.ResumeLayout(false);
            this.HexPanel1.ResumeLayout(false);
            this.HexPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        internal HexTools.HexListBox HexListBox1;
        internal BasicTools.BasicControls.BasicListBoxAssociate BasicListBoxAssociate1;
        internal HexTools.HexPanel HexPanel1;
        internal HexTools.HexTableView UnknownRawMapData;
        internal ColumnHeader ColumnHeader1;
        internal ColumnHeader ColumnHeader2;
        internal ColumnHeader ColumnHeader3;
        internal ColumnHeader ColumnHeader4;
        internal ColumnHeader ColumnHeader5;
        internal ColumnHeader ColumnHeader6;
        internal ColumnHeader ColumnHeader7;
        internal ColumnHeader ColumnHeader8;
        internal HexTools.HexComboBox Group1;
        internal Label Label5;
        internal Label Label1;
        internal HexTools.HexComboBox Group5;
        internal HexTools.HexComboBox Group2;
        internal Label Label4;
        internal Label Label2;
        internal HexTools.HexComboBox Group4;
        internal HexTools.HexComboBox Group3;
        internal Label Label3;
        internal Label Label6;
        internal BasicTools.BasicExperimentalControl ExperimentRawMapData;
        internal HexTools.HexTextBoxItemControl HexTableViewEditorsItem1;
        internal HexTools.HexTextBoxItemControl HexTableViewEditorsItem2;
        internal HexTools.HexTextBoxItemControl HexTableViewEditorsItem3;
        internal HexTools.HexTextBoxItemControl HexTableViewEditorsItem4;
        internal HexTools.HexTextBoxItemControl HexTableViewEditorsItem5;
        internal HexTools.HexTextBoxItemControl HexTableViewEditorsItem6;
        internal HexTools.HexTextBoxItemControl HexTableViewEditorsItem7;
        internal HexTools.HexTextBoxItemControl HexTableViewEditorsItem8;
    }
}