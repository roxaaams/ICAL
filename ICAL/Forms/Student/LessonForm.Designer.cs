namespace ICAL_Final.Forms.Student
{
    partial class LessonForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.headerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.previousButton = new System.Windows.Forms.Button();
            this.chapterLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lessonTextBox = new System.Windows.Forms.RichTextBox();
            this.lessonsListBox = new System.Windows.Forms.ListBox();
            this.playPanel = new System.Windows.Forms.Panel();
            this.lessonPictureBox = new System.Windows.Forms.PictureBox();
            this.speechButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.speechLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.headerTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.playPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lessonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.headerTableLayoutPanel);
            this.panel2.Controls.Add(this.imageBoxFrameGrabber);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1013, 70);
            this.panel2.TabIndex = 40;
            // 
            // headerTableLayoutPanel
            // 
            this.headerTableLayoutPanel.ColumnCount = 4;
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.68597F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.31403F));
            this.headerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.headerTableLayoutPanel.Controls.Add(this.previousButton, 2, 1);
            this.headerTableLayoutPanel.Controls.Add(this.pictureBox1, 0, 0);
            this.headerTableLayoutPanel.Controls.Add(this.chapterLabel, 1, 0);
            this.headerTableLayoutPanel.Controls.Add(this.nextButton, 3, 1);
            this.headerTableLayoutPanel.Controls.Add(this.descriptionLabel, 1, 1);
            this.headerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.headerTableLayoutPanel.Name = "headerTableLayoutPanel";
            this.headerTableLayoutPanel.RowCount = 2;
            this.headerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.57143F));
            this.headerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.42857F));
            this.headerTableLayoutPanel.Size = new System.Drawing.Size(1013, 70);
            this.headerTableLayoutPanel.TabIndex = 45;
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.previousButton.FlatAppearance.BorderSize = 0;
            this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousButton.Font = new System.Drawing.Font("Calibri", 13F);
            this.previousButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.previousButton.Location = new System.Drawing.Point(631, 37);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(164, 30);
            this.previousButton.TabIndex = 43;
            this.previousButton.Text = "Previous Lesson";
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // chapterLabel
            // 
            this.chapterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chapterLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.chapterLabel.Location = new System.Drawing.Point(105, 0);
            this.chapterLabel.Name = "chapterLabel";
            this.chapterLabel.Size = new System.Drawing.Size(520, 34);
            this.chapterLabel.TabIndex = 33;
            this.chapterLabel.Text = "CHAPTER X";
            this.chapterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nextButton.Location = new System.Drawing.Point(839, 37);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(169, 30);
            this.nextButton.TabIndex = 44;
            this.nextButton.Text = "Next Lesson";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.descriptionLabel.Location = new System.Drawing.Point(105, 34);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(520, 36);
            this.descriptionLabel.TabIndex = 34;
            this.descriptionLabel.Text = "Let\'s get into the Java World\r\n";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.07006F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.92994F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 272F));
            this.tableLayoutPanel.Controls.Add(this.lessonTextBox, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.lessonPictureBox, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.lessonsListBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.playPanel, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 70);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.46154F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1013, 363);
            this.tableLayoutPanel.TabIndex = 46;
            // 
            // lessonTextBox
            // 
            this.lessonTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lessonTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lessonTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lessonTextBox.Location = new System.Drawing.Point(129, 3);
            this.lessonTextBox.Name = "lessonTextBox";
            this.lessonTextBox.ReadOnly = true;
            this.lessonTextBox.Size = new System.Drawing.Size(608, 287);
            this.lessonTextBox.TabIndex = 42;
            this.lessonTextBox.Text = "";
            // 
            // lessonsListBox
            // 
            this.lessonsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lessonsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lessonsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lessonsListBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonsListBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lessonsListBox.FormattingEnabled = true;
            this.lessonsListBox.ItemHeight = 23;
            this.lessonsListBox.Location = new System.Drawing.Point(3, 3);
            this.lessonsListBox.Name = "lessonsListBox";
            this.lessonsListBox.Size = new System.Drawing.Size(120, 287);
            this.lessonsListBox.TabIndex = 45;
            this.lessonsListBox.SelectedIndexChanged += new System.EventHandler(this.lessonsListBox_SelectedIndexChanged);
            // 
            // playPanel
            // 
            this.playPanel.Controls.Add(this.speechLabel);
            this.playPanel.Controls.Add(this.speechButton);
            this.playPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playPanel.Location = new System.Drawing.Point(129, 296);
            this.playPanel.Name = "playPanel";
            this.playPanel.Size = new System.Drawing.Size(608, 64);
            this.playPanel.TabIndex = 51;
            // 
            // lessonPictureBox
            // 
            this.lessonPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lessonPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lessonPictureBox.Location = new System.Drawing.Point(743, 3);
            this.lessonPictureBox.Name = "lessonPictureBox";
            this.lessonPictureBox.Size = new System.Drawing.Size(267, 287);
            this.lessonPictureBox.TabIndex = 41;
            this.lessonPictureBox.TabStop = false;
            // 
            // speechButton
            // 
            this.speechButton.BackgroundImage = global::ICAL_Final.Properties.Resources.play;
            this.speechButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.speechButton.FlatAppearance.BorderSize = 0;
            this.speechButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.speechButton.Location = new System.Drawing.Point(-38, -34);
            this.speechButton.Name = "speechButton";
            this.speechButton.Size = new System.Drawing.Size(176, 130);
            this.speechButton.TabIndex = 50;
            this.speechButton.UseVisualStyleBackColor = true;
            this.speechButton.Click += new System.EventHandler(this.speechButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ICAL_Final.Properties.Resources._4_editare_lectii;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(0, 12);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(10, 2);
            this.imageBoxFrameGrabber.TabIndex = 39;
            this.imageBoxFrameGrabber.TabStop = false;
            this.imageBoxFrameGrabber.Visible = false;
            // 
            // speechLabel
            // 
            this.speechLabel.AutoSize = true;
            this.speechLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.speechLabel.Location = new System.Drawing.Point(85, 20);
            this.speechLabel.Name = "speechLabel";
            this.speechLabel.Size = new System.Drawing.Size(123, 23);
            this.speechLabel.TabIndex = 51;
            this.speechLabel.Text = "Text to Speech";
            // 
            // LessonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1013, 433);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LessonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student - View Chapter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.headerTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.playPanel.ResumeLayout(false);
            this.playPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lessonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label chapterLabel;
        private System.Windows.Forms.PictureBox lessonPictureBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.RichTextBox lessonTextBox;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.ListBox lessonsListBox;
        private System.Windows.Forms.Panel playPanel;
        private System.Windows.Forms.Button speechButton;
        private System.Windows.Forms.TableLayoutPanel headerTableLayoutPanel;
        private System.Windows.Forms.Label speechLabel;
    }
}