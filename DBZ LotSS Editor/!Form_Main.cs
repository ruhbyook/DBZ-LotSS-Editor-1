using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Media;
using BasicTools;
using BasicTools.BasicControls;
using HexTools;
using HexTools.HexStructures;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

// Replace Powerpacks dependancy with GDI components:
// http://www.codeproject.com/Articles/27228/A-class-for-creating-round-rectangles-in-GDI-with
// https://msdn.microsoft.com/en-us/library/8z5dw491%28v=vs.110%29.aspx

// Add drag and drop
// Don't load into memory, use the stream instead
// Form Extensions That Encompass repetitive Form functions

// Create AutoPatch Method
// Patch PC Pointers
// TableView Column Sorts are bugged

// Attribute fixes a bug where the whole application resizes when a WPF form is used
[assembly: DisableDpiAwareness]

namespace DBZ_LotSS_Editor
{
    public partial class Form_Main : BasicForm
    {
        public AppDefinition AppDefinition { get; private set; }
        public bool OpenedFile;
        public string FileFullName;
        public string FileShortPath;
        public string FilePath;
        public string FileName;
        public string FileExt;
        private string DefaultText;

        public bool IsHeadered
        {
            get
            {
                var remainder = HexStorage.Memory.LongLength % 0x400;

                if (remainder == 0x200) return true;
                else if (remainder == 0x00) return false;
                else throw new FileFormatException("File is not a valid SNES ROM");
            }
        }

        public override string Text
        {
            get => base.Text;
            set => base.Text = value.Replace("{version}", Application.ProductVersion);
        }

        private SystemKeyboardEvent SystemKeyboardHandler = new SystemKeyboardEvent();
        private SystemMouseEvent SystemMouseHandler = new SystemMouseEvent();

        protected bool Maximize;

        private string _LastStatus;
        protected string LastStatus
        {
            get
            {
                return _LastStatus;
            }
            private set
            {
                if ((value ?? "") != (_LastStatus ?? ""))
                {
                    _LastStatus = value;
                }
            }
        }

        protected string Status
        {
            get
            {
                return DocumentStatus.Text;
            }
            set
            {
                if ((value ?? "") != (DocumentStatus.Text ?? ""))
                {
                    LastStatus = DocumentStatus.Text;
                    DocumentStatus.Text = value;
                }
            }
        }

        protected string LastModified
        {
            get
            {
                return DocumentLastModified.Text;
            }
            set
            {
                if ((value ?? "") != (DocumentLastModified.Text ?? ""))
                {
                    DocumentLastModified.Text = value;
                }
            }
        }

        protected string FileMessage
        {
            get
            {
                return DocumentFileMessage.Text;
            }
            set
            {
                if ((value ?? "") != (DocumentFileMessage.Text ?? ""))
                {
                    DocumentFileMessage.Text = value;
                    DocumentFileMessage.Visible = true;
                    MiscellanousExtension.WaitThenExecute(7500, (x, y) => DocumentFileMessage.Visible = false);
                }
            }
        }

        public object IsReady
        {
            get
            {
                return OpenedFile;
            }
        }

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.ConfirmUnsavedDialog("close the Editor", (x, y) =>
            {
                SaveAllSettings();
                e.Cancel = false;
            });
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            // ForceCulture();
            DefaultText = Text;
            LoadRecentList();
            LoadMDIList();
            LoadAppSettings();
            AppDefinition = new AppDefinition(this);
            ObjectExtension.AllForms = My.MyProject.Forms.Forms;
            300.WaitThenExecute((_, __) => ReloadRecentFile());
            AddHandlers();
            My.MyProject.Forms.Form_ToolFont.LoadProjectTable();
        }

        private void ForceCulture()
        {
            var editorLanguage = new CultureInfo("es-ES"); // es-ES en-US
            CultureInfo.DefaultThreadCurrentCulture = editorLanguage;
            CultureInfo.DefaultThreadCurrentUICulture = editorLanguage;
        }

        private void AddHandlers()
        {
            // Module1.Main()
            MemoryLiterator.OnWrite += FileModified;
            MemoryLiterator.ActionModule.RefreshHappened += UndoRedoRefresh;
            Application.AddMessageFilter(SystemKeyboardHandler);
            Application.AddMessageFilter(SystemMouseHandler);
            SystemKeyboardHandler.KeyPressed += FormMain_KeyboardPress;
            SystemMouseHandler.MouseUsed += FormMain_MouseClick;
        }

        private void FileModified(object Sender, MemoryOperationAction Args)
        {
            bool IsModified = HexStorage.HasUnsavedWork;
            Status = IsModified ? "Unsaved" : LastStatus;
            // No idea why using the AllUndos is necessary here, for some reason just calling the Peek on the Internal Stack doesn't work??
            var Action = Args.IsReversed == true ? MemoryLiterator.ActionModule.AllUndos.LastOrDefault() : Args;
            LastModified = IsModified & Action != null ? Action.Changes.Ellipsis(DocumentLastModified) : "Never";
            StatusToolTip.SetToolTip(DocumentLastModified, IsModified & Action != null ? Action.Author : "");
        }

        private void UndoRedoRefresh(object Sender, UndoRedoRefreshArgs Args)
        {
            UndoToolStripMenuItem.Enabled = Args.HasUndo;
            RedoToolStripMenuItem.Enabled = Args.HasRedo;
        }

        private Control FocusedControl { get; set; }
        private Control FocusedEditor
        {
            get
            {
                if (FocusedControl == null)
                {
                    return null;
                }
                if (FocusedControl is TextBoxBase)
                {
                    return FocusedControl;
                }
                var targetControl = FocusedControl;
                return (Control)(FocusedControl is IHexEditor ? FocusedControl : ControlExtension.FindParent(ref targetControl));
            }
        }

        private Control FindFocusedControl(Control ActiveControl = null)
        {
            ActiveControl = ActiveControl == null ? ActiveForm?.ActiveControl : ActiveControl;
            ContainerControl Container = ActiveControl as ContainerControl;
            while (Container != null)
            {
                ActiveControl = Container.ActiveControl;
                Container = ActiveControl as ContainerControl;
            }
            return ActiveControl;
        }

        private TextBoxBase TextControl(Control Control)
        {
            if (Control != null)
            {
                if (Control is ITextControl)
                {
                    ITextControl Controller = (ITextControl)Control;
                    return Controller.TextControl;
                }
                else if (Control is TextBoxBase)
                {
                    return (TextBoxBase)Control;
                }
            }
            return null;
        }

        private void FindActiveControl()
        {
            FocusedControl = FindFocusedControl();
            var TextControl = this.TextControl(FocusedControl);
            bool HasText = TextControl != null;
            SelectAllToolStripMenuItem.Enabled = HasText && TextControl.Enabled;
            CutToolStripMenuItem.Enabled = HasText && !TextControl.ReadOnly;
            CopyToolStripMenuItem.Enabled = HasText && TextControl.Enabled;
            PasteToolStripMenuItem.Enabled = HasText && !TextControl.ReadOnly;
        }

        public void ExecuteOnNextFrame(Action action)
        {
            1.WaitThenExecute((_, __) => action?.Invoke());
        }

        public void RefreshForm(HexForm form)
        {
            ExecuteOnNextFrame(() => form.Active(null));
        }

        private void FormMain_KeyboardPress(object Sender, KeyPressedEventArgs Args)
        {
            if (Args.Key == Keys.Tab)
            {
                ExecuteOnNextFrame(FindActiveControl);
            }
        }

        private void FormMain_MouseClick(object Sender, MouseUsedEventArgs Args)
        {
            ExecuteOnNextFrame(FindActiveControl);
        }

        private void LoadAppSettings()
        {
            if (My.Settings.Default.WindowSize == new Size())
                return;
            WindowState = (FormWindowState)My.Settings.Default.WindowState;
            // Location = My.Settings.WindowLocation
            Size = My.Settings.Default.WindowSize;
            Normal = new Rectangle(My.Settings.Default.WindowLocation, My.Settings.Default.WindowSize);
            SystemFormEvent.RaisePreferencesSaved(My.Settings.Default);
        }

        private void SaveAppSettings()
        {
            My.Settings.Default.WindowState = (int)WindowState;
            My.Settings.Default.WindowLocation = Normal.Location;
            My.Settings.Default.WindowSize = Normal.Size;
        }

        private void LoadMDIList()
        {
            if (My.Settings.Default.AutoLoadWindows == false | My.Settings.Default.MDI == null)
                return;
            var windows = My.Settings.Default.MDI.ToArray();

            foreach (string mdi in windows)
            {
                string[] state = mdi.Split(',');
                BasicForm form = (BasicForm)GetFormReference(state[0]);
                form.MdiParent = this;
                form.WindowState = (FormWindowState)Conversions.ToInteger(state[1]);
                form.Location = new Point(Conversions.ToInteger(state[2]), Conversions.ToInteger(state[3]));
                form.Width = Conversions.ToInteger(state[4]);
                form.Height = Conversions.ToInteger(state[5]);
                form.Normal = new Rectangle(new Point(Conversions.ToInteger(state[2]), Conversions.ToInteger(state[3])), new Size(Conversions.ToInteger(state[4]), Conversions.ToInteger(state[5])));
                form.Show();
            }

            if(My.Settings.Default.ActiveMDI >= 0)
                MdiChildren[My.Settings.Default.ActiveMDI].Focus();

            DrawVisibleForms();
        }

        private object GetFormReference(string Name)
        {
            switch (Name ?? "")
            {
                case "Form_EditorDatabase":
                    {
                        return My.MyProject.Forms.Form_EditorDatabase;
                    }
                case "Form_EditorPalette":
                    {
                        return My.MyProject.Forms.Form_EditorPalette;
                    }
                case "Form_EditorSprite":
                    {
                        return My.MyProject.Forms.Form_EditorSprite;
                    }
                case "Form_EditorText":
                    {
                        return My.MyProject.Forms.Form_EditorText;
                    }
            }
            return null;
        }

        private void SaveMDISettings()
        {
            
            if (My.Settings.Default.AutoLoadWindows == false)
                return;
            My.Settings.Default.MDI = new ArrayList();
            if (MdiChildren.Count() > 0)
            {
                int index = 0;
                foreach (BasicForm mdi in MdiChildren)
                {
                    if (mdi.Visible == false)
                        continue;
                    string state;
                    state = mdi.GetType().Name + "," + ((int)mdi.WindowState).ToString() + "," + mdi.Normal.Location.X + "," + mdi.Normal.Location.Y + "," + mdi.Normal.Width + "," + mdi.Normal.Height;

                    My.Settings.Default.MDI.Insert(index, state);
                    index += 1;
                }
            }
            My.Settings.Default.ActiveMDI = GetCurrentMdiChildIndex();
            My.Settings.Default.Save();
        }

        private void SaveAllSettings()
        {
            SaveMDISettings();
            SaveAppSettings();
        }

        private void AddToRecentList(string param_path)
        {
            if (My.Settings.Default.Recent == null)
                My.Settings.Default.Recent = new ArrayList();
            else
                RemoveFromRecentList(param_path);
            My.Settings.Default.Recent.Add(param_path);
            if (My.Settings.Default.Recent.Count > 10)
                My.Settings.Default.Recent.RemoveAt(0);
            LoadRecentList();
        }

        private void RemoveFromRecentList(string param_path)
        {
            int item_index = 0;
            for (int index = 0, loopTo = My.Settings.Default.Recent.Count - 1; index <= loopTo; index++)
            {
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(My.Settings.Default.Recent[item_index], param_path, false)))
                {
                    My.Settings.Default.Recent.RemoveAt(item_index);
                }
                else
                {
                    item_index += 1;
                }
            }

            LoadRecentList();
        }

        private void ClearRecentList()
        {
            My.Settings.Default.Recent.Clear();
            LoadRecentList();
        }

        private void UseRecentList(object sender, EventArgs e)
        {
            dynamic target = sender;
            this.ConfirmUnsavedDialog("open a recent file", (x, y) => OpenRecentFile(Conversions.ToInteger(target.Name)));
        }

        private void ReloadRecentFile()
        {
            if (My.Settings.Default.AutoLoadRecent && My.Settings.Default.Recent?.Count > 0)
            {
                OpenRecentFile(1);
            }
        }

        private void OpenRecentFile(int param_index)
        {
            if (My.Settings.Default.Recent.Count <= 0 || param_index > My.Settings.Default.Recent.Count)
                return;
            OpenFile(Conversions.ToString(My.Settings.Default.Recent[My.Settings.Default.Recent.Count - param_index]));
        }

        private void LoadRecentList()
        {
            if (My.Settings.Default.Recent == null)
                return;
            RecentToolStripMenuItem.DropDownItems.Clear();
            int index = 1;
            foreach (string item_list in (IEnumerable)BasicHelper.GetArrayReverse(My.Settings.Default.Recent))
            {
                if (index > 10)
                    break;
                RecentToolStripMenuItem.DropDownItems.Add(Conversions.ToString(Operators.ConcatenateObject(index + ": ", GetShortPath(item_list))), My.Resources.Resources.newdocument32, UseRecentList);
                RecentToolStripMenuItem.DropDownItems[index - 1].Name = index.ToString();
                index += 1;
            }
            RecentToolStripMenuItem.DropDownItems.Add("-");
            RecentToolStripMenuItem.DropDownItems.Add("Clear", null, (_, __) => ClearRecentList());
        }

        private object GetShortPath(string param_path)
        {
            string lv_string = "";
            lv_string += param_path.Split('\\')[0];
            lv_string += @"\...\";
            lv_string += param_path.Split('\\')[param_path.Split('\\').Length - 2];
            lv_string += @"\" + param_path.Split('\\')[param_path.Split('\\').Length - 1];
            return lv_string;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ConfirmUnsavedDialog("open a file", (x, y) => { if (WindowOpenFileDialog.ShowDialog() == DialogResult.OK) { OpenFile(WindowOpenFileDialog.FileName); } });
        }

        private void OpenFile(string ParamLocation)
        {
            if (!File.Exists(ParamLocation))
            {
                CallError("That file has been moved or deleted.");
                RemoveFromRecentList(ParamLocation);
                return;
            }
            OpenInBackground(ParamLocation);
        }

        private void OnMdiFormClose(object sender, EventArgs e)
        {
            100.WaitThenExecute((_, __) => DrawVisibleForms());
        }

        private void OpenInBackground(string FileLocation)
        {
            var Worker = new BackgroundWorker();
            StartFileWork(FileLocation);
            Worker.DoWork += OpenFileWork;
            Worker.RunWorkerCompleted += CompleteFileWork;
            Worker.WorkerReportsProgress = false;
            Worker.RunWorkerAsync(FileLocation);
        }

        private void StartFileWork(string FileLocation)
        {
            TryCloseFile();
            FileFullName = FileLocation;
            FilePath = Path.GetDirectoryName(FileLocation);
            FileName = Path.GetFileName(FileLocation);
            FileExt = Path.GetExtension(FileLocation);
            ShowProgress();
        }

        private void ShowProgress()
        {
            FileLoadingProgressBar.Value = 18;
            FileLoadingProgressBar.Visible = true;
            Enabled = false;
            Status = "Loading";
        }

        private void OpenFileWork(object sender, DoWorkEventArgs e)
        {
            string FileLocation = e.Argument.ToString();
            Stream lv_stream = File.Open(FileLocation, FileMode.Open);
            if (lv_stream.Length == 0L)
                throw new Exception("File is empty.");
            // Attempting to read before the file is loaded...causing issues, so it's disabled for now.
            // If HeaderValidated() = False Then Throw New System.Exception("Invalid ROM type.")
            if (lv_stream != null)
            {
                ReadData(lv_stream);
            }
        }

        private void CompleteFileWork(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                AddToRecentList(FileFullName);
                DataReadComplete();
            }
            else
            {
                CallError("Cannot read file from disk." + Environment.NewLine + "Error: " + e.Error.Message + " " + e.Error.TargetSite.Name);
            }
            HideProgress();
        }

        private void HideProgress()
        {
            FileLoadingProgressBar.Visible = false;
            RefreshOpenState(true);
            Enabled = true;
            Status = "Loaded";
        }

        private void RefreshOpenState(bool IncludeReload)
        {
            bool Enabled = HexStorage.IsOpen;
            if (IncludeReload)
                ReloadMenuItem.Enabled = Enabled;
            CloseMenuItem.Enabled = Enabled;
        }

        private void CallError(string param_message)
        {
            Interaction.MsgBox(param_message, MsgBoxStyle.Critical, "Error");
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile(FileFullName);
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowSaveFileDialog.FileName = FileName;
            if (WindowSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveFile(WindowSaveFileDialog.FileName);
            }
        }

        private void GenerateBackup(string FileLocation, int MaxBackups)
        {
            string CurrentDirectory = Path.GetDirectoryName(FileLocation);
            string FileName = Path.GetFileNameWithoutExtension(FileLocation);
            var BackupFileRegex = new Regex($@"{Regex.Escape(FileName)}.*_(\d{{2}}).*$");
            string[] AllBackupFiles = Directory.GetFiles(CurrentDirectory, FileName + "*.bak").Where((BackupFilePath) =>
    {
        string BackupName = Path.GetFileNameWithoutExtension(BackupFilePath);
        return BackupFileRegex.IsMatch(BackupName);
    }).OrderByDescending((BackupFilePath) => File.GetLastWriteTime(BackupFilePath)).ToArray();
            if (AllBackupFiles.Length == 0)
            {
                string InitialBackupFilePath = $"{CurrentDirectory}/{FileName}_01.smc.bak";
                AllBackupFiles = new string[] { InitialBackupFilePath };
            }
            var NewFileIndex = default(int);
            foreach (string BackupFilePath in AllBackupFiles)
            {
                string NewBackupFilePath = BackupFileRegex.Replace(BackupFilePath, (Match) =>
    {
        var BackupIndexGroup = Match.Groups[1];
        int OffsetIndex = BackupIndexGroup.Index - (BackupFilePath.Length - Match.Value.Length);
        NewFileIndex = Math.Min(Conversions.ToInteger(BackupIndexGroup.Value) + 1, My.Settings.Default.Backups);
        return Match.Value.ReplaceAt(OffsetIndex, NewFileIndex.ToString("00"));
    });
                if (Conversions.ToBoolean(NewFileIndex & Conversions.ToInteger(!File.Exists(NewBackupFilePath))))
                {
                    File.Copy(FileLocation, NewBackupFilePath);
                    FileMessage = $"Backup {NewFileIndex} Created!";
                    return;
                }
            }
            string OldestBackupFilePath = AllBackupFiles.Last();
            int OldBackupFileIndex = Conversions.ToInteger(BackupFileRegex.Match(OldestBackupFilePath).Groups[1].Value);
            File.Delete(OldestBackupFilePath);
            File.Copy(FileLocation, OldestBackupFilePath);
            FileMessage = $"Backup {OldBackupFileIndex} Replaced!";
        }

        private void SaveFile(string FileLocation)
        {
            try
            {
                if (My.Settings.Default.AutoBackup)
                    GenerateBackup(FileLocation, My.Settings.Default.Backups);
                File.WriteAllBytes(FileLocation, HexStorage.Memory);
                HexStorage.Save();
                Status = "Saved";
                LastModified = "Never";
                Interaction.MsgBox("Save Complete!");
            }
            catch (Exception Ex)
            {
                CallError("Cannot write file to disk." + Environment.NewLine + "Error: " + Ex.Message);
            }
        }

        private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interaction.Shell("explorer /select," + FileFullName, AppWinStyle.NormalFocus);
        }

        private void TryCloseFile()
        {
            OpenedFile = false;
            My.MyProject.Forms.Form_EditorDatabase.Inactive(ProgressFileWork);
            My.MyProject.Forms.Form_EditorPalette.Inactive(ProgressFileWork);
            My.MyProject.Forms.Form_EditorSprite.Inactive(ProgressFileWork);
            My.MyProject.Forms.Form_EditorText.Inactive(ProgressFileWork);
            Text = DefaultText;
            ClearCache();
            Status = "Unopened";
        }

        private void ClearCache()
        {
            HexStorage.Memory = new byte[0];
            MemoryLiterator.ActionModule.Clear();
        }

        private void ReadBytes(Stream lv_data)
        {
            long NumBytes = lv_data.Length;
            var BinaryReader = new BinaryReader(lv_data);
            HexStorage.Memory = BinaryReader.ReadBytes(Convert.ToInt32(NumBytes));
            HexStorage.GlobalHexOffset = IsHeadered == true ? 0x200.ToString() : 0x000.ToString();
        }

        private void ReadData(Stream lv_stream)
        {
            ReadBytes(lv_stream);
            lv_stream.Close();
        }

        private void ProgressFileWork()
        {
            FileLoadingProgressBar.PerformStep();
            StatusPanel.Refresh();
        }

        private void RefreshControls(OnControlProgress OnProgress)
        {
            My.MyProject.Forms.Form_EditorDatabase.Active(OnProgress);
            My.MyProject.Forms.Form_EditorPalette.Active(OnProgress);
            My.MyProject.Forms.Form_EditorSprite.Active(OnProgress);
            My.MyProject.Forms.Form_EditorText.Active(OnProgress);
        }

        public void RefreshControls()
        {
            if (Conversions.ToBoolean(IsReady))
            {
                RefreshControls(() => { });
            }
        }

        private void DataReadComplete()
        {
            OpenedFile = true;
            HexStorage.Load();
            RefreshControls(ProgressFileWork);
            Text = DefaultText + " " + "(" + FileName + ")";
            OpenFileFolderToolStripMenuItem.Enabled = true;
            OpenProjectFolderToolStripMenuItem.Enabled = true;
            SaveToolStripMenuItem.Enabled = true;
            SaveAsToolStripMenuItem.Enabled = true;
            Interaction.MsgBox("Load Complete!");
            SystemFormEvent.RaiseInitialize(this);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ConfirmUnsavedDialog("exit from the Editor", (x, y) =>
                {
                    SaveAllSettings();
                    Dispose();
                });
        }

        private void ConfirmUnsavedDialog(string Action, EventHandler OnConfirm)
        {
            SystemFormEvent.ConfirmDialog(this, HexStorage.HasUnsavedWork, Action, OnConfirm, "You have unsaved work. ");
        }

        private void DataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormByName("Form_EditorDatabase");
        }

        private void SpriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormByName("Form_EditorSprite");
        }

        private void PaletteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormByName("Form_EditorPalette");
        }

        private void TextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFormByName("Form_EditorText");
        }

        private void ToolStripButtonData_Click(object sender, EventArgs e)
        {
            OpenFormByName("Form_EditorDatabase");
        }

        private void ToolStripButtonSprite_Click(object sender, EventArgs e)
        {
            OpenFormByName("Form_EditorSprite");
        }

        private void ToolStripButtonPalette_Click(object sender, EventArgs e)
        {
            OpenFormByName("Form_EditorPalette");
        }

        private void ToolStripButtonText_Click(object sender, EventArgs e)
        {
            OpenFormByName("Form_EditorText");
        }

        private void OpenFormByName(string Name)
        {
            BasicForm form = (BasicForm)GetFormReference(Name);
            if (My.MyProject.Application.OpenForms.FindByName(Name) != null)
            {
                form.BringToFront();
                DrawVisibleForms();
                return;
            }
            form.MdiParent = this;
            form.WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
            form.Show();
            if (HexStorage.IsOpen)
            {
                SystemFormEvent.RaiseInitialize(this);
            }
            form.BringToFront();
            DrawVisibleForms();
        }

        private void DrawVisibleForms()
        {
            BasicForm topMostForm = (BasicForm)ActiveMdiChild;
            foreach (ToolStripButton toolStripButton in WindowToolStrip.Items)
            {
                BasicForm mdi = (BasicForm)My.MyProject.Application.OpenForms.FindByName(toolStripButton.Text);
                toolStripButton.Visible = mdi != null && mdi.Visible;
                toolStripButton.Checked = mdi != null && ReferenceEquals(mdi, topMostForm);
                toolStripButton.Enabled = !toolStripButton.Checked;
            }
        }

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x112;
            const int SC_RESTORE = 0xF120;
            const int SC_MAXIMIZE = 0xF030;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    {
                        int command = message.WParam.ToInt32() & 0xFFF0;
                        if (command == SC_MAXIMIZE)
                        {
                            Maximize = true;
                        }
                        else if (command == SC_RESTORE)
                        {
                            Maximize = false;
                        }

                        break;
                    }
            }

            base.WndProc(ref message);
        }

        private void Me_KeyDown(object sender, KeyEventArgs e)
        {
            if (MdiChildren.Count() > 0 && e.Modifiers == Keys.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.PageUp:
                        {
                            GoToNextMdiChild();
                            break;
                        }
                    case Keys.PageDown:
                        {
                            GoToLastMdiChild();
                            break;
                        }
                }
            }
        }

        private int GetCurrentMdiChildIndex()
        {
            return Array.IndexOf(MdiChildren, ActiveMdiChild);
        }

        private void GoToNextMdiChild()
        {
            var index = Conversions.ToInteger(GetNextMdiChild());
            MdiChildren[index].Focus();
        }

        private void GoToLastMdiChild()
        {
            var index = Conversions.ToInteger(GetLastMdiChild());
            MdiChildren[index].Focus();
        }

        private object GetNextMdiChild()
        {
            int start_index = Array.IndexOf(MdiChildren, ActiveMdiChild);
            int index = start_index < MdiChildren.Count() - 1 ? start_index + 1 : 0;
            while (!(index == start_index | MdiChildren[index].Visible == true))
                index = index < MdiChildren.Count() - 1 ? index + 1 : 0;
            return index;
        }

        private object GetLastMdiChild()
        {
            int start_index = Array.IndexOf(MdiChildren, ActiveMdiChild);
            int index = start_index > 0 ? start_index - 1 : MdiChildren.Count() - 1;
            while (!(index == start_index | MdiChildren[index].Visible == true))
                index = index > 0 ? index - 1 : MdiChildren.Count() - 1;
            return index;
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Form_ToolFont.ShowDialog();
        }

        private void HelpAboutStripMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Form_HelpAbout.ShowFormAsTool();
        }

        private void PreferencesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Form_OptionsPreferences.ShowFormAsTool();
        }

        private void ReloadMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmUnsavedDialog("reload the file", (_, __) => ReloadRecentFile());
        }

        private void CloseFile()
        {
            TryCloseFile();
            RefreshOpenState(false);
        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            ConfirmUnsavedDialog("close the file", (_, __) => CloseFile());
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemoryLiterator.ActionModule.Undo();
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MemoryLiterator.ActionModule.Redo();
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var TextBox = TextControl(FocusedEditor);
            if (TextBox != null)
            {
                TextBox.SelectAll();
            }
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var TextBox = TextControl(FocusedEditor);
            if (TextBox != null)
            {
                TextBox.Cut();
            }
        }

        private void Me_Copy(object sender, EventArgs e)
        {
            var TextBox = TextControl(FocusedEditor);
            if (TextBox != null)
            {
                TextBox.Copy();
            }
        }

        private void Me_Paste(object sender, EventArgs e)
        {
            var TextBox = TextControl(FocusedEditor);
            if (TextBox != null)
            {
                TextBox.Paste();
            }
        }

        private void DataEditorMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Form_ToolData.ShowDialog();
        }

        private void HistoryViewerMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Form_ToolHistory.ShowDialog();
        }

        private void DocumentLastModified_DoubleClick(object sender, EventArgs e)
        {
            My.MyProject.Forms.Form_ToolHistory.StartIndex = 0;
            My.MyProject.Forms.Form_ToolHistory.ShowDialog();
        }

        private void GraphicsViewerMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.Form_ToolGraphic.ShowDialog();
        }

        private void NextOpenModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToNextMdiChild();
        }

        private void LastOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoToLastMdiChild();
        }

        private void OpenProjectFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Interaction.Shell("explorer /select," + FontTable.ActiveFilePath, AppWinStyle.NormalFocus);
        }
    }
}