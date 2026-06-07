using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using BasicTools.BasicControls;

namespace DBZ_LotSS_Editor
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form_EditorText : HexTools.HexForm
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
            this.HexFontTable1 = new HexTools.HexFontTable(this.components);
            this.TabGame = new BasicTools.BasicControls.BasicTabPage();
            this.Text_Game = new DBZ_LotSS_Editor.Text_Game();
            this.TabControl1 = new BasicTools.BasicControls.BasicTabControl();
            this.TabCharacters = new BasicTools.BasicControls.BasicTabPage();
            this.Text_Characters = new DBZ_LotSS_Editor.Text_Characters();
            this.TabBattlers = new BasicTools.BasicControls.BasicTabPage();
            this.Text_Battlers = new DBZ_LotSS_Editor.Text_Battlers();
            this.TabSkills = new BasicTools.BasicControls.BasicTabPage();
            this.Text_Skills = new DBZ_LotSS_Editor.Text_Skills();
            this.TabItems = new BasicTools.BasicControls.BasicTabPage();
            this.Text_Items = new DBZ_LotSS_Editor.Text_Items();
            this.TabGame.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabCharacters.SuspendLayout();
            this.TabBattlers.SuspendLayout();
            this.TabSkills.SuspendLayout();
            this.TabItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // HexFontTable1
            // 
            this.HexFontTable1.FontTable = null;
            this.HexFontTable1.IsGlobal = true;
            // 
            // TabGame
            // 
            this.TabGame.Controls.Add(this.Text_Game);
            this.TabGame.Location = new System.Drawing.Point(4, 30);
            this.TabGame.Name = "TabGame";
            this.TabGame.Size = new System.Drawing.Size(931, 691);
            this.TabGame.TabIndex = 5;
            this.TabGame.Text = "Game";
            this.TabGame.UseVisualStyleBackColor = true;
            // 
            // Text_Game
            // 
            this.Text_Game.AutoScroll = true;
            this.Text_Game.BackColor = System.Drawing.SystemColors.Control;
            this.Text_Game.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text_Game.Location = new System.Drawing.Point(0, 0);
            this.Text_Game.Margin = new System.Windows.Forms.Padding(4);
            this.Text_Game.Name = "Text_Game";
            this.Text_Game.Size = new System.Drawing.Size(931, 691);
            this.Text_Game.TabIndex = 0;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabCharacters);
            this.TabControl1.Controls.Add(this.TabBattlers);
            this.TabControl1.Controls.Add(this.TabSkills);
            this.TabControl1.Controls.Add(this.TabItems);
            this.TabControl1.Controls.Add(this.TabGame);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Enabled = false;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(939, 725);
            this.TabControl1.TabIndex = 0;
            // 
            // TabCharacters
            // 
            this.TabCharacters.Controls.Add(this.Text_Characters);
            this.TabCharacters.Location = new System.Drawing.Point(4, 30);
            this.TabCharacters.Name = "TabCharacters";
            this.TabCharacters.Size = new System.Drawing.Size(931, 691);
            this.TabCharacters.TabIndex = 1;
            this.TabCharacters.Text = "Characters";
            this.TabCharacters.UseVisualStyleBackColor = true;
            // 
            // Text_Characters
            // 
            this.Text_Characters.AutoScroll = true;
            this.Text_Characters.BackColor = System.Drawing.SystemColors.Control;
            this.Text_Characters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text_Characters.Location = new System.Drawing.Point(0, 0);
            this.Text_Characters.Margin = new System.Windows.Forms.Padding(4);
            this.Text_Characters.Name = "Text_Characters";
            this.Text_Characters.Size = new System.Drawing.Size(931, 691);
            this.Text_Characters.TabIndex = 0;
            // 
            // TabBattlers
            // 
            this.TabBattlers.Controls.Add(this.Text_Battlers);
            this.TabBattlers.Location = new System.Drawing.Point(4, 30);
            this.TabBattlers.Name = "TabBattlers";
            this.TabBattlers.Size = new System.Drawing.Size(931, 691);
            this.TabBattlers.TabIndex = 2;
            this.TabBattlers.Text = "Battlers";
            this.TabBattlers.UseVisualStyleBackColor = true;
            // 
            // Text_Battlers
            // 
            this.Text_Battlers.AutoScroll = true;
            this.Text_Battlers.BackColor = System.Drawing.SystemColors.Control;
            this.Text_Battlers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text_Battlers.Location = new System.Drawing.Point(0, 0);
            this.Text_Battlers.Margin = new System.Windows.Forms.Padding(4);
            this.Text_Battlers.Name = "Text_Battlers";
            this.Text_Battlers.Size = new System.Drawing.Size(931, 691);
            this.Text_Battlers.TabIndex = 0;
            // 
            // TabSkills
            // 
            this.TabSkills.Controls.Add(this.Text_Skills);
            this.TabSkills.Location = new System.Drawing.Point(4, 30);
            this.TabSkills.Name = "TabSkills";
            this.TabSkills.Size = new System.Drawing.Size(931, 691);
            this.TabSkills.TabIndex = 3;
            this.TabSkills.Text = "Skills";
            this.TabSkills.UseVisualStyleBackColor = true;
            // 
            // Text_Skills
            // 
            this.Text_Skills.AutoScroll = true;
            this.Text_Skills.BackColor = System.Drawing.SystemColors.Control;
            this.Text_Skills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text_Skills.Location = new System.Drawing.Point(0, 0);
            this.Text_Skills.Margin = new System.Windows.Forms.Padding(4);
            this.Text_Skills.Name = "Text_Skills";
            this.Text_Skills.Size = new System.Drawing.Size(931, 691);
            this.Text_Skills.TabIndex = 0;
            // 
            // TabItems
            // 
            this.TabItems.Controls.Add(this.Text_Items);
            this.TabItems.Location = new System.Drawing.Point(4, 30);
            this.TabItems.Name = "TabItems";
            this.TabItems.Size = new System.Drawing.Size(931, 691);
            this.TabItems.TabIndex = 4;
            this.TabItems.Text = "Items";
            this.TabItems.UseVisualStyleBackColor = true;
            // 
            // Text_Items
            // 
            this.Text_Items.AutoScroll = true;
            this.Text_Items.BackColor = System.Drawing.SystemColors.Control;
            this.Text_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text_Items.Location = new System.Drawing.Point(0, 0);
            this.Text_Items.Margin = new System.Windows.Forms.Padding(4);
            this.Text_Items.Name = "Text_Items";
            this.Text_Items.Size = new System.Drawing.Size(931, 691);
            this.Text_Items.TabIndex = 0;
            // 
            // Form_EditorText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 725);
            this.Controls.Add(this.TabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_EditorText";
            this.Normal = new System.Drawing.Rectangle(19, 19, 957, 772);
            this.Text = "Text Editor";
            this.TabGame.ResumeLayout(false);
            this.TabControl1.ResumeLayout(false);
            this.TabCharacters.ResumeLayout(false);
            this.TabBattlers.ResumeLayout(false);
            this.TabSkills.ResumeLayout(false);
            this.TabItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal HexTools.HexFontTable HexFontTable1;
        internal BasicTabPage TabGame;
        internal Text_Game Text_Game;
        internal BasicTabControl TabControl1;
        internal BasicTabPage TabBattlers;
        internal Text_Battlers Text_Battlers;
        internal BasicTabPage TabCharacters;
        internal Text_Characters Text_Characters;
        internal BasicTabPage TabItems;
        internal Text_Items Text_Items;
        internal BasicTabPage TabSkills;
        internal Text_Skills Text_Skills;
    }
}