
using System.Diagnostics;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Pokemon_SP_Phrases_Editor
{
    public partial class Form1 : Form
    {
        private string currentFilePath;
        private JObject jsonDocument;
        private List<string> extractedStrings;
        public Form1()
        {
            InitializeComponent();
            InitializeMenu();
            extractedStrings = new List<string>();
        }

        private void InitializeMenu()
        {
            var fileMenu = new ToolStripMenuItem("File");
            fileMenu.DropDownItems.Add("Open", null, OpenFile);
            fileMenu.DropDownItems.Add("Save", null, SaveFile);
            fileMenu.DropDownItems.Add("Close", null, CloseFile);

            var editMenu = new ToolStripMenuItem("Edit");
            editMenu.DropDownItems.Add("Copy", null, CopyText);
            editMenu.DropDownItems.Add("Select All", null, SelectAllText);
            editMenu.DropDownItems.Add("Paste", null, PasteText);

            var aboutMenu = new ToolStripMenuItem("About");
            aboutMenu.Click += AboutMenu_Click;

            var menuStrip = new MenuStrip();
            menuStrip.Items.Add(fileMenu);
            menuStrip.Items.Add(editMenu);
            menuStrip.Items.Add(aboutMenu);

            Controls.Add(menuStrip);
        }

        private void OpenFile(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog { Filter = "JSON Files|*.json" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = openFileDialog.FileName;
                    try
                    {
                        var fileContent = File.ReadAllText(currentFilePath);
                        jsonDocument = JObject.Parse(fileContent);
                        ExtractStrings();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error opening file: {ex.Message}");
                    }
                }
            }
        }

        private void ExtractStrings()
        {
            extractedStrings.Clear();

            if (jsonDocument.TryGetValue("labelDataArray", out var labelDataArray))
            {
                foreach (var label in labelDataArray["Array"])
                {
                    if (label["wordDataArray"] != null)
                    {
                        foreach (var word in label["wordDataArray"]["Array"])
                        {
                            if (word["str"] != null)
                            {
                                extractedStrings.Add(word["str"].ToString());
                            }
                        }
                    }
                }
            }

            listBoxStrings.DataSource = new BindingSource(extractedStrings, null);
        }

        private void SaveFile(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentFilePath))
            {
                MessageBox.Show("No file open.");
                return;
            }
            SaveEditedText();
        }


        private void CloseFile(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                jsonDocument = null;
                extractedStrings.Clear();
                listBoxStrings.DataSource = null;
            }
        }

        private void AboutMenu_Click(object sender, EventArgs e)
        {
            string appName = "Pokemon BDSP Text Editor";
            string appVersion = "0.1";
            string buildDate = "2024-11-20";
            string githubUrl = "https://github.com/hawkiq";
            string message = $"{appName}\nVersion: {appVersion}\nBuild Date: {buildDate}\n\nVisit our GitHub project:\n{githubUrl}";
            string title = "About";
            using (var aboutForm = new AboutForm(appName, appVersion, buildDate, githubUrl))
            {
                aboutForm.ShowDialog(this);
            }
        }

        private void CopyText(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxEdit.Text);
        }

        private void SelectAllText(object sender, EventArgs e)
        {
            textBoxEdit.SelectAll();
        }

        private void PasteText(object sender, EventArgs e)
        {
            textBoxEdit.Paste();
        }

        private void listBoxStrings_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedString = listBoxStrings.SelectedItem as string;
            textBoxEdit.Text = selectedString ?? string.Empty;
            textBoxEdit_old.Text = selectedString ?? string.Empty;
        }


        private void textBoxEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || (e.Control && e.KeyCode == Keys.S))
            {
                SaveEditedText();
            }
        }

        private void SaveEditedText()
        {
            var selectedString = listBoxStrings.SelectedItem as string;
            if (selectedString == null) return;

            string newText = textBoxEdit.Text;

            int selectedIndex = extractedStrings.IndexOf(selectedString);
            if (selectedIndex >= 0)
            {
                extractedStrings[selectedIndex] = newText;

                listBoxStrings.DataSource = null;
                listBoxStrings.DataSource = new BindingSource(extractedStrings, null);

                SaveToJson(selectedIndex, newText);
            }
        }

        private void SaveToJson(int index, string newText)
        {
            var jsonString = File.ReadAllText(currentFilePath);
            JObject json = JObject.Parse(jsonString);

            JArray labelDataArray = (JArray)json["labelDataArray"];
            foreach (var label in labelDataArray)
            {
                JArray wordDataArray = (JArray)label["Array"];
                foreach (var word in wordDataArray)
                {
                    if (word["str"] != null)
                    {
                        string currentStr = word["str"].ToString();
                        int currentIndex = extractedStrings.IndexOf(currentStr);
                        if (currentIndex == index)
                        {
                            word["str"] = newText;
                        }
                    }
                }
            }
            File.WriteAllText(currentFilePath, json.ToString());
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            SaveEditedText();
        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            textBoxEdit.Text = null; textBoxEdit.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
    
            string githubUrl = "https://github.com/hawkiq";
            Process.Start(new ProcessStartInfo
            {
                FileName = githubUrl,
                UseShellExecute = true
            });
        }
    }
}
