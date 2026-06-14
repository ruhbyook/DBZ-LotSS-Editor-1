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
            this.TabControl1 = new BasicTools.BasicControls.BasicTabControl();
            this.TabCharacters = new BasicTools.BasicControls.BasicTabPage();
            this.Text_Characters = new DBZ_LotSS_Editor.Text_Characters();
            this.TabBattlers = new BasicTools.BasicControls.BasicTabPage();
            this.Text_Battlers = new DBZ_LotSS_Editor.Text_Battlers();
            this.TabSkills = new BasicTools.BasicControls.BasicTabPage();
            this.Text_Skills = new DBZ_LotSS_Editor.Text_Skills();
            this.TabItems = new BasicTools.BasicControls.BasicTabPage();
            this.Text_Items = new DBZ_LotSS_Editor.Text_Items();
            this.TabDialogues = new BasicTools.BasicControls.BasicTabPage();
            this.Text_Dialogues = new DBZ_LotSS_Editor.Text_Dialogues();
            this.TabDescriptions = new BasicTools.BasicControls.BasicTabPage();
            this.Text_Descriptions = new DBZ_LotSS_Editor.Text_Descriptions();
            this.TabControl1.SuspendLayout();
            this.TabCharacters.SuspendLayout();
            this.TabBattlers.SuspendLayout();
            this.TabSkills.SuspendLayout();
            this.TabItems.SuspendLayout();
            this.TabDialogues.SuspendLayout();
            this.TabDescriptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // HexFontTable1
            // 
            this.HexFontTable1.FontTable = null;
            this.HexFontTable1.IsGlobal = true;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabCharacters);
            this.TabControl1.Controls.Add(this.TabBattlers);
            this.TabControl1.Controls.Add(this.TabSkills);
            this.TabControl1.Controls.Add(this.TabItems);
            this.TabControl1.Controls.Add(this.TabDescriptions);
            this.TabControl1.Controls.Add(this.TabDialogues);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Enabled = false;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1408, 1133);
            this.TabControl1.TabIndex = 0;
            // 
            // TabCharacters
            // 
            this.TabCharacters.Controls.Add(this.Text_Characters);
            this.TabCharacters.Location = new System.Drawing.Point(4, 31);
            this.TabCharacters.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabCharacters.Name = "TabCharacters";
            this.TabCharacters.Size = new System.Drawing.Size(1400, 1098);
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
            this.Text_Characters.Margin = new System.Windows.Forms.Padding(6);
            this.Text_Characters.Name = "Text_Characters";
            this.Text_Characters.Size = new System.Drawing.Size(1400, 1098);
            this.Text_Characters.TabIndex = 0;
            // 
            // TabBattlers
            // 
            this.TabBattlers.Controls.Add(this.Text_Battlers);
            this.TabBattlers.Location = new System.Drawing.Point(4, 31);
            this.TabBattlers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabBattlers.Name = "TabBattlers";
            this.TabBattlers.Size = new System.Drawing.Size(1400, 1098);
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
            this.Text_Battlers.Margin = new System.Windows.Forms.Padding(6);
            this.Text_Battlers.Name = "Text_Battlers";
            this.Text_Battlers.Size = new System.Drawing.Size(1400, 1098);
            this.Text_Battlers.TabIndex = 0;
            // 
            // TabSkills
            // 
            this.TabSkills.Controls.Add(this.Text_Skills);
            this.TabSkills.Location = new System.Drawing.Point(4, 31);
            this.TabSkills.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabSkills.Name = "TabSkills";
            this.TabSkills.Size = new System.Drawing.Size(1400, 1098);
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
            this.Text_Skills.Margin = new System.Windows.Forms.Padding(6);
            this.Text_Skills.Name = "Text_Skills";
            this.Text_Skills.Size = new System.Drawing.Size(1400, 1098);
            this.Text_Skills.TabIndex = 0;
            // 
            // TabItems
            // 
            this.TabItems.Controls.Add(this.Text_Items);
            this.TabItems.Location = new System.Drawing.Point(4, 31);
            this.TabItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabItems.Name = "TabItems";
            this.TabItems.Size = new System.Drawing.Size(1400, 1098);
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
            this.Text_Items.Margin = new System.Windows.Forms.Padding(6);
            this.Text_Items.Name = "Text_Items";
            this.Text_Items.Size = new System.Drawing.Size(1400, 1098);
            this.Text_Items.TabIndex = 0;
            // 
            // TabDialogues
            // 
            this.TabDialogues.Controls.Add(this.Text_Dialogues);
            this.TabDialogues.Location = new System.Drawing.Point(4, 31);
            this.TabDialogues.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabDialogues.Name = "TabDialogues";
            this.TabDialogues.Size = new System.Drawing.Size(1400, 1098);
            this.TabDialogues.TabIndex = 5;
            this.TabDialogues.Text = "Dialogues";
            this.TabDialogues.UseVisualStyleBackColor = true;
            // 
            // Text_Dialogues
            // 
            this.Text_Dialogues.AutoScroll = true;
            this.Text_Dialogues.BackColor = System.Drawing.SystemColors.Control;
            this.Text_Dialogues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text_Dialogues.Location = new System.Drawing.Point(0, 0);
            this.Text_Dialogues.Margin = new System.Windows.Forms.Padding(6);
            this.Text_Dialogues.Name = "Text_Dialogues";
            this.Text_Dialogues.Size = new System.Drawing.Size(1400, 1098);
            this.Text_Dialogues.TabIndex = 0;
            // 
            // TabDescriptions
            // 
            this.TabDescriptions.Controls.Add(this.Text_Descriptions);
            this.TabDescriptions.Location = new System.Drawing.Point(4, 31);
            this.TabDescriptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabDescriptions.Name = "TabDescriptions";
            this.TabDescriptions.Size = new System.Drawing.Size(1400, 1098);
            this.TabDescriptions.TabIndex = 6;
            this.TabDescriptions.Text = "Descriptions";
            this.TabDescriptions.UseVisualStyleBackColor = true;
            // 
            // Text_Descriptions
            // 
            this.Text_Descriptions.AutoScroll = true;
            this.Text_Descriptions.BackColor = System.Drawing.SystemColors.Control;
            this.Text_Descriptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text_Descriptions.Location = new System.Drawing.Point(0, 0);
            this.Text_Descriptions.Margin = new System.Windows.Forms.Padding(6);
            this.Text_Descriptions.Name = "Text_Descriptions";
            this.Text_Descriptions.Size = new System.Drawing.Size(1400, 1098);
            this.Text_Descriptions.TabIndex = 0;
            // 
            // Form_EditorText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 1133);
            this.Controls.Add(this.TabControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form_EditorText";
            this.Normal = new System.Drawing.Rectangle(30, 30, 1434, 1204);
            this.Text = "Text Editor";
            this.TabControl1.ResumeLayout(false);
            this.TabCharacters.ResumeLayout(false);
            this.TabBattlers.ResumeLayout(false);
            this.TabSkills.ResumeLayout(false);
            this.TabItems.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal HexTools.HexFontTable HexFontTable1;
        internal BasicTabControl TabControl1;
        internal BasicTabPage TabDialogues;
        internal Text_Dialogues Text_Dialogues;
        internal BasicTabPage TabBattlers;
        internal Text_Battlers Text_Battlers;
        internal BasicTabPage TabCharacters;
        internal Text_Characters Text_Characters;
        internal BasicTabPage TabItems;
        internal Text_Items Text_Items;
        internal BasicTabPage TabSkills;
        internal Text_Skills Text_Skills;
        internal BasicTabPage TabDescriptions;
        internal Text_Descriptions Text_Descriptions;
    }
}