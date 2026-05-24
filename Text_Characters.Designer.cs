using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DBZ_LotSS_Editor
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Text_Characters : HexTools.HexUserControl
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
            HexTools.HexListBoxItem hexListBoxItem53 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem54 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem55 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem56 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem57 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem58 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem59 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem60 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem61 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem62 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem63 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem64 = new HexTools.HexListBoxItem();
            HexTools.HexListBoxItem hexListBoxItem65 = new HexTools.HexListBoxItem();
            this.BasicListBoxAssociate1 = new BasicTools.BasicControls.BasicListBoxAssociate();
            this.HexPanel1 = new HexTools.HexPanel();
            this._Text = new HexTools.HexTextBox();
            this.HexListBox1 = new HexTools.HexListBox();
            this.BasicListBoxAssociate1.SuspendLayout();
            this.HexPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BasicListBoxAssociate1
            // 
            this.BasicListBoxAssociate1.Controls.Add(this.HexPanel1);
            this.BasicListBoxAssociate1.ListBox = this.HexListBox1;
            this.BasicListBoxAssociate1.Location = new System.Drawing.Point(255, 17);
            this.BasicListBoxAssociate1.Name = "BasicListBoxAssociate1";
            this.BasicListBoxAssociate1.Size = new System.Drawing.Size(518, 550);
            this.BasicListBoxAssociate1.TabIndex = 19;
            this.BasicListBoxAssociate1.TabStop = false;
            this.BasicListBoxAssociate1.Text = "HexListBox1";
            // 
            // HexPanel1
            // 
            this.HexPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HexPanel1.Controls.Add(this._Text);
            this.HexPanel1.IndexOffset = "&H000002";
            this.HexPanel1.Location = new System.Drawing.Point(8, 36);
            this.HexPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.HexPanel1.Name = "HexPanel1";
            this.HexPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.HexPanel1.Pointer = "&H012D66";
            this.HexPanel1.PointerBank = 2;
            this.HexPanel1.PointerIgnoreHeader = true;
            this.HexPanel1.PointerLength = 2;
            this.HexPanel1.Size = new System.Drawing.Size(240, 41);
            this.HexPanel1.TabIndex = 37;
            // 
            // _Text
            // 
            this._Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Text.DynamicLength = 1;
            this._Text.Font = new System.Drawing.Font("Consolas", 12F);
            this._Text.FontTableUsesGlobal = true;
            this._Text.Location = new System.Drawing.Point(5, 5);
            this._Text.Margin = new System.Windows.Forms.Padding(5);
            this._Text.MaxLengthLabel = true;
            this._Text.Name = "_Text";
            this._Text.Size = new System.Drawing.Size(230, 31);
            this._Text.TabIndex = 18;
            // 
            // HexListBox1
            // 
            this.HexListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.HexListBox1.FormatString = "X2";
            this.HexListBox1.FormattingEnabled = true;
            this.HexListBox1.IndexDisplay = true;
            hexListBoxItem53.Text = "Index00";
            hexListBoxItem53.Value = "&HABBE";
            hexListBoxItem54.Text = "Index01";
            hexListBoxItem54.Value = "&HABC3";
            hexListBoxItem55.Text = "Index02";
            hexListBoxItem55.Value = "&HABC9";
            hexListBoxItem56.Text = "Index03";
            hexListBoxItem56.Value = "&HABD1";
            hexListBoxItem57.Text = "Index04";
            hexListBoxItem57.Value = "&HABD9";
            hexListBoxItem58.Text = "Index05";
            hexListBoxItem58.Value = "&HABDE";
            hexListBoxItem59.Text = "Index06";
            hexListBoxItem59.Value = "&HABE5";
            hexListBoxItem60.Text = "Index07";
            hexListBoxItem60.Value = "&HABEE";
            hexListBoxItem61.Text = "Index08";
            hexListBoxItem61.Value = "&HABF5";
            hexListBoxItem62.Text = "Index09";
            hexListBoxItem62.Value = "&HABFA";
            hexListBoxItem63.Text = "Index10";
            hexListBoxItem63.Value = "&HF4D0";
            hexListBoxItem64.Text = "Index11";
            hexListBoxItem64.Value = "&HAC03";
            hexListBoxItem65.Text = "Index12";
            hexListBoxItem65.Value = "&HF4B0";
            this.HexListBox1.Items.Add(hexListBoxItem53);
            this.HexListBox1.Items.Add(hexListBoxItem54);
            this.HexListBox1.Items.Add(hexListBoxItem55);
            this.HexListBox1.Items.Add(hexListBoxItem56);
            this.HexListBox1.Items.Add(hexListBoxItem57);
            this.HexListBox1.Items.Add(hexListBoxItem58);
            this.HexListBox1.Items.Add(hexListBoxItem59);
            this.HexListBox1.Items.Add(hexListBoxItem60);
            this.HexListBox1.Items.Add(hexListBoxItem61);
            this.HexListBox1.Items.Add(hexListBoxItem62);
            this.HexListBox1.Items.Add(hexListBoxItem63);
            this.HexListBox1.Items.Add(hexListBoxItem64);
            this.HexListBox1.Items.Add(hexListBoxItem65);
            this.HexListBox1.Location = new System.Drawing.Point(16, 17);
            this.HexListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.HexListBox1.Name = "HexListBox1";
            this.HexListBox1.SelectedItem = hexListBoxItem53;
            this.HexListBox1.Size = new System.Drawing.Size(232, 550);
            this.HexListBox1.TabIndex = 18;
            // 
            // Text_Characters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BasicListBoxAssociate1);
            this.Controls.Add(this.HexListBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Text_Characters";
            this.Size = new System.Drawing.Size(787, 603);
            this.BasicListBoxAssociate1.ResumeLayout(false);
            this.HexPanel1.ResumeLayout(false);
            this.HexPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        internal BasicTools.BasicControls.BasicListBoxAssociate BasicListBoxAssociate1;
        internal HexTools.HexPanel HexPanel1;
        internal HexTools.HexTextBox _Text;
        internal HexTools.HexListBox HexListBox1;
    }
}