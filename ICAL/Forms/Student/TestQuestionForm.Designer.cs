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
            this.label1 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.questionsPanel = new System.Windows.Forms.Panel();
            this.thirdQuestPanel = new System.Windows.Forms.Panel();
            this.thirdQuestTextBox = new System.Windows.Forms.RichTextBox();
            this.thirdAnsradioButton3 = new System.Windows.Forms.RadioButton();
            this.thirdAnsradioButton2 = new System.Windows.Forms.RadioButton();
            this.thirdAnsradioButton1 = new System.Windows.Forms.RadioButton();
            this.secondQuestPanel = new System.Windows.Forms.Panel();
            this.secondQuestTextBox = new System.Windows.Forms.RichTextBox();
            this.secondAnsradioButton3 = new System.Windows.Forms.RadioButton();
            this.secondAnsradioButton2 = new System.Windows.Forms.RadioButton();
            this.secondAnsradioButton1 = new System.Windows.Forms.RadioButton();
            this.firstQuestPanel = new System.Windows.Forms.Panel();
            this.firstQuestTextBox = new System.Windows.Forms.RichTextBox();
            this.firstAnsradioButton3 = new System.Windows.Forms.RadioButton();
            this.firstAnsradioButton2 = new System.Windows.Forms.RadioButton();
            this.firstAnsradioButton1 = new System.Windows.Forms.RadioButton();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.questionsPanel.SuspendLayout();
            this.thirdQuestPanel.SuspendLayout();
            this.secondQuestPanel.SuspendLayout();
            this.firstQuestPanel.SuspendLayout();
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
            this.statusPanel.Controls.Add(this.label1);
            this.statusPanel.Controls.Add(this.submitButton);
            this.statusPanel.Controls.Add(this.logoPictureBox);
            this.statusPanel.Controls.Add(this.descriptionLabel);
            this.statusPanel.Controls.Add(this.evaluationLabel);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusPanel.Location = new System.Drawing.Point(0, 0);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(886, 83);
            this.statusPanel.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(438, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 57;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.submitButton.Location = new System.Drawing.Point(691, 21);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(180, 50);
            this.submitButton.TabIndex = 56;
            this.submitButton.Text = "Submit Answers";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
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
            // questionsPanel
            // 
            this.questionsPanel.AutoScroll = true;
            this.questionsPanel.Controls.Add(this.thirdQuestPanel);
            this.questionsPanel.Controls.Add(this.secondQuestPanel);
            this.questionsPanel.Controls.Add(this.firstQuestPanel);
            this.questionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionsPanel.Font = new System.Drawing.Font("Calibri", 13F);
            this.questionsPanel.Location = new System.Drawing.Point(0, 83);
            this.questionsPanel.Name = "questionsPanel";
            this.questionsPanel.Size = new System.Drawing.Size(886, 385);
            this.questionsPanel.TabIndex = 49;
            // 
            // thirdQuestPanel
            // 
            this.thirdQuestPanel.AutoScroll = true;
            this.thirdQuestPanel.Controls.Add(this.thirdQuestTextBox);
            this.thirdQuestPanel.Controls.Add(this.thirdAnsradioButton3);
            this.thirdQuestPanel.Controls.Add(this.thirdAnsradioButton2);
            this.thirdQuestPanel.Controls.Add(this.thirdAnsradioButton1);
            this.thirdQuestPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.thirdQuestPanel.Location = new System.Drawing.Point(0, 389);
            this.thirdQuestPanel.Name = "thirdQuestPanel";
            this.thirdQuestPanel.Size = new System.Drawing.Size(869, 186);
            this.thirdQuestPanel.TabIndex = 51;
            this.thirdQuestPanel.Tag = "2";
            // 
            // thirdQuestTextBox
            // 
            this.thirdQuestTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.thirdQuestTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.thirdQuestTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdQuestTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.thirdQuestTextBox.Location = new System.Drawing.Point(12, 14);
            this.thirdQuestTextBox.Name = "thirdQuestTextBox";
            this.thirdQuestTextBox.ReadOnly = true;
            this.thirdQuestTextBox.Size = new System.Drawing.Size(834, 50);
            this.thirdQuestTextBox.TabIndex = 7;
            this.thirdQuestTextBox.Text = "";
            // 
            // thirdAnsradioButton3
            // 
            this.thirdAnsradioButton3.AutoSize = true;
            this.thirdAnsradioButton3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdAnsradioButton3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.thirdAnsradioButton3.Location = new System.Drawing.Point(26, 161);
            this.thirdAnsradioButton3.Name = "thirdAnsradioButton3";
            this.thirdAnsradioButton3.Size = new System.Drawing.Size(14, 13);
            this.thirdAnsradioButton3.TabIndex = 6;
            this.thirdAnsradioButton3.TabStop = true;
            this.thirdAnsradioButton3.Tag = "c)";
            this.thirdAnsradioButton3.UseVisualStyleBackColor = true;
            // 
            // thirdAnsradioButton2
            // 
            this.thirdAnsradioButton2.AutoSize = true;
            this.thirdAnsradioButton2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdAnsradioButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.thirdAnsradioButton2.Location = new System.Drawing.Point(26, 118);
            this.thirdAnsradioButton2.Name = "thirdAnsradioButton2";
            this.thirdAnsradioButton2.Size = new System.Drawing.Size(14, 13);
            this.thirdAnsradioButton2.TabIndex = 5;
            this.thirdAnsradioButton2.TabStop = true;
            this.thirdAnsradioButton2.Tag = "b)";
            this.thirdAnsradioButton2.UseVisualStyleBackColor = true;
            // 
            // thirdAnsradioButton1
            // 
            this.thirdAnsradioButton1.AutoSize = true;
            this.thirdAnsradioButton1.Checked = true;
            this.thirdAnsradioButton1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdAnsradioButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.thirdAnsradioButton1.Location = new System.Drawing.Point(26, 77);
            this.thirdAnsradioButton1.Name = "thirdAnsradioButton1";
            this.thirdAnsradioButton1.Size = new System.Drawing.Size(14, 13);
            this.thirdAnsradioButton1.TabIndex = 4;
            this.thirdAnsradioButton1.TabStop = true;
            this.thirdAnsradioButton1.Tag = "a)";
            this.thirdAnsradioButton1.UseVisualStyleBackColor = true;
            // 
            // secondQuestPanel
            // 
            this.secondQuestPanel.AutoScroll = true;
            this.secondQuestPanel.Controls.Add(this.secondQuestTextBox);
            this.secondQuestPanel.Controls.Add(this.secondAnsradioButton3);
            this.secondQuestPanel.Controls.Add(this.secondAnsradioButton2);
            this.secondQuestPanel.Controls.Add(this.secondAnsradioButton1);
            this.secondQuestPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.secondQuestPanel.Location = new System.Drawing.Point(0, 198);
            this.secondQuestPanel.Name = "secondQuestPanel";
            this.secondQuestPanel.Size = new System.Drawing.Size(869, 191);
            this.secondQuestPanel.TabIndex = 50;
            this.secondQuestPanel.Tag = "1";
            // 
            // secondQuestTextBox
            // 
            this.secondQuestTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.secondQuestTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.secondQuestTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondQuestTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.secondQuestTextBox.Location = new System.Drawing.Point(15, 15);
            this.secondQuestTextBox.Name = "secondQuestTextBox";
            this.secondQuestTextBox.ReadOnly = true;
            this.secondQuestTextBox.Size = new System.Drawing.Size(834, 50);
            this.secondQuestTextBox.TabIndex = 5;
            this.secondQuestTextBox.Text = "";
            // 
            // secondAnsradioButton3
            // 
            this.secondAnsradioButton3.AutoSize = true;
            this.secondAnsradioButton3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondAnsradioButton3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.secondAnsradioButton3.Location = new System.Drawing.Point(26, 164);
            this.secondAnsradioButton3.Name = "secondAnsradioButton3";
            this.secondAnsradioButton3.Size = new System.Drawing.Size(14, 13);
            this.secondAnsradioButton3.TabIndex = 6;
            this.secondAnsradioButton3.TabStop = true;
            this.secondAnsradioButton3.Tag = "c)";
            this.secondAnsradioButton3.UseVisualStyleBackColor = true;
            // 
            // secondAnsradioButton2
            // 
            this.secondAnsradioButton2.AutoSize = true;
            this.secondAnsradioButton2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondAnsradioButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.secondAnsradioButton2.Location = new System.Drawing.Point(26, 121);
            this.secondAnsradioButton2.Name = "secondAnsradioButton2";
            this.secondAnsradioButton2.Size = new System.Drawing.Size(14, 13);
            this.secondAnsradioButton2.TabIndex = 5;
            this.secondAnsradioButton2.TabStop = true;
            this.secondAnsradioButton2.Tag = "b)";
            this.secondAnsradioButton2.UseVisualStyleBackColor = true;
            // 
            // secondAnsradioButton1
            // 
            this.secondAnsradioButton1.AutoSize = true;
            this.secondAnsradioButton1.Checked = true;
            this.secondAnsradioButton1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondAnsradioButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.secondAnsradioButton1.Location = new System.Drawing.Point(26, 75);
            this.secondAnsradioButton1.Name = "secondAnsradioButton1";
            this.secondAnsradioButton1.Size = new System.Drawing.Size(14, 13);
            this.secondAnsradioButton1.TabIndex = 4;
            this.secondAnsradioButton1.TabStop = true;
            this.secondAnsradioButton1.Tag = "a)";
            this.secondAnsradioButton1.UseVisualStyleBackColor = true;
            // 
            // firstQuestPanel
            // 
            this.firstQuestPanel.AutoScroll = true;
            this.firstQuestPanel.Controls.Add(this.firstQuestTextBox);
            this.firstQuestPanel.Controls.Add(this.firstAnsradioButton3);
            this.firstQuestPanel.Controls.Add(this.firstAnsradioButton2);
            this.firstQuestPanel.Controls.Add(this.firstAnsradioButton1);
            this.firstQuestPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.firstQuestPanel.Location = new System.Drawing.Point(0, 0);
            this.firstQuestPanel.Name = "firstQuestPanel";
            this.firstQuestPanel.Size = new System.Drawing.Size(869, 198);
            this.firstQuestPanel.TabIndex = 49;
            this.firstQuestPanel.Tag = "0";
            // 
            // firstQuestTextBox
            // 
            this.firstQuestTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.firstQuestTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstQuestTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstQuestTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.firstQuestTextBox.Location = new System.Drawing.Point(15, 7);
            this.firstQuestTextBox.Name = "firstQuestTextBox";
            this.firstQuestTextBox.ReadOnly = true;
            this.firstQuestTextBox.Size = new System.Drawing.Size(834, 50);
            this.firstQuestTextBox.TabIndex = 4;
            this.firstQuestTextBox.Text = "";
            // 
            // firstAnsradioButton3
            // 
            this.firstAnsradioButton3.AutoSize = true;
            this.firstAnsradioButton3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstAnsradioButton3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.firstAnsradioButton3.Location = new System.Drawing.Point(26, 164);
            this.firstAnsradioButton3.Name = "firstAnsradioButton3";
            this.firstAnsradioButton3.Size = new System.Drawing.Size(14, 13);
            this.firstAnsradioButton3.TabIndex = 3;
            this.firstAnsradioButton3.Tag = "c)";
            this.firstAnsradioButton3.UseVisualStyleBackColor = true;
            // 
            // firstAnsradioButton2
            // 
            this.firstAnsradioButton2.AutoSize = true;
            this.firstAnsradioButton2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstAnsradioButton2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.firstAnsradioButton2.Location = new System.Drawing.Point(26, 116);
            this.firstAnsradioButton2.Name = "firstAnsradioButton2";
            this.firstAnsradioButton2.Size = new System.Drawing.Size(14, 13);
            this.firstAnsradioButton2.TabIndex = 2;
            this.firstAnsradioButton2.TabStop = true;
            this.firstAnsradioButton2.Tag = "b)";
            this.firstAnsradioButton2.UseVisualStyleBackColor = true;
            // 
            // firstAnsradioButton1
            // 
            this.firstAnsradioButton1.AutoSize = true;
            this.firstAnsradioButton1.Checked = true;
            this.firstAnsradioButton1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstAnsradioButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.firstAnsradioButton1.Location = new System.Drawing.Point(26, 66);
            this.firstAnsradioButton1.Name = "firstAnsradioButton1";
            this.firstAnsradioButton1.Size = new System.Drawing.Size(14, 13);
            this.firstAnsradioButton1.TabIndex = 1;
            this.firstAnsradioButton1.TabStop = true;
            this.firstAnsradioButton1.Tag = "a)";
            this.firstAnsradioButton1.UseVisualStyleBackColor = true;
            // 
            // TestQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(886, 468);
            this.Controls.Add(this.questionsPanel);
            this.Controls.Add(this.statusPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TestQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student - Evaluation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TestQuestionForm_Load);
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.questionsPanel.ResumeLayout(false);
            this.thirdQuestPanel.ResumeLayout(false);
            this.thirdQuestPanel.PerformLayout();
            this.secondQuestPanel.ResumeLayout(false);
            this.secondQuestPanel.PerformLayout();
            this.firstQuestPanel.ResumeLayout(false);
            this.firstQuestPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label evaluationLabel;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Panel questionsPanel;
        private System.Windows.Forms.Panel thirdQuestPanel;
        private System.Windows.Forms.RadioButton thirdAnsradioButton3;
        private System.Windows.Forms.RadioButton thirdAnsradioButton2;
        private System.Windows.Forms.RadioButton thirdAnsradioButton1;
        private System.Windows.Forms.Panel secondQuestPanel;
        private System.Windows.Forms.RadioButton secondAnsradioButton3;
        private System.Windows.Forms.RadioButton secondAnsradioButton2;
        private System.Windows.Forms.RadioButton secondAnsradioButton1;
        private System.Windows.Forms.Panel firstQuestPanel;
        private System.Windows.Forms.RadioButton firstAnsradioButton3;
        private System.Windows.Forms.RadioButton firstAnsradioButton2;
        private System.Windows.Forms.RadioButton firstAnsradioButton1;
        private System.Windows.Forms.RichTextBox thirdQuestTextBox;
        private System.Windows.Forms.RichTextBox secondQuestTextBox;
        private System.Windows.Forms.RichTextBox firstQuestTextBox;
        private System.Windows.Forms.Label label1;
    }
}