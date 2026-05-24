using System;

namespace DBZ_LotSS_Editor
{
    public partial class Data_Items : HexTools.HexUserControl
    {
        public Data_Items()
        {
            InitializeComponent();
        }

        private void RefreshZenie()
        {
            Zenie.Enabled = !Priceless.Checked;
        }

        private void HexCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            RefreshZenie();
        }

        private void HexCheckBox1_EnabledChanged(object sender, EventArgs e)
        {
            RefreshZenie();
        }

        private void HexCheckBox1_PreWrite(object sender, HexTools.PreWriteArgs e)
        {
            if (Zenie.Enabled)
            {
                e.NewValue = Math.Min(Zenie.Value, 254m);
            }
        }

        // Private Sub DataGridView1_Layout(sender As Object, e As LayoutEventArgs) Handles DataGridView1.Layout
        // If DataGridView1.Rows.Count = 0 Then
        // DataGridView1.Rows.Add("1", "00")

        // DataGridView1.Columns(0).DataPropertyName = "Index"
        // DataGridView1.Columns(1).DataPropertyName = "Skill"
        // End If
        // End Sub
    }
}