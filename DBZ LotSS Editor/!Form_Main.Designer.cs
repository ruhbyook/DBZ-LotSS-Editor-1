using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DBZ_LotSS_Editor
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form_Main : BasicTools.BasicControls.BasicForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.WindowMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReloadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AudioEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EventEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NextOpenModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LastOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataEditorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GraphicsEditorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoryViewerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenFileFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenProjectFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PreferencesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.WindowSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.Button1 = new System.Windows.Forms.Button();
            this.WindowToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStripButtonData = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonSprite = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonPalette = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButtonText = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.StatusLayout = new System.Windows.Forms.TableLayoutPanel();
            this.DocumentFileMessage = new System.Windows.Forms.Label();
            this.FileLoadingProgressBar = new System.Windows.Forms.ProgressBar();
            this.DocumentLastModified = new System.Windows.Forms.TextBox();
            this.DocumentStatus = new System.Windows.Forms.Label();
            this.DocumentStatusLabel = new System.Windows.Forms.Label();
            this.DocumentLastModifiedLabel = new System.Windows.Forms.Label();
            this.StatusToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.WindowMenuStrip.SuspendLayout();
            this.WindowToolStrip.SuspendLayout();
            this.StatusPanel.SuspendLayout();
            this.StatusLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // WindowMenuStrip
            // 
            this.WindowMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.WindowMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.ModuleToolStripMenuItem,
            this.ToolsToolStripMenuItem,
            this.OptionsToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.WindowMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.WindowMenuStrip.Name = "WindowMenuStrip";
            this.WindowMenuStrip.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.WindowMenuStrip.Size = new System.Drawing.Size(792, 28);
            this.WindowMenuStrip.TabIndex = 0;
            this.WindowMenuStrip.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.RecentToolStripMenuItem,
            this.ReloadMenuItem,
            this.CloseMenuItem,
            this.toolStripSeparator,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.Open;
            this.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.OpenToolStripMenuItem.Text = "&Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // RecentToolStripMenuItem
            // 
            this.RecentToolStripMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.newdocument32;
            this.RecentToolStripMenuItem.Name = "RecentToolStripMenuItem";
            this.RecentToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.RecentToolStripMenuItem.Text = "Recent";
            // 
            // ReloadMenuItem
            // 
            this.ReloadMenuItem.Enabled = false;
            this.ReloadMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.Reload;
            this.ReloadMenuItem.Name = "ReloadMenuItem";
            this.ReloadMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ReloadMenuItem.Size = new System.Drawing.Size(222, 26);
            this.ReloadMenuItem.Text = "&Reload";
            this.ReloadMenuItem.Click += new System.EventHandler(this.ReloadMenuItem_Click);
            // 
            // CloseMenuItem
            // 
            this.CloseMenuItem.Enabled = false;
            this.CloseMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.close32;
            this.CloseMenuItem.Name = "CloseMenuItem";
            this.CloseMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.CloseMenuItem.Size = new System.Drawing.Size(222, 26);
            this.CloseMenuItem.Text = "&Close";
            this.CloseMenuItem.Click += new System.EventHandler(this.CloseMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(219, 6);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Enabled = false;
            this.SaveToolStripMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.Save;
            this.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.SaveToolStripMenuItem.Text = "&Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Enabled = false;
            this.SaveAsToolStripMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.saveas32;
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.SaveAsToolStripMenuItem.Text = "Save &As";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(219, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.exit16;
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripMenuItem,
            this.RedoToolStripMenuItem,
            this.toolStripSeparator3,
            this.SelectAllToolStripMenuItem,
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.EditToolStripMenuItem.Text = "&Edit";
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Enabled = false;
            this.UndoToolStripMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.undo16;
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.UndoToolStripMenuItem.Text = "&Undo";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // RedoToolStripMenuItem
            // 
            this.RedoToolStripMenuItem.Enabled = false;
            this.RedoToolStripMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.redo16;
            this.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem";
            this.RedoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.RedoToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.RedoToolStripMenuItem.Text = "&Redo";
            this.RedoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(203, 6);
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Enabled = false;
            this.SelectAllToolStripMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.select16;
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.SelectAllToolStripMenuItem.Text = "Select &All";
            this.SelectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Enabled = false;
            this.CutToolStripMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.Cut;
            this.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.CutToolStripMenuItem.Text = "Cu&t";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Enabled = false;
            this.CopyToolStripMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.Copy;
            this.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.CopyToolStripMenuItem.Text = "&Copy";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.Me_Copy);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Enabled = false;
            this.PasteToolStripMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.Paste;
            this.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.PasteToolStripMenuItem.Text = "&Paste";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.Me_Paste);
            // 
            // ModuleToolStripMenuItem
            // 
            this.ModuleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataToolStripMenuItem,
            this.SpriteToolStripMenuItem,
            this.PaletteToolStripMenuItem,
            this.TextToolStripMenuItem,
            this.AudioEditorToolStripMenuItem,
            this.EventEditorToolStripMenuItem,
            this.toolStripSeparator2,
            this.NextOpenModuleToolStripMenuItem,
            this.LastOpenToolStripMenuItem});
            this.ModuleToolStripMenuItem.Name = "ModuleToolStripMenuItem";
            this.ModuleToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.ModuleToolStripMenuItem.Text = "&Modules";
            // 
            // DataToolStripMenuItem
            // 
            this.DataToolStripMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.prepare32;
            this.DataToolStripMenuItem.Name = "DataToolStripMenuItem";
            this.DataToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.DataToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.DataToolStripMenuItem.Text = "Database Editor";
            this.DataToolStripMenuItem.Click += new System.EventHandler(this.DataToolStripMenuItem_Click);
            // 
            // SpriteToolStripMenuItem
            // 
            this.SpriteToolStripMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.image16;
            this.SpriteToolStripMenuItem.Name = "SpriteToolStripMenuItem";
            this.SpriteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.SpriteToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.SpriteToolStripMenuItem.Text = "Sprite Editor";
            this.SpriteToolStripMenuItem.Click += new System.EventHandler(this.SpriteToolStripMenuItem_Click);
            // 
            // PaletteToolStripMenuItem
            // 
            this.PaletteToolStripMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.fontcolor16;
            this.PaletteToolStripMenuItem.Name = "PaletteToolStripMenuItem";
            this.PaletteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.PaletteToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.PaletteToolStripMenuItem.Text = "Palette Editor";
            this.PaletteToolStripMenuItem.Click += new System.EventHandler(this.PaletteToolStripMenuItem_Click);
            // 
            // TextToolStripMenuItem
            // 
            this.TextToolStripMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.orderedlist16;
            this.TextToolStripMenuItem.Name = "TextToolStripMenuItem";
            this.TextToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.TextToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.TextToolStripMenuItem.Text = "Text Editor";
            this.TextToolStripMenuItem.Click += new System.EventHandler(this.TextToolStripMenuItem_Click);
            // 
            // AudioEditorToolStripMenuItem
            // 
            this.AudioEditorToolStripMenuItem.Enabled = false;
            this.AudioEditorToolStripMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.Musical32;
            this.AudioEditorToolStripMenuItem.Name = "AudioEditorToolStripMenuItem";
            this.AudioEditorToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.AudioEditorToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.AudioEditorToolStripMenuItem.Text = "Audio Editor";
            this.AudioEditorToolStripMenuItem.Visible = false;
            // 
            // EventEditorToolStripMenuItem
            // 
            this.EventEditorToolStripMenuItem.Enabled = false;
            this.EventEditorToolStripMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.goto16;
            this.EventEditorToolStripMenuItem.Name = "EventEditorToolStripMenuItem";
            this.EventEditorToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.EventEditorToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.EventEditorToolStripMenuItem.Text = "Event Editor";
            this.EventEditorToolStripMenuItem.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(256, 6);
            // 
            // NextOpenModuleToolStripMenuItem
            // 
            this.NextOpenModuleToolStripMenuItem.Name = "NextOpenModuleToolStripMenuItem";
            this.NextOpenModuleToolStripMenuItem.ShortcutKeyDisplayString = "CTRL + PGUP";
            this.NextOpenModuleToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.NextOpenModuleToolStripMenuItem.Text = "Next Open";
            this.NextOpenModuleToolStripMenuItem.Click += new System.EventHandler(this.NextOpenModuleToolStripMenuItem_Click);
            // 
            // LastOpenToolStripMenuItem
            // 
            this.LastOpenToolStripMenuItem.Name = "LastOpenToolStripMenuItem";
            this.LastOpenToolStripMenuItem.ShortcutKeyDisplayString = "CTRL + PGDN";
            this.LastOpenToolStripMenuItem.Size = new System.Drawing.Size(259, 26);
            this.LastOpenToolStripMenuItem.Text = "Last Open";
            this.LastOpenToolStripMenuItem.Click += new System.EventHandler(this.LastOpenToolStripMenuItem_Click);
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontToolStripMenuItem,
            this.DataEditorMenuItem,
            this.GraphicsEditorMenuItem,
            this.HistoryViewerMenuItem,
            this.ToolStripSeparator4,
            this.OpenFileFolderToolStripMenuItem,
            this.OpenProjectFolderToolStripMenuItem});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.ToolsToolStripMenuItem.Text = "&Tools";
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.styleset16;
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.FontToolStripMenuItem.Text = "Font Table";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // DataEditorMenuItem
            // 
            this.DataEditorMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.multilevellist16;
            this.DataEditorMenuItem.Name = "DataEditorMenuItem";
            this.DataEditorMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.DataEditorMenuItem.Size = new System.Drawing.Size(313, 26);
            this.DataEditorMenuItem.Text = "Data Editor";
            this.DataEditorMenuItem.Click += new System.EventHandler(this.DataEditorMenuItem_Click);
            // 
            // GraphicsEditorMenuItem
            // 
            this.GraphicsEditorMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.image16;
            this.GraphicsEditorMenuItem.Name = "GraphicsEditorMenuItem";
            this.GraphicsEditorMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.GraphicsEditorMenuItem.Size = new System.Drawing.Size(313, 26);
            this.GraphicsEditorMenuItem.Text = "Graphics Editor";
            this.GraphicsEditorMenuItem.Click += new System.EventHandler(this.GraphicsViewerMenuItem_Click);
            // 
            // HistoryViewerMenuItem
            // 
            this.HistoryViewerMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.printpreview32;
            this.HistoryViewerMenuItem.Name = "HistoryViewerMenuItem";
            this.HistoryViewerMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.HistoryViewerMenuItem.Size = new System.Drawing.Size(313, 26);
            this.HistoryViewerMenuItem.Text = "History Viewer";
            this.HistoryViewerMenuItem.Click += new System.EventHandler(this.HistoryViewerMenuItem_Click);
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(310, 6);
            // 
            // OpenFileFolderToolStripMenuItem
            // 
            this.OpenFileFolderToolStripMenuItem.Enabled = false;
            this.OpenFileFolderToolStripMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.publish32;
            this.OpenFileFolderToolStripMenuItem.Name = "OpenFileFolderToolStripMenuItem";
            this.OpenFileFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.OpenFileFolderToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.OpenFileFolderToolStripMenuItem.Text = "&Open File Folder";
            this.OpenFileFolderToolStripMenuItem.Click += new System.EventHandler(this.OpenFolderToolStripMenuItem_Click);
            // 
            // OpenProjectFolderToolStripMenuItem
            // 
            this.OpenProjectFolderToolStripMenuItem.Enabled = false;
            this.OpenProjectFolderToolStripMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.publish32;
            this.OpenProjectFolderToolStripMenuItem.Name = "OpenProjectFolderToolStripMenuItem";
            this.OpenProjectFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.OpenProjectFolderToolStripMenuItem.Size = new System.Drawing.Size(313, 26);
            this.OpenProjectFolderToolStripMenuItem.Text = "&Open Project Folder";
            this.OpenProjectFolderToolStripMenuItem.Click += new System.EventHandler(this.OpenProjectFolderToolStripMenuItem_Click);
            // 
            // OptionsToolStripMenuItem
            // 
            this.OptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PreferencesToolStripMenuItem1});
            this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
            this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.OptionsToolStripMenuItem.Text = "Options";
            // 
            // PreferencesToolStripMenuItem1
            // 
            this.PreferencesToolStripMenuItem1.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.options16;
            this.PreferencesToolStripMenuItem1.Name = "PreferencesToolStripMenuItem1";
            this.PreferencesToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PreferencesToolStripMenuItem1.Size = new System.Drawing.Size(218, 26);
            this.PreferencesToolStripMenuItem1.Text = "Preferences";
            this.PreferencesToolStripMenuItem1.Click += new System.EventHandler(this.PreferencesToolStripMenuItem1_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpAboutToolStripMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.HelpToolStripMenuItem.Text = "&Help";
            // 
            // HelpAboutToolStripMenuItem
            // 
            this.HelpAboutToolStripMenuItem.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.addons32;
            this.HelpAboutToolStripMenuItem.Name = "HelpAboutToolStripMenuItem";
            this.HelpAboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.HelpAboutToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.HelpAboutToolStripMenuItem.Text = "About";
            this.HelpAboutToolStripMenuItem.Click += new System.EventHandler(this.HelpAboutStripMenuItem_Click);
            // 
            // WindowOpenFileDialog
            // 
            this.WindowOpenFileDialog.Filter = "Super Magicom|*.smc|Super Famicom|*.sfc";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(5, 66);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(118, 23);
            this.Button1.TabIndex = 5;
            this.Button1.Text = "Sprites Palettes";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // WindowToolStrip
            // 
            this.WindowToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.WindowToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButtonData,
            this.ToolStripButtonSprite,
            this.ToolStripButtonPalette,
            this.ToolStripButtonText});
            this.WindowToolStrip.Location = new System.Drawing.Point(0, 28);
            this.WindowToolStrip.Name = "WindowToolStrip";
            this.WindowToolStrip.Size = new System.Drawing.Size(792, 25);
            this.WindowToolStrip.TabIndex = 4;
            this.WindowToolStrip.Text = "ToolStrip1";
            // 
            // ToolStripButtonData
            // 
            this.ToolStripButtonData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonData.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.prepare32;
            this.ToolStripButtonData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonData.Name = "ToolStripButtonData";
            this.ToolStripButtonData.Size = new System.Drawing.Size(29, 24);
            this.ToolStripButtonData.Text = "Form_EditorDatabase";
            this.ToolStripButtonData.ToolTipText = "Show Database Editor";
            this.ToolStripButtonData.Visible = false;
            this.ToolStripButtonData.Click += new System.EventHandler(this.ToolStripButtonData_Click);
            // 
            // ToolStripButtonSprite
            // 
            this.ToolStripButtonSprite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonSprite.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.image16;
            this.ToolStripButtonSprite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonSprite.Name = "ToolStripButtonSprite";
            this.ToolStripButtonSprite.Size = new System.Drawing.Size(29, 24);
            this.ToolStripButtonSprite.Text = "Form_EditorSprite";
            this.ToolStripButtonSprite.ToolTipText = "Show Sprite Editor";
            this.ToolStripButtonSprite.Visible = false;
            this.ToolStripButtonSprite.Click += new System.EventHandler(this.ToolStripButtonSprite_Click);
            // 
            // ToolStripButtonPalette
            // 
            this.ToolStripButtonPalette.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonPalette.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.fontcolor16;
            this.ToolStripButtonPalette.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonPalette.Name = "ToolStripButtonPalette";
            this.ToolStripButtonPalette.Size = new System.Drawing.Size(29, 24);
            this.ToolStripButtonPalette.Text = "Form_EditorPalette";
            this.ToolStripButtonPalette.ToolTipText = "Show Palette Editor";
            this.ToolStripButtonPalette.Visible = false;
            this.ToolStripButtonPalette.Click += new System.EventHandler(this.ToolStripButtonPalette_Click);
            // 
            // ToolStripButtonText
            // 
            this.ToolStripButtonText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButtonText.Image = global::DBZ_LotSS_Editor.My.Resources.Resources.orderedlist16;
            this.ToolStripButtonText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButtonText.Name = "ToolStripButtonText";
            this.ToolStripButtonText.Size = new System.Drawing.Size(29, 24);
            this.ToolStripButtonText.Text = "Form_EditorText";
            this.ToolStripButtonText.ToolTipText = "Show Text Editor";
            this.ToolStripButtonText.Visible = false;
            this.ToolStripButtonText.Click += new System.EventHandler(this.ToolStripButtonText_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.AutoSize = false;
            this.StatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.StatusStrip.Location = new System.Drawing.Point(0, 684);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 18, 0);
            this.StatusStrip.Size = new System.Drawing.Size(792, 69);
            this.StatusStrip.TabIndex = 9;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // StatusPanel
            // 
            this.StatusPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusPanel.Controls.Add(this.StatusLayout);
            this.StatusPanel.Location = new System.Drawing.Point(0, 690);
            this.StatusPanel.Margin = new System.Windows.Forms.Padding(4);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(777, 62);
            this.StatusPanel.TabIndex = 14;
            // 
            // StatusLayout
            // 
            this.StatusLayout.ColumnCount = 4;
            this.StatusLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.StatusLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.31008F));
            this.StatusLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.96124F));
            this.StatusLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.65184F));
            this.StatusLayout.Controls.Add(this.DocumentFileMessage, 2, 1);
            this.StatusLayout.Controls.Add(this.FileLoadingProgressBar, 3, 1);
            this.StatusLayout.Controls.Add(this.DocumentLastModified, 1, 0);
            this.StatusLayout.Controls.Add(this.DocumentStatus, 1, 1);
            this.StatusLayout.Controls.Add(this.DocumentStatusLabel, 0, 1);
            this.StatusLayout.Controls.Add(this.DocumentLastModifiedLabel, 0, 0);
            this.StatusLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusLayout.Location = new System.Drawing.Point(0, 0);
            this.StatusLayout.Margin = new System.Windows.Forms.Padding(4);
            this.StatusLayout.Name = "StatusLayout";
            this.StatusLayout.RowCount = 2;
            this.StatusLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StatusLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.StatusLayout.Size = new System.Drawing.Size(777, 62);
            this.StatusLayout.TabIndex = 12;
            // 
            // DocumentFileMessage
            // 
            this.DocumentFileMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentFileMessage.Location = new System.Drawing.Point(267, 31);
            this.DocumentFileMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DocumentFileMessage.Name = "DocumentFileMessage";
            this.DocumentFileMessage.Size = new System.Drawing.Size(282, 31);
            this.DocumentFileMessage.TabIndex = 13;
            this.DocumentFileMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DocumentFileMessage.Visible = false;
            // 
            // FileLoadingProgressBar
            // 
            this.FileLoadingProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileLoadingProgressBar.Location = new System.Drawing.Point(557, 35);
            this.FileLoadingProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.FileLoadingProgressBar.Name = "FileLoadingProgressBar";
            this.FileLoadingProgressBar.Size = new System.Drawing.Size(216, 23);
            this.FileLoadingProgressBar.Step = 1;
            this.FileLoadingProgressBar.TabIndex = 12;
            this.FileLoadingProgressBar.Visible = false;
            // 
            // DocumentLastModified
            // 
            this.DocumentLastModified.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusLayout.SetColumnSpan(this.DocumentLastModified, 3);
            this.DocumentLastModified.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentLastModified.Location = new System.Drawing.Point(138, 4);
            this.DocumentLastModified.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.DocumentLastModified.Name = "DocumentLastModified";
            this.DocumentLastModified.ReadOnly = true;
            this.DocumentLastModified.Size = new System.Drawing.Size(633, 19);
            this.DocumentLastModified.TabIndex = 4;
            this.DocumentLastModified.Text = "Never";
            this.DocumentLastModified.DoubleClick += new System.EventHandler(this.DocumentLastModified_DoubleClick);
            // 
            // DocumentStatus
            // 
            this.DocumentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DocumentStatus.Location = new System.Drawing.Point(136, 31);
            this.DocumentStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DocumentStatus.Name = "DocumentStatus";
            this.DocumentStatus.Size = new System.Drawing.Size(123, 31);
            this.DocumentStatus.TabIndex = 1;
            this.DocumentStatus.Text = "Unopened";
            this.DocumentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DocumentStatusLabel
            // 
            this.DocumentStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DocumentStatusLabel.AutoSize = true;
            this.DocumentStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentStatusLabel.Location = new System.Drawing.Point(48, 31);
            this.DocumentStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DocumentStatusLabel.Name = "DocumentStatusLabel";
            this.DocumentStatusLabel.Size = new System.Drawing.Size(80, 31);
            this.DocumentStatusLabel.TabIndex = 0;
            this.DocumentStatusLabel.Text = "Document:";
            this.DocumentStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DocumentLastModifiedLabel
            // 
            this.DocumentLastModifiedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DocumentLastModifiedLabel.AutoSize = true;
            this.DocumentLastModifiedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentLastModifiedLabel.Location = new System.Drawing.Point(24, 0);
            this.DocumentLastModifiedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DocumentLastModifiedLabel.Name = "DocumentLastModifiedLabel";
            this.DocumentLastModifiedLabel.Size = new System.Drawing.Size(104, 31);
            this.DocumentLastModifiedLabel.TabIndex = 2;
            this.DocumentLastModifiedLabel.Text = "Last Modified:";
            this.DocumentLastModifiedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusToolTip
            // 
            this.StatusToolTip.IsBalloon = true;
            this.StatusToolTip.ShowAlways = true;
            // 
            // Form_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(792, 753);
            this.Controls.Add(this.StatusPanel);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.WindowToolStrip);
            this.Controls.Add(this.WindowMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.WindowMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(810, 800);
            this.Name = "Form_Main";
            this.Normal = new System.Drawing.Rectangle(19, -271, 810, 800);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBZ LotSS Editor v{version}";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.MdiChildActivate += new System.EventHandler(this.OnMdiFormClose);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Me_KeyDown);
            this.WindowMenuStrip.ResumeLayout(false);
            this.WindowMenuStrip.PerformLayout();
            this.WindowToolStrip.ResumeLayout(false);
            this.WindowToolStrip.PerformLayout();
            this.StatusPanel.ResumeLayout(false);
            this.StatusLayout.ResumeLayout(false);
            this.StatusLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        internal MenuStrip WindowMenuStrip;
        internal ToolStripMenuItem FileToolStripMenuItem;
        internal ToolStripMenuItem OpenToolStripMenuItem;
        internal ToolStripSeparator toolStripSeparator;
        internal ToolStripMenuItem SaveToolStripMenuItem;
        internal ToolStripMenuItem SaveAsToolStripMenuItem;
        internal ToolStripSeparator toolStripSeparator1;
        internal ToolStripMenuItem ExitToolStripMenuItem;
        internal ToolStripMenuItem EditToolStripMenuItem;
        internal ToolStripMenuItem UndoToolStripMenuItem;
        internal ToolStripMenuItem RedoToolStripMenuItem;
        internal ToolStripSeparator toolStripSeparator3;
        internal ToolStripMenuItem CutToolStripMenuItem;
        internal ToolStripMenuItem CopyToolStripMenuItem;
        internal ToolStripMenuItem PasteToolStripMenuItem;
        internal ToolStripMenuItem ModuleToolStripMenuItem;
        internal ToolStripMenuItem HelpToolStripMenuItem;
        internal ToolStripMenuItem HelpAboutToolStripMenuItem;
        internal OpenFileDialog WindowOpenFileDialog;
        internal SaveFileDialog WindowSaveFileDialog;
        internal ToolStripMenuItem RecentToolStripMenuItem;
        internal ToolStripMenuItem OptionsToolStripMenuItem;
        internal ToolStripMenuItem PreferencesToolStripMenuItem1;
        internal Button Button1;
        internal ToolStrip WindowToolStrip;
        internal ToolStripButton ToolStripButtonData;
        internal ToolStripButton ToolStripButtonSprite;
        internal ToolStripButton ToolStripButtonPalette;
        internal ToolStripButton ToolStripButtonText;
        internal ToolStripMenuItem ToolsToolStripMenuItem;
        internal ToolStripMenuItem DataToolStripMenuItem;
        internal ToolStripMenuItem SpriteToolStripMenuItem;
        internal ToolStripMenuItem TextToolStripMenuItem;
        internal ToolStripMenuItem PaletteToolStripMenuItem;
        internal ToolStripSeparator ToolStripSeparator4;
        internal ToolStripMenuItem OpenFileFolderToolStripMenuItem;
        internal ToolStripMenuItem FontToolStripMenuItem;
        internal ToolStripMenuItem AudioEditorToolStripMenuItem;
        internal ToolStripMenuItem EventEditorToolStripMenuItem;
        internal ToolStripMenuItem ReloadMenuItem;
        internal ToolStripMenuItem CloseMenuItem;
        internal ToolStripMenuItem DataEditorMenuItem;
        internal StatusStrip StatusStrip;
        internal ToolStripMenuItem SelectAllToolStripMenuItem;
        internal Panel StatusPanel;
        internal TableLayoutPanel StatusLayout;
        internal Label DocumentStatusLabel;
        internal Label DocumentStatus;
        internal Label DocumentLastModifiedLabel;
        internal TextBox DocumentLastModified;
        internal ToolTip StatusToolTip;
        internal ProgressBar FileLoadingProgressBar;
        internal Label DocumentFileMessage;
        internal ToolStripMenuItem HistoryViewerMenuItem;
        private ToolStripMenuItem GraphicsEditorMenuItem;
        private ToolStripMenuItem NextOpenModuleToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem LastOpenToolStripMenuItem;
        internal ToolStripMenuItem OpenProjectFolderToolStripMenuItem;
    }
}