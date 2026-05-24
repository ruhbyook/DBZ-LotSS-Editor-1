using System;
using System.Windows.Forms;
using BasicTools;
using HexTools;
using HexTools.HexEnumerations;

namespace DBZ_LotSS_Editor
{

    public partial class Form_ToolData : HexForm
    {

        public Editor_Find Editor_Find { get; set; } = new Editor_Find();
        public Editor_GoTo Editor_GoTo { get; set; } = new Editor_GoTo();

        private SystemKeyboardEvent Shortcuts;

        public bool HaveData
        {
            get
            {
                return HexStorage.IsOpen;
            }
        }

        public Form_ToolData()
        {
            InitializeComponent();
        }

        private void Initalize()
        {
            ContentPanel.Enabled = HaveData;
            AbsoluteCenterLayout.Visible = !HaveData;

            if (HaveData)
            {
                HexDeveloper.Load();
            }

            if (Shortcuts == null)
            {
                Shortcuts = new SystemKeyboardEvent();

                Shortcuts.RegisterHotKey(KeyboardModifierKeys.Control, Keys.NumPad0);
                Shortcuts.RegisterHotKey(KeyboardModifierKeys.Control, Keys.NumPad1);
                Shortcuts.RegisterHotKey(KeyboardModifierKeys.Control, Keys.NumPad2);
                Shortcuts.RegisterHotKey(KeyboardModifierKeys.Control, Keys.NumPad3);
                Shortcuts.RegisterHotKey(KeyboardModifierKeys.Control, Keys.NumPad4);
                Shortcuts.RegisterHotKey(KeyboardModifierKeys.Control, Keys.NumPad5);
                Shortcuts.RegisterHotKey(KeyboardModifierKeys.Control, Keys.NumPad6);
                Shortcuts.RegisterHotKey(KeyboardModifierKeys.Control, Keys.NumPad7);
                Shortcuts.RegisterHotKey(KeyboardModifierKeys.Control, Keys.NumPad8);
                Shortcuts.RegisterHotKey(KeyboardModifierKeys.Control, Keys.NumPad9);
                Shortcuts.RegisterHotKey(KeyboardModifierKeys.Control, Keys.Add);
                Shortcuts.RegisterHotKey(KeyboardModifierKeys.Control, Keys.Subtract);
                Shortcuts.KeyPressed += ShortcutPressed;
            }
        }

        private void Form_ToolHistory_Load(object sender, EventArgs e)
        {
            Initalize();
        }

        private void OK_Button_Click(object Sender, EventArgs e)
        {
            if (HaveData)
            {
                HexDeveloper.Save();
            }
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            if (HaveData)
            {
                HexDeveloper.Discard();
            }
            Close();
        }

        private void GoToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Result = Editor_GoTo.ShowAsTool();
            if (Result.Offset >= 0)
            {
                HexDeveloper.GoTo(Result.Offset);
            }
        }

        private void Find(FindQuantityType Quantity, FindDirectionType Direction = 0)
        {
            var Result = Editor_Find.ShowAsTool(Quantity, Direction);
            if (!string.IsNullOrEmpty(Result.Search))
            {
                switch (Result.Quantity)
                {
                    case FindQuantityType.One:
                        {
                            HexDeveloper.Find(Result.Search, Result.Direction, Result.Location);
                            break;
                        }
                    case FindQuantityType.All:
                        {
                            HexDeveloper.FindAll(Result.Search, Result.Location);
                            break;
                        }
                }
            }
        }

        private void ShortcutPressed(object sender, KeyPressedEventArgs args)
        {
            if (args.Modifier == KeyboardModifierKeys.Control)
            {
                switch (args.Key)
                {
                    case Keys.NumPad0:
                        {
                            ZoomMenuItem0.PerformClick();
                            break;
                        }
                    case Keys.NumPad1:
                        {
                            ZoomMenuItem1.PerformClick();
                            break;
                        }
                    case Keys.NumPad2:
                        {
                            ZoomMenuItem2.PerformClick();
                            break;
                        }
                    case Keys.NumPad3:
                        {
                            ZoomMenuItem3.PerformClick();
                            break;
                        }
                    case Keys.NumPad4:
                        {
                            ZoomMenuItem4.PerformClick();
                            break;
                        }
                    case Keys.NumPad5:
                        {
                            ZoomMenuItem5.PerformClick();
                            break;
                        }
                    case Keys.NumPad6:
                        {
                            ZoomMenuItem6.PerformClick();
                            break;
                        }
                    case Keys.NumPad7:
                        {
                            ZoomMenuItem7.PerformClick();
                            break;
                        }
                    case Keys.NumPad8:
                        {
                            ZoomMenuItem8.PerformClick();
                            break;
                        }
                    case Keys.NumPad9:
                        {
                            ZoomMenuItem9.PerformClick();
                            break;
                        }
                    case Keys.Add:
                        {
                            ZoomMenuItemPlus.PerformClick();
                            break;
                        }
                    case Keys.Subtract:
                        {
                            ZoomMenuItemMinus.PerformClick();
                            break;
                        }
                }
            }
        }

        private void FindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find(FindQuantityType.One, FindDirectionType.First);
        }

        private void NextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find(FindQuantityType.One, FindDirectionType.Next);
        }

        private void LastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find(FindQuantityType.One, FindDirectionType.Previous);
        }

        private void FindAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Find(FindQuantityType.All);
        }

        private void PlainTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HexDeveloper.ViewMode = ViewHexType.PlainText;
            FontTableToolStripMenuItem.Checked = false;
        }

        private void FontTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HexDeveloper.ViewMode = ViewHexType.FontTable;
            PlainTextToolStripMenuItem.Checked = false;
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HexDeveloper.ClearFind();
        }

        private void ZoomMenuItem0_Click(object sender, EventArgs e)
        {
            HexDeveloper.Zoom(1.0d);
        }

        private void ZoomMenuItem1_Click(object sender, EventArgs e)
        {
            HexDeveloper.Zoom(1.1d);
        }

        private void ZoomMenuItem2_Click(object sender, EventArgs e)
        {
            HexDeveloper.Zoom(1.2d);
        }

        private void ZoomMenuItem3_Click(object sender, EventArgs e)
        {
            HexDeveloper.Zoom(1.3d);
        }

        private void ZoomMenuItem4_Click(object sender, EventArgs e)
        {
            HexDeveloper.Zoom(1.4d);
        }

        private void ZoomMenuItem5_Click(object sender, EventArgs e)
        {
            HexDeveloper.Zoom(1.5d);
        }

        private void ZoomMenuItem6_Click(object sender, EventArgs e)
        {
            HexDeveloper.Zoom(1.6d);
        }

        private void ZoomMenuItem7_Click(object sender, EventArgs e)
        {
            HexDeveloper.Zoom(1.7d);
        }

        private void ZoomMenuItem8_Click(object sender, EventArgs e)
        {
            HexDeveloper.Zoom(1.8d);
        }

        private void ZoomMenuItem9_Click(object sender, EventArgs e)
        {
            HexDeveloper.Zoom(1.9d);
        }

        private void ZoomMenuItemPlus_Click(object sender, EventArgs e)
        {
            HexDeveloper.Zoom(0.1d, true);
        }

        private void ZoomMenuItemMinus_Click(object sender, EventArgs e)
        {
            HexDeveloper.Zoom(-0.1d, true);
        }
    }
}