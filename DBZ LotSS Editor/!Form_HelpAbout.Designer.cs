using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DBZ_LotSS_Editor
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class Form_HelpAbout : HexTools.HexForm
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
            TableLayoutPanel1 = new TableLayoutPanel();
            OK_Button = new Button();
            OK_Button.Click += new EventHandler(OK_Button_Click);
            LabelDescription = new Label();
            Description = new TextBox();
            LabelTitle = new Label();
            Title = new TextBox();
            Author = new TextBox();
            LabelAuthor = new Label();
            Version = new TextBox();
            LabelVersion = new Label();
            Company = new TextBox();
            LabelCompany = new Label();
            Copyright = new TextBox();
            LabelCopyright = new Label();
            SiteLink = new LinkLabel();
            SiteLink.LinkClicked += new LinkLabelLinkClickedEventHandler(SiteLink_LinkClicked);
            Credits = new TextBox();
            LabelCredits = new Label();
            JustinCreditsLink = new LinkLabel();
            JustinCreditsLink.LinkClicked += new LinkLabelLinkClickedEventHandler(JustinCreditsLink_LinkClicked_1);
            TableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            TableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableLayoutPanel1.ColumnCount = 1;
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Controls.Add(OK_Button, 0, 0);
            TableLayoutPanel1.Location = new Point(276, 415);
            TableLayoutPanel1.Margin = new Padding(5);
            TableLayoutPanel1.Name = "TableLayoutPanel1";
            TableLayoutPanel1.RowCount = 1;
            TableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0f));
            TableLayoutPanel1.Size = new Size(125, 45);
            TableLayoutPanel1.TabIndex = 1;
            // 
            // OK_Button
            // 
            OK_Button.Anchor = AnchorStyles.None;
            OK_Button.Location = new Point(7, 5);
            OK_Button.Margin = new Padding(5);
            OK_Button.Name = "OK_Button";
            OK_Button.Size = new Size(111, 35);
            OK_Button.TabIndex = 0;
            OK_Button.Text = "OK";
            // 
            // LabelDescription
            // 
            LabelDescription.AutoSize = true;
            LabelDescription.Location = new Point(20, 262);
            LabelDescription.Margin = new Padding(4, 0, 4, 0);
            LabelDescription.Name = "LabelDescription";
            LabelDescription.Size = new Size(100, 20);
            LabelDescription.TabIndex = 2;
            LabelDescription.Text = "Description:";
            LabelDescription.TextAlign = ContentAlignment.TopRight;
            // 
            // Description
            // 
            Description.Location = new Point(131, 259);
            Description.Margin = new Padding(4);
            Description.Multiline = true;
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Size = new Size(499, 144);
            Description.TabIndex = 3;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Location = new Point(75, 11);
            LabelTitle.Margin = new Padding(4, 0, 4, 0);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(46, 20);
            LabelTitle.TabIndex = 4;
            LabelTitle.Text = "Title:";
            LabelTitle.TextAlign = ContentAlignment.TopRight;
            // 
            // Title
            // 
            Title.Location = new Point(131, 8);
            Title.Margin = new Padding(4);
            Title.Multiline = true;
            Title.Name = "Title";
            Title.ReadOnly = true;
            Title.Size = new Size(499, 30);
            Title.TabIndex = 5;
            // 
            // Author
            // 
            Author.Location = new Point(131, 95);
            Author.Margin = new Padding(4);
            Author.Multiline = true;
            Author.Name = "Author";
            Author.ReadOnly = true;
            Author.Size = new Size(499, 30);
            Author.TabIndex = 7;
            // 
            // LabelAuthor
            // 
            LabelAuthor.AutoSize = true;
            LabelAuthor.Location = new Point(56, 99);
            LabelAuthor.Margin = new Padding(4, 0, 4, 0);
            LabelAuthor.Name = "LabelAuthor";
            LabelAuthor.Size = new Size(63, 20);
            LabelAuthor.TabIndex = 6;
            LabelAuthor.Text = "Author:";
            LabelAuthor.TextAlign = ContentAlignment.TopRight;
            // 
            // Version
            // 
            Version.Location = new Point(131, 176);
            Version.Margin = new Padding(4);
            Version.Multiline = true;
            Version.Name = "Version";
            Version.ReadOnly = true;
            Version.Size = new Size(499, 30);
            Version.TabIndex = 9;
            // 
            // LabelVersion
            // 
            LabelVersion.AutoSize = true;
            LabelVersion.Location = new Point(49, 180);
            LabelVersion.Margin = new Padding(4, 0, 4, 0);
            LabelVersion.Name = "LabelVersion";
            LabelVersion.Size = new Size(71, 20);
            LabelVersion.TabIndex = 8;
            LabelVersion.Text = "Version:";
            LabelVersion.TextAlign = ContentAlignment.TopRight;
            // 
            // Company
            // 
            Company.Location = new Point(131, 52);
            Company.Margin = new Padding(4);
            Company.Multiline = true;
            Company.Name = "Company";
            Company.ReadOnly = true;
            Company.Size = new Size(499, 30);
            Company.TabIndex = 11;
            // 
            // LabelCompany
            // 
            LabelCompany.AutoSize = true;
            LabelCompany.Location = new Point(35, 56);
            LabelCompany.Margin = new Padding(4, 0, 4, 0);
            LabelCompany.Name = "LabelCompany";
            LabelCompany.Size = new Size(84, 20);
            LabelCompany.TabIndex = 10;
            LabelCompany.Text = "Company:";
            LabelCompany.TextAlign = ContentAlignment.TopRight;
            // 
            // Copyright
            // 
            Copyright.Location = new Point(131, 218);
            Copyright.Margin = new Padding(4);
            Copyright.Multiline = true;
            Copyright.Name = "Copyright";
            Copyright.ReadOnly = true;
            Copyright.Size = new Size(499, 30);
            Copyright.TabIndex = 13;
            // 
            // LabelCopyright
            // 
            LabelCopyright.AutoSize = true;
            LabelCopyright.Location = new Point(35, 221);
            LabelCopyright.Margin = new Padding(4, 0, 4, 0);
            LabelCopyright.Name = "LabelCopyright";
            LabelCopyright.Size = new Size(85, 20);
            LabelCopyright.TabIndex = 12;
            LabelCopyright.Text = "Copyright:";
            LabelCopyright.TextAlign = ContentAlignment.TopRight;
            // 
            // SiteLink
            // 
            SiteLink.Location = new Point(427, 56);
            SiteLink.Margin = new Padding(4, 0, 4, 0);
            SiteLink.Name = "SiteLink";
            SiteLink.Size = new Size(201, 21);
            SiteLink.TabIndex = 14;
            SiteLink.TabStop = true;
            SiteLink.Tag = "www.cetragames.com";
            SiteLink.Text = "www.cetragames.com";
            // 
            // Credits
            // 
            Credits.Location = new Point(131, 136);
            Credits.Margin = new Padding(4);
            Credits.Multiline = true;
            Credits.Name = "Credits";
            Credits.ReadOnly = true;
            Credits.Size = new Size(499, 30);
            Credits.TabIndex = 16;
            Credits.Text = "Special thanks to   Justin3009   at RomHacking.net!";
            // 
            // LabelCredits
            // 
            LabelCredits.AutoSize = true;
            LabelCredits.Location = new Point(56, 140);
            LabelCredits.Margin = new Padding(4, 0, 4, 0);
            LabelCredits.Name = "LabelCredits";
            LabelCredits.Size = new Size(68, 20);
            LabelCredits.TabIndex = 15;
            LabelCredits.Text = "Credits:";
            LabelCredits.TextAlign = ContentAlignment.TopRight;
            // 
            // JustinCreditsLink
            // 
            JustinCreditsLink.Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            JustinCreditsLink.Location = new Point(236, 138);
            JustinCreditsLink.Margin = new Padding(4, 0, 4, 0);
            JustinCreditsLink.Name = "JustinCreditsLink";
            JustinCreditsLink.Size = new Size(80, 20);
            JustinCreditsLink.TabIndex = 17;
            JustinCreditsLink.TabStop = true;
            JustinCreditsLink.Tag = "https://www.romhacking.net/forum/index.php?action=profile;u=2449";
            JustinCreditsLink.Text = "Justin3009";
            // 
            // Form_HelpAbout
            // 
            AutoScaleDimensions = new SizeF(10.0f, 20.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 466);
            Controls.Add(JustinCreditsLink);
            Controls.Add(Credits);
            Controls.Add(LabelCredits);
            Controls.Add(SiteLink);
            Controls.Add(Copyright);
            Controls.Add(LabelCopyright);
            Controls.Add(Company);
            Controls.Add(LabelCompany);
            Controls.Add(Version);
            Controls.Add(LabelVersion);
            Controls.Add(Author);
            Controls.Add(LabelAuthor);
            Controls.Add(Title);
            Controls.Add(LabelTitle);
            Controls.Add(Description);
            Controls.Add(LabelDescription);
            Controls.Add(TableLayoutPanel1);
            Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            MinimumSize = new Size(670, 513);
            Name = "Form_HelpAbout";
            Normal = new Rectangle(19, 19, 670, 513);
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            TableLayoutPanel1.ResumeLayout(false);
            Load += new EventHandler(Form_HelpAbout_Load);
            ResumeLayout(false);
            PerformLayout();

        }
        internal TableLayoutPanel TableLayoutPanel1;
        internal Button OK_Button;
        internal Label LabelDescription;
        internal TextBox Description;
        internal Label LabelTitle;
        internal TextBox Title;
        internal TextBox Author;
        internal Label LabelAuthor;
        internal TextBox Version;
        internal Label LabelVersion;
        internal TextBox Company;
        internal Label LabelCompany;
        internal TextBox Copyright;
        internal Label LabelCopyright;
        internal LinkLabel SiteLink;
        internal TextBox Credits;
        internal Label LabelCredits;
        internal LinkLabel JustinCreditsLink;
    }
}