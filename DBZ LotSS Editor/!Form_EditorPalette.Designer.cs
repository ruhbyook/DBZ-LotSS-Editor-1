using System.Diagnostics;
using BasicTools.BasicControls;

namespace DBZ_LotSS_Editor
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form_EditorPalette : HexTools.HexForm
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
            this.TabControl1 = new BasicTools.BasicControls.BasicTabControl();
            this.TabCharacter = new BasicTools.BasicControls.BasicTabPage();
            this.TabPortrait = new BasicTools.BasicControls.BasicTabPage();
            this.HexPanel1 = new HexTools.HexPanel();
            this.TabBattler = new BasicTools.BasicControls.BasicTabPage();
            this.HexPanel2 = new HexTools.HexPanel();
            this.TabFlyers = new BasicTools.BasicControls.BasicTabPage();
            this.TabSystem = new BasicTools.BasicControls.BasicTabPage();
            this.Palette_Characters = new DBZ_LotSS_Editor.Palette_Characters();
            this.Palette_Portrait = new DBZ_LotSS_Editor.Palette_Portrait();
            this.Palette_Battlers = new DBZ_LotSS_Editor.Palette_Battlers();
            this.Palette_Flyers = new DBZ_LotSS_Editor.Palette_Flyers();
            this.Palette_System = new DBZ_LotSS_Editor.Palette_System();
            this.TabControl1.SuspendLayout();
            this.TabCharacter.SuspendLayout();
            this.TabPortrait.SuspendLayout();
            this.HexPanel1.SuspendLayout();
            this.TabBattler.SuspendLayout();
            this.HexPanel2.SuspendLayout();
            this.TabFlyers.SuspendLayout();
            this.TabSystem.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabSystem);
            this.TabControl1.Controls.Add(this.TabCharacter);
            this.TabControl1.Controls.Add(this.TabPortrait);
            this.TabControl1.Controls.Add(this.TabBattler);
            this.TabControl1.Controls.Add(this.TabFlyers);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Enabled = false;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(939, 725);
            this.TabControl1.TabIndex = 3;
            // 
            // TabCharacter
            // 
            this.TabCharacter.BackColor = System.Drawing.SystemColors.Control;
            this.TabCharacter.Controls.Add(this.Palette_Characters);
            this.TabCharacter.Location = new System.Drawing.Point(4, 30);
            this.TabCharacter.Name = "TabCharacter";
            this.TabCharacter.Size = new System.Drawing.Size(931, 691);
            this.TabCharacter.TabIndex = 3;
            this.TabCharacter.Text = "Characters";
            // 
            // TabPortrait
            // 
            this.TabPortrait.BackColor = System.Drawing.SystemColors.Control;
            this.TabPortrait.Controls.Add(this.HexPanel1);
            this.TabPortrait.Location = new System.Drawing.Point(4, 30);
            this.TabPortrait.Name = "TabPortrait";
            this.TabPortrait.Size = new System.Drawing.Size(931, 691);
            this.TabPortrait.TabIndex = 1;
            this.TabPortrait.Text = "Portraits";
            // 
            // HexPanel1
            // 
            this.HexPanel1.Controls.Add(this.Palette_Portrait);
            this.HexPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HexPanel1.HexOffset = "&H040000";
            this.HexPanel1.Location = new System.Drawing.Point(0, 0);
            this.HexPanel1.Name = "HexPanel1";
            this.HexPanel1.Size = new System.Drawing.Size(931, 691);
            this.HexPanel1.TabIndex = 0;
            // 
            // TabBattler
            // 
            this.TabBattler.BackColor = System.Drawing.SystemColors.Control;
            this.TabBattler.Controls.Add(this.HexPanel2);
            this.TabBattler.Location = new System.Drawing.Point(4, 30);
            this.TabBattler.Name = "TabBattler";
            this.TabBattler.Size = new System.Drawing.Size(931, 691);
            this.TabBattler.TabIndex = 0;
            this.TabBattler.Text = "Battlers";
            // 
            // HexPanel2
            // 
            this.HexPanel2.Controls.Add(this.Palette_Battlers);
            this.HexPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HexPanel2.Location = new System.Drawing.Point(0, 0);
            this.HexPanel2.Name = "HexPanel2";
            this.HexPanel2.Size = new System.Drawing.Size(931, 691);
            this.HexPanel2.TabIndex = 0;
            // 
            // TabFlyers
            // 
            this.TabFlyers.BackColor = System.Drawing.SystemColors.Control;
            this.TabFlyers.Controls.Add(this.Palette_Flyers);
            this.TabFlyers.Location = new System.Drawing.Point(4, 30);
            this.TabFlyers.Name = "TabFlyers";
            this.TabFlyers.Size = new System.Drawing.Size(931, 691);
            this.TabFlyers.TabIndex = 2;
            this.TabFlyers.Text = "Flyers";
            // 
            // TabSystem
            // 
            this.TabSystem.Controls.Add(this.Palette_System);
            this.TabSystem.Location = new System.Drawing.Point(4, 30);
            this.TabSystem.Name = "TabSystem";
            this.TabSystem.Size = new System.Drawing.Size(931, 691);
            this.TabSystem.TabIndex = 4;
            this.TabSystem.Text = "System";
            // 
            // Palette_Characters
            // 
            this.Palette_Characters.AutoScroll = true;
            this.Palette_Characters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Palette_Characters.Location = new System.Drawing.Point(0, 0);
            this.Palette_Characters.Margin = new System.Windows.Forms.Padding(4);
            this.Palette_Characters.Name = "Palette_Characters";
            this.Palette_Characters.Size = new System.Drawing.Size(931, 691);
            this.Palette_Characters.TabIndex = 0;
            // 
            // Palette_Portrait
            // 
            this.Palette_Portrait.AutoScroll = true;
            this.Palette_Portrait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Palette_Portrait.Location = new System.Drawing.Point(0, 0);
            this.Palette_Portrait.Margin = new System.Windows.Forms.Padding(4);
            this.Palette_Portrait.Name = "Palette_Portrait";
            this.Palette_Portrait.Size = new System.Drawing.Size(931, 691);
            this.Palette_Portrait.TabIndex = 0;
            // 
            // Palette_Battlers
            // 
            this.Palette_Battlers.AutoScroll = true;
            this.Palette_Battlers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Palette_Battlers.Location = new System.Drawing.Point(0, 0);
            this.Palette_Battlers.Margin = new System.Windows.Forms.Padding(4);
            this.Palette_Battlers.Name = "Palette_Battlers";
            this.Palette_Battlers.Size = new System.Drawing.Size(931, 691);
            this.Palette_Battlers.TabIndex = 0;
            // 
            // Palette_Flyers
            // 
            this.Palette_Flyers.AutoScroll = true;
            this.Palette_Flyers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Palette_Flyers.Location = new System.Drawing.Point(0, 0);
            this.Palette_Flyers.Margin = new System.Windows.Forms.Padding(4);
            this.Palette_Flyers.Name = "Palette_Flyers";
            this.Palette_Flyers.Size = new System.Drawing.Size(931, 691);
            this.Palette_Flyers.TabIndex = 0;
            // 
            // palette_System1
            // 
            this.Palette_System.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Palette_System.Location = new System.Drawing.Point(0, 0);
            this.Palette_System.Margin = new System.Windows.Forms.Padding(4);
            this.Palette_System.Name = "Palette_System";
            this.Palette_System.Size = new System.Drawing.Size(931, 691);
            this.Palette_System.TabIndex = 0;
            // 
            // Form_EditorPalette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 725);
            this.Controls.Add(this.TabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_EditorPalette";
            this.Normal = new System.Drawing.Rectangle(19, -18, 957, 772);
            this.Text = "Palette Editor";
            this.TabControl1.ResumeLayout(false);
            this.TabCharacter.ResumeLayout(false);
            this.TabPortrait.ResumeLayout(false);
            this.HexPanel1.ResumeLayout(false);
            this.TabBattler.ResumeLayout(false);
            this.HexPanel2.ResumeLayout(false);
            this.TabFlyers.ResumeLayout(false);
            this.TabSystem.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal BasicTabControl TabControl1;
        internal BasicTabPage TabBattler;
        internal HexTools.HexPanel HexPanel1;
        internal Palette_Battlers Palette_Battlers;
        internal BasicTabPage TabPortrait;
        internal HexTools.HexPanel HexPanel2;
        internal Palette_Portrait Palette_Portrait;
        internal BasicTabPage TabFlyers;
        internal Palette_Flyers Palette_Flyers;
        internal BasicTabPage TabCharacter;
        internal Palette_Characters Palette_Characters;
        internal BasicTabPage TabSystem;
        internal Palette_System Palette_System;
    }
}