using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DBZ_LotSS_Editor
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form_ToolData : HexTools.HexForm
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
            FlowLayoutPanel1 = new FlowLayoutPanel();
            OK_Button = new Button();
            OK_Button.Click += new EventHandler(OK_Button_Click);
            Cancel_Button = new Button();
            Cancel_Button.Click += new EventHandler(Cancel_Button_Click);
            ContentPanel = new TableLayoutPanel();
            ActionsPanel = new FlowLayoutPanel();
            HexDeveloper = new HexTools.HexDeveloper();
            DataToolTip = new ToolTip(components);
            LabelEmpty = new Label();
            ChangeContextMenuStrip = new ContextMenuStrip(components);
            CopyToolStripMenuItem = new ToolStripMenuItem();
            AbsoluteCenterLayout = new TableLayoutPanel();
            MenuStrip1 = new MenuStrip();
            SearchToolStripMenuItem = new ToolStripMenuItem();
            FindToolStripMenuItem = new ToolStripMenuItem();
            FindToolStripMenuItem.Click += new EventHandler(FindToolStripMenuItem_Click);
            NextToolStripMenuItem = new ToolStripMenuItem();
            NextToolStripMenuItem.Click += new EventHandler(NextToolStripMenuItem_Click);
            LastToolStripMenuItem = new ToolStripMenuItem();
            LastToolStripMenuItem.Click += new EventHandler(LastToolStripMenuItem_Click);
            FindAllToolStripMenuItem = new ToolStripMenuItem();
            FindAllToolStripMenuItem.Click += new EventHandler(FindAllToolStripMenuItem_Click);
            ToolStripSeparator1 = new ToolStripSeparator();
            ClearToolStripMenuItem = new ToolStripMenuItem();
            ClearToolStripMenuItem.Click += new EventHandler(ClearToolStripMenuItem_Click);
            ViewToolStripMenuItem = new ToolStripMenuItem();
            DisplayToolStripMenuItem = new ToolStripMenuItem();
            PlainTextToolStripMenuItem = new ToolStripMenuItem();
            PlainTextToolStripMenuItem.Click += new EventHandler(PlainTextToolStripMenuItem_Click);
            FontTableToolStripMenuItem = new ToolStripMenuItem();
            FontTableToolStripMenuItem.Click += new EventHandler(FontTableToolStripMenuItem_Click);
            ZoomToolStripMenuItem = new ToolStripMenuItem();
            ZoomMenuItem0 = new ToolStripMenuItem();
            ZoomMenuItem0.Click += new EventHandler(ZoomMenuItem0_Click);
            ZoomMenuItem1 = new ToolStripMenuItem();
            ZoomMenuItem1.Click += new EventHandler(ZoomMenuItem1_Click);
            ZoomMenuItem2 = new ToolStripMenuItem();
            ZoomMenuItem2.Click += new EventHandler(ZoomMenuItem2_Click);
            ZoomMenuItem3 = new ToolStripMenuItem();
            ZoomMenuItem3.Click += new EventHandler(ZoomMenuItem3_Click);
            ZoomMenuItem4 = new ToolStripMenuItem();
            ZoomMenuItem4.Click += new EventHandler(ZoomMenuItem4_Click);
            ZoomMenuItem5 = new ToolStripMenuItem();
            ZoomMenuItem5.Click += new EventHandler(ZoomMenuItem5_Click);
            ZoomMenuItem6 = new ToolStripMenuItem();
            ZoomMenuItem6.Click += new EventHandler(ZoomMenuItem6_Click);
            ZoomMenuItem7 = new ToolStripMenuItem();
            ZoomMenuItem7.Click += new EventHandler(ZoomMenuItem7_Click);
            ZoomMenuItem8 = new ToolStripMenuItem();
            ZoomMenuItem8.Click += new EventHandler(ZoomMenuItem8_Click);
            ZoomMenuItem9 = new ToolStripMenuItem();
            ZoomMenuItem9.Click += new EventHandler(ZoomMenuItem9_Click);
            ToolStripSeparator2 = new ToolStripSeparator();
            ZoomMenuItemPlus = new ToolStripMenuItem();
            ZoomMenuItemPlus.Click += new EventHandler(ZoomMenuItemPlus_Click);
            ZoomMenuItemMinus = new ToolStripMenuItem();
            ZoomMenuItemMinus.Click += new EventHandler(ZoomMenuItemMinus_Click);
            GoToToolStripMenuItem = new ToolStripMenuItem();
            GoToToolStripMenuItem.Click += new EventHandler(GoToToolStripMenuItem_Click);
            ControlsPanel.SuspendLayout();
            FlowLayoutPanel1.SuspendLayout();
            ContentPanel.SuspendLayout();
            ChangeContextMenuStrip.SuspendLayout();
            AbsoluteCenterLayout.SuspendLayout();
            MenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ControlsPanel
            // 
            ControlsPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ControlsPanel.ColumnCount = 1;
            ControlsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            ControlsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            ControlsPanel.Controls.Add(FlowLayoutPanel1, 0, 0);
            ControlsPanel.Location = new Point(0, 434);
            ControlsPanel.Margin = new Padding(5);
            ControlsPanel.Name = "ControlsPanel";
            ControlsPanel.RowCount = 1;
            ControlsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            ControlsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45.0f));
            ControlsPanel.Size = new Size(646, 45);
            ControlsPanel.TabIndex = 1;
            // 
            // FlowLayoutPanel1
            // 
            FlowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FlowLayoutPanel1.Controls.Add(OK_Button);
            FlowLayoutPanel1.Controls.Add(Cancel_Button);
            FlowLayoutPanel1.Location = new Point(431, 3);
            FlowLayoutPanel1.Name = "FlowLayoutPanel1";
            FlowLayoutPanel1.Size = new Size(212, 39);
            FlowLayoutPanel1.TabIndex = 0;
            // 
            // OK_Button
            // 
            OK_Button.Anchor = AnchorStyles.None;
            OK_Button.Location = new Point(5, 5);
            OK_Button.Margin = new Padding(5);
            OK_Button.Name = "OK_Button";
            OK_Button.Size = new Size(96, 35);
            OK_Button.TabIndex = 1;
            OK_Button.Text = "OK";
            // 
            // Cancel_Button
            // 
            Cancel_Button.Anchor = AnchorStyles.None;
            Cancel_Button.Location = new Point(111, 5);
            Cancel_Button.Margin = new Padding(5);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new Size(96, 35);
            Cancel_Button.TabIndex = 2;
            Cancel_Button.Text = "Cancel";
            // 
            // ContentPanel
            // 
            ContentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            ContentPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ContentPanel.ColumnCount = 1;
            ContentPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100.0f));
            ContentPanel.Controls.Add(ActionsPanel, 0, 0);
            ContentPanel.Controls.Add(HexDeveloper, 0, 1);
            ContentPanel.Enabled = false;
            ContentPanel.Location = new Point(0, 0);
            ContentPanel.Margin = new Padding(4);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Padding = new Padding(12);
            ContentPanel.RowCount = 2;
            ContentPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 44.0f));
            ContentPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100.0f));
            ContentPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20.0f));
            ContentPanel.Size = new Size(645, 424);
            ContentPanel.TabIndex = 12;
            // 
            // ActionsPanel
            // 
            ActionsPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ActionsPanel.FlowDirection = FlowDirection.RightToLeft;
            ActionsPanel.Location = new Point(16, 27);
            ActionsPanel.Margin = new Padding(4);
            ActionsPanel.Name = "ActionsPanel";
            ActionsPanel.Size = new Size(613, 25);
            ActionsPanel.TabIndex = 13;
            // 
            // HexDeveloper
            // 
            HexDeveloper.AutoScroll = true;
            HexDeveloper.Dock = DockStyle.Fill;
            HexDeveloper.Location = new Point(16, 60);
            HexDeveloper.Margin = new Padding(4);
            HexDeveloper.Name = "HexDeveloper";
            HexDeveloper.Size = new Size(613, 348);
            HexDeveloper.TabIndex = 14;
            HexDeveloper.ViewMode = HexTools.HexEnumerations.ViewHexType.FontTable;
            // 
            // DataToolTip
            // 
            DataToolTip.IsBalloon = true;
            // 
            // LabelEmpty
            // 
            LabelEmpty.Anchor = AnchorStyles.None;
            LabelEmpty.AutoSize = true;
            LabelEmpty.BackColor = SystemColors.Window;
            LabelEmpty.Location = new Point(87, 63);
            LabelEmpty.Margin = new Padding(4, 0, 4, 0);
            LabelEmpty.Name = "LabelEmpty";
            LabelEmpty.Size = new Size(76, 20);
            LabelEmpty.TabIndex = 13;
            LabelEmpty.Text = "No Data!";
            LabelEmpty.TextAlign = ContentAlignment.MiddleCenter;
            DataToolTip.SetToolTip(LabelEmpty, "Please load a file!");
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
            // AbsoluteCenterLayout
            // 
            AbsoluteCenterLayout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            AbsoluteCenterLayout.BackColor = SystemColors.Window;
            AbsoluteCenterLayout.ColumnCount = 1;
            AbsoluteCenterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            AbsoluteCenterLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            AbsoluteCenterLayout.Controls.Add(LabelEmpty, 0, 0);
            AbsoluteCenterLayout.Location = new Point(201, 162);
            AbsoluteCenterLayout.Margin = new Padding(4);
            AbsoluteCenterLayout.Name = "AbsoluteCenterLayout";
            AbsoluteCenterLayout.RowCount = 1;
            AbsoluteCenterLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            AbsoluteCenterLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            AbsoluteCenterLayout.Size = new Size(250, 147);
            AbsoluteCenterLayout.TabIndex = 14;
            // 
            // MenuStrip1
            // 
            MenuStrip1.ImageScalingSize = new Size(20, 20);
            MenuStrip1.Items.AddRange(new ToolStripItem[] { SearchToolStripMenuItem, ViewToolStripMenuItem });
            MenuStrip1.Location = new Point(0, 0);
            MenuStrip1.Name = "MenuStrip1";
            MenuStrip1.Size = new Size(652, 28);
            MenuStrip1.TabIndex = 16;
            MenuStrip1.Text = "MenuStrip1";
            // 
            // SearchToolStripMenuItem
            // 
            SearchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { FindToolStripMenuItem, NextToolStripMenuItem, LastToolStripMenuItem, FindAllToolStripMenuItem, ToolStripSeparator1, ClearToolStripMenuItem });
            SearchToolStripMenuItem.Name = "SearchToolStripMenuItem";
            SearchToolStripMenuItem.Size = new Size(65, 24);
            SearchToolStripMenuItem.Text = "Search";
            // 
            // FindToolStripMenuItem
            // 
            FindToolStripMenuItem.Image = My.Resources.Resources.find32;
            FindToolStripMenuItem.Name = "FindToolStripMenuItem";
            FindToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            FindToolStripMenuItem.Size = new Size(196, 26);
            FindToolStripMenuItem.Text = "&Find";
            // 
            // NextToolStripMenuItem
            // 
            NextToolStripMenuItem.Name = "NextToolStripMenuItem";
            NextToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            NextToolStripMenuItem.Size = new Size(196, 26);
            NextToolStripMenuItem.Text = "&Next";
            // 
            // LastToolStripMenuItem
            // 
            LastToolStripMenuItem.Name = "LastToolStripMenuItem";
            LastToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            LastToolStripMenuItem.Size = new Size(196, 26);
            LastToolStripMenuItem.Text = "&Last";
            // 
            // FindAllToolStripMenuItem
            // 
            FindAllToolStripMenuItem.Name = "FindAllToolStripMenuItem";
            FindAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F;
            FindAllToolStripMenuItem.Size = new Size(196, 26);
            FindAllToolStripMenuItem.Text = "All";
            // 
            // ToolStripSeparator1
            // 
            ToolStripSeparator1.Name = "ToolStripSeparator1";
            ToolStripSeparator1.Size = new Size(193, 6);
            // 
            // ClearToolStripMenuItem
            // 
            ClearToolStripMenuItem.Image = My.Resources.Resources.exit16;
            ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            ClearToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Alt | Keys.F;
            ClearToolStripMenuItem.Size = new Size(196, 26);
            ClearToolStripMenuItem.Text = "Clear";
            // 
            // ViewToolStripMenuItem
            // 
            ViewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { DisplayToolStripMenuItem, ZoomToolStripMenuItem, GoToToolStripMenuItem });
            ViewToolStripMenuItem.Name = "ViewToolStripMenuItem";
            ViewToolStripMenuItem.Size = new Size(53, 24);
            ViewToolStripMenuItem.Text = "View";
            // 
            // DisplayToolStripMenuItem
            // 
            DisplayToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { PlainTextToolStripMenuItem, FontTableToolStripMenuItem });
            DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem";
            DisplayToolStripMenuItem.Size = new Size(175, 26);
            DisplayToolStripMenuItem.Text = "Display";
            // 
            // PlainTextToolStripMenuItem
            // 
            PlainTextToolStripMenuItem.CheckOnClick = true;
            PlainTextToolStripMenuItem.Name = "PlainTextToolStripMenuItem";
            PlainTextToolStripMenuItem.Size = new Size(152, 26);
            PlainTextToolStripMenuItem.Text = "Plain Text";
            // 
            // FontTableToolStripMenuItem
            // 
            FontTableToolStripMenuItem.Checked = true;
            FontTableToolStripMenuItem.CheckOnClick = true;
            FontTableToolStripMenuItem.CheckState = CheckState.Checked;
            FontTableToolStripMenuItem.Name = "FontTableToolStripMenuItem";
            FontTableToolStripMenuItem.Size = new Size(152, 26);
            FontTableToolStripMenuItem.Text = "Font Table";
            // 
            // ZoomToolStripMenuItem
            // 
            ZoomToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ZoomMenuItem0, ZoomMenuItem1, ZoomMenuItem2, ZoomMenuItem3, ZoomMenuItem4, ZoomMenuItem5, ZoomMenuItem6, ZoomMenuItem7, ZoomMenuItem8, ZoomMenuItem9, ToolStripSeparator2, ZoomMenuItemPlus, ZoomMenuItemMinus });
            ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem";
            ZoomToolStripMenuItem.Size = new Size(175, 26);
            ZoomToolStripMenuItem.Text = "Zoom";
            // 
            // ZoomMenuItem0
            // 
            ZoomMenuItem0.Name = "ZoomMenuItem0";
            ZoomMenuItem0.ShortcutKeys = Keys.Control | Keys.D0;
            ZoomMenuItem0.Size = new Size(210, 26);
            ZoomMenuItem0.Text = "1&00%";
            // 
            // ZoomMenuItem1
            // 
            ZoomMenuItem1.Name = "ZoomMenuItem1";
            ZoomMenuItem1.ShortcutKeys = Keys.Control | Keys.D1;
            ZoomMenuItem1.Size = new Size(210, 26);
            ZoomMenuItem1.Text = "1&10%";
            // 
            // ZoomMenuItem2
            // 
            ZoomMenuItem2.Name = "ZoomMenuItem2";
            ZoomMenuItem2.ShortcutKeys = Keys.Control | Keys.D2;
            ZoomMenuItem2.Size = new Size(210, 26);
            ZoomMenuItem2.Text = "1&20%";
            // 
            // ZoomMenuItem3
            // 
            ZoomMenuItem3.Name = "ZoomMenuItem3";
            ZoomMenuItem3.ShortcutKeys = Keys.Control | Keys.D3;
            ZoomMenuItem3.Size = new Size(210, 26);
            ZoomMenuItem3.Text = "1&30%";
            // 
            // ZoomMenuItem4
            // 
            ZoomMenuItem4.Name = "ZoomMenuItem4";
            ZoomMenuItem4.ShortcutKeys = Keys.Control | Keys.D4;
            ZoomMenuItem4.Size = new Size(210, 26);
            ZoomMenuItem4.Text = "1&40%";
            // 
            // ZoomMenuItem5
            // 
            ZoomMenuItem5.Name = "ZoomMenuItem5";
            ZoomMenuItem5.ShortcutKeys = Keys.Control | Keys.D5;
            ZoomMenuItem5.Size = new Size(210, 26);
            ZoomMenuItem5.Text = "1&50%";
            // 
            // ZoomMenuItem6
            // 
            ZoomMenuItem6.Name = "ZoomMenuItem6";
            ZoomMenuItem6.ShortcutKeys = Keys.Control | Keys.D6;
            ZoomMenuItem6.Size = new Size(210, 26);
            ZoomMenuItem6.Text = "1&60%";
            // 
            // ZoomMenuItem7
            // 
            ZoomMenuItem7.Name = "ZoomMenuItem7";
            ZoomMenuItem7.ShortcutKeys = Keys.Control | Keys.D7;
            ZoomMenuItem7.Size = new Size(210, 26);
            ZoomMenuItem7.Text = "1&70%";
            // 
            // ZoomMenuItem8
            // 
            ZoomMenuItem8.Name = "ZoomMenuItem8";
            ZoomMenuItem8.ShortcutKeys = Keys.Control | Keys.D8;
            ZoomMenuItem8.Size = new Size(210, 26);
            ZoomMenuItem8.Text = "1&80%";
            // 
            // ZoomMenuItem9
            // 
            ZoomMenuItem9.Name = "ZoomMenuItem9";
            ZoomMenuItem9.ShortcutKeys = Keys.Control | Keys.D9;
            ZoomMenuItem9.Size = new Size(210, 26);
            ZoomMenuItem9.Text = "1&90%";
            // 
            // ToolStripSeparator2
            // 
            ToolStripSeparator2.Name = "ToolStripSeparator2";
            ToolStripSeparator2.Size = new Size(207, 6);
            // 
            // ZoomMenuItemPlus
            // 
            ZoomMenuItemPlus.Name = "ZoomMenuItemPlus";
            ZoomMenuItemPlus.ShortcutKeys = Keys.Control | Keys.Oemplus;
            ZoomMenuItemPlus.ShowShortcutKeys = false;
            ZoomMenuItemPlus.Size = new Size(210, 26);
            ZoomMenuItemPlus.Text = "Zoom &+           Ctrl +";
            // 
            // ZoomMenuItemMinus
            // 
            ZoomMenuItemMinus.Name = "ZoomMenuItemMinus";
            ZoomMenuItemMinus.ShortcutKeys = Keys.Control | Keys.OemMinus;
            ZoomMenuItemMinus.ShowShortcutKeys = false;
            ZoomMenuItemMinus.Size = new Size(210, 26);
            ZoomMenuItemMinus.Text = "Zoom &-            Ctrl -";
            // 
            // GoToToolStripMenuItem
            // 
            GoToToolStripMenuItem.Image = My.Resources.Resources.goto16;
            GoToToolStripMenuItem.Name = "GoToToolStripMenuItem";
            GoToToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.G;
            GoToToolStripMenuItem.Size = new Size(175, 26);
            GoToToolStripMenuItem.Text = "&Go To";
            // 
            // Form_ToolData
            // 
            AutoScaleDimensions = new SizeF(10.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 488);
            Controls.Add(MenuStrip1);
            Controls.Add(AbsoluteCenterLayout);
            Controls.Add(ContentPanel);
            Controls.Add(ControlsPanel);
            Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = MenuStrip1;
            Margin = new Padding(5);
            MinimumSize = new Size(670, 535);
            Name = "Form_ToolData";
            Normal = new Rectangle(19, 14, 670, 535);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Data Editor";
            ControlsPanel.ResumeLayout(false);
            FlowLayoutPanel1.ResumeLayout(false);
            ContentPanel.ResumeLayout(false);
            ChangeContextMenuStrip.ResumeLayout(false);
            AbsoluteCenterLayout.ResumeLayout(false);
            AbsoluteCenterLayout.PerformLayout();
            MenuStrip1.ResumeLayout(false);
            MenuStrip1.PerformLayout();
            Load += new EventHandler(Form_ToolHistory_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal TableLayoutPanel ControlsPanel;
        internal TableLayoutPanel ContentPanel;
        internal FlowLayoutPanel ActionsPanel;
        internal ToolTip DataToolTip;
        internal ContextMenuStrip ChangeContextMenuStrip;
        internal ToolStripMenuItem CopyToolStripMenuItem;
        internal Label LabelEmpty;
        internal TableLayoutPanel AbsoluteCenterLayout;
        internal HexTools.HexDeveloper HexDeveloper;
        internal FlowLayoutPanel FlowLayoutPanel1;
        internal Button OK_Button;
        internal Button Cancel_Button;
        internal MenuStrip MenuStrip1;
        internal ToolStripMenuItem ViewToolStripMenuItem;
        internal ToolStripMenuItem GoToToolStripMenuItem;
        internal ToolStripMenuItem SearchToolStripMenuItem;
        internal ToolStripMenuItem FindToolStripMenuItem;
        internal ToolStripMenuItem NextToolStripMenuItem;
        internal ToolStripMenuItem LastToolStripMenuItem;
        internal ToolStripMenuItem FindAllToolStripMenuItem;
        internal ToolStripMenuItem ClearToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator1;
        internal ToolStripMenuItem DisplayToolStripMenuItem;
        internal ToolStripMenuItem PlainTextToolStripMenuItem;
        internal ToolStripMenuItem FontTableToolStripMenuItem;
        internal ToolStripMenuItem ZoomToolStripMenuItem;
        internal ToolStripMenuItem ZoomMenuItem0;
        internal ToolStripMenuItem ZoomMenuItem1;
        internal ToolStripMenuItem ZoomMenuItem2;
        internal ToolStripMenuItem ZoomMenuItem3;
        internal ToolStripMenuItem ZoomMenuItem4;
        internal ToolStripMenuItem ZoomMenuItem5;
        internal ToolStripMenuItem ZoomMenuItem6;
        internal ToolStripMenuItem ZoomMenuItem7;
        internal ToolStripMenuItem ZoomMenuItem8;
        internal ToolStripMenuItem ZoomMenuItem9;
        internal ToolStripSeparator ToolStripSeparator2;
        internal ToolStripMenuItem ZoomMenuItemPlus;
        internal ToolStripMenuItem ZoomMenuItemMinus;
    }
}