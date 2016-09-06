namespace ICAL_Final.Forms.Teacher
{
    partial class TeacherMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherMainForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.headerLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.addNewQuestionButton = new System.Windows.Forms.Button();
            this.addNewLessonButton = new System.Windows.Forms.Button();
            this.viewTestQuestionsButton = new System.Windows.Forms.Button();
            this.viewLessonsButton = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.headerPanel.SuspendLayout();
            this.headerLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.dashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.headerPanel.Controls.Add(this.headerLayoutPanel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(983, 70);
            this.headerPanel.TabIndex = 6;
            // 
            // headerLayoutPanel
            // 
            this.headerLayoutPanel.ColumnCount = 4;
            this.headerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.043218F));
            this.headerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.95678F));
            this.headerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            this.headerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.headerLayoutPanel.Controls.Add(this.nameLabel, 2, 0);
            this.headerLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.headerLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.headerLayoutPanel.Name = "headerLayoutPanel";
            this.headerLayoutPanel.RowCount = 1;
            this.headerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.headerLayoutPanel.Size = new System.Drawing.Size(983, 70);
            this.headerLayoutPanel.TabIndex = 2;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nameLabel.Location = new System.Drawing.Point(778, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(193, 70);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = global::ICAL_Final.Properties.Resources._7_aplicatie_iconita;
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(56, 64);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dashboardPanel.Controls.Add(this.addNewQuestionButton);
            this.dashboardPanel.Controls.Add(this.addNewLessonButton);
            this.dashboardPanel.Controls.Add(this.viewTestQuestionsButton);
            this.dashboardPanel.Controls.Add(this.viewLessonsButton);
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboardPanel.Location = new System.Drawing.Point(0, 70);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(97, 405);
            this.dashboardPanel.TabIndex = 7;
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
            this.addNewQuestionButton.Tag = "Add New Question";
            this.addNewQuestionButton.Text = "Add New Question";
            this.addNewQuestionButton.UseVisualStyleBackColor = false;
            this.addNewQuestionButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // addNewLessonButton
            // 
            this.addNewLessonButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.addNewLessonButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addNewLessonButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.addNewLessonButton.FlatAppearance.BorderSize = 2;
            this.addNewLessonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewLessonButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewLessonButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addNewLessonButton.Location = new System.Drawing.Point(0, 138);
            this.addNewLessonButton.Name = "addNewLessonButton";
            this.addNewLessonButton.Size = new System.Drawing.Size(97, 69);
            this.addNewLessonButton.TabIndex = 36;
            this.addNewLessonButton.Tag = "Add New Lesson";
            this.addNewLessonButton.Text = "Add New Lesson";
            this.addNewLessonButton.UseVisualStyleBackColor = false;
            this.addNewLessonButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // viewTestQuestionsButton
            // 
            this.viewTestQuestionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.viewTestQuestionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewTestQuestionsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewTestQuestionsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.viewTestQuestionsButton.FlatAppearance.BorderSize = 2;
            this.viewTestQuestionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewTestQuestionsButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewTestQuestionsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.viewTestQuestionsButton.Location = new System.Drawing.Point(0, 69);
            this.viewTestQuestionsButton.Name = "viewTestQuestionsButton";
            this.viewTestQuestionsButton.Size = new System.Drawing.Size(97, 69);
            this.viewTestQuestionsButton.TabIndex = 35;
            this.viewTestQuestionsButton.Text = "View Test Questions";
            this.viewTestQuestionsButton.UseVisualStyleBackColor = false;
            this.viewTestQuestionsButton.Click += new System.EventHandler(this.viewDataButton_Click);
            // 
            // viewLessonsButton
            // 
            this.viewLessonsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.viewLessonsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewLessonsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewLessonsButton.Enabled = false;
            this.viewLessonsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.viewLessonsButton.FlatAppearance.BorderSize = 2;
            this.viewLessonsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewLessonsButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLessonsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.viewLessonsButton.Location = new System.Drawing.Point(0, 0);
            this.viewLessonsButton.Name = "viewLessonsButton";
            this.viewLessonsButton.Size = new System.Drawing.Size(97, 69);
            this.viewLessonsButton.TabIndex = 34;
            this.viewLessonsButton.Text = "View Lessons";
            this.viewLessonsButton.UseVisualStyleBackColor = false;
            this.viewLessonsButton.Click += new System.EventHandler(this.viewDataButton_Click);
            // 
            // dataView
            // 
            this.dataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataView.Location = new System.Drawing.Point(97, 70);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(886, 405);
            this.dataView.TabIndex = 8;
            this.dataView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataView_MouseDoubleClick);
            // 
            // TeacherMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 475);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.dashboardPanel);
            this.Controls.Add(this.headerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher - Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.TeacherMainForm_Shown);
            this.headerPanel.ResumeLayout(false);
            this.headerLayoutPanel.ResumeLayout(false);
            this.headerLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.dashboardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button viewTestQuestionsButton;
        private System.Windows.Forms.Button viewLessonsButton;
        private System.Windows.Forms.Button addNewQuestionButton;
        private System.Windows.Forms.Button addNewLessonButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TableLayoutPanel headerLayoutPanel;
    }
}