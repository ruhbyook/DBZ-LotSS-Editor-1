using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using BasicTools.BasicControls;

namespace DBZ_LotSS_Editor
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form_EditorSprite : HexTools.HexForm
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
            this.TabSystem = new BasicTools.BasicControls.BasicTabPage();
            this.Sprite_System = new DBZ_LotSS_Editor.Sprite_System();
            this.TabCharacters = new BasicTools.BasicControls.BasicTabPage();
            this.Sprite_Characters = new DBZ_LotSS_Editor.Sprite_Characters();
            this.TabPortraits = new BasicTools.BasicControls.BasicTabPage();
            this.Sprite_Portraits = new DBZ_LotSS_Editor.Sprite_Portrait();
            this.TabBattlers = new BasicTools.BasicControls.BasicTabPage();
            this.Sprite_Battlers = new DBZ_LotSS_Editor.Sprite_Battlers();
            this.TabControl1.SuspendLayout();
            this.TabSystem.SuspendLayout();
            this.TabCharacters.SuspendLayout();
            this.TabPortraits.SuspendLayout();
            this.TabBattlers.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabSystem);
            this.TabControl1.Controls.Add(this.TabCharacters);
            this.TabControl1.Controls.Add(this.TabPortraits);
            this.TabControl1.Controls.Add(this.TabBattlers);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Enabled = false;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl1.Multiline = true;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(939, 741);
            this.TabControl1.TabIndex = 4;
            // 
            // TabSystem
            // 
            this.TabSystem.Controls.Add(this.Sprite_System);
            this.TabSystem.Location = new System.Drawing.Point(4, 30);
            this.TabSystem.Name = "TabSystem";
            this.TabSystem.Size = new System.Drawing.Size(931, 707);
            this.TabSystem.TabIndex = 3;
            this.TabSystem.Text = "System";
            // 
            // Sprite_System
            // 
            this.Sprite_System.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sprite_System.Location = new System.Drawing.Point(0, 0);
            this.Sprite_System.Margin = new System.Windows.Forms.Padding(4);
            this.Sprite_System.Name = "Sprite_System";
            this.Sprite_System.Size = new System.Drawing.Size(931, 707);
            this.Sprite_System.TabIndex = 0;
            // 
            // TabCharacters
            // 
            this.TabCharacters.Controls.Add(this.Sprite_Characters);
            this.TabCharacters.Location = new System.Drawing.Point(4, 30);
            this.TabCharacters.Name = "TabCharacters";
            this.TabCharacters.Size = new System.Drawing.Size(931, 707);
            this.TabCharacters.TabIndex = 2;
            this.TabCharacters.Text = "Characters";
            this.TabCharacters.UseVisualStyleBackColor = true;
            // 
            // Sprite_Characters
            // 
            this.Sprite_Characters.BackColor = System.Drawing.SystemColors.Control;
            this.Sprite_Characters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sprite_Characters.Location = new System.Drawing.Point(0, 0);
            this.Sprite_Characters.Margin = new System.Windows.Forms.Padding(4);
            this.Sprite_Characters.Name = "Sprite_Characters";
            this.Sprite_Characters.Size = new System.Drawing.Size(931, 707);
            this.Sprite_Characters.TabIndex = 0;
            // 
            // TabPortraits
            // 
            this.TabPortraits.Controls.Add(this.Sprite_Portraits);
            this.TabPortraits.Location = new System.Drawing.Point(4, 30);
            this.TabPortraits.Name = "TabPortraits";
            this.TabPortraits.Size = new System.Drawing.Size(931, 707);
            this.TabPortraits.TabIndex = 0;
            this.TabPortraits.Text = "Portraits";
            this.TabPortraits.UseVisualStyleBackColor = true;
            // 
            // Sprite_Portraits
            // 
            this.Sprite_Portraits.BackColor = System.Drawing.SystemColors.Control;
            this.Sprite_Portraits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sprite_Portraits.Location = new System.Drawing.Point(0, 0);
            this.Sprite_Portraits.Margin = new System.Windows.Forms.Padding(4);
            this.Sprite_Portraits.Name = "Sprite_Portraits";
            this.Sprite_Portraits.Size = new System.Drawing.Size(931, 707);
            this.Sprite_Portraits.TabIndex = 0;
            // 
            // TabBattlers
            // 
            this.TabBattlers.Controls.Add(this.Sprite_Battlers);
            this.TabBattlers.Location = new System.Drawing.Point(4, 30);
            this.TabBattlers.Name = "TabBattlers";
            this.TabBattlers.Size = new System.Drawing.Size(931, 707);
            this.TabBattlers.TabIndex = 1;
            this.TabBattlers.Text = "Battlers";
            // 
            // Sprite_Battlers
            // 
            this.Sprite_Battlers.BackColor = System.Drawing.SystemColors.Control;
            this.Sprite_Battlers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sprite_Battlers.Location = new System.Drawing.Point(0, 0);
            this.Sprite_Battlers.Margin = new System.Windows.Forms.Padding(5);
            this.Sprite_Battlers.Name = "Sprite_Battlers";
            this.Sprite_Battlers.Size = new System.Drawing.Size(931, 707);
            this.Sprite_Battlers.TabIndex = 0;
            // 
            // Form_EditorSprite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 741);
            this.Controls.Add(this.TabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_EditorSprite";
            this.Normal = new System.Drawing.Rectangle(19, 19, 957, 788);
            this.Text = "Sprite Editor";
            this.TabControl1.ResumeLayout(false);
            this.TabSystem.ResumeLayout(false);
            this.TabCharacters.ResumeLayout(false);
            this.TabPortraits.ResumeLayout(false);
            this.TabBattlers.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal BasicTabControl TabControl1;
        internal BasicTabPage TabBattlers;
        internal Sprite_Battlers Sprite_Battlers;
        private BasicTabPage TabPortraits;
        private Sprite_Portrait Sprite_Portraits;
        private BasicTabPage TabCharacters;
        internal Sprite_Characters Sprite_Characters;
        private BasicTabPage TabSystem;
        private Sprite_System Sprite_System;
    }
}