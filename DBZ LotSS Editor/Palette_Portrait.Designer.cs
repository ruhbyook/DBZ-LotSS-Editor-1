using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DBZ_LotSS_Editor
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Palette_Portrait : HexTools.HexUserControl
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
            this.BasicListBoxAssociate1 = new HexTools.HexListBoxAssociate();
            this.HexPalette = new HexTools.HexPalette();
            this.HexListBox1 = new HexTools.HexListBox();
            this.BasicColorSelector1 = new BasicTools.BasicControls.BasicColorSelector();
            this.BasicListBoxAssociate1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BasicListBoxAssociate1
            // 
            this.BasicListBoxAssociate1.Controls.Add(this.HexPalette);
            this.BasicListBoxAssociate1.FormatAddress = "X4";
            this.BasicListBoxAssociate1.ListBox = this.HexListBox1;
            this.BasicListBoxAssociate1.Location = new System.Drawing.Point(255, 17);
            this.BasicListBoxAssociate1.Name = "BasicListBoxAssociate1";
            this.BasicListBoxAssociate1.Size = new System.Drawing.Size(517, 550);
            this.BasicListBoxAssociate1.TabIndex = 18;
            this.BasicListBoxAssociate1.TabStop = false;
            this.BasicListBoxAssociate1.Text = "HexListBox1";
            // 
            // HexPalette
            // 
            this.HexPalette.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.HexPalette.Location = new System.Drawing.Point(7, 28);
            this.HexPalette.Name = "HexPalette";
            this.HexPalette.Size = new System.Drawing.Size(377, 101);
            this.HexPalette.TabIndex = 21;
            // 
            // HexListBox1
            // 
            this.HexListBox1.CanEditLabel = true;
            this.HexListBox1.Definition = "PaletteEditor.Portraits.List";
            this.HexListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.HexListBox1.FormatString = "X2";
            this.HexListBox1.FormattingEnabled = true;
            this.HexListBox1.IndexDisplay = true;
            this.HexListBox1.Location = new System.Drawing.Point(16, 17);
            this.HexListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.HexListBox1.Name = "HexListBox1";
            this.HexListBox1.SelectedItem = null;
            this.HexListBox1.Size = new System.Drawing.Size(232, 550);
            this.HexListBox1.TabIndex = 14;
            // 
            // BasicColorSelector1
            // 
            this.BasicColorSelector1.ShortcutKeys = true;
            // 
            // Palette_Portrait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BasicListBoxAssociate1);
            this.Controls.Add(this.HexListBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Palette_Portrait";
            this.Size = new System.Drawing.Size(787, 603);
            this.BasicListBoxAssociate1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal HexTools.HexListBox HexListBox1;
        internal BasicTools.BasicControls.BasicColorSelector BasicColorSelector1;
        internal HexTools.HexListBoxAssociate BasicListBoxAssociate1;
        private HexTools.HexPalette HexPalette;
    }
}