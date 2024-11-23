namespace Pokemon_SP_Phrases_Editor
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            labelAppInfo = new Label();
            linkLabelGitHub = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelAppInfo
            // 
            labelAppInfo.AutoSize = true;
            labelAppInfo.ForeColor = SystemColors.Control;
            labelAppInfo.Location = new Point(12, 18);
            labelAppInfo.Name = "labelAppInfo";
            labelAppInfo.Size = new Size(57, 15);
            labelAppInfo.TabIndex = 0;
            labelAppInfo.Text = "label_title";
            // 
            // linkLabelGitHub
            // 
            linkLabelGitHub.AutoSize = true;
            linkLabelGitHub.Location = new Point(9, 220);
            linkLabelGitHub.Name = "linkLabelGitHub";
            linkLabelGitHub.Size = new Size(60, 15);
            linkLabelGitHub.TabIndex = 1;
            linkLabelGitHub.TabStop = true;
            linkLabelGitHub.Text = "linkLabel1";
            linkLabelGitHub.LinkClicked += linkLabelGitHub_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_osama_ead70dda;
            pictureBox1.Location = new Point(52, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(207, 245);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabelGitHub);
            Controls.Add(labelAppInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            Load += AboutForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAppInfo;
        private LinkLabel linkLabelGitHub;
        private PictureBox pictureBox1;
    }
}