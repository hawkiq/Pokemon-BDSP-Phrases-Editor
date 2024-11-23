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
            buttonClose = new Button();
            SuspendLayout();
            // 
            // labelAppInfo
            // 
            labelAppInfo.AutoSize = true;
            labelAppInfo.Location = new Point(12, 23);
            labelAppInfo.Name = "labelAppInfo";
            labelAppInfo.Size = new Size(57, 15);
            labelAppInfo.TabIndex = 0;
            labelAppInfo.Text = "label_title";
            // 
            // linkLabelGitHub
            // 
            linkLabelGitHub.AutoSize = true;
            linkLabelGitHub.Location = new Point(12, 190);
            linkLabelGitHub.Name = "linkLabelGitHub";
            linkLabelGitHub.Size = new Size(60, 15);
            linkLabelGitHub.TabIndex = 1;
            linkLabelGitHub.TabStop = true;
            linkLabelGitHub.Text = "linkLabel1";
            linkLabelGitHub.LinkClicked += linkLabelGitHub_LinkClicked;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(80, 151);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(59, 26);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 214);
            Controls.Add(buttonClose);
            Controls.Add(linkLabelGitHub);
            Controls.Add(labelAppInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAppInfo;
        private LinkLabel linkLabelGitHub;
        private Button buttonClose;
    }
}