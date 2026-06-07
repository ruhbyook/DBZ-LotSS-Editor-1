using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using BasicTools.BasicControls;

namespace DBZ_LotSS_Editor
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form_EditorDatabase : HexTools.HexForm
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
            this.TabCharacters = new BasicTools.BasicControls.BasicTabPage();
            this.PanelCharacters = new HexTools.HexPanel();
            this.Database_Characters = new DBZ_LotSS_Editor.Data_Characters();
            this.TabBattlers = new BasicTools.BasicControls.BasicTabPage();
            this.PanelBattlers = new HexTools.HexPanel();
            this.Database_Battlers = new DBZ_LotSS_Editor.Data_Battlers();
            this.TabSkills = new BasicTools.BasicControls.BasicTabPage();
            this.PanelSkills = new HexTools.HexPanel();
            this.Database_Skills = new DBZ_LotSS_Editor.Data_Skills();
            this.TabItems = new BasicTools.BasicControls.BasicTabPage();
            this.PanelItems = new HexTools.HexPanel();
            this.Database_Items = new DBZ_LotSS_Editor.Data_Items();
            this.TabGroups = new BasicTools.BasicControls.BasicTabPage();
            this.PanelGroups = new HexTools.HexPanel();
            this.Database_Groups = new DBZ_LotSS_Editor.Data_Groups();
            this.TabMaps = new BasicTools.BasicControls.BasicTabPage();
            this.PanelMaps = new HexTools.HexPanel();
            this.Database_Maps = new DBZ_LotSS_Editor.Data_Maps();
            this.TabGlobal = new BasicTools.BasicControls.BasicTabPage();
            this.Database_Global = new DBZ_LotSS_Editor.Data_Global();
            this.TabControl1.SuspendLayout();
            this.TabCharacters.SuspendLayout();
            this.PanelCharacters.SuspendLayout();
            this.TabBattlers.SuspendLayout();
            this.PanelBattlers.SuspendLayout();
            this.TabSkills.SuspendLayout();
            this.PanelSkills.SuspendLayout();
            this.TabItems.SuspendLayout();
            this.PanelItems.SuspendLayout();
            this.TabGroups.SuspendLayout();
            this.PanelGroups.SuspendLayout();
            this.TabMaps.SuspendLayout();
            this.PanelMaps.SuspendLayout();
            this.TabGlobal.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabCharacters);
            this.TabControl1.Controls.Add(this.TabBattlers);
            this.TabControl1.Controls.Add(this.TabSkills);
            this.TabControl1.Controls.Add(this.TabItems);
            this.TabControl1.Controls.Add(this.TabGroups);
            this.TabControl1.Controls.Add(this.TabMaps);
            this.TabControl1.Controls.Add(this.TabGlobal);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Enabled = false;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(939, 725);
            this.TabControl1.TabIndex = 2;
            // 
            // TabCharacters
            // 
            this.TabCharacters.BackColor = System.Drawing.SystemColors.Control;
            this.TabCharacters.Controls.Add(this.PanelCharacters);
            this.TabCharacters.Location = new System.Drawing.Point(4, 30);
            this.TabCharacters.Margin = new System.Windows.Forms.Padding(4);
            this.TabCharacters.Name = "TabCharacters";
            this.TabCharacters.Padding = new System.Windows.Forms.Padding(4);
            this.TabCharacters.Size = new System.Drawing.Size(931, 691);
            this.TabCharacters.TabIndex = 0;
            this.TabCharacters.Text = "Characters";
            // 
            // PanelCharacters
            // 
            this.PanelCharacters.Controls.Add(this.Database_Characters);
            this.PanelCharacters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCharacters.HexOffset = "0";
            this.PanelCharacters.Location = new System.Drawing.Point(4, 4);
            this.PanelCharacters.Margin = new System.Windows.Forms.Padding(4);
            this.PanelCharacters.Name = "PanelCharacters";
            this.PanelCharacters.Size = new System.Drawing.Size(923, 683);
            this.PanelCharacters.TabIndex = 0;
            // 
            // Database_Characters
            // 
            this.Database_Characters.AutoScroll = true;
            this.Database_Characters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Database_Characters.Location = new System.Drawing.Point(0, 0);
            this.Database_Characters.Margin = new System.Windows.Forms.Padding(5);
            this.Database_Characters.Name = "Database_Characters";
            this.Database_Characters.Size = new System.Drawing.Size(923, 683);
            this.Database_Characters.TabIndex = 0;
            // 
            // TabBattlers
            // 
            this.TabBattlers.BackColor = System.Drawing.SystemColors.Control;
            this.TabBattlers.Controls.Add(this.PanelBattlers);
            this.TabBattlers.Location = new System.Drawing.Point(4, 30);
            this.TabBattlers.Margin = new System.Windows.Forms.Padding(4);
            this.TabBattlers.Name = "TabBattlers";
            this.TabBattlers.Padding = new System.Windows.Forms.Padding(4);
            this.TabBattlers.Size = new System.Drawing.Size(931, 691);
            this.TabBattlers.TabIndex = 1;
            this.TabBattlers.Text = "Battlers";
            // 
            // PanelBattlers
            // 
            this.PanelBattlers.Controls.Add(this.Database_Battlers);
            this.PanelBattlers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBattlers.HexOffset = "0";
            this.PanelBattlers.Location = new System.Drawing.Point(4, 4);
            this.PanelBattlers.Margin = new System.Windows.Forms.Padding(4);
            this.PanelBattlers.Name = "PanelBattlers";
            this.PanelBattlers.Size = new System.Drawing.Size(923, 683);
            this.PanelBattlers.TabIndex = 1;
            // 
            // Database_Battlers
            // 
            this.Database_Battlers.AutoScroll = true;
            this.Database_Battlers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Database_Battlers.Location = new System.Drawing.Point(0, 0);
            this.Database_Battlers.Margin = new System.Windows.Forms.Padding(5);
            this.Database_Battlers.Name = "Database_Battlers";
            this.Database_Battlers.Size = new System.Drawing.Size(923, 683);
            this.Database_Battlers.TabIndex = 0;
            // 
            // TabSkills
            // 
            this.TabSkills.BackColor = System.Drawing.SystemColors.Control;
            this.TabSkills.Controls.Add(this.PanelSkills);
            this.TabSkills.Location = new System.Drawing.Point(4, 30);
            this.TabSkills.Margin = new System.Windows.Forms.Padding(4);
            this.TabSkills.Name = "TabSkills";
            this.TabSkills.Padding = new System.Windows.Forms.Padding(4);
            this.TabSkills.Size = new System.Drawing.Size(931, 691);
            this.TabSkills.TabIndex = 2;
            this.TabSkills.Text = "Skills";
            // 
            // PanelSkills
            // 
            this.PanelSkills.Controls.Add(this.Database_Skills);
            this.PanelSkills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelSkills.HexOffset = "0";
            this.PanelSkills.Location = new System.Drawing.Point(4, 4);
            this.PanelSkills.Margin = new System.Windows.Forms.Padding(4);
            this.PanelSkills.Name = "PanelSkills";
            this.PanelSkills.Size = new System.Drawing.Size(923, 683);
            this.PanelSkills.TabIndex = 2;
            // 
            // Database_Skills
            // 
            this.Database_Skills.AutoScroll = true;
            this.Database_Skills.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Database_Skills.Location = new System.Drawing.Point(0, 0);
            this.Database_Skills.Margin = new System.Windows.Forms.Padding(5);
            this.Database_Skills.Name = "Database_Skills";
            this.Database_Skills.Size = new System.Drawing.Size(923, 683);
            this.Database_Skills.TabIndex = 0;
            // 
            // TabItems
            // 
            this.TabItems.BackColor = System.Drawing.SystemColors.Control;
            this.TabItems.Controls.Add(this.PanelItems);
            this.TabItems.Location = new System.Drawing.Point(4, 30);
            this.TabItems.Margin = new System.Windows.Forms.Padding(4);
            this.TabItems.Name = "TabItems";
            this.TabItems.Padding = new System.Windows.Forms.Padding(4);
            this.TabItems.Size = new System.Drawing.Size(931, 691);
            this.TabItems.TabIndex = 4;
            this.TabItems.Text = "Items";
            // 
            // PanelItems
            // 
            this.PanelItems.Controls.Add(this.Database_Items);
            this.PanelItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelItems.HexOffset = "0";
            this.PanelItems.Location = new System.Drawing.Point(4, 4);
            this.PanelItems.Margin = new System.Windows.Forms.Padding(4);
            this.PanelItems.Name = "PanelItems";
            this.PanelItems.Size = new System.Drawing.Size(923, 683);
            this.PanelItems.TabIndex = 4;
            // 
            // Database_Items
            // 
            this.Database_Items.AutoScroll = true;
            this.Database_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Database_Items.Location = new System.Drawing.Point(0, 0);
            this.Database_Items.Margin = new System.Windows.Forms.Padding(5);
            this.Database_Items.Name = "Database_Items";
            this.Database_Items.Size = new System.Drawing.Size(923, 683);
            this.Database_Items.TabIndex = 0;
            // 
            // TabGroups
            // 
            this.TabGroups.BackColor = System.Drawing.SystemColors.Control;
            this.TabGroups.Controls.Add(this.PanelGroups);
            this.TabGroups.Location = new System.Drawing.Point(4, 30);
            this.TabGroups.Margin = new System.Windows.Forms.Padding(4);
            this.TabGroups.Name = "TabGroups";
            this.TabGroups.Padding = new System.Windows.Forms.Padding(4);
            this.TabGroups.Size = new System.Drawing.Size(931, 691);
            this.TabGroups.TabIndex = 3;
            this.TabGroups.Text = "Groups";
            // 
            // PanelGroups
            // 
            this.PanelGroups.Controls.Add(this.Database_Groups);
            this.PanelGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelGroups.HexOffset = "0";
            this.PanelGroups.Location = new System.Drawing.Point(4, 4);
            this.PanelGroups.Margin = new System.Windows.Forms.Padding(4);
            this.PanelGroups.Name = "PanelGroups";
            this.PanelGroups.Size = new System.Drawing.Size(923, 683);
            this.PanelGroups.TabIndex = 3;
            // 
            // Database_Groups
            // 
            this.Database_Groups.AutoScroll = true;
            this.Database_Groups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Database_Groups.Location = new System.Drawing.Point(0, 0);
            this.Database_Groups.Margin = new System.Windows.Forms.Padding(5);
            this.Database_Groups.Name = "Database_Groups";
            this.Database_Groups.Size = new System.Drawing.Size(923, 683);
            this.Database_Groups.TabIndex = 0;
            // 
            // TabMaps
            // 
            this.TabMaps.BackColor = System.Drawing.SystemColors.Control;
            this.TabMaps.Controls.Add(this.PanelMaps);
            this.TabMaps.Location = new System.Drawing.Point(4, 30);
            this.TabMaps.Margin = new System.Windows.Forms.Padding(4);
            this.TabMaps.Name = "TabMaps";
            this.TabMaps.Padding = new System.Windows.Forms.Padding(4);
            this.TabMaps.Size = new System.Drawing.Size(931, 691);
            this.TabMaps.TabIndex = 5;
            this.TabMaps.Text = "Maps";
            // 
            // PanelMaps
            // 
            this.PanelMaps.Controls.Add(this.Database_Maps);
            this.PanelMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMaps.HexOffset = "0";
            this.PanelMaps.Location = new System.Drawing.Point(4, 4);
            this.PanelMaps.Margin = new System.Windows.Forms.Padding(4);
            this.PanelMaps.Name = "PanelMaps";
            this.PanelMaps.Size = new System.Drawing.Size(923, 683);
            this.PanelMaps.TabIndex = 5;
            // 
            // Database_Maps
            // 
            this.Database_Maps.AutoScroll = true;
            this.Database_Maps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Database_Maps.Location = new System.Drawing.Point(0, 0);
            this.Database_Maps.Margin = new System.Windows.Forms.Padding(5);
            this.Database_Maps.Name = "Database_Maps";
            this.Database_Maps.Size = new System.Drawing.Size(923, 683);
            this.Database_Maps.TabIndex = 0;
            // 
            // TabGlobal
            // 
            this.TabGlobal.BackColor = System.Drawing.SystemColors.Control;
            this.TabGlobal.Controls.Add(this.Database_Global);
            this.TabGlobal.Location = new System.Drawing.Point(4, 30);
            this.TabGlobal.Name = "TabGlobal";
            this.TabGlobal.Size = new System.Drawing.Size(931, 691);
            this.TabGlobal.TabIndex = 6;
            this.TabGlobal.Text = "Global";
            // 
            // Database_Global
            // 
            this.Database_Global.AutoScroll = true;
            this.Database_Global.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Database_Global.Location = new System.Drawing.Point(0, 0);
            this.Database_Global.Margin = new System.Windows.Forms.Padding(4);
            this.Database_Global.Name = "Database_Global";
            this.Database_Global.Size = new System.Drawing.Size(931, 691);
            this.Database_Global.TabIndex = 0;
            // 
            // Form_EditorDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 725);
            this.Controls.Add(this.TabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_EditorDatabase";
            this.Normal = new System.Drawing.Rectangle(19, 19, 957, 772);
            this.Text = "Database Editor";
            this.TabControl1.ResumeLayout(false);
            this.TabCharacters.ResumeLayout(false);
            this.PanelCharacters.ResumeLayout(false);
            this.TabBattlers.ResumeLayout(false);
            this.PanelBattlers.ResumeLayout(false);
            this.TabSkills.ResumeLayout(false);
            this.PanelSkills.ResumeLayout(false);
            this.TabItems.ResumeLayout(false);
            this.PanelItems.ResumeLayout(false);
            this.TabGroups.ResumeLayout(false);
            this.PanelGroups.ResumeLayout(false);
            this.TabMaps.ResumeLayout(false);
            this.PanelMaps.ResumeLayout(false);
            this.TabGlobal.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        internal BasicTabControl TabControl1;
        internal BasicTabPage TabCharacters;
        internal HexTools.HexPanel PanelCharacters;
        internal Data_Characters Database_Characters;
        internal BasicTabPage TabBattlers;
        internal HexTools.HexPanel PanelBattlers;
        internal Data_Battlers Database_Battlers;
        internal BasicTabPage TabSkills;
        internal HexTools.HexPanel PanelSkills;
        internal Data_Skills Database_Skills;
        internal BasicTabPage TabGroups;
        internal HexTools.HexPanel PanelGroups;
        internal Data_Groups Database_Groups;
        internal BasicTabPage TabItems;
        internal HexTools.HexPanel PanelItems;
        internal Data_Items Database_Items;
        internal BasicTabPage TabMaps;
        internal HexTools.HexPanel PanelMaps;
        internal Data_Maps Database_Maps;
        internal BasicTabPage TabGlobal;
        internal Data_Global Database_Global;
    }
}