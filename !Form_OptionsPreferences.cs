using System;
using System.Linq;
using System.Windows.Forms;
using BasicTools;
using HexTools.HexEnumerations;

namespace DBZ_LotSS_Editor
{

    public partial class Form_OptionsPreferences : HexTools.HexForm
    {
        public Form_OptionsPreferences()
        {
            InitializeComponent();
        }

        private void Form_OptionsPreferences_Load(object sender, EventArgs e)
        {
            My.Settings.Default.Reload();
            AutoLoadWindows.Checked = My.Settings.Default.AutoLoadWindows;
            AutoLoadRecent.Checked = My.Settings.Default.AutoLoadRecent;
            AutoBackup.Checked = My.Settings.Default.AutoBackup;
            Backups.Value = My.Settings.Default.Backups;
            SupressUnsafeWarnings.Checked = My.Settings.Default.SupressUnsafeWarnings;
            if(DataManagement.Items.Count == 0)
            {
                DataManagement.Items.AddRange(Enum.GetValues(typeof(DataManagementType))
                    .Cast<object>().ToArray());
            }
            DataManagement.SelectedItem = My.Settings.Default.DataManagement;
        }

        private void AutoLoadWindows_CheckedChanged(object sender, EventArgs e)
        {
            My.Settings.Default.AutoLoadWindows = AutoLoadWindows.Checked;
        }

        private void AutoLoadRecent_CheckedChanged(object sender, EventArgs e)
        {
            My.Settings.Default.AutoLoadRecent = AutoLoadRecent.Checked;
        }

        private void AutoBackup_CheckedChanged(object sender, EventArgs e)
        {
            My.Settings.Default.AutoBackup = AutoBackup.Checked;
            BackupsPanel.Enabled = AutoBackup.Checked;
        }

        private void Backups_ValueChanged(object sender, EventArgs e)
        {
            My.Settings.Default.Backups = (byte)Math.Round(Backups.Value);
        }

        private void SupressUnsafeWarnings_CheckedChanged(object sender, EventArgs e)
        {
            My.Settings.Default.SupressUnsafeWarnings = SupressUnsafeWarnings.Checked;
        }

        private void DataManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            My.Settings.Default.DataManagement = (DataManagementType) DataManagement.SelectedItem;
        }

        private void Form_OptionsPreferences_FormClosing(object sender, FormClosingEventArgs e)
        {
            My.Settings.Default.Reload();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            My.Settings.Default.Save();
            SystemFormEvent.RaisePreferencesSaved(My.Settings.Default);
            Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            My.Settings.Default.Reload();
            Close();
        }
    }
}