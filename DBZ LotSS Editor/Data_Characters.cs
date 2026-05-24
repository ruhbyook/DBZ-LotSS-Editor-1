using System.Linq;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.ListViewItem;
using System.Collections.Generic;

namespace DBZ_LotSS_Editor
{
    public partial class Data_Characters : HexTools.HexUserControl
    {
        readonly int[] CannotLevel = new int[] { 8, 9, 10, 12 };
        readonly int[] CannotBattle = new int[] { 12 };

        public Data_Characters()
        {
            InitializeComponent();
        }

        private void HexListBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selectedIndex = HexListBox1.SelectedIndex;

            Transformation.Visible = selectedIndex <= 7;
            NoTransformation.Visible = !Transformation.Visible;

            Levels.Enabled = !CannotLevel.Contains(selectedIndex);
            NoLevel.Visible = !Levels.Enabled;

            Battler.Visible = !CannotBattle.Contains(selectedIndex);
            NoBattler.Visible = !Battler.Visible;
        }

        private void ExportLevelData_Click(object sender, System.EventArgs e)
        {
            var exportedData = new List<string>();

            foreach (ListViewItem item in Levels.Items)
            {
                exportedData.Add(string.Join(",", item.SubItems.Cast<ListViewSubItem>()
                    .Skip(1).Select(x => x.Text.Replace(",", string.Empty))
                ));
            }

            File.WriteAllLines(Path.GetDirectoryName(Application.ExecutablePath) + $"/{HexListBox1.SelectedItem.Text}.csv", exportedData);

            MessageBox.Show($"{HexListBox1.SelectedItem.Text} data was successfully exported!");
        }
    }
}