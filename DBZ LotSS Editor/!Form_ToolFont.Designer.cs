using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DBZ_LotSS_Editor
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form_ToolFont : HexTools.HexForm
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
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ToolFont));
            EditableListViewItem2 = new BasicTools.BasicControls.EditableListViewItem();
            EditableListViewItemControl_11 = new HexTools.HexNumericBoxItemControl();
            EditableListViewItemControl_12 = new HexTools.HexTextBoxItemControl();
            OpenFileImport = new OpenFileDialog();
            SaveFileExport = new SaveFileDialog();
            ToolTipButtons = new ToolTip(components);
            ButtonAdd = new Button();
            ButtonAdd.Click += new EventHandler(ButtonAdd_Click);
            ButtonRemove = new Button();
            ButtonRemove.Click += new EventHandler(ButtonRemove_Click);
            ButtonReset = new Button();
            ButtonReset.Click += new EventHandler(ButtonReset_Click);
            ButtonImport = new Button();
            ButtonImport.Click += new EventHandler(ButtonImport_Click);
            ButtonExport = new Button();
            ButtonExport.Click += new EventHandler(ButtonExport_Click);
            ButtonReload = new Button();
            ButtonReload.Click += new EventHandler(ButtonReload_Click);
            ButtonSave = new Button();
            ButtonSave.Click += new EventHandler(ButtonSave_Click);
            FlowLayoutPanel3 = new FlowLayoutPanel();
            FlowLayoutPanel2 = new FlowLayoutPanel();
            FontTableView = new HexTools.HexTableView();
            FontTableView.SubItemEndEditing += new BasicTools.BasicControls.SubItemEndEditingEventHandler(Column_Edit);
            ColumnHeader0 = new ColumnHeader();
            ColumnHeader1 = new ColumnHeader();
            ColumnHeader2 = new ColumnHeader();
            TableLayoutPanel1 = new TableLayoutPanel();
            OK_Button = new Button();
            OK_Button.Click += new EventHandler(OK_Button_Click);
            Cancel_Button = new Button();
            Cancel_Button.Click += new EventHandler(Cancel_Button_Click);
            ((System.ComponentModel.ISupportInitialize)EditableListViewItemControl_11.Control).BeginInit();
            FlowLayoutPanel3.SuspendLayout();
            FlowLayoutPanel2.SuspendLayout();
            TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // EditableListViewItem2
            // 
            EditableListViewItem2.Name = "Index";
            // 
            // EditableListViewItemControl_11
            // 
            // 
            // 
            // 
            EditableListViewItemControl_11.Control.Display = HexTools.HexEnumerations.DisplayType.Hex;
            EditableListViewItemControl_11.Control.Hexadecimal = true;
            EditableListViewItemControl_11.Control.Input = HexTools.HexEnumerations.InputType.Hex;
            EditableListViewItemControl_11.Control.Location = new Point(0, 0);
            EditableListViewItemControl_11.Control.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            EditableListViewItemControl_11.Control.MaxLength = 2;
            EditableListViewItemControl_11.Control.Name = "Hex";
            EditableListViewItemControl_11.Control.TabIndex = 0;
            // 
            // EditableListViewItemControl_12
            // 
            // 
            // 
            // 
            EditableListViewItemControl_12.Control.AllowEmpty = true;
            EditableListViewItemControl_12.Control.Location = new Point(0, 0);
            EditableListViewItemControl_12.Control.Name = "Value";
            EditableListViewItemControl_12.Control.TabIndex = 0;
            // 
            // OpenFileImport
            // 
            OpenFileImport.Filter = "Font Table|*.tbl";
            OpenFileImport.Title = "Importing Table";
            // 
            // SaveFileExport
            // 
            SaveFileExport.Filter = "Font Table|*.tbl";
            SaveFileExport.Title = "Exporting Table";
            // 
            // ButtonAdd
            // 
            ButtonAdd.Image = (Image)resources.GetObject("ButtonAdd.Image");
            ButtonAdd.Location = new Point(3, 3);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(36, 36);
            ButtonAdd.TabIndex = 4;
            ToolTipButtons.SetToolTip(ButtonAdd, "Add");
            ButtonAdd.UseVisualStyleBackColor = true;
            // 
            // ButtonRemove
            // 
            ButtonRemove.Image = (Image)resources.GetObject("ButtonRemove.Image");
            ButtonRemove.Location = new Point(45, 3);
            ButtonRemove.Name = "ButtonRemove";
            ButtonRemove.Size = new Size(36, 36);
            ButtonRemove.TabIndex = 5;
            ToolTipButtons.SetToolTip(ButtonRemove, "Remove");
            ButtonRemove.UseVisualStyleBackColor = true;
            // 
            // ButtonReset
            // 
            ButtonReset.Image = My.Resources.Resources.undo16;
            ButtonReset.Location = new Point(87, 3);
            ButtonReset.Name = "ButtonReset";
            ButtonReset.Size = new Size(36, 36);
            ButtonReset.TabIndex = 0;
            ToolTipButtons.SetToolTip(ButtonReset, "Reset this Font Table to the default one built into this application.");
            ButtonReset.UseVisualStyleBackColor = true;
            // 
            // ButtonImport
            // 
            ButtonImport.Image = (Image)resources.GetObject("ButtonImport.Image");
            ButtonImport.Location = new Point(129, 3);
            ButtonImport.Name = "ButtonImport";
            ButtonImport.Size = new Size(36, 36);
            ButtonImport.TabIndex = 1;
            ToolTipButtons.SetToolTip(ButtonImport, "Import a Custom Font Table from any file.");
            ButtonImport.UseVisualStyleBackColor = true;
            // 
            // ButtonExport
            // 
            ButtonExport.Image = (Image)resources.GetObject("ButtonExport.Image");
            ButtonExport.Location = new Point(171, 3);
            ButtonExport.Name = "ButtonExport";
            ButtonExport.Size = new Size(36, 36);
            ButtonExport.TabIndex = 2;
            ToolTipButtons.SetToolTip(ButtonExport, "Export this Font Table to any file.");
            ButtonExport.UseVisualStyleBackColor = true;
            // 
            // ButtonReload
            // 
            ButtonReload.Image = (Image)resources.GetObject("ButtonReload.Image");
            ButtonReload.Location = new Point(3, 3);
            ButtonReload.Name = "ButtonReload";
            ButtonReload.Size = new Size(36, 36);
            ButtonReload.TabIndex = 3;
            ToolTipButtons.SetToolTip(ButtonReload, "Reload the saved version of the Font Table.");
            ButtonReload.UseVisualStyleBackColor = true;
            // 
            // ButtonSave
            // 
            ButtonSave.Image = My.Resources.Resources.Save;
            ButtonSave.Location = new Point(45, 3);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(36, 36);
            ButtonSave.TabIndex = 4;
            ToolTipButtons.SetToolTip(ButtonSave, "Save this Font Table to be used by this application.");
            ButtonSave.UseVisualStyleBackColor = true;
            // 
            // FlowLayoutPanel3
            // 
            FlowLayoutPanel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            FlowLayoutPanel3.AutoSize = true;
            FlowLayoutPanel3.Controls.Add(ButtonAdd);
            FlowLayoutPanel3.Controls.Add(ButtonRemove);
            FlowLayoutPanel3.Location = new Point(355, 339);
            FlowLayoutPanel3.Margin = new Padding(0);
            FlowLayoutPanel3.Name = "FlowLayoutPanel3";
            FlowLayoutPanel3.Size = new Size(84, 42);
            FlowLayoutPanel3.TabIndex = 9;
            // 
            // FlowLayoutPanel2
            // 
            FlowLayoutPanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            FlowLayoutPanel2.AutoSize = true;
            FlowLayoutPanel2.Controls.Add(ButtonReload);
            FlowLayoutPanel2.Controls.Add(ButtonSave);
            FlowLayoutPanel2.Controls.Add(ButtonReset);
            FlowLayoutPanel2.Controls.Add(ButtonImport);
            FlowLayoutPanel2.Controls.Add(ButtonExport);
            FlowLayoutPanel2.Location = new Point(12, 339);
            FlowLayoutPanel2.Margin = new Padding(0);
            FlowLayoutPanel2.Name = "FlowLayoutPanel2";
            FlowLayoutPanel2.Size = new Size(210, 42);
            FlowLayoutPanel2.TabIndex = 0;
            // 
            // FontTableView
            // 
            FontTableView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            FontTableView.ColumnResizable = true;
            FontTableView.Columns.AddRange(new ColumnHeader[] { ColumnHeader0, ColumnHeader1, ColumnHeader2 });
            FontTableView.DoubleClickActivation = true;
            FontTableView.Editors.AddRange(new BasicTools.BasicControls.EditableListViewItem[] { EditableListViewItem2, EditableListViewItemControl_11, EditableListViewItemControl_12 });
            FontTableView.FullRowSelect = true;
            FontTableView.GridLines = true;
            FontTableView.HideSelection = false;
            FontTableView.Location = new Point(12, 21);
            FontTableView.MultiSelect = true;
            FontTableView.Name = "FontTableView";
            FontTableView.OwnerDraw = true;
            FontTableView.Size = new Size(427, 318);
            FontTableView.Style = BasicTools.BasicControls.BasicTableView.TableViewStyles.Columns;
            FontTableView.TabIndex = 3;
            FontTableView.UseCompatibleStateImageBehavior = false;
            // 
            // ColumnHeader0
            // 
            ColumnHeader0.Text = "Index";
            ColumnHeader0.Width = 0;
            // 
            // ColumnHeader1
            // 
            ColumnHeader1.Text = "Hex";
            ColumnHeader1.Width = 50;
            // 
            // ColumnHeader2
            // 
            ColumnHeader2.Text = "Value";
            ColumnHeader2.Width = 300;
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 2;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(OK_Button, 0, 0);
            TableLayoutPanel1.Controls.Add(Cancel_Button, 1, 0);
            TableLayoutPanel1.Location = new Point(279, 400);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new Size(160, 32);
            TableLayoutPanel1.TabIndex = 1;
            // 
            // OK_Button
            // 
            OK_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            OK_Button.Location = new Point(10, 4);
            OK_Button.Name = "OK_Button";
            OK_Button.Size = new Size(67, 25);
            OK_Button.TabIndex = 0;
            OK_Button.Text = "OK";
            // 
            // Cancel_Button
            // 
            Cancel_Button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Cancel_Button.DialogResult = DialogResult.Cancel;
            Cancel_Button.Location = new Point(87, 4);
            Cancel_Button.Name = "Cancel_Button";
            Cancel_Button.Size = new Size(70, 25);
            Cancel_Button.TabIndex = 1;
            Cancel_Button.Text = "Cancel";
            // 
            // Form_ToolFont
            // 
            AutoScaleDimensions = new SizeF(10.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 444);
            Controls.Add(FlowLayoutPanel3);
            Controls.Add(FlowLayoutPanel2);
            Controls.Add(FontTableView);
            Controls.Add(TableLayoutPanel1);
            Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(400, 400);
            Name = "Form_ToolFont";
            Normal = new Rectangle(15, 15, 467, 482);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Font Table";
            ((System.ComponentModel.ISupportInitialize)EditableListViewItemControl_11.Control).EndInit();
            FlowLayoutPanel3.ResumeLayout(false);
            FlowLayoutPanel2.ResumeLayout(false);
            TableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }
        internal Button ButtonReset;
        internal TableLayoutPanel TableLayoutPanel1;
        internal Button OK_Button;
        internal Button Cancel_Button;
        internal HexTools.HexTableView FontTableView;
        internal ColumnHeader ColumnHeader0;
        internal ColumnHeader ColumnHeader1;
        internal ColumnHeader ColumnHeader2;
        internal FlowLayoutPanel FlowLayoutPanel2;
        internal FlowLayoutPanel FlowLayoutPanel3;
        internal Button ButtonAdd;
        internal Button ButtonRemove;
        internal Button ButtonImport;
        internal Button ButtonExport;
        internal OpenFileDialog OpenFileImport;
        internal SaveFileDialog SaveFileExport;
        internal ToolTip ToolTipButtons;
        internal Button ButtonReload;
        internal Button ButtonSave;
        internal BasicTools.BasicControls.EditableListViewItem EditableListViewItem2;
        internal HexTools.HexNumericBoxItemControl EditableListViewItemControl_11;
        internal HexTools.HexTextBoxItemControl EditableListViewItemControl_12;
    }
}