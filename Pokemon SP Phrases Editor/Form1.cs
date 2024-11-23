
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
            extractedStrings = new List<string>();
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
                        lblFileName.Text = $"File: {Path.GetFileName(currentFilePath)}";
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
                MessageBox.Show("No File Opened.");
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
                lblFileName.Text = "";
            }
        }

        private void AboutMenu_Click(object sender, EventArgs e)
        {
            string appName = "Pokemon BDSP Text Editor";
            string appVersion = "1.0.0";
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
            try
            {
                if (jsonDocument.TryGetValue("labelDataArray", out var labelDataArrayToken))
                {
                    var labelDataArray = labelDataArrayToken["Array"] as JArray;
                    if (labelDataArray == null)
                    {
                        MessageBox.Show("Invalid JSON structure: 'labelDataArray.Array' is missing or not an array.");
                        return;
                    }

                    int currentIndex = 0;

                    foreach (var label in labelDataArray)
                    {
                        var wordDataArray = label["wordDataArray"]?["Array"] as JArray;
                        if (wordDataArray == null) continue;

                        foreach (var word in wordDataArray)
                        {
                            if (word["str"] != null)
                            {

                                if (currentIndex == index)
                                {
                                    word["str"] = newText;

                                    File.WriteAllText(currentFilePath, jsonDocument.ToString(Formatting.Indented));
                                    return;
                                }

                                currentIndex++;
                            }
                        }
                    }

                    MessageBox.Show("Failed to locate the text for saving.", "Save Error");
                }
                else
                {
                    MessageBox.Show("Invalid JSON structure: 'labelDataArray' is missing.", "Save Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving to JSON: {ex.Message}", "Save Error");
            }
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

            string githubUrl = "https://osama.app";
            Process.Start(new ProcessStartInfo
            {
                FileName = githubUrl,
                UseShellExecute = true
            });
        }

        private void SaveAsFile(object sender, EventArgs e)
        {
            if (extractedStrings == null || extractedStrings.Count == 0)
            {
                MessageBox.Show("There is no content to save.", "Save As");
                return;
            }

            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON Files|*.json|Text Files|*.txt";
                saveFileDialog.Title = "Save As";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = saveFileDialog.FileName;
                    string extension = Path.GetExtension(selectedPath).ToLower();

                    try
                    {
                        if (extension == ".json")
                        {
                            SaveAsJson(selectedPath);
                        }
                        else if (extension == ".txt")
                        {
                            SaveAsText(selectedPath);
                        }
                        else
                        {
                            MessageBox.Show("Unsupported file format.", "Error");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error saving file: {ex.Message}", "Error");
                    }
                }
            }
        }

        private void SaveAsJson(string filePath)
        {
            try
            {
                if (jsonDocument.TryGetValue("labelDataArray", out var labelDataArrayToken))
                {
                    var labelDataArray = labelDataArrayToken["Array"] as JArray;
                    if (labelDataArray == null)
                    {
                        MessageBox.Show("Invalid JSON structure for saving.", "Save As JSON");
                        return;
                    }

                    int currentIndex = 0;
                    foreach (var label in labelDataArray)
                    {
                        var wordDataArray = label["wordDataArray"]?["Array"] as JArray;
                        if (wordDataArray == null) continue;

                        foreach (var word in wordDataArray)
                        {
                            if (word["str"] != null && currentIndex < extractedStrings.Count)
                            {
                                word["str"] = extractedStrings[currentIndex];
                                currentIndex++;
                            }
                        }
                    }

                    File.WriteAllText(filePath, jsonDocument.ToString(Formatting.Indented));
                    MessageBox.Show("File saved as JSON successfully.", "Save As JSON");
                }
                else
                {
                    MessageBox.Show("Invalid JSON structure: 'labelDataArray' is missing.", "Save As JSON");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving JSON: {ex.Message}", "Save As JSON");
            }
        }

        private void SaveAsText(string filePath)
        {
            try
            {
                File.WriteAllLines(filePath, extractedStrings);
                MessageBox.Show("File saved as TXT successfully.", "Save As TXT");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving TXT: {ex.Message}", "Save As TXT");
            }
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile(sender, e);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile(sender, e);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseFile(sender, e);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAllText(sender, e);
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyText(sender, e);
        }


        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasteText(sender, e);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Implemented Yet", "Future Function");
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsFile(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutMenu_Click(sender, e);
        }

        private void githubRepoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string githubUrl = "https://github.com/hawkiq/Pokemon-BDSP-Phrases-Editor";
            Process.Start(new ProcessStartInfo
            {
                FileName = githubUrl,
                UseShellExecute = true
            });
        }

        private void howtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var helpDialog = new HelpForm())
            {
                helpDialog.ShowDialog(this);
            }
        }
    }
}
