namespace Pokemon_SP_Phrases_Editor
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
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            groupBox3.Text = "Old Phrase";
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
            save_btn.Location = new Point(92, 119);
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(264, 46);
            save_btn.TabIndex = 2;
            save_btn.Text = "Save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // textBoxEdit
            // 
            textBoxEdit.Location = new Point(6, 22);
            textBoxEdit.Name = "textBoxEdit";
            textBoxEdit.RightToLeft = RightToLeft.Yes;
            textBoxEdit.Size = new Size(424, 23);
            textBoxEdit.TabIndex = 1;
            textBoxEdit.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(719, 460);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 4;
            label1.Text = "Created By";
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
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 481);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Pokemon BDSP Text Editor";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
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
    }
}
