namespace ICAL_Final.Forms.Student
{
    partial class TestQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestQuestionForm));
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.evaluationLabel = new System.Windows.Forms.Label();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.questionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.questionPanel = new System.Windows.Forms.Panel();
            this.nextButton = new System.Windows.Forms.Button();
            this.questionLabel = new System.Windows.Forms.Label();
            this.thirdAnswerRadioButton = new System.Windows.Forms.RadioButton();
            this.secondAnswerRadioButton = new System.Windows.Forms.RadioButton();
            this.firstAnswerRadioButton = new System.Windows.Forms.RadioButton();
            this.scorePerTestLabel = new System.Windows.Forms.Label();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.questionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.descriptionLabel.Location = new System.Drawing.Point(81, 49);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(350, 22);
            this.descriptionLabel.TabIndex = 31;
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // evaluationLabel
            // 
            this.evaluationLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.evaluationLabel.Location = new System.Drawing.Point(81, 10);
            this.evaluationLabel.Name = "evaluationLabel";
            this.evaluationLabel.Size = new System.Drawing.Size(350, 33);
            this.evaluationLabel.TabIndex = 30;
            this.evaluationLabel.Text = "EVALUATION";
            this.evaluationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.statusPanel.Controls.Add(this.logoPictureBox);
            this.statusPanel.Controls.Add(this.descriptionLabel);
            this.statusPanel.Controls.Add(this.evaluationLabel);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusPanel.Location = new System.Drawing.Point(0, 0);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(944, 83);
            this.statusPanel.TabIndex = 48;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoPictureBox.Image = global::ICAL_Final.Properties.Resources._1vtestareevaluare;
            this.logoPictureBox.Location = new System.Drawing.Point(12, 10);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(63, 63);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 29;
            this.logoPictureBox.TabStop = false;
            // 
            // questionRichTextBox
            // 
            this.questionRichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.questionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionRichTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.questionRichTextBox.Location = new System.Drawing.Point(74, 31);
            this.questionRichTextBox.Name = "questionRichTextBox";
            this.questionRichTextBox.Size = new System.Drawing.Size(797, 96);
            this.questionRichTextBox.TabIndex = 49;
            this.questionRichTextBox.Text = "";
            // 
            // questionPanel
            // 
            this.questionPanel.Controls.Add(this.scorePerTestLabel);
            this.questionPanel.Controls.Add(this.nextButton);
            this.questionPanel.Controls.Add(this.questionLabel);
            this.questionPanel.Controls.Add(this.thirdAnswerRadioButton);
            this.questionPanel.Controls.Add(this.secondAnswerRadioButton);
            this.questionPanel.Controls.Add(this.firstAnswerRadioButton);
            this.questionPanel.Controls.Add(this.questionRichTextBox);
            this.questionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionPanel.Location = new System.Drawing.Point(0, 83);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(944, 374);
            this.questionPanel.TabIndex = 50;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nextButton.Location = new System.Drawing.Point(714, 299);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(157, 44);
            this.nextButton.TabIndex = 54;
            this.nextButton.Text = "Next Question";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Visible = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.questionLabel.Location = new System.Drawing.Point(107, 5);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(0, 23);
            this.questionLabel.TabIndex = 53;
            // 
            // thirdAnswerRadioButton
            // 
            this.thirdAnswerRadioButton.AutoSize = true;
            this.thirdAnswerRadioButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdAnswerRadioButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.thirdAnswerRadioButton.Location = new System.Drawing.Point(95, 250);
            this.thirdAnswerRadioButton.Name = "thirdAnswerRadioButton";
            this.thirdAnswerRadioButton.Size = new System.Drawing.Size(14, 13);
            this.thirdAnswerRadioButton.TabIndex = 52;
            this.thirdAnswerRadioButton.TabStop = true;
            this.thirdAnswerRadioButton.Tag = "c)";
            this.thirdAnswerRadioButton.UseVisualStyleBackColor = true;
            this.thirdAnswerRadioButton.CheckedChanged += new System.EventHandler(this.answerRadioButton_CheckedChanged);
            // 
            // secondAnswerRadioButton
            // 
            this.secondAnswerRadioButton.AutoSize = true;
            this.secondAnswerRadioButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondAnswerRadioButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.secondAnswerRadioButton.Location = new System.Drawing.Point(95, 196);
            this.secondAnswerRadioButton.Name = "secondAnswerRadioButton";
            this.secondAnswerRadioButton.Size = new System.Drawing.Size(14, 13);
            this.secondAnswerRadioButton.TabIndex = 51;
            this.secondAnswerRadioButton.TabStop = true;
            this.secondAnswerRadioButton.Tag = "b)";
            this.secondAnswerRadioButton.UseVisualStyleBackColor = true;
            this.secondAnswerRadioButton.CheckedChanged += new System.EventHandler(this.answerRadioButton_CheckedChanged);
            // 
            // firstAnswerRadioButton
            // 
            this.firstAnswerRadioButton.AutoSize = true;
            this.firstAnswerRadioButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstAnswerRadioButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.firstAnswerRadioButton.Location = new System.Drawing.Point(95, 143);
            this.firstAnswerRadioButton.Name = "firstAnswerRadioButton";
            this.firstAnswerRadioButton.Size = new System.Drawing.Size(14, 13);
            this.firstAnswerRadioButton.TabIndex = 50;
            this.firstAnswerRadioButton.TabStop = true;
            this.firstAnswerRadioButton.Tag = "a)";
            this.firstAnswerRadioButton.UseVisualStyleBackColor = true;
            this.firstAnswerRadioButton.CheckedChanged += new System.EventHandler(this.answerRadioButton_CheckedChanged);
            // 
            // scorePerTestLabel
            // 
            this.scorePerTestLabel.AutoSize = true;
            this.scorePerTestLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorePerTestLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.scorePerTestLabel.Location = new System.Drawing.Point(107, 299);
            this.scorePerTestLabel.Name = "scorePerTestLabel";
            this.scorePerTestLabel.Size = new System.Drawing.Size(0, 23);
            this.scorePerTestLabel.TabIndex = 55;
            // 
            // TestQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(944, 457);
            this.Controls.Add(this.questionPanel);
            this.Controls.Add(this.statusPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TestQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student - Evaluation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TestQuestionForm_Load);
            this.statusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.questionPanel.ResumeLayout(false);
            this.questionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label evaluationLabel;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.RichTextBox questionRichTextBox;
        private System.Windows.Forms.Panel questionPanel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.RadioButton thirdAnswerRadioButton;
        private System.Windows.Forms.RadioButton secondAnswerRadioButton;
        private System.Windows.Forms.RadioButton firstAnswerRadioButton;
        private System.Windows.Forms.Label scorePerTestLabel;
    }
}