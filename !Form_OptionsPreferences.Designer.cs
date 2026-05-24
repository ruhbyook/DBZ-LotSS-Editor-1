using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DBZ_LotSS_Editor
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form_OptionsPreferences : HexTools.HexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OptionsPreferences));
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.ControlPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AutoLoadWindows = new System.Windows.Forms.CheckBox();
            this.AutoLoadRecent = new System.Windows.Forms.CheckBox();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.BackupsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelBackups = new System.Windows.Forms.Label();
            this.Backups = new System.Windows.Forms.NumericUpDown();
            this.AutoBackup = new System.Windows.Forms.CheckBox();
            this.SupressUnsafeWarnings = new System.Windows.Forms.CheckBox();
            this.DataManagementPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LabelDataManagement = new System.Windows.Forms.Label();
            this.DataManagement = new System.Windows.Forms.ComboBox();
            this.PreferencesToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TableLayoutPanel1.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.BackupsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Backups)).BeginInit();
            this.DataManagementPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableLayoutPanel1.ColumnCount = 2;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 0, 0);
            this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
            this.TableLayoutPanel1.Location = new System.Drawing.Point(432, 412);
            this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(214, 45);
            this.TableLayoutPanel1.TabIndex = 1;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cancel_Button.Location = new System.Drawing.Point(112, 5);
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
            this.OK_Button.Location = new System.Drawing.Point(5, 5);
            this.OK_Button.Margin = new System.Windows.Forms.Padding(5);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(96, 35);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlPanel.Controls.Add(this.AutoLoadWindows);
            this.ControlPanel.Controls.Add(this.AutoLoadRecent);
            this.ControlPanel.Controls.Add(this.Panel1);
            this.ControlPanel.Controls.Add(this.SupressUnsafeWarnings);
            this.ControlPanel.Controls.Add(this.DataManagementPanel);
            this.ControlPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Padding = new System.Windows.Forms.Padding(12);
            this.ControlPanel.Size = new System.Drawing.Size(646, 404);
            this.ControlPanel.TabIndex = 12;
            // 
            // AutoLoadWindows
            // 
            this.AutoLoadWindows.AutoSize = true;
            this.AutoLoadWindows.Location = new System.Drawing.Point(16, 16);
            this.AutoLoadWindows.Margin = new System.Windows.Forms.Padding(4);
            this.AutoLoadWindows.Name = "AutoLoadWindows";
            this.AutoLoadWindows.Size = new System.Drawing.Size(266, 24);
            this.AutoLoadWindows.TabIndex = 14;
            this.AutoLoadWindows.Text = "Reload Last Opened Windows?";
            this.PreferencesToolTip.SetToolTip(this.AutoLoadWindows, "Automatically reload any windows and modules you last had opened when the Editor " +
        "was closed.");
            this.AutoLoadWindows.UseVisualStyleBackColor = true;
            this.AutoLoadWindows.CheckedChanged += new System.EventHandler(this.AutoLoadWindows_CheckedChanged);
            // 
            // AutoLoadRecent
            // 
            this.AutoLoadRecent.AutoSize = true;
            this.AutoLoadRecent.Location = new System.Drawing.Point(16, 48);
            this.AutoLoadRecent.Margin = new System.Windows.Forms.Padding(4);
            this.AutoLoadRecent.Name = "AutoLoadRecent";
            this.AutoLoadRecent.Size = new System.Drawing.Size(225, 24);
            this.AutoLoadRecent.TabIndex = 11;
            this.AutoLoadRecent.Text = "Reload Last Opened File?";
            this.PreferencesToolTip.SetToolTip(this.AutoLoadRecent, "Automatically reload whatever file you last had opened.");
            this.AutoLoadRecent.UseVisualStyleBackColor = true;
            this.AutoLoadRecent.CheckedChanged += new System.EventHandler(this.AutoLoadRecent_CheckedChanged);
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.BackupsPanel);
            this.Panel1.Controls.Add(this.AutoBackup);
            this.Panel1.Location = new System.Drawing.Point(16, 80);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(612, 38);
            this.Panel1.TabIndex = 13;
            // 
            // BackupsPanel
            // 
            this.BackupsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BackupsPanel.Controls.Add(this.LabelBackups);
            this.BackupsPanel.Controls.Add(this.Backups);
            this.BackupsPanel.Enabled = false;
            this.BackupsPanel.Location = new System.Drawing.Point(299, 0);
            this.BackupsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.BackupsPanel.Name = "BackupsPanel";
            this.BackupsPanel.Size = new System.Drawing.Size(314, 38);
            this.BackupsPanel.TabIndex = 13;
            // 
            // LabelBackups
            // 
            this.LabelBackups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelBackups.AutoSize = true;
            this.LabelBackups.Location = new System.Drawing.Point(4, 0);
            this.LabelBackups.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelBackups.Name = "LabelBackups";
            this.LabelBackups.Size = new System.Drawing.Size(151, 34);
            this.LabelBackups.TabIndex = 15;
            this.LabelBackups.Text = "Maximum Backups";
            this.LabelBackups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PreferencesToolTip.SetToolTip(this.LabelBackups, "The number of backups to keep before rewriting previously generated ones.");
            // 
            // Backups
            // 
            this.Backups.Location = new System.Drawing.Point(163, 4);
            this.Backups.Margin = new System.Windows.Forms.Padding(4);
            this.Backups.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.Backups.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Backups.Name = "Backups";
            this.Backups.Size = new System.Drawing.Size(68, 26);
            this.Backups.TabIndex = 16;
            this.PreferencesToolTip.SetToolTip(this.Backups, "Can store anywhere between 1-25 backups.");
            this.Backups.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Backups.ValueChanged += new System.EventHandler(this.Backups_ValueChanged);
            // 
            // AutoBackup
            // 
            this.AutoBackup.AutoSize = true;
            this.AutoBackup.Location = new System.Drawing.Point(0, 8);
            this.AutoBackup.Margin = new System.Windows.Forms.Padding(4);
            this.AutoBackup.Name = "AutoBackup";
            this.AutoBackup.Size = new System.Drawing.Size(257, 24);
            this.AutoBackup.TabIndex = 12;
            this.AutoBackup.Text = "Auto Generate A Backup File?";
            this.PreferencesToolTip.SetToolTip(this.AutoBackup, "Automatically generate a backup file whenever you perform a save operation.");
            this.AutoBackup.UseVisualStyleBackColor = true;
            this.AutoBackup.CheckedChanged += new System.EventHandler(this.AutoBackup_CheckedChanged);
            // 
            // SupressUnsafeWarnings
            // 
            this.SupressUnsafeWarnings.AutoSize = true;
            this.SupressUnsafeWarnings.Location = new System.Drawing.Point(16, 126);
            this.SupressUnsafeWarnings.Margin = new System.Windows.Forms.Padding(4);
            this.SupressUnsafeWarnings.Name = "SupressUnsafeWarnings";
            this.SupressUnsafeWarnings.Size = new System.Drawing.Size(295, 24);
            this.SupressUnsafeWarnings.TabIndex = 13;
            this.SupressUnsafeWarnings.Text = "Supress Unsafe Control Warnings?";
            this.PreferencesToolTip.SetToolTip(this.SupressUnsafeWarnings, "Disables any warnings the editor would normally give asking for confirmation abou" +
        "t using experimental controls.");
            this.SupressUnsafeWarnings.UseVisualStyleBackColor = true;
            this.SupressUnsafeWarnings.CheckedChanged += new System.EventHandler(this.SupressUnsafeWarnings_CheckedChanged);
            // 
            // DataManagementPanel
            // 
            this.DataManagementPanel.Controls.Add(this.LabelDataManagement);
            this.DataManagementPanel.Controls.Add(this.DataManagement);
            this.DataManagementPanel.Location = new System.Drawing.Point(16, 158);
            this.DataManagementPanel.Margin = new System.Windows.Forms.Padding(4);
            this.DataManagementPanel.Name = "DataManagementPanel";
            this.DataManagementPanel.Size = new System.Drawing.Size(314, 38);
            this.DataManagementPanel.TabIndex = 13;
            // 
            // LabelDataManagement
            // 
            this.LabelDataManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LabelDataManagement.AutoSize = true;
            this.LabelDataManagement.Location = new System.Drawing.Point(4, 0);
            this.LabelDataManagement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDataManagement.Name = "LabelDataManagement";
            this.LabelDataManagement.Size = new System.Drawing.Size(146, 34);
            this.LabelDataManagement.TabIndex = 15;
            this.LabelDataManagement.Text = "Data Management";
            this.LabelDataManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PreferencesToolTip.SetToolTip(this.LabelDataManagement, "The number of backups to keep before rewriting previously generated ones.");
            // 
            // DataManagement
            // 
            this.DataManagement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DataManagement.FormattingEnabled = true;
            this.DataManagement.Location = new System.Drawing.Point(157, 3);
            this.DataManagement.Name = "DataManagement";
            this.DataManagement.Size = new System.Drawing.Size(121, 28);
            this.DataManagement.TabIndex = 16;
            this.PreferencesToolTip.SetToolTip(this.DataManagement, resources.GetString("DataManagement.ToolTip"));
            this.DataManagement.SelectedIndexChanged += new System.EventHandler(this.DataManagement_SelectedIndexChanged);
            // 
            // PreferencesToolTip
            // 
            this.PreferencesToolTip.AutoPopDelay = 32000;
            this.PreferencesToolTip.InitialDelay = 500;
            this.PreferencesToolTip.IsBalloon = true;
            this.PreferencesToolTip.ReshowDelay = 100;
            // 
            // Form_OptionsPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 466);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.TableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(670, 513);
            this.Name = "Form_OptionsPreferences";
            this.Normal = new System.Drawing.Rectangle(19, 19, 670, 513);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_OptionsPreferences_FormClosing);
            this.Load += new System.EventHandler(this.Form_OptionsPreferences_Load);
            this.TableLayoutPanel1.ResumeLayout(false);
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.BackupsPanel.ResumeLayout(false);
            this.BackupsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Backups)).EndInit();
            this.DataManagementPanel.ResumeLayout(false);
            this.DataManagementPanel.PerformLayout();
            this.ResumeLayout(false);

        }
        internal TableLayoutPanel TableLayoutPanel1;
        internal Button OK_Button;
        internal Button Cancel_Button;
        internal FlowLayoutPanel ControlPanel;
        internal CheckBox AutoLoadRecent;
        internal CheckBox AutoBackup;
        internal Panel Panel1;
        internal FlowLayoutPanel BackupsPanel;
        internal Label LabelBackups;
        internal NumericUpDown Backups;
        internal ToolTip PreferencesToolTip;
        internal CheckBox SupressUnsafeWarnings;
        internal CheckBox AutoLoadWindows;
        internal FlowLayoutPanel DataManagementPanel;
        internal Label LabelDataManagement;
        private ComboBox DataManagement;
    }
}