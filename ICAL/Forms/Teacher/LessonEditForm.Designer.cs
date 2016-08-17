namespace ICAL_Final.Forms.Teacher
{
    partial class LessonEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonEditForm));
            this.lessonRichTextBox = new System.Windows.Forms.RichTextBox();
            this.chapterComboBox = new System.Windows.Forms.ComboBox();
            this.chapterLabel = new System.Windows.Forms.Label();
            this.uploadNewPictureButton = new System.Windows.Forms.Button();
            this.newPictureBox = new System.Windows.Forms.PictureBox();
            this.lessonLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.managementLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.managementPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.newPictureBox)).BeginInit();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.managementPanel.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lessonRichTextBox
            // 
            this.lessonRichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lessonRichTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lessonRichTextBox.Location = new System.Drawing.Point(74, 167);
            this.lessonRichTextBox.Name = "lessonRichTextBox";
            this.lessonRichTextBox.Size = new System.Drawing.Size(530, 114);
            this.lessonRichTextBox.TabIndex = 64;
            this.lessonRichTextBox.Text = "";
            // 
            // chapterComboBox
            // 
            this.chapterComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4"});
            this.chapterComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chapterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chapterComboBox.Enabled = false;
            this.chapterComboBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.chapterComboBox.FormattingEnabled = true;
            this.chapterComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.chapterComboBox.Location = new System.Drawing.Point(74, 34);
            this.chapterComboBox.Name = "chapterComboBox";
            this.chapterComboBox.Size = new System.Drawing.Size(530, 31);
            this.chapterComboBox.TabIndex = 62;
            // 
            // chapterLabel
            // 
            this.chapterLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chapterLabel.Location = new System.Drawing.Point(79, 9);
            this.chapterLabel.Name = "chapterLabel";
            this.chapterLabel.Size = new System.Drawing.Size(520, 22);
            this.chapterLabel.TabIndex = 63;
            this.chapterLabel.Text = "Chapter";
            // 
            // uploadNewPictureButton
            // 
            this.uploadNewPictureButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uploadNewPictureButton.FlatAppearance.BorderSize = 0;
            this.uploadNewPictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadNewPictureButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadNewPictureButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.uploadNewPictureButton.Location = new System.Drawing.Point(74, 301);
            this.uploadNewPictureButton.Name = "uploadNewPictureButton";
            this.uploadNewPictureButton.Size = new System.Drawing.Size(201, 45);
            this.uploadNewPictureButton.TabIndex = 61;
            this.uploadNewPictureButton.Text = "Upload a new picture";
            this.uploadNewPictureButton.UseVisualStyleBackColor = false;
            this.uploadNewPictureButton.Click += new System.EventHandler(this.uploadNewPictureButton_Click);
            // 
            // newPictureBox
            // 
            this.newPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.newPictureBox.Location = new System.Drawing.Point(285, 298);
            this.newPictureBox.Name = "newPictureBox";
            this.newPictureBox.Size = new System.Drawing.Size(319, 225);
            this.newPictureBox.TabIndex = 60;
            this.newPictureBox.TabStop = false;
            // 
            // lessonLabel
            // 
            this.lessonLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lessonLabel.Location = new System.Drawing.Point(81, 142);
            this.lessonLabel.Name = "lessonLabel";
            this.lessonLabel.Size = new System.Drawing.Size(520, 22);
            this.lessonLabel.TabIndex = 45;
            this.lessonLabel.Text = "Lesson";
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.titleTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.titleTextBox.Location = new System.Drawing.Point(74, 102);
            this.titleTextBox.MaxLength = 32;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(530, 30);
            this.titleTextBox.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.descriptionLabel.Location = new System.Drawing.Point(81, 49);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(350, 22);
            this.descriptionLabel.TabIndex = 31;
            this.descriptionLabel.Text = "Edit lessons";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.statusPanel.Controls.Add(this.pictureBox1);
            this.statusPanel.Controls.Add(this.descriptionLabel);
            this.statusPanel.Controls.Add(this.managementLabel);
            this.statusPanel.Location = new System.Drawing.Point(29, 12);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(700, 83);
            this.statusPanel.TabIndex = 50;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::ICAL_Final.Properties.Resources._4_editare_lectii;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // managementLabel
            // 
            this.managementLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.managementLabel.Location = new System.Drawing.Point(79, 8);
            this.managementLabel.Name = "managementLabel";
            this.managementLabel.Size = new System.Drawing.Size(350, 33);
            this.managementLabel.TabIndex = 30;
            this.managementLabel.Text = "MANAGEMENT";
            this.managementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.titleLabel.Location = new System.Drawing.Point(80, 77);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(520, 22);
            this.titleLabel.TabIndex = 38;
            this.titleLabel.Text = "Title";
            // 
            // managementPanel
            // 
            this.managementPanel.AutoScroll = true;
            this.managementPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.managementPanel.Controls.Add(this.lessonRichTextBox);
            this.managementPanel.Controls.Add(this.chapterComboBox);
            this.managementPanel.Controls.Add(this.chapterLabel);
            this.managementPanel.Controls.Add(this.uploadNewPictureButton);
            this.managementPanel.Controls.Add(this.newPictureBox);
            this.managementPanel.Controls.Add(this.lessonLabel);
            this.managementPanel.Controls.Add(this.titleTextBox);
            this.managementPanel.Controls.Add(this.titleLabel);
            this.managementPanel.Font = new System.Drawing.Font("Calibri", 13F);
            this.managementPanel.Location = new System.Drawing.Point(3, 3);
            this.managementPanel.Name = "managementPanel";
            this.managementPanel.Size = new System.Drawing.Size(694, 207);
            this.managementPanel.TabIndex = 14;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(88, 234);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(180, 50);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // bodyPanel
            // 
            this.bodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.bodyPanel.Controls.Add(this.deleteButton);
            this.bodyPanel.Controls.Add(this.managementPanel);
            this.bodyPanel.Controls.Add(this.saveButton);
            this.bodyPanel.Location = new System.Drawing.Point(29, 101);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(700, 372);
            this.bodyPanel.TabIndex = 49;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(431, 234);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(180, 50);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete Lesson";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // LessonEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(755, 397);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.bodyPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LessonEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher - Edit User";
            this.Load += new System.EventHandler(this.LessonEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newPictureBox)).EndInit();
            this.statusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.managementPanel.ResumeLayout(false);
            this.managementPanel.PerformLayout();
            this.bodyPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox lessonRichTextBox;
        private System.Windows.Forms.ComboBox chapterComboBox;
        private System.Windows.Forms.Label chapterLabel;
        private System.Windows.Forms.Button uploadNewPictureButton;
        private System.Windows.Forms.PictureBox newPictureBox;
        private System.Windows.Forms.Label lessonLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label managementLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel managementPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Button deleteButton;
    }
}