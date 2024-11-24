﻿namespace Pokemon_SP_Phrases_Editor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            lblFileName = new Label();
            pictureBox1 = new PictureBox();
            listBoxStrings = new ListBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            textBoxEdit_old = new TextBox();
            clr_btn = new Button();
            save_btn = new Button();
            textBoxEdit = new TextBox();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            cutToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            howtoToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            githubRepoToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(lblFileName);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(listBoxStrings);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(0, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(863, 430);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "JSON file Phrases";
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(119, 0);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(0, 15);
            lblFileName.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.brilliant_diamond_shining_pearl_169_en;
            pictureBox1.Location = new Point(427, 228);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(436, 196);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // listBoxStrings
            // 
            listBoxStrings.AllowDrop = true;
            listBoxStrings.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            listBoxStrings.FormattingEnabled = true;
            listBoxStrings.ItemHeight = 15;
            listBoxStrings.Location = new Point(6, 22);
            listBoxStrings.Name = "listBoxStrings";
            listBoxStrings.Size = new Size(404, 394);
            listBoxStrings.TabIndex = 0;
            listBoxStrings.SelectedIndexChanged += listBoxStrings_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(clr_btn);
            groupBox2.Controls.Add(save_btn);
            groupBox2.Controls.Add(textBoxEdit);
            groupBox2.Location = new Point(427, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(448, 200);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Text to Edit";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxEdit_old);
            groupBox3.Location = new Point(6, 61);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(424, 52);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Original Phrase";
            // 
            // textBoxEdit_old
            // 
            textBoxEdit_old.Location = new Point(6, 21);
            textBoxEdit_old.Name = "textBoxEdit_old";
            textBoxEdit_old.ReadOnly = true;
            textBoxEdit_old.Size = new Size(412, 23);
            textBoxEdit_old.TabIndex = 0;
            // 
            // clr_btn
            // 
            clr_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            clr_btn.Location = new Point(136, 171);
            clr_btn.Name = "clr_btn";
            clr_btn.Size = new Size(168, 23);
            clr_btn.TabIndex = 3;
            clr_btn.Text = "Clear Text";
            clr_btn.UseVisualStyleBackColor = true;
            clr_btn.Click += clr_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            save_btn.Cursor = Cursors.Hand;
            save_btn.FlatAppearance.BorderColor = Color.Blue;
            save_btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 192, 255);
            save_btn.FlatStyle = FlatStyle.Flat;
            save_btn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save_btn.Location = new Point(92, 119);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(264, 46);
            save_btn.TabIndex = 2;
            save_btn.Text = "Save (Ctrl+S)";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // textBoxEdit
            // 
            textBoxEdit.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxEdit.Location = new Point(6, 22);
            textBoxEdit.Name = "textBoxEdit";
            textBoxEdit.PlaceholderText = "Write the Text you want to replace here";
            textBoxEdit.RightToLeft = RightToLeft.Yes;
            textBoxEdit.Size = new Size(424, 27);
            textBoxEdit.TabIndex = 1;
            textBoxEdit.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(674, 460);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 4;
            label1.Text = "Brought to you By :";
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(789, 460);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(68, 15);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "OsaMa Soft";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(875, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(186, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(186, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            saveAsToolStripMenuItem.Size = new Size(186, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            closeToolStripMenuItem.Size = new Size(186, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectAllToolStripMenuItem, copyToolStripMenuItem, cutToolStripMenuItem, pasteToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            selectAllToolStripMenuItem.Size = new Size(164, 22);
            selectAllToolStripMenuItem.Text = "Select All";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(164, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(164, 22);
            cutToolStripMenuItem.Text = "Cut";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(164, 22);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "Tools";
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            exportToolStripMenuItem.Size = new Size(148, 22);
            exportToolStripMenuItem.Text = "Export";
            exportToolStripMenuItem.Click += exportToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { howtoToolStripMenuItem, aboutToolStripMenuItem1, githubRepoToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // howtoToolStripMenuItem
            // 
            howtoToolStripMenuItem.Name = "howtoToolStripMenuItem";
            howtoToolStripMenuItem.Size = new Size(140, 22);
            howtoToolStripMenuItem.Text = "How-to...";
            howtoToolStripMenuItem.ToolTipText = "How to Use Program";
            howtoToolStripMenuItem.Click += howtoToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(140, 22);
            aboutToolStripMenuItem1.Text = "About";
            aboutToolStripMenuItem1.Click += aboutToolStripMenuItem1_Click;
            // 
            // githubRepoToolStripMenuItem
            // 
            githubRepoToolStripMenuItem.Name = "githubRepoToolStripMenuItem";
            githubRepoToolStripMenuItem.Size = new Size(140, 22);
            githubRepoToolStripMenuItem.Text = "Github Repo";
            githubRepoToolStripMenuItem.Click += githubRepoToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 460);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 6;
            label2.Text = "Version : 1.0.1";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 481);
            Controls.Add(label2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Pokemon BDSP Text Editor - Helper Tool By : OsaMa hawkiq";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private ListBox listBoxStrings;
        private GroupBox groupBox2;
        private Button save_btn;
        private TextBox textBoxEdit;
        private Label label1;
        private LinkLabel linkLabel1;
        private Button clr_btn;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private TextBox textBoxEdit_old;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private Label lblFileName;
        private Label label2;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem howtoToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        private ToolStripMenuItem githubRepoToolStripMenuItem;
    }
}
