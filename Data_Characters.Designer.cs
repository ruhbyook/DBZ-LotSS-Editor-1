using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DBZ_LotSS_Editor
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Data_Characters : HexTools.HexUserControl
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
            this.EditableListViewItem2 = new BasicTools.BasicControls.EditableListViewItem();
            this.EditableListViewItemControl_16 = new HexTools.HexNumericBoxItemControl();
            this.EditableListViewItemControl_17 = new HexTools.HexNumericBoxItemControl();
            this.EditableListViewItemControl_18 = new HexTools.HexNumericBoxItemControl();
            this.EditableListViewItemControl_19 = new HexTools.HexNumericBoxItemControl();
            this.EditableListViewItemControl_160 = new HexTools.HexNumericBoxItemControl();
            this.HexListBox1 = new HexTools.HexListBox();
            this.BasicListBoxAssociate1 = new BasicTools.BasicControls.BasicListBoxAssociate();
            this.NamePanel = new HexTools.HexPanel();
            this.NameBox = new HexTools.HexComboBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.NoLevel = new System.Windows.Forms.Label();
            this.TransformationPanel = new HexTools.HexPanel();
            this.NoTransformation = new System.Windows.Forms.Label();
            this.Transformation = new HexTools.HexComboBox();
            this.LabelTransformation = new System.Windows.Forms.Label();
            this.Levels = new HexTools.HexTableView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BaseFormPanel = new HexTools.HexPanel();
            this.NoBattler = new System.Windows.Forms.Label();
            this.Battler = new HexTools.HexComboBox();
            this.LabelBattler = new System.Windows.Forms.Label();
            this.ExportLevelData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EditableListViewItemControl_16.Control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditableListViewItemControl_17.Control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditableListViewItemControl_18.Control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditableListViewItemControl_19.Control)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditableListViewItemControl_160.Control)).BeginInit();
            this.BasicListBoxAssociate1.SuspendLayout();
            this.NamePanel.SuspendLayout();
            this.TransformationPanel.SuspendLayout();
            this.BaseFormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditableListViewItem2
            // 
            this.EditableListViewItem2.Name = "Level";
            // 
            // EditableListViewItemControl_16
            // 
            // 
            // 
            // 
            this.EditableListViewItemControl_16.Control.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.EditableListViewItemControl_16.Control.ExcludeRanged = new int[] {
        0,
        -1};
            this.EditableListViewItemControl_16.Control.Location = new System.Drawing.Point(0, 0);
            this.EditableListViewItemControl_16.Control.Maximum = new decimal(new int[] {
            160000000,
            0,
            0,
            0});
            this.EditableListViewItemControl_16.Control.MaxLength = 3;
            this.EditableListViewItemControl_16.Control.Name = "BattlePower";
            this.EditableListViewItemControl_16.Control.Ranged = true;
            this.EditableListViewItemControl_16.Control.TabIndex = 0;
            this.EditableListViewItemControl_16.Control.ThousandsSeparator = true;
            // 
            // EditableListViewItemControl_17
            // 
            // 
            // 
            // 
            this.EditableListViewItemControl_17.Control.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.EditableListViewItemControl_17.Control.HexOffset = "&H000003";
            this.EditableListViewItemControl_17.Control.Location = new System.Drawing.Point(0, 0);
            this.EditableListViewItemControl_17.Control.Maximum = new decimal(new int[] {
            160000000,
            0,
            0,
            0});
            this.EditableListViewItemControl_17.Control.MaxLength = 3;
            this.EditableListViewItemControl_17.Control.Name = "Experience";
            this.EditableListViewItemControl_17.Control.TabIndex = 0;
            this.EditableListViewItemControl_17.Control.ThousandsSeparator = true;
            // 
            // EditableListViewItemControl_18
            // 
            // 
            // 
            // 
            this.EditableListViewItemControl_18.Control.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.EditableListViewItemControl_18.Control.HexOffset = "&H000006";
            this.EditableListViewItemControl_18.Control.Location = new System.Drawing.Point(0, 0);
            this.EditableListViewItemControl_18.Control.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.EditableListViewItemControl_18.Control.MaxLength = 2;
            this.EditableListViewItemControl_18.Control.Name = "Health";
            this.EditableListViewItemControl_18.Control.TabIndex = 0;
            this.EditableListViewItemControl_18.Control.ThousandsSeparator = true;
            // 
            // EditableListViewItemControl_19
            // 
            // 
            // 
            // 
            this.EditableListViewItemControl_19.Control.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.EditableListViewItemControl_19.Control.ExcludeRanged = new int[] {
        0,
        -1};
            this.EditableListViewItemControl_19.Control.HexOffset = "&H000008";
            this.EditableListViewItemControl_19.Control.Location = new System.Drawing.Point(0, 0);
            this.EditableListViewItemControl_19.Control.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.EditableListViewItemControl_19.Control.MaxLength = 2;
            this.EditableListViewItemControl_19.Control.Name = "Ki";
            this.EditableListViewItemControl_19.Control.Ranged = true;
            this.EditableListViewItemControl_19.Control.TabIndex = 0;
            this.EditableListViewItemControl_19.Control.ThousandsSeparator = true;
            // 
            // EditableListViewItemControl_160
            // 
            // 
            // 
            // 
            this.EditableListViewItemControl_160.Control.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.EditableListViewItemControl_160.Control.HexOffset = "&H00000A";
            this.EditableListViewItemControl_160.Control.Location = new System.Drawing.Point(0, 0);
            this.EditableListViewItemControl_160.Control.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.EditableListViewItemControl_160.Control.MaxLength = 1;
            this.EditableListViewItemControl_160.Control.Name = "Rage";
            this.EditableListViewItemControl_160.Control.TabIndex = 0;
            // 
            // HexListBox1
            // 
            this.HexListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.HexListBox1.FormatString = "X2";
            this.HexListBox1.FormattingEnabled = true;
            this.HexListBox1.IndexDisplay = true;
            hexListBoxItem1.HexOffset = "&H014155";
            hexListBoxItem1.Text = "Goku";
            hexListBoxItem2.HexOffset = "&H014365";
            hexListBoxItem2.Text = "Gohan";
            hexListBoxItem3.HexOffset = "&H014575";
            hexListBoxItem3.Text = "Piccolo";
            hexListBoxItem4.HexOffset = "&H014785";
            hexListBoxItem4.Text = "Krillin";
            hexListBoxItem5.HexOffset = "&H014995";
            hexListBoxItem5.Text = "Tien";
            hexListBoxItem6.HexOffset = "&H014BA5";
            hexListBoxItem6.Text = "Yamcha";
            hexListBoxItem7.HexOffset = "&H014DB5";
            hexListBoxItem7.Text = "Chiaotzu";
            hexListBoxItem8.HexOffset = "&H14FC5";
            hexListBoxItem8.Text = "Vegeta";
            hexListBoxItem9.HexOffset = "&H0135F0";
            hexListBoxItem9.Text = "Nail";
            hexListBoxItem10.HexOffset = "&H0135FE";
            hexListBoxItem10.Text = "Tsumari";
            hexListBoxItem11.HexOffset = "&H01360C";
            hexListBoxItem11.Text = "Mai-ma";
            hexListBoxItem12.HexOffset = "&H0151D5";
            hexListBoxItem12.Text = "Dende";
            hexListBoxItem13.HexOffset = "&H014155";
            hexListBoxItem13.Text = "Emi";
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
            this.HexListBox1.Location = new System.Drawing.Point(16, 17);
            this.HexListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.HexListBox1.Name = "HexListBox1";
            this.HexListBox1.SelectedItem = hexListBoxItem1;
            this.HexListBox1.Size = new System.Drawing.Size(232, 550);
            this.HexListBox1.TabIndex = 14;
            this.HexListBox1.SelectedIndexChanged += new System.EventHandler(this.HexListBox1_SelectedIndexChanged);
            // 
            // BasicListBoxAssociate1
            // 
            this.BasicListBoxAssociate1.Controls.Add(this.NamePanel);
            this.BasicListBoxAssociate1.Controls.Add(this.NoLevel);
            this.BasicListBoxAssociate1.Controls.Add(this.TransformationPanel);
            this.BasicListBoxAssociate1.Controls.Add(this.Levels);
            this.BasicListBoxAssociate1.Controls.Add(this.BaseFormPanel);
            this.BasicListBoxAssociate1.ListBox = this.HexListBox1;
            this.BasicListBoxAssociate1.Location = new System.Drawing.Point(257, 17);
            this.BasicListBoxAssociate1.Margin = new System.Windows.Forms.Padding(4);
            this.BasicListBoxAssociate1.Name = "BasicListBoxAssociate1";
            this.BasicListBoxAssociate1.Padding = new System.Windows.Forms.Padding(4);
            this.BasicListBoxAssociate1.Size = new System.Drawing.Size(509, 550);
            this.BasicListBoxAssociate1.TabIndex = 15;
            this.BasicListBoxAssociate1.TabStop = false;
            this.BasicListBoxAssociate1.Text = "HexListBox1";
            // 
            // NamePanel
            // 
            this.NamePanel.Controls.Add(this.NameBox);
            this.NamePanel.Controls.Add(this.LabelName);
            this.NamePanel.HexOffset = "&H012B66";
            this.NamePanel.IndexOffset = "&H000002";
            this.NamePanel.Location = new System.Drawing.Point(8, 28);
            this.NamePanel.Margin = new System.Windows.Forms.Padding(4);
            this.NamePanel.Name = "NamePanel";
            this.NamePanel.Size = new System.Drawing.Size(480, 27);
            this.NamePanel.TabIndex = 44;
            // 
            // NameBox
            // 
            this.NameBox.Display = HexTools.HexEnumerations.DisplayType.Hex;
            this.NameBox.DisplayMember = "Text";
            this.NameBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.NameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameBox.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.NameBox.FormatString = "X4";
            this.NameBox.FormattingEnabled = true;
            this.NameBox.ItemCollection = "Text_Characters.HexListBox1";
            this.NameBox.Location = new System.Drawing.Point(124, 1);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameBox.MaxDropDownItems = 15;
            this.NameBox.MaxLength = 2;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(256, 23);
            this.NameBox.TabIndex = 31;
            this.NameBox.ValueDisplay = true;
            this.NameBox.ValueMember = "Value";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(74, 6);
            this.LabelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(49, 17);
            this.LabelName.TabIndex = 26;
            this.LabelName.Text = "Name:";
            // 
            // NoLevel
            // 
            this.NoLevel.AutoSize = true;
            this.NoLevel.Location = new System.Drawing.Point(134, 145);
            this.NoLevel.Name = "NoLevel";
            this.NoLevel.Size = new System.Drawing.Size(173, 17);
            this.NoLevel.TabIndex = 43;
            this.NoLevel.Text = "Character cannot level up!";
            this.NoLevel.Visible = false;
            // 
            // TransformationPanel
            // 
            this.TransformationPanel.Controls.Add(this.ExportLevelData);
            this.TransformationPanel.Controls.Add(this.NoTransformation);
            this.TransformationPanel.Controls.Add(this.Transformation);
            this.TransformationPanel.Controls.Add(this.LabelTransformation);
            this.TransformationPanel.HexOffset = "&H01867B";
            this.TransformationPanel.IndexOffset = "&H000001";
            this.TransformationPanel.Location = new System.Drawing.Point(8, 86);
            this.TransformationPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TransformationPanel.Name = "TransformationPanel";
            this.TransformationPanel.Size = new System.Drawing.Size(480, 27);
            this.TransformationPanel.TabIndex = 42;
            // 
            // NoTransformation
            // 
            this.NoTransformation.AutoSize = true;
            this.NoTransformation.Location = new System.Drawing.Point(126, 5);
            this.NoTransformation.Name = "NoTransformation";
            this.NoTransformation.Size = new System.Drawing.Size(184, 17);
            this.NoTransformation.TabIndex = 32;
            this.NoTransformation.Text = "Character cannot transform!";
            this.NoTransformation.Visible = false;
            // 
            // Transformation
            // 
            this.Transformation.Display = HexTools.HexEnumerations.DisplayType.Hex;
            this.Transformation.DisplayMember = "Text";
            this.Transformation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Transformation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Transformation.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.Transformation.FormatString = "X2";
            this.Transformation.FormattingEnabled = true;
            this.Transformation.ItemCollection = "Data_Battlers.HexListBox1";
            this.Transformation.Location = new System.Drawing.Point(124, 0);
            this.Transformation.Margin = new System.Windows.Forms.Padding(4);
            this.Transformation.MaxDropDownItems = 15;
            this.Transformation.MaxLength = 1;
            this.Transformation.Name = "Transformation";
            this.Transformation.Size = new System.Drawing.Size(256, 23);
            this.Transformation.TabIndex = 31;
            this.Transformation.ValueDisplay = true;
            this.Transformation.ValueMember = "Value";
            // 
            // LabelTransformation
            // 
            this.LabelTransformation.AutoSize = true;
            this.LabelTransformation.Location = new System.Drawing.Point(16, 5);
            this.LabelTransformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelTransformation.Name = "LabelTransformation";
            this.LabelTransformation.Size = new System.Drawing.Size(108, 17);
            this.LabelTransformation.TabIndex = 26;
            this.LabelTransformation.Text = "Transformation:";
            // 
            // Levels
            // 
            this.Levels.ColumnActivity = BasicTools.BasicControls.BasicTableView.TableViewColumnActivity.NonClickable;
            this.Levels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3,
            this.ColumnHeader4,
            this.ColumnHeader5,
            this.ColumnHeader6});
            this.Levels.DoubleClickActivation = true;
            this.Levels.Editors.AddRange(new BasicTools.BasicControls.EditableListViewItem[] {
            this.EditableListViewItem2,
            this.EditableListViewItemControl_16,
            this.EditableListViewItemControl_17,
            this.EditableListViewItemControl_18,
            this.EditableListViewItemControl_19,
            this.EditableListViewItemControl_160});
            this.Levels.Enabled = false;
            this.Levels.FullRowSelect = true;
            this.Levels.HexOffsetBaseType = HexTools.HexEnumerations.OffsetType.Temporary;
            this.Levels.HexOffsetCount = "&H01850E";
            this.Levels.HexOffsetCountPointer = 1;
            this.Levels.HexOffsetCountType = HexTools.HexEnumerations.OffsetType.Indexed;
            this.Levels.HexOffsetLength = "&H00000B";
            this.Levels.HideSelection = false;
            this.Levels.Location = new System.Drawing.Point(8, 115);
            this.Levels.Margin = new System.Windows.Forms.Padding(4);
            this.Levels.Name = "Levels";
            this.Levels.OwnerDraw = true;
            this.Levels.Size = new System.Drawing.Size(479, 427);
            this.Levels.Style = BasicTools.BasicControls.BasicTableView.TableViewStyles.Columns;
            this.Levels.TabIndex = 41;
            this.Levels.TempTableType = HexTools.HexTableView.TableType.Stat;
            this.Levels.UseCompatibleStateImageBehavior = false;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Level";
            this.ColumnHeader1.Width = 50;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Battle Power";
            this.ColumnHeader2.Width = 100;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "Experience";
            this.ColumnHeader3.Width = 100;
            // 
            // ColumnHeader4
            // 
            this.ColumnHeader4.Text = "Health";
            this.ColumnHeader4.Width = 70;
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "Ki";
            this.ColumnHeader5.Width = 65;
            // 
            // ColumnHeader6
            // 
            this.ColumnHeader6.Text = "Rage";
            this.ColumnHeader6.Width = 50;
            // 
            // BaseFormPanel
            // 
            this.BaseFormPanel.Controls.Add(this.NoBattler);
            this.BaseFormPanel.Controls.Add(this.Battler);
            this.BaseFormPanel.Controls.Add(this.LabelBattler);
            this.BaseFormPanel.HexOffset = "&H000AE5";
            this.BaseFormPanel.IndexOffset = "&H000001";
            this.BaseFormPanel.Location = new System.Drawing.Point(8, 57);
            this.BaseFormPanel.Margin = new System.Windows.Forms.Padding(4);
            this.BaseFormPanel.Name = "BaseFormPanel";
            this.BaseFormPanel.Size = new System.Drawing.Size(480, 27);
            this.BaseFormPanel.TabIndex = 40;
            // 
            // NoBattler
            // 
            this.NoBattler.AutoSize = true;
            this.NoBattler.Location = new System.Drawing.Point(126, 5);
            this.NoBattler.Name = "NoBattler";
            this.NoBattler.Size = new System.Drawing.Size(159, 17);
            this.NoBattler.TabIndex = 44;
            this.NoBattler.Text = "Character cannot battle!";
            this.NoBattler.Visible = false;
            // 
            // Battler
            // 
            this.Battler.Display = HexTools.HexEnumerations.DisplayType.Hex;
            this.Battler.DisplayMember = "Text";
            this.Battler.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Battler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Battler.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.Battler.FormatString = "X2";
            this.Battler.FormattingEnabled = true;
            this.Battler.ItemCollection = "Data_Battlers.HexListBox1";
            this.Battler.Location = new System.Drawing.Point(124, 1);
            this.Battler.Margin = new System.Windows.Forms.Padding(4);
            this.Battler.MaxDropDownItems = 15;
            this.Battler.MaxLength = 1;
            this.Battler.Name = "Battler";
            this.Battler.Size = new System.Drawing.Size(256, 23);
            this.Battler.TabIndex = 31;
            this.Battler.ValueDisplay = true;
            this.Battler.ValueMember = "Value";
            // 
            // LabelBattler
            // 
            this.LabelBattler.AutoSize = true;
            this.LabelBattler.Location = new System.Drawing.Point(44, 6);
            this.LabelBattler.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelBattler.Name = "LabelBattler";
            this.LabelBattler.Size = new System.Drawing.Size(80, 17);
            this.LabelBattler.TabIndex = 26;
            this.LabelBattler.Text = "Base Form:";
            // 
            // ExportLevelData
            // 
            this.ExportLevelData.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.Export;
            this.ExportLevelData.Location = new System.Drawing.Point(402, 0);
            this.ExportLevelData.Name = "ExportLevelData";
            this.ExportLevelData.Size = new System.Drawing.Size(41, 23);
            this.ExportLevelData.TabIndex = 45;
            this.ExportLevelData.UseVisualStyleBackColor = true;
            this.ExportLevelData.Click += new System.EventHandler(this.ExportLevelData_Click);
            // 
            // Data_Characters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BasicListBoxAssociate1);
            this.Controls.Add(this.HexListBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Data_Characters";
            this.Size = new System.Drawing.Size(787, 603);
            ((System.ComponentModel.ISupportInitialize)(this.EditableListViewItemControl_16.Control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditableListViewItemControl_17.Control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditableListViewItemControl_18.Control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditableListViewItemControl_19.Control)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditableListViewItemControl_160.Control)).EndInit();
            this.BasicListBoxAssociate1.ResumeLayout(false);
            this.BasicListBoxAssociate1.PerformLayout();
            this.NamePanel.ResumeLayout(false);
            this.NamePanel.PerformLayout();
            this.TransformationPanel.ResumeLayout(false);
            this.TransformationPanel.PerformLayout();
            this.BaseFormPanel.ResumeLayout(false);
            this.BaseFormPanel.PerformLayout();
            this.ResumeLayout(false);

        }
        internal HexTools.HexListBox HexListBox1;
        internal BasicTools.BasicControls.BasicListBoxAssociate BasicListBoxAssociate1;
        internal HexTools.HexTableView Levels;
        internal ColumnHeader ColumnHeader1;
        internal ColumnHeader ColumnHeader2;
        internal ColumnHeader ColumnHeader3;
        internal ColumnHeader ColumnHeader4;
        internal ColumnHeader ColumnHeader5;
        internal ColumnHeader ColumnHeader6;
        internal HexTools.HexPanel BaseFormPanel;
        internal HexTools.HexComboBox Battler;
        internal Label LabelBattler;
        internal BasicTools.BasicControls.EditableListViewItem EditableListViewItem2;
        internal HexTools.HexNumericBoxItemControl EditableListViewItemControl_16;
        internal HexTools.HexNumericBoxItemControl EditableListViewItemControl_17;
        internal HexTools.HexNumericBoxItemControl EditableListViewItemControl_18;
        internal HexTools.HexNumericBoxItemControl EditableListViewItemControl_19;
        internal HexTools.HexNumericBoxItemControl EditableListViewItemControl_160;
        internal HexTools.HexPanel TransformationPanel;
        internal HexTools.HexComboBox Transformation;
        internal Label LabelTransformation;
        private Label NoTransformation;
        private Label NoLevel;
        private Label NoBattler;
        internal HexTools.HexPanel NamePanel;
        internal HexTools.HexComboBox NameBox;
        internal Label LabelName;
        private Button ExportLevelData;
    }
}