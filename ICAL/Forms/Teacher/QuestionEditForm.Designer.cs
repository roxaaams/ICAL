namespace ICAL_Final.Forms.Teacher
{
    partial class QuestionEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionEditForm));
            this.statusPanel = new System.Windows.Forms.Panel();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.managementLabel = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.managementPanel = new System.Windows.Forms.Panel();
            this.chapterComboBox = new System.Windows.Forms.ComboBox();
            this.thirdAnswerLabel = new System.Windows.Forms.Label();
            this.chapterLabel = new System.Windows.Forms.Label();
            this.thirdAnswerTextBox = new System.Windows.Forms.TextBox();
            this.secondAnswerLabel = new System.Windows.Forms.Label();
            this.secondAnswerTextBox = new System.Windows.Forms.TextBox();
            this.firstAnswerLabel = new System.Windows.Forms.Label();
            this.firstAnswerTextBox = new System.Windows.Forms.TextBox();
            this.correctAnswerComboBox = new System.Windows.Forms.ComboBox();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.correctAnswerLabel = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.bodyPanel.SuspendLayout();
            this.managementPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.statusPanel.Controls.Add(this.logoBox);
            this.statusPanel.Controls.Add(this.descriptionLabel);
            this.statusPanel.Controls.Add(this.managementLabel);
            this.statusPanel.Location = new System.Drawing.Point(41, 15);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(700, 83);
            this.statusPanel.TabIndex = 46;
            // 
            // logoBox
            // 
            this.logoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoBox.Image = global::ICAL_Final.Properties.Resources._5_editare_intrebari_pentru_teste;
            this.logoBox.Location = new System.Drawing.Point(10, 10);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(63, 63);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 29;
            this.logoBox.TabStop = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.descriptionLabel.Location = new System.Drawing.Point(81, 49);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(350, 22);
            this.descriptionLabel.TabIndex = 31;
            this.descriptionLabel.Text = "Edit question";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // bodyPanel
            // 
            this.bodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.bodyPanel.Controls.Add(this.deleteButton);
            this.bodyPanel.Controls.Add(this.managementPanel);
            this.bodyPanel.Controls.Add(this.saveButton);
            this.bodyPanel.Location = new System.Drawing.Point(4, 0);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(737, 418);
            this.bodyPanel.TabIndex = 45;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.Location = new System.Drawing.Point(466, 357);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(180, 50);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete Question";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // managementPanel
            // 
            this.managementPanel.AutoScroll = true;
            this.managementPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.managementPanel.Controls.Add(this.chapterComboBox);
            this.managementPanel.Controls.Add(this.thirdAnswerLabel);
            this.managementPanel.Controls.Add(this.chapterLabel);
            this.managementPanel.Controls.Add(this.thirdAnswerTextBox);
            this.managementPanel.Controls.Add(this.secondAnswerLabel);
            this.managementPanel.Controls.Add(this.secondAnswerTextBox);
            this.managementPanel.Controls.Add(this.firstAnswerLabel);
            this.managementPanel.Controls.Add(this.firstAnswerTextBox);
            this.managementPanel.Controls.Add(this.correctAnswerComboBox);
            this.managementPanel.Controls.Add(this.levelComboBox);
            this.managementPanel.Controls.Add(this.correctAnswerLabel);
            this.managementPanel.Controls.Add(this.questionTextBox);
            this.managementPanel.Controls.Add(this.questionLabel);
            this.managementPanel.Controls.Add(this.levelLabel);
            this.managementPanel.Location = new System.Drawing.Point(41, 104);
            this.managementPanel.Name = "managementPanel";
            this.managementPanel.Size = new System.Drawing.Size(700, 243);
            this.managementPanel.TabIndex = 14;
            // 
            // chapterComboBox
            // 
            this.chapterComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.chapterComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.chapterComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chapterComboBox.Enabled = false;
            this.chapterComboBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.chapterComboBox.FormattingEnabled = true;
            this.chapterComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.chapterComboBox.Location = new System.Drawing.Point(81, 30);
            this.chapterComboBox.Name = "chapterComboBox";
            this.chapterComboBox.Size = new System.Drawing.Size(524, 31);
            this.chapterComboBox.TabIndex = 48;
            this.chapterComboBox.Text = "1";
            // 
            // thirdAnswerLabel
            // 
            this.thirdAnswerLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdAnswerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.thirdAnswerLabel.Location = new System.Drawing.Point(81, 387);
            this.thirdAnswerLabel.Name = "thirdAnswerLabel";
            this.thirdAnswerLabel.Size = new System.Drawing.Size(524, 22);
            this.thirdAnswerLabel.TabIndex = 27;
            this.thirdAnswerLabel.Text = "c)";
            // 
            // chapterLabel
            // 
            this.chapterLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chapterLabel.Location = new System.Drawing.Point(81, 5);
            this.chapterLabel.Name = "chapterLabel";
            this.chapterLabel.Size = new System.Drawing.Size(520, 22);
            this.chapterLabel.TabIndex = 47;
            this.chapterLabel.Text = "Chapter";
            // 
            // thirdAnswerTextBox
            // 
            this.thirdAnswerTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.thirdAnswerTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdAnswerTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.thirdAnswerTextBox.Location = new System.Drawing.Point(81, 412);
            this.thirdAnswerTextBox.MaxLength = 32;
            this.thirdAnswerTextBox.Multiline = true;
            this.thirdAnswerTextBox.Name = "thirdAnswerTextBox";
            this.thirdAnswerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.thirdAnswerTextBox.Size = new System.Drawing.Size(524, 29);
            this.thirdAnswerTextBox.TabIndex = 26;
            // 
            // secondAnswerLabel
            // 
            this.secondAnswerLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondAnswerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.secondAnswerLabel.Location = new System.Drawing.Point(81, 323);
            this.secondAnswerLabel.Name = "secondAnswerLabel";
            this.secondAnswerLabel.Size = new System.Drawing.Size(524, 22);
            this.secondAnswerLabel.TabIndex = 25;
            this.secondAnswerLabel.Text = "b)";
            // 
            // secondAnswerTextBox
            // 
            this.secondAnswerTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.secondAnswerTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondAnswerTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.secondAnswerTextBox.Location = new System.Drawing.Point(79, 348);
            this.secondAnswerTextBox.MaxLength = 32;
            this.secondAnswerTextBox.Multiline = true;
            this.secondAnswerTextBox.Name = "secondAnswerTextBox";
            this.secondAnswerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.secondAnswerTextBox.Size = new System.Drawing.Size(526, 29);
            this.secondAnswerTextBox.TabIndex = 24;
            // 
            // firstAnswerLabel
            // 
            this.firstAnswerLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstAnswerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.firstAnswerLabel.Location = new System.Drawing.Point(81, 249);
            this.firstAnswerLabel.Name = "firstAnswerLabel";
            this.firstAnswerLabel.Size = new System.Drawing.Size(520, 22);
            this.firstAnswerLabel.TabIndex = 23;
            this.firstAnswerLabel.Text = "a)";
            // 
            // firstAnswerTextBox
            // 
            this.firstAnswerTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.firstAnswerTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstAnswerTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.firstAnswerTextBox.Location = new System.Drawing.Point(79, 274);
            this.firstAnswerTextBox.MaxLength = 32;
            this.firstAnswerTextBox.Multiline = true;
            this.firstAnswerTextBox.Name = "firstAnswerTextBox";
            this.firstAnswerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.firstAnswerTextBox.Size = new System.Drawing.Size(526, 29);
            this.firstAnswerTextBox.TabIndex = 22;
            // 
            // correctAnswerComboBox
            // 
            this.correctAnswerComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "a)",
            "b)",
            "c)"});
            this.correctAnswerComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.correctAnswerComboBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctAnswerComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.correctAnswerComboBox.FormattingEnabled = true;
            this.correctAnswerComboBox.Items.AddRange(new object[] {
            "a)",
            "b)",
            "c)"});
            this.correctAnswerComboBox.Location = new System.Drawing.Point(79, 481);
            this.correctAnswerComboBox.Name = "correctAnswerComboBox";
            this.correctAnswerComboBox.Size = new System.Drawing.Size(526, 31);
            this.correctAnswerComboBox.TabIndex = 21;
            this.correctAnswerComboBox.Text = "a)";
            // 
            // levelComboBox
            // 
            this.levelComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "easy",
            "medium",
            "hard",
            "very hard"});
            this.levelComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.levelComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.levelComboBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Items.AddRange(new object[] {
            "easy",
            "medium",
            "hard",
            "very hard"});
            this.levelComboBox.Location = new System.Drawing.Point(81, 102);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(524, 31);
            this.levelComboBox.TabIndex = 20;
            this.levelComboBox.Text = "easy";
            // 
            // correctAnswerLabel
            // 
            this.correctAnswerLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctAnswerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.correctAnswerLabel.Location = new System.Drawing.Point(81, 455);
            this.correctAnswerLabel.Name = "correctAnswerLabel";
            this.correctAnswerLabel.Size = new System.Drawing.Size(530, 22);
            this.correctAnswerLabel.TabIndex = 18;
            this.correctAnswerLabel.Text = "Correct Answer";
            // 
            // questionTextBox
            // 
            this.questionTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.questionTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.questionTextBox.Location = new System.Drawing.Point(81, 176);
            this.questionTextBox.MaxLength = 32;
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.questionTextBox.Size = new System.Drawing.Size(524, 54);
            this.questionTextBox.TabIndex = 2;
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.questionLabel.Location = new System.Drawing.Point(81, 149);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(520, 22);
            this.questionLabel.TabIndex = 16;
            this.questionLabel.Text = "Question";
            // 
            // levelLabel
            // 
            this.levelLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.levelLabel.Location = new System.Drawing.Point(81, 77);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(520, 22);
            this.levelLabel.TabIndex = 14;
            this.levelLabel.Text = "Level";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.saveButton.Location = new System.Drawing.Point(126, 357);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(180, 50);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // QuestionEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(791, 430);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.bodyPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QuestionEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher - Edit Question";
            this.Load += new System.EventHandler(this.QuestionEditForm_Load);
            this.statusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.bodyPanel.ResumeLayout(false);
            this.managementPanel.ResumeLayout(false);
            this.managementPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label managementLabel;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.ComboBox correctAnswerComboBox;
        private System.Windows.Forms.Panel managementPanel;
        private System.Windows.Forms.ComboBox levelComboBox;
        private System.Windows.Forms.Label correctAnswerLabel;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label thirdAnswerLabel;
        private System.Windows.Forms.TextBox thirdAnswerTextBox;
        private System.Windows.Forms.Label secondAnswerLabel;
        private System.Windows.Forms.TextBox secondAnswerTextBox;
        private System.Windows.Forms.Label firstAnswerLabel;
        private System.Windows.Forms.TextBox firstAnswerTextBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox chapterComboBox;
        private System.Windows.Forms.Label chapterLabel;
    }
}