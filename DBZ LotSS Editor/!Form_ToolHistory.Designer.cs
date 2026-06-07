using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DBZ_LotSS_Editor
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form_ToolHistory : HexTools.HexForm
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
            components = new System.ComponentModel.Container();
            ControlsPanel = new TableLayoutPanel();
            OK_Button = new Button();
            OK_Button.Click += new EventHandler(OK_Button_Click);
            ContentPanel = new TableLayoutPanel();
            ActionsPanel = new FlowLayoutPanel();
            CheckBoxSort = new CheckBox();
            CheckBoxSort.CheckedChanged += new EventHandler(CheckBoxSort_CheckedChanged);
            PanelExport = new Panel();
            LabelDisabled = new Label();
            ExportButton = new Button();
            FiltersPanel = new TableLayoutPanel();
            ComboBoxControl = new ComboBox();
            ComboBoxControl.SelectedIndexChanged += new EventHandler(ComboBoxControl_SelectedIndexChanged);
            ComboBoxControl.KeyDown += new KeyEventHandler(ComboBoxControl_KeyDown);
            LabelModule = new Label();
            ComboBoxModule = new ComboBox();
            ComboBoxModule.SelectedIndexChanged += new EventHandler(ComboBoxModule_SelectedIndexChanged);
            ComboBoxModule.KeyDown += new KeyEventHandler(ComboBoxModule_KeyDown);
            LabelControl = new Label();
            TreeViewHistory = new TreeView();
            HistoryToolTip = new ToolTip(components);
            LabelEmpty = new Label();
            AbsoluteCenterLayout = new TableLayoutPanel();
            ChangeContextMenuStrip = new ContextMenuStrip(components);
            CopyToolStripMenuItem = new ToolStripMenuItem();
            CopyToolStripMenuItem.Click += new EventHandler(CopyToolStripMenuItem_Click);
            ControlsPanel.SuspendLayout();
            ContentPanel.SuspendLayout();
            ActionsPanel.SuspendLayout();
            PanelExport.SuspendLayout();
            FiltersPanel.SuspendLayout();
            AbsoluteCenterLayout.SuspendLayout();
            ChangeContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ControlsPanel
            // 
            ControlsPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ControlsPanel.ColumnCount = 1;
            ControlsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            ControlsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            ControlsPanel.Controls.Add(OK_Button, 1, 0);
            ControlsPanel.Location = new Point(0, 412);
            ControlsPanel.Margin = new Padding(5);
            ControlsPanel.Name = "ControlsPanel";
            ControlsPanel.RowCount = 1;
            ControlsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            ControlsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45.0f));
            ControlsPanel.Size = new Size(646, 45);
            ControlsPanel.TabIndex = 1;
            // 
            // OK_Button
            // 
            OK_Button.Anchor = AnchorStyles.None;
            OK_Button.Location = new Point(275, 5);
            OK_Button.Margin = new Padding(5);
            OK_Button.Name = "OK_Button";
            OK_Button.Size = new Size(96, 35);
            OK_Button.TabIndex = 0;
            OK_Button.Text = "OK";
            // 
            // ContentPanel
            // 
            ContentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            ContentPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ContentPanel.ColumnCount = 1;
            ContentPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0f));
            ContentPanel.Controls.Add(ActionsPanel, 0, 0);
            ContentPanel.Controls.Add(FiltersPanel, 0, 1);
            ContentPanel.Controls.Add(TreeViewHistory, 0, 2);
            ContentPanel.Enabled = false;
            ContentPanel.Location = new Point(0, 0);
            ContentPanel.Margin = new Padding(4);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Padding = new Padding(12);
            ContentPanel.RowCount = 3;
            ContentPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44.0f));
            ContentPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44.0f));
            ContentPanel.RowStyles.Add(new RowStyle());
            ContentPanel.Size = new Size(645, 402);
            ContentPanel.TabIndex = 12;
            // 
            // ActionsPanel
            // 
            ActionsPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ActionsPanel.Controls.Add(CheckBoxSort);
            ActionsPanel.Controls.Add(PanelExport);
            ActionsPanel.FlowDirection = FlowDirection.RightToLeft;
            ActionsPanel.Location = new Point(17, 16);
            ActionsPanel.Margin = new Padding(4);
            ActionsPanel.Name = "ActionsPanel";
            ActionsPanel.Size = new Size(612, 36);
            ActionsPanel.TabIndex = 13;
            // 
            // CheckBoxSort
            // 
            CheckBoxSort.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CheckBoxSort.Appearance = Appearance.Button;
            CheckBoxSort.AutoSize = true;
            CheckBoxSort.Image = My.Resources.Resources.sort16;
            CheckBoxSort.ImageAlign = ContentAlignment.MiddleLeft;
            CheckBoxSort.Location = new Point(517, 4);
            CheckBoxSort.Margin = new Padding(4);
            CheckBoxSort.Name = "CheckBoxSort";
            CheckBoxSort.Size = new Size(91, 30);
            CheckBoxSort.TabIndex = 18;
            CheckBoxSort.Text = "Newest";
            CheckBoxSort.TextImageRelation = TextImageRelation.ImageBeforeText;
            HistoryToolTip.SetToolTip(CheckBoxSort, "Toggle history order between Most Recent & Least Recent changes.");
            CheckBoxSort.UseVisualStyleBackColor = true;
            // 
            // PanelExport
            // 
            PanelExport.Controls.Add(LabelDisabled);
            PanelExport.Controls.Add(ExportButton);
            PanelExport.Dock = DockStyle.Fill;
            PanelExport.Location = new Point(429, 4);
            PanelExport.Margin = new Padding(4);
            PanelExport.Name = "PanelExport";
            PanelExport.Size = new Size(80, 30);
            PanelExport.TabIndex = 19;
            // 
            // LabelDisabled
            // 
            LabelDisabled.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            LabelDisabled.BackColor = SystemColors.ActiveBorder;
            LabelDisabled.ForeColor = SystemColors.ControlDarkDark;
            LabelDisabled.Location = new Point(0, 3);
            LabelDisabled.Margin = new Padding(4, 0, 4, 0);
            LabelDisabled.Name = "LabelDisabled";
            LabelDisabled.Size = new Size(81, 25);
            LabelDisabled.TabIndex = 15;
            LabelDisabled.Text = "Export";
            LabelDisabled.TextAlign = ContentAlignment.MiddleCenter;
            HistoryToolTip.SetToolTip(LabelDisabled, "Not Yet Available... would like to be able to create an IPS patch");
            // 
            // ExportButton
            // 
            ExportButton.Dock = DockStyle.Fill;
            ExportButton.Enabled = false;
            ExportButton.Location = new Point(0, 0);
            ExportButton.Margin = new Padding(4);
            ExportButton.Name = "ExportButton";
            ExportButton.Size = new Size(80, 30);
            ExportButton.TabIndex = 17;
            ExportButton.Text = "Export";
            ExportButton.UseVisualStyleBackColor = true;
            // 
            // FiltersPanel
            // 
            FiltersPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FiltersPanel.ColumnCount = 4;
            FiltersPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88.0f));
            FiltersPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            FiltersPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88.0f));
            FiltersPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            FiltersPanel.Controls.Add(ComboBoxControl, 3, 0);
            FiltersPanel.Controls.Add(LabelModule, 0, 0);
            FiltersPanel.Controls.Add(ComboBoxModule, 1, 0);
            FiltersPanel.Controls.Add(LabelControl, 2, 0);
            FiltersPanel.Location = new Point(16, 60);
            FiltersPanel.Margin = new Padding(4);
            FiltersPanel.Name = "FiltersPanel";
            FiltersPanel.RowCount = 1;
            FiltersPanel.RowStyles.Add(new RowStyle());
            FiltersPanel.Size = new Size(613, 36);
            FiltersPanel.TabIndex = 18;
            // 
            // ComboBoxControl
            // 
            ComboBoxControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxControl.FormattingEnabled = true;
            ComboBoxControl.IntegralHeight = false;
            ComboBoxControl.Location = new Point(398, 4);
            ComboBoxControl.Margin = new Padding(4);
            ComboBoxControl.MaxDropDownItems = 15;
            ComboBoxControl.MaximumSize = new Size(374, 0);
            ComboBoxControl.Name = "ComboBoxControl";
            ComboBoxControl.Size = new Size(211, 28);
            ComboBoxControl.TabIndex = 6;
            HistoryToolTip.SetToolTip(ComboBoxControl, "Filter by the Control used to make the change. Note: you can type in any text, th" + "e options are just given as suggestions.");
            // 
            // LabelModule
            // 
            LabelModule.AutoSize = true;
            LabelModule.Dock = DockStyle.Fill;
            LabelModule.Location = new Point(4, 0);
            LabelModule.Margin = new Padding(4, 0, 4, 0);
            LabelModule.Name = "LabelModule";
            LabelModule.Size = new Size(80, 38);
            LabelModule.TabIndex = 5;
            LabelModule.Text = "Module";
            LabelModule.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ComboBoxModule
            // 
            ComboBoxModule.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ComboBoxModule.CausesValidation = false;
            ComboBoxModule.FormattingEnabled = true;
            ComboBoxModule.Location = new Point(92, 4);
            ComboBoxModule.Margin = new Padding(4);
            ComboBoxModule.MaxDropDownItems = 15;
            ComboBoxModule.MaximumSize = new Size(374, 0);
            ComboBoxModule.Name = "ComboBoxModule";
            ComboBoxModule.Size = new Size(210, 28);
            ComboBoxModule.TabIndex = 4;
            HistoryToolTip.SetToolTip(ComboBoxModule, "Filter by the Module used to make the change. Note: you can type in any text, the" + " options are just given as suggestions.");
            // 
            // LabelControl
            // 
            LabelControl.Dock = DockStyle.Fill;
            LabelControl.Location = new Point(310, 0);
            LabelControl.Margin = new Padding(4, 0, 4, 0);
            LabelControl.Name = "LabelControl";
            LabelControl.Size = new Size(80, 38);
            LabelControl.TabIndex = 4;
            LabelControl.Text = "Control";
            LabelControl.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TreeViewHistory
            // 
            TreeViewHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            TreeViewHistory.Location = new Point(16, 104);
            TreeViewHistory.Margin = new Padding(4);
            TreeViewHistory.Name = "TreeViewHistory";
            TreeViewHistory.Size = new Size(613, 282);
            TreeViewHistory.TabIndex = 14;
            // 
            // HistoryToolTip
            // 
            HistoryToolTip.IsBalloon = true;
            // 
            // LabelEmpty
            // 
            LabelEmpty.Anchor = AnchorStyles.None;
            LabelEmpty.AutoSize = true;
            LabelEmpty.BackColor = SystemColors.Window;
            LabelEmpty.Location = new Point(78, 52);
            LabelEmpty.Margin = new Padding(4, 0, 4, 0);
            LabelEmpty.Name = "LabelEmpty";
            LabelEmpty.Size = new Size(94, 20);
            LabelEmpty.TabIndex = 13;
            LabelEmpty.Text = "No History!";
            LabelEmpty.TextAlign = ContentAlignment.MiddleCenter;
            HistoryToolTip.SetToolTip(LabelEmpty, "Go make some changes in the Editor!");
            // 
            // AbsoluteCenterLayout
            // 
            AbsoluteCenterLayout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            AbsoluteCenterLayout.BackColor = SystemColors.Window;
            AbsoluteCenterLayout.ColumnCount = 1;
            AbsoluteCenterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            AbsoluteCenterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            AbsoluteCenterLayout.Controls.Add(LabelEmpty, 0, 0);
            AbsoluteCenterLayout.Location = new Point(201, 180);
            AbsoluteCenterLayout.Margin = new Padding(4);
            AbsoluteCenterLayout.Name = "AbsoluteCenterLayout";
            AbsoluteCenterLayout.RowCount = 1;
            AbsoluteCenterLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            AbsoluteCenterLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            AbsoluteCenterLayout.Size = new Size(250, 125);
            AbsoluteCenterLayout.TabIndex = 14;
            // 
            // ChangeContextMenuStrip
            // 
            ChangeContextMenuStrip.ImageScalingSize = new Size(20, 20);
            ChangeContextMenuStrip.Items.AddRange(new ToolStripItem[] { CopyToolStripMenuItem });
            ChangeContextMenuStrip.Name = "ChangeContextMenuStrip";
            ChangeContextMenuStrip.Size = new Size(168, 30);
            // 
            // CopyToolStripMenuItem
            // 
            CopyToolStripMenuItem.Image = My.Resources.Resources.Copy;
            CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            CopyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            CopyToolStripMenuItem.Size = new Size(167, 26);
            CopyToolStripMenuItem.Text = "&Copy";
            // 
            // Form_ToolHistory
            // 
            AutoScaleDimensions = new SizeF(10.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 466);
            Controls.Add(AbsoluteCenterLayout);
            Controls.Add(ContentPanel);
            Controls.Add(ControlsPanel);
            Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            MinimumSize = new Size(670, 513);
            Name = "Form_ToolHistory";
            Normal = new Rectangle(19, 19, 670, 513);
            StartPosition = FormStartPosition.CenterParent;
            Text = "History Viewer";
            ControlsPanel.ResumeLayout(false);
            ContentPanel.ResumeLayout(false);
            ActionsPanel.ResumeLayout(false);
            ActionsPanel.PerformLayout();
            PanelExport.ResumeLayout(false);
            FiltersPanel.ResumeLayout(false);
            FiltersPanel.PerformLayout();
            AbsoluteCenterLayout.ResumeLayout(false);
            AbsoluteCenterLayout.PerformLayout();
            ChangeContextMenuStrip.ResumeLayout(false);
            Load += new EventHandler(Form_ToolHistory_Load);
            FormClosing += new FormClosingEventHandler(Form_ToolHistory_FormClosing);
            ResumeLayout(false);

        }
        internal TableLayoutPanel ControlsPanel;
        internal Button OK_Button;
        internal TableLayoutPanel ContentPanel;
        internal FlowLayoutPanel ActionsPanel;
        internal ToolTip HistoryToolTip;
        internal TreeView TreeViewHistory;
        internal Button ExportButton;
        internal TableLayoutPanel FiltersPanel;
        internal Label LabelEmpty;
        internal TableLayoutPanel AbsoluteCenterLayout;
        internal ContextMenuStrip ChangeContextMenuStrip;
        internal ToolStripMenuItem CopyToolStripMenuItem;
        internal Label LabelControl;
        internal ComboBox ComboBoxModule;
        internal ComboBox ComboBoxControl;
        internal Label LabelModule;
        internal Label LabelDisabled;
        internal CheckBox CheckBoxSort;
        internal Panel PanelExport;
    }
}