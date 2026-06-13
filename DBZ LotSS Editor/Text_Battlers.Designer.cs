using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DBZ_LotSS_Editor
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Text_Battlers : HexTools.HexUserControl
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
            this.BasicListBoxAssociate1.Location = new System.Drawing.Point(382, 27);
            this.BasicListBoxAssociate1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BasicListBoxAssociate1.Name = "BasicListBoxAssociate1";
            this.BasicListBoxAssociate1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BasicListBoxAssociate1.Size = new System.Drawing.Size(777, 859);
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
            this.HexPanel1.Definition = "TextEditor.Battlers";
            this.HexPanel1.Location = new System.Drawing.Point(12, 56);
            this.HexPanel1.Margin = new System.Windows.Forms.Padding(8);
            this.HexPanel1.Name = "HexPanel1";
            this.HexPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.HexPanel1.Size = new System.Drawing.Size(360, 64);
            this.HexPanel1.TabIndex = 37;
            // 
            // _Text
            // 
            this._Text.Dock = System.Windows.Forms.DockStyle.Fill;
            this._Text.DynamicLength = 1;
            this._Text.Font = new System.Drawing.Font("Consolas", 12F);
            this._Text.FontTableUsesGlobal = true;
            this._Text.Location = new System.Drawing.Point(8, 8);
            this._Text.Margin = new System.Windows.Forms.Padding(8);
            this._Text.MaxLengthLabel = true;
            this._Text.Name = "_Text";
            this._Text.Size = new System.Drawing.Size(344, 45);
            this._Text.TabIndex = 18;
            // 
            // HexListBox1
            // 
            this.HexListBox1.Definition = "TextEditor.Battlers.List";
            this.HexListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.HexListBox1.FormatString = "X2";
            this.HexListBox1.FormattingEnabled = true;
            this.HexListBox1.IndexDisplay = true;
            this.HexListBox1.Location = new System.Drawing.Point(24, 27);
            this.HexListBox1.Margin = new System.Windows.Forms.Padding(6);
            this.HexListBox1.Name = "HexListBox1";
            this.HexListBox1.SelectedItem = null;
            this.HexListBox1.Size = new System.Drawing.Size(346, 849);
            this.HexListBox1.TabIndex = 18;
            // 
            // Text_Battlers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BasicListBoxAssociate1);
            this.Controls.Add(this.HexListBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Text_Battlers";
            this.Size = new System.Drawing.Size(1180, 942);
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