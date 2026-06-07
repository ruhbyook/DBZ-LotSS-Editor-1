using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DBZ_LotSS_Editor
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Data_Global : HexTools.HexUserControl
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
            HexTools.HexOffsetType hexOffsetType7 = new HexTools.HexOffsetType();
            HexTools.HexOffsetType hexOffsetType8 = new HexTools.HexOffsetType();
            HexTools.HexOffsetType hexOffsetType9 = new HexTools.HexOffsetType();
            this.HexPanel1 = new HexTools.HexPanel();
            this.ExpandStorage = new HexTools.HexCheckBox();
            this.Party = new System.Windows.Forms.GroupBox();
            this.Member2Group = new System.Windows.Forms.GroupBox();
            this.Member2 = new HexTools.HexPanel();
            this.Level2 = new HexTools.HexNumericBox();
            this.Level2Label = new System.Windows.Forms.Label();
            this.Character2 = new HexTools.HexComboBox();
            this.Character2Label = new System.Windows.Forms.Label();
            this.Member1Group = new System.Windows.Forms.GroupBox();
            this.Member1 = new HexTools.HexPanel();
            this.Level1 = new HexTools.HexNumericBox();
            this.Level1Label = new System.Windows.Forms.Label();
            this.Character1 = new HexTools.HexComboBox();
            this.Character1Label = new System.Windows.Forms.Label();
            this.DebugMenu = new HexTools.HexCheckBox();
            this.FlagsLabel = new System.Windows.Forms.Label();
            this.HexPanel1.SuspendLayout();
            this.Party.SuspendLayout();
            this.Member2Group.SuspendLayout();
            this.Member2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Level2)).BeginInit();
            this.Member1Group.SuspendLayout();
            this.Member1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Level1)).BeginInit();
            this.SuspendLayout();
            // 
            // HexPanel1
            // 
            this.HexPanel1.Controls.Add(this.ExpandStorage);
            this.HexPanel1.Controls.Add(this.Party);
            this.HexPanel1.Controls.Add(this.DebugMenu);
            this.HexPanel1.Controls.Add(this.FlagsLabel);
            this.HexPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HexPanel1.IndexOffset = "&H000005";
            this.HexPanel1.Location = new System.Drawing.Point(0, 0);
            this.HexPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.HexPanel1.Name = "HexPanel1";
            this.HexPanel1.Size = new System.Drawing.Size(1180, 942);
            this.HexPanel1.TabIndex = 25;
            // 
            // ExpandStorage
            // 
            this.ExpandStorage.AutoSize = true;
            hexOffsetType7.HexOffset = "&H007FD7";
            hexOffsetType7.HexValueFalse = "&H00000A";
            hexOffsetType7.HexValueTrue = "&H00000C";
            this.ExpandStorage.HexOffsets = new HexTools.HexOffsetType[] {
        hexOffsetType7};
            this.ExpandStorage.Location = new System.Drawing.Point(28, 41);
            this.ExpandStorage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExpandStorage.Name = "ExpandStorage";
            this.ExpandStorage.Size = new System.Drawing.Size(198, 29);
            this.ExpandStorage.TabIndex = 18;
            this.ExpandStorage.Text = "Expand Storage";
            this.ExpandStorage.UseVisualStyleBackColor = true;
            // 
            // Party
            // 
            this.Party.Controls.Add(this.Member2Group);
            this.Party.Controls.Add(this.Member1Group);
            this.Party.Location = new System.Drawing.Point(10, 134);
            this.Party.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Party.Name = "Party";
            this.Party.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Party.Size = new System.Drawing.Size(969, 250);
            this.Party.TabIndex = 17;
            this.Party.TabStop = false;
            this.Party.Text = "Party";
            // 
            // Member2Group
            // 
            this.Member2Group.Controls.Add(this.Member2);
            this.Member2Group.Location = new System.Drawing.Point(9, 133);
            this.Member2Group.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Member2Group.Name = "Member2Group";
            this.Member2Group.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Member2Group.Size = new System.Drawing.Size(951, 91);
            this.Member2Group.TabIndex = 36;
            this.Member2Group.TabStop = false;
            this.Member2Group.Text = "Member 2";
            // 
            // Member2
            // 
            this.Member2.Controls.Add(this.Level2);
            this.Member2.Controls.Add(this.Level2Label);
            this.Member2.Controls.Add(this.Character2);
            this.Member2.Controls.Add(this.Character2Label);
            this.Member2.HexOffset = "&H01EAA2";
            this.Member2.Location = new System.Drawing.Point(9, 36);
            this.Member2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Member2.Name = "Member2";
            this.Member2.Size = new System.Drawing.Size(933, 45);
            this.Member2.TabIndex = 34;
            // 
            // Level2
            // 
            this.Level2.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.Level2.ExcludeRanged = new int[0];
            this.Level2.HexOffset = "&H000001";
            this.Level2.Location = new System.Drawing.Point(573, 6);
            this.Level2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Level2.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.Level2.MaxLength = 1;
            this.Level2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Level2.Name = "Level2";
            this.Level2.Size = new System.Drawing.Size(180, 31);
            this.Level2.TabIndex = 35;
            this.Level2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Level2Label
            // 
            this.Level2Label.AutoSize = true;
            this.Level2Label.Location = new System.Drawing.Point(508, 8);
            this.Level2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Level2Label.Name = "Level2Label";
            this.Level2Label.Size = new System.Drawing.Size(70, 25);
            this.Level2Label.TabIndex = 34;
            this.Level2Label.Text = "Level:";
            // 
            // Character2
            // 
            this.Character2.Definition = "DataEditor.Characters.List";
            this.Character2.DefinitionOffsetFormat = HexTools.HexEnumerations.HexAddressFormatType.Index;
            this.Character2.Display = HexTools.HexEnumerations.DisplayType.Hex;
            this.Character2.DisplayMember = "Text";
            this.Character2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Character2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Character2.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.Character2.FormatString = "X2";
            this.Character2.FormattingEnabled = true;
            this.Character2.Location = new System.Drawing.Point(114, 3);
            this.Character2.Margin = new System.Windows.Forms.Padding(6);
            this.Character2.MaxDropDownItems = 15;
            this.Character2.MaxLength = 1;
            this.Character2.Name = "Character2";
            this.Character2.NullValue = "&HFF";
            this.Character2.Size = new System.Drawing.Size(382, 32);
            this.Character2.TabIndex = 32;
            this.Character2.ValueDisplay = true;
            this.Character2.ValueMember = "Value";
            // 
            // Character2Label
            // 
            this.Character2Label.AutoSize = true;
            this.Character2Label.Location = new System.Drawing.Point(4, 8);
            this.Character2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Character2Label.Name = "Character2Label";
            this.Character2Label.Size = new System.Drawing.Size(112, 25);
            this.Character2Label.TabIndex = 33;
            this.Character2Label.Text = "Character:";
            // 
            // Member1Group
            // 
            this.Member1Group.Controls.Add(this.Member1);
            this.Member1Group.Location = new System.Drawing.Point(9, 33);
            this.Member1Group.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Member1Group.Name = "Member1Group";
            this.Member1Group.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Member1Group.Size = new System.Drawing.Size(951, 91);
            this.Member1Group.TabIndex = 35;
            this.Member1Group.TabStop = false;
            this.Member1Group.Text = "Member 1";
            // 
            // Member1
            // 
            this.Member1.Controls.Add(this.Level1);
            this.Member1.Controls.Add(this.Level1Label);
            this.Member1.Controls.Add(this.Character1);
            this.Member1.Controls.Add(this.Character1Label);
            this.Member1.HexOffset = "&H01EA96";
            this.Member1.Location = new System.Drawing.Point(9, 36);
            this.Member1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Member1.Name = "Member1";
            this.Member1.Size = new System.Drawing.Size(933, 45);
            this.Member1.TabIndex = 34;
            // 
            // Level1
            // 
            this.Level1.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.Level1.ExcludeRanged = new int[0];
            this.Level1.HexOffset = "&H000001";
            this.Level1.Location = new System.Drawing.Point(573, 6);
            this.Level1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Level1.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.Level1.MaxLength = 1;
            this.Level1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Level1.Name = "Level1";
            this.Level1.Size = new System.Drawing.Size(180, 31);
            this.Level1.TabIndex = 35;
            this.Level1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Level1Label
            // 
            this.Level1Label.AutoSize = true;
            this.Level1Label.Location = new System.Drawing.Point(508, 8);
            this.Level1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Level1Label.Name = "Level1Label";
            this.Level1Label.Size = new System.Drawing.Size(70, 25);
            this.Level1Label.TabIndex = 34;
            this.Level1Label.Text = "Level:";
            // 
            // Character1
            // 
            this.Character1.Definition = "DataEditor.Characters.List";
            this.Character1.DefinitionOffsetFormat = HexTools.HexEnumerations.HexAddressFormatType.Index;
            this.Character1.Display = HexTools.HexEnumerations.DisplayType.Hex;
            this.Character1.DisplayMember = "Text";
            this.Character1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Character1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Character1.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.Character1.FormatString = "X2";
            this.Character1.FormattingEnabled = true;
            this.Character1.Location = new System.Drawing.Point(114, 3);
            this.Character1.Margin = new System.Windows.Forms.Padding(6);
            this.Character1.MaxDropDownItems = 15;
            this.Character1.MaxLength = 1;
            this.Character1.Name = "Character1";
            this.Character1.NullValue = "&HFF";
            this.Character1.Size = new System.Drawing.Size(382, 32);
            this.Character1.TabIndex = 32;
            this.Character1.ValueDisplay = true;
            this.Character1.ValueMember = "Value";
            // 
            // Character1Label
            // 
            this.Character1Label.AutoSize = true;
            this.Character1Label.Location = new System.Drawing.Point(4, 8);
            this.Character1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Character1Label.Name = "Character1Label";
            this.Character1Label.Size = new System.Drawing.Size(112, 25);
            this.Character1Label.TabIndex = 33;
            this.Character1Label.Text = "Character:";
            // 
            // DebugMenu
            // 
            this.DebugMenu.AutoSize = true;
            hexOffsetType8.HexOffset = "&H00180D";
            hexOffsetType8.HexValueFalse = "&H00A90F";
            hexOffsetType8.HexValueTrue = "&H00A90A";
            hexOffsetType8.MaxLength = 2;
            hexOffsetType9.HexOffset = "&H016232";
            hexOffsetType9.HexValueFalse = "&H000005";
            hexOffsetType9.HexValueTrue = "&H000007";
            this.DebugMenu.HexOffsets = new HexTools.HexOffsetType[] {
        hexOffsetType8,
        hexOffsetType9};
            this.DebugMenu.Location = new System.Drawing.Point(28, 83);
            this.DebugMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DebugMenu.Name = "DebugMenu";
            this.DebugMenu.Size = new System.Drawing.Size(167, 29);
            this.DebugMenu.TabIndex = 16;
            this.DebugMenu.Text = "Debug Menu";
            this.DebugMenu.UseVisualStyleBackColor = true;
            // 
            // FlagsLabel
            // 
            this.FlagsLabel.AutoSize = true;
            this.FlagsLabel.Location = new System.Drawing.Point(6, 9);
            this.FlagsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FlagsLabel.Name = "FlagsLabel";
            this.FlagsLabel.Size = new System.Drawing.Size(79, 25);
            this.FlagsLabel.TabIndex = 15;
            this.FlagsLabel.Text = "Enable";
            // 
            // Data_Global
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HexPanel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Data_Global";
            this.Size = new System.Drawing.Size(1180, 942);
            this.HexPanel1.ResumeLayout(false);
            this.HexPanel1.PerformLayout();
            this.Party.ResumeLayout(false);
            this.Member2Group.ResumeLayout(false);
            this.Member2.ResumeLayout(false);
            this.Member2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Level2)).EndInit();
            this.Member1Group.ResumeLayout(false);
            this.Member1.ResumeLayout(false);
            this.Member1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Level1)).EndInit();
            this.ResumeLayout(false);

        }
        internal HexTools.HexPanel HexPanel1;
        internal Label FlagsLabel;
        internal HexTools.HexCheckBox DebugMenu;
        private GroupBox Party;
        private GroupBox Member1Group;
        private HexTools.HexPanel Member1;
        private HexTools.HexNumericBox Level1;
        private Label Level1Label;
        internal HexTools.HexComboBox Character1;
        private Label Character1Label;
        private GroupBox Member2Group;
        private HexTools.HexPanel Member2;
        private HexTools.HexNumericBox Level2;
        private Label Level2Label;
        internal HexTools.HexComboBox Character2;
        private Label Character2Label;
        internal HexTools.HexCheckBox ExpandStorage;
    }
}