namespace ICAL_Final.Forms.Student
{
    partial class StudentMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentMainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.headerLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addNewQuestionButton = new System.Windows.Forms.Button();
            this.addNewLessonButton = new System.Windows.Forms.Button();
            this.viewTestQuestionsButton = new System.Windows.Forms.Button();
            this.chapter1Button = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.headerLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.headerLayoutPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(891, 70);
            this.panel2.TabIndex = 4;
            // 
            // headerLayoutPanel
            // 
            this.headerLayoutPanel.ColumnCount = 3;
            this.headerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.734807F));
            this.headerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.26519F));
            this.headerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.headerLayoutPanel.Controls.Add(this.nameLabel, 2, 0);
            this.headerLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.headerLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.headerLayoutPanel.Name = "headerLayoutPanel";
            this.headerLayoutPanel.RowCount = 1;
            this.headerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.headerLayoutPanel.Size = new System.Drawing.Size(891, 70);
            this.headerLayoutPanel.TabIndex = 3;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameLabel.Location = new System.Drawing.Point(773, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(115, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = global::ICAL_Final.Properties.Resources._7_aplicatie_iconita;
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(53, 64);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.addNewQuestionButton);
            this.panel1.Controls.Add(this.addNewLessonButton);
            this.panel1.Controls.Add(this.viewTestQuestionsButton);
            this.panel1.Controls.Add(this.chapter1Button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(97, 414);
            this.panel1.TabIndex = 8;
            // 
            // addNewQuestionButton
            // 
            this.addNewQuestionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.addNewQuestionButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addNewQuestionButton.Enabled = false;
            this.addNewQuestionButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.addNewQuestionButton.FlatAppearance.BorderSize = 2;
            this.addNewQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewQuestionButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewQuestionButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addNewQuestionButton.Location = new System.Drawing.Point(0, 207);
            this.addNewQuestionButton.Name = "addNewQuestionButton";
            this.addNewQuestionButton.Size = new System.Drawing.Size(97, 69);
            this.addNewQuestionButton.TabIndex = 37;
            this.addNewQuestionButton.Tag = "4";
            this.addNewQuestionButton.Text = "Chapter 4";
            this.addNewQuestionButton.UseVisualStyleBackColor = false;
            this.addNewQuestionButton.Click += new System.EventHandler(this.viewChapterButton_Click);
            // 
            // addNewLessonButton
            // 
            this.addNewLessonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.addNewLessonButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addNewLessonButton.Enabled = false;
            this.addNewLessonButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.addNewLessonButton.FlatAppearance.BorderSize = 2;
            this.addNewLessonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewLessonButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewLessonButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addNewLessonButton.Location = new System.Drawing.Point(0, 138);
            this.addNewLessonButton.Name = "addNewLessonButton";
            this.addNewLessonButton.Size = new System.Drawing.Size(97, 69);
            this.addNewLessonButton.TabIndex = 36;
            this.addNewLessonButton.Tag = "3";
            this.addNewLessonButton.Text = "Chapter 3";
            this.addNewLessonButton.UseVisualStyleBackColor = false;
            this.addNewLessonButton.Click += new System.EventHandler(this.viewChapterButton_Click);
            // 
            // viewTestQuestionsButton
            // 
            this.viewTestQuestionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.viewTestQuestionsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewTestQuestionsButton.Enabled = false;
            this.viewTestQuestionsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.viewTestQuestionsButton.FlatAppearance.BorderSize = 2;
            this.viewTestQuestionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewTestQuestionsButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTestQuestionsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.viewTestQuestionsButton.Location = new System.Drawing.Point(0, 69);
            this.viewTestQuestionsButton.Name = "viewTestQuestionsButton";
            this.viewTestQuestionsButton.Size = new System.Drawing.Size(97, 69);
            this.viewTestQuestionsButton.TabIndex = 35;
            this.viewTestQuestionsButton.Tag = "2";
            this.viewTestQuestionsButton.Text = "Chapter 2";
            this.viewTestQuestionsButton.UseVisualStyleBackColor = false;
            this.viewTestQuestionsButton.Click += new System.EventHandler(this.viewChapterButton_Click);
            // 
            // chapter1Button
            // 
            this.chapter1Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.chapter1Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chapter1Button.Dock = System.Windows.Forms.DockStyle.Top;
            this.chapter1Button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.chapter1Button.FlatAppearance.BorderSize = 2;
            this.chapter1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chapter1Button.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapter1Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chapter1Button.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chapter1Button.Location = new System.Drawing.Point(0, 0);
            this.chapter1Button.Name = "chapter1Button";
            this.chapter1Button.Size = new System.Drawing.Size(97, 69);
            this.chapter1Button.TabIndex = 34;
            this.chapter1Button.Tag = "1";
            this.chapter1Button.Text = "Chapter 1";
            this.chapter1Button.UseVisualStyleBackColor = false;
            this.chapter1Button.Click += new System.EventHandler(this.viewChapterButton_Click);
            // 
            // StudentMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(891, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StudentMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student - Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.StudentMainForm_Shown);
            this.panel2.ResumeLayout(false);
            this.headerLayoutPanel.ResumeLayout(false);
            this.headerLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addNewQuestionButton;
        private System.Windows.Forms.Button addNewLessonButton;
        private System.Windows.Forms.Button viewTestQuestionsButton;
        private System.Windows.Forms.Button chapter1Button;
        private System.Windows.Forms.TableLayoutPanel headerLayoutPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.PictureBox logoPictureBox;
    }
}