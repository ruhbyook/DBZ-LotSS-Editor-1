using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DBZ_LotSS_Editor
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Palette_System : HexTools.HexUserControl
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
            this.BasicColorSelector1 = new BasicTools.BasicControls.BasicColorSelector();
            this.HexListBox1 = new HexTools.HexListBox();
            this.BasicListBoxAssociate1 = new HexTools.HexListBoxAssociate();
            this.HexPanel1 = new HexTools.HexPanel();
            this.HexPalette = new HexTools.HexPalette();
            this.BasicListBoxAssociate1.SuspendLayout();
            this.HexPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BasicColorSelector1
            // 
            this.BasicColorSelector1.ShortcutKeys = true;
            // 
            // HexListBox1
            // 
            this.HexListBox1.CanEditLabel = true;
            this.HexListBox1.Definition = "PaletteEditor.System.List";
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
            // BasicListBoxAssociate1
            // 
            this.BasicListBoxAssociate1.Controls.Add(this.HexPanel1);
            this.BasicListBoxAssociate1.FormatAddress = "X6";
            this.BasicListBoxAssociate1.ListBox = this.HexListBox1;
            this.BasicListBoxAssociate1.Location = new System.Drawing.Point(255, 17);
            this.BasicListBoxAssociate1.Name = "BasicListBoxAssociate1";
            this.BasicListBoxAssociate1.Size = new System.Drawing.Size(518, 550);
            this.BasicListBoxAssociate1.TabIndex = 18;
            this.BasicListBoxAssociate1.TabStop = false;
            this.BasicListBoxAssociate1.Text = "HexListBox1";
            // 
            // HexPanel1
            // 
            this.HexPanel1.Controls.Add(this.HexPalette);
            this.HexPanel1.Location = new System.Drawing.Point(7, 28);
            this.HexPanel1.Name = "HexPanel1";
            this.HexPanel1.Size = new System.Drawing.Size(383, 112);
            this.HexPanel1.TabIndex = 18;
            // 
            // HexPalette
            // 
            this.HexPalette.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HexPalette.Encoding = HexTools.HexEnumerations.ImageEncodingType.FormatPlanar2BPP;
            this.HexPalette.Endian = HexTools.HexEnumerations.EndianType.Little_Endian;
            this.HexPalette.Location = new System.Drawing.Point(0, 0);
            this.HexPalette.Name = "HexPalette";
            this.HexPalette.Size = new System.Drawing.Size(383, 112);
            this.HexPalette.TabIndex = 21;
            // 
            // Palette_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BasicListBoxAssociate1);
            this.Controls.Add(this.HexListBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Palette_System";
            this.Size = new System.Drawing.Size(787, 603);
            this.BasicListBoxAssociate1.ResumeLayout(false);
            this.HexPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal HexTools.HexListBox HexListBox1;
        internal BasicTools.BasicControls.BasicColorSelector BasicColorSelector1;
        internal HexTools.HexListBoxAssociate BasicListBoxAssociate1;
        internal HexTools.HexPanel HexPanel1;
        private HexTools.HexPalette HexPalette;
    }
}