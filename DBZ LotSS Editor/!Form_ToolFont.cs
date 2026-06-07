using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BasicTools;
using BasicTools.BasicControls;
using HexTools;
using HexTools.HexStructures;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace DBZ_LotSS_Editor
{

    public partial class Form_ToolFont : HexForm
    {

        public FontTable CustomFontTable
        {
            get
            {
                return My.MyProject.Forms.Form_EditorText.HexFontTable1.FontTable;
            }
        }

        public Form_ToolFont()
        {
            InitializeComponent();
        }

        private void ReloadTextBoxes()
        {
            if (Conversions.ToBoolean(My.MyProject.Forms.Form_Main.IsReady))
            {

                My.MyProject.Forms.Form_EditorText.Active(() => { });
            }
        }

        private void Sync(int SelectedKey = -1)
        {
            int TopItem = SelectedKey >= 0 ? FontTableView.TopItem.Index : -1;
            int SelectedIndex = -1;
            FontTableView.Items.Clear();
            int Index = 0;
            foreach (KeyValuePair<int, string> Entry in CustomFontTable)
            {
                var Item = new ListViewItem();
                FontTableView.Items.Add(Item);

                var HexItem = new ListViewItem.ListViewSubItem();
                HexItem.Text = Entry.Key.ToString("X2");
                HexItem.Tag = Entry.Key.ToString("X2");
                FontTableView.Items[Index].SubItems.Add(HexItem);

                var ValueItem = new ListViewItem.ListViewSubItem();
                ValueItem.Text = Entry.Value.ToString();
                ValueItem.Tag = ValueItem.Text;
                FontTableView.Items[Index].SubItems.Add(ValueItem);

                if (SelectedIndex == -1 && Entry.Key == SelectedKey)
                    SelectedIndex = Index;
                Index += 1;
            }
            if (TopItem != -1)
            {
                FontTableView.TopItem = FontTableView.Items[TopItem];
                FontTableView.SelectedIndices.Clear();
                FontTableView.SelectedIndices.Add(SelectedIndex);
            }
            ReloadTextBoxes();
        }

        private bool LoadTableIntoMemory(byte[] Table)
        {
            string chars = "";
            var keys = new List<int>();
            var values = new List<string>();
            int index = 0;
            int skip = 0;

            int line = 1;
            try
            {
                foreach (byte b in Table)
                {
                    if (skip > 0)
                    {
                        skip -= 1;
                        continue;
                    }
                    if (b == 0xEF | b == 0xBB | b == 0xBF)
                    {
                    }
                    // Ignore it
                    else if (b == 0xA)
                    {
                        // New Line
                        if (Table.ElementAt(index + 1) == 0xD)
                        {
                            skip = 2;
                        }
                        else
                        {
                            line += 1;
                        }
                    }
                    else if (b == 0xD)
                    {
                        // Add Value
                        values.Add(chars);
                        chars = "";
                    }
                    else
                    {
                        // Windows 1252, which is an extended ASCII format to allow for some special characters
                        char c = System.Text.Encoding.GetEncoding(1252).GetChars(new byte[] { b }).First();
                        if (Conversions.ToString(c) == "=")
                        {
                            // Add Key
                            keys.Add(HexConvert.HexToIntRaw(chars));
                            chars = "";
                        }
                        else
                        {
                            // Append Value
                            chars += Conversions.ToString(c);
                        }
                    }
                    index += 1;
                }
                if (chars.Length > 0)
                    values.Add(chars);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error on line: {0}", line), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!(keys.Count == values.Count))
            {
                MessageBox.Show(string.Format(@"Line Count Mismatch \n Keys: {0} \n Values: {1}", keys.Count, values.Count), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            for (int i = 0, loopTo = line - 1; i <= loopTo; i += 1)
                CustomFontTable.Add(keys[i], values[i]);

            return true;

        }

        public static byte[] HexToBytes(string s)
        {
            string[] bytes = s.Split(' ');
            var retval = new byte[bytes.Length];
            for (int ix = 0, loopTo = bytes.Length - 1; ix <= loopTo; ix++)
                retval[ix] = byte.Parse(bytes[ix], NumberStyles.HexNumber);
            return retval;
        }

        private void AddStringToByteList(ref List<byte> Output, string Input)
        {
            foreach (char c in Input.ToCharArray())
                Output.Add(Convert.ToByte(Strings.Asc(c)));
        }

        private bool SaveTable(string Path, FontTable Table)
        {
            try
            {
                var Output = new List<byte>();
                for (int i = 0, loopTo = CustomFontTable.Count - 1; i <= loopTo; i++)
                {
                    AddStringToByteList(ref Output, HexConvert.IntToHexRaw(CustomFontTable.Entries.ElementAtOrDefault(i), 1) + "=" + CustomFontTable.Symbols.ElementAtOrDefault(i).ToString());
                    if (i < CustomFontTable.Count - 1)
                    {
                        Output.Add(0xD);
                        Output.Add(0xA);
                    }
                }
                File.WriteAllBytes(Path, Output.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private object LoadTable(string Path)
        {
            return LoadTableIntoMemory(File.ReadAllBytes(Path));
        }

        public void LoadProjectTable()
        {
            CustomFontTable.Clear();
            LoadTableIntoMemory(FontTable.LoadActiveFile);
            Sync();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            KeyValuePair<int, string> SelectedItem;
            if (FontTableView.SelectedItems.Count > 0)
            {
                int index = HexConvert.HexToIntRaw(FontTableView.SelectedItems[0].SubItems[1].Tag.ToString());
                SelectedItem = CustomFontTable.Insert(index);
            }
            else
            {
                SelectedItem = CustomFontTable.Add();
            }
            Sync();
            int newIndex = CustomFontTable.FindIndex(SelectedItem.Key);
            var ListViewItem = FontTableView.Items[newIndex];
            ListViewItem.Selected = true;
            ListViewItem.EnsureVisible();
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            int LastSelectedItemIndex = FontTableView.SelectedIndices.Count > 0 ? FontTableView.SelectedIndices[0] : -1;
            int LastTopItemIndex = FontTableView.TopItem.Index;
            if (FontTableView.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in FontTableView.SelectedItems)
                {
                    int index = HexConvert.HexToIntRaw(item.SubItems[1].Tag.ToString());
                    CustomFontTable.Remove(index);
                }
                Sync();
            }
            if (FontTableView.Items.Count > 0 && LastSelectedItemIndex < FontTableView.Items.Count - 1)
            {
                var ListViewItem = FontTableView.Items[LastSelectedItemIndex];
                ListViewItem.Selected = true;
            }
            FontTableView.TopItem = FontTableView.Items[LastTopItemIndex];
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            CustomFontTable.Clear();
            LoadTableIntoMemory(My.Resources.Resources.DefaultTable);
            Sync();
        }

        private void Column_Edit(object sender, SubItemEndEditingEventArgs e)
        {
            if (e.Cancel)
                return;
            if (e.Column == 1)
            {
                string NewKey = e.Control.Text;
                int NewKeyIndex = HexConvert.HexToIntRaw(NewKey);
                if (Conversions.ToBoolean(Operators.ConditionalCompareObjectEqual(CustomFontTable.IsNew(NewKeyIndex), false, false)))
                {
                    string NewValue = CustomFontTable.Entries.ElementAtOrDefault(NewKeyIndex).ToString();
                    e.Cancel = true;
                    MiscellanousExtension.WaitThenExecute(50, (x, y) => MessageBox.Show($"The Key {NewKey} already exists as: {NewKey} = {NewValue}", "Duplicate Key"));
                    return;
                }
                int OldKeyIndex = HexConvert.HexToIntRaw(e.Control.Tag.ToString());
                string OldValue = CustomFontTable.Entries.ElementAtOrDefault(OldKeyIndex).ToString();
                CustomFontTable.Remove(OldKeyIndex);
                CustomFontTable.Add(NewKeyIndex, OldValue);
                Sync(NewKeyIndex);
            }
            else if (e.Column == 2)
            {
                string OldKey = e.Item.SubItems[1].Text;
                int OldKeyIndex = HexConvert.HexToIntRaw(OldKey);
                string NewValue = e.Control.Text;
                CustomFontTable.Remove(Conversions.ToInteger(OldKey));
                CustomFontTable.Add(OldKeyIndex, NewValue);
                Sync(OldKeyIndex);
            }
        }

        private void ButtonImport_Click(object sender, EventArgs e)
        {
            if (OpenFileImport.ShowDialog() == DialogResult.OK)
            {
                CustomFontTable.Clear();
                if (Conversions.ToBoolean(LoadTable(OpenFileImport.FileName)))
                {
                    Sync();
                }
            }
        }

        private void ButtonExport_Click(object sender, EventArgs e)
        {
            if (SaveFileExport.ShowDialog() == DialogResult.OK)
            {
                SaveTable(SaveFileExport.FileName, CustomFontTable);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveTable(FontTable.ActiveFilePath, CustomFontTable);
        }

        private void ButtonReload_Click(object sender, EventArgs e)
        {
            LoadProjectTable();
        }
    }
}