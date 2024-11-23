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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            Text = "How to Use";
            InitializeHelpContent();
        }
        private void InitializeHelpContent()
        {
            var instructions = new RichTextBox
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                Text = "Steps to Use the Program:\n" +
                       "1. Open a JSON file using File -> Open or Ctrl+O.\n" +
                       "2. Select a phrase from the list.\n" +
                       "3. Edit the selected phrase in the text box.\n" +
                       "4. Save changes using File -> Save or Ctrl+S.\n" +
                       "\nFor more help, visit: https://github.com/hawkiq/Pokemon-BDSP-Phrases-Editor",
                Font = new Font("Arial", 10),
            };

            Controls.Add(instructions);
            instructions.LinkClicked += (s, e) =>
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = e.LinkText,
                    UseShellExecute = true
                });
            };

            // Close Button
            var closeButton = new Button
            {
                Text = "Close",
                Dock = DockStyle.Bottom,
                Height = 30,
            };
            closeButton.Click += (s, e) => Close();
            Controls.Add(closeButton);
        }

        private void HelpForm_Load(object sender, EventArgs e)
        {

        }
    }
}
