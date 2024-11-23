using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_SP_Phrases_Editor
{
    public partial class AboutForm : Form
    {
        public AboutForm(string appName, string appVersion, string buildDate, string githubUrl)
        {
            InitializeComponent();
            labelAppInfo.Text = $"{appName}\nVersion: {appVersion}\nBuild Date: {buildDate}";
            linkLabelGitHub.Text = githubUrl;
            linkLabelGitHub.Links.Add(0, githubUrl.Length, githubUrl);
        }

        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var targetUrl = e.Link.LinkData as string;
            if (!string.IsNullOrEmpty(targetUrl))
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = targetUrl,
                    UseShellExecute = true
                });
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
