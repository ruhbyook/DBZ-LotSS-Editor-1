using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;

namespace DBZ_LotSS_Editor
{
    public partial class Data_Characters : HexTools.HexUserControl
    {
        private static readonly CharacterDataDefinition DefaultCharacterDefinition =
            new BasicTools.BasicJsonDefinition<CharacterDataDefinition>(My.Resources.Resources.DataEditor_Characters)
                .Definition;

        public Data_Characters()
        {
            InitializeComponent();
        }

        private void HexListBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            UpdateControls();
        }

        private void UpdateControls()
        {
            var selectedIndex = HexListBox1.SelectedIndex;

            var character = DefaultCharacterDefinition.List[selectedIndex];

            Transformation.Visible = character.CanTransform;
            NoTransformation.Visible = !character.CanTransform;

            Levels.Enabled = character.CanLevel;
            NoLevel.Visible = !character.CanLevel;

            Battler.Visible = character.CanBattle;
            NoBattler.Visible = !character.CanBattle;
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