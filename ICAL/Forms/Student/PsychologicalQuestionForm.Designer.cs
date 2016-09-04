namespace ICAL_Final.Forms.Student
{
    partial class PsychologicalQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PsychologicalQuestionForm));
            this.confirmAnswerButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.blobTreePictureBox = new System.Windows.Forms.PictureBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.breakTimeLabel = new System.Windows.Forms.Label();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blobTreePictureBox)).BeginInit();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bodyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // confirmAnswerButton
            // 
            this.confirmAnswerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.confirmAnswerButton.FlatAppearance.BorderSize = 0;
            this.confirmAnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmAnswerButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmAnswerButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.confirmAnswerButton.Location = new System.Drawing.Point(583, 23);
            this.confirmAnswerButton.Name = "confirmAnswerButton";
            this.confirmAnswerButton.Size = new System.Drawing.Size(180, 50);
            this.confirmAnswerButton.TabIndex = 9;
            this.confirmAnswerButton.Text = "Confirm your answer";
            this.confirmAnswerButton.UseVisualStyleBackColor = false;
            this.confirmAnswerButton.Click += new System.EventHandler(this.confirmAnswerButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.descriptionLabel.Location = new System.Drawing.Point(83, 51);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(350, 22);
            this.descriptionLabel.TabIndex = 31;
            this.descriptionLabel.Text = "Let\'s know you a little bit more";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.blobTreePictureBox);
            this.panel1.Controls.Add(this.numberTextBox);
            this.panel1.Controls.Add(this.numberLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Calibri", 13F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 311);
            this.panel1.TabIndex = 14;
            // 
            // blobTreePictureBox
            // 
            this.blobTreePictureBox.Location = new System.Drawing.Point(29, 67);
            this.blobTreePictureBox.Name = "blobTreePictureBox";
            this.blobTreePictureBox.Size = new System.Drawing.Size(708, 313);
            this.blobTreePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blobTreePictureBox.TabIndex = 55;
            this.blobTreePictureBox.TabStop = false;
            // 
            // numberTextBox
            // 
            this.numberTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numberTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.numberTextBox.Location = new System.Drawing.Point(29, 25);
            this.numberTextBox.MaxLength = 2;
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(670, 30);
            this.numberTextBox.TabIndex = 4;
            this.numberTextBox.TextChanged += new System.EventHandler(this.numberTextBox_TextChanged);
            this.numberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberTextBox_KeyPress);
            // 
            // numberLabel
            // 
            this.numberLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.numberLabel.Location = new System.Drawing.Point(25, 0);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(700, 25);
            this.numberLabel.TabIndex = 43;
            this.numberLabel.Text = "Please write a number from the drawing which represents you the most at the momen" +
    "t:\r\n";
            // 
            // breakTimeLabel
            // 
            this.breakTimeLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.breakTimeLabel.Location = new System.Drawing.Point(81, 10);
            this.breakTimeLabel.Name = "breakTimeLabel";
            this.breakTimeLabel.Size = new System.Drawing.Size(350, 33);
            this.breakTimeLabel.TabIndex = 30;
            this.breakTimeLabel.Text = "BREAK TIME";
            this.breakTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.statusPanel.Controls.Add(this.pictureBox1);
            this.statusPanel.Controls.Add(this.confirmAnswerButton);
            this.statusPanel.Controls.Add(this.descriptionLabel);
            this.statusPanel.Controls.Add(this.breakTimeLabel);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusPanel.Location = new System.Drawing.Point(0, 0);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(775, 83);
            this.statusPanel.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::ICAL_Final.Properties.Resources._6fereastra_cu_intrebarea_de_psihologie;
            this.pictureBox1.Location = new System.Drawing.Point(-32, -34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // bodyPanel
            // 
            this.bodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.bodyPanel.Controls.Add(this.panel1);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bodyPanel.Location = new System.Drawing.Point(0, 88);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(775, 311);
            this.bodyPanel.TabIndex = 47;
            // 
            // PsychologicalQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(775, 399);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.bodyPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PsychologicalQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student - Break Time";
            this.Load += new System.EventHandler(this.PsychologicalQuestionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blobTreePictureBox)).EndInit();
            this.statusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bodyPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button confirmAnswerButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox blobTreePictureBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label breakTimeLabel;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel bodyPanel;
    }
}