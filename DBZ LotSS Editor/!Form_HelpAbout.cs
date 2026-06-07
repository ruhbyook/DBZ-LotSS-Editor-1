using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DBZ_LotSS_Editor
{
    public partial class Form_HelpAbout : HexTools.HexForm
    {
        public Form_HelpAbout()
        {
            InitializeComponent();
        }

        private void Form_HelpAbout_Load(object sender, EventArgs e)
        {
            var Info = My.MyProject.Application.Info;

            Title.Text = Info.ProductName;
            Company.Text = Info.CompanyName;
            Author.Text = Info.Trademark;
            Version.Text = Info.Version.ToString();
            Copyright.Text = Info.Copyright;
            Description.Text = Info.Description;
        }

        private void OpenLink(LinkLabel LinkLabel)
        {
            Process.Start(LinkLabel.Tag.ToString());
        }

        private void SiteLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink(SiteLink);
        }

        private void JustinCreditsLink_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLink(JustinCreditsLink);
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}