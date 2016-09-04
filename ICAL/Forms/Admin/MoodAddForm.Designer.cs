namespace ICAL_Final.Forms.Admin
{
    partial class MoodAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoodAddForm));
            this.statusPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.managementLabel = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.managementPanel = new System.Windows.Forms.Panel();
            this.moodComboBox = new System.Windows.Forms.ComboBox();
            this.uploadNewFaceButton = new System.Windows.Forms.Button();
            this.facePictureBox = new System.Windows.Forms.PictureBox();
            this.moodLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bodyPanel.SuspendLayout();
            this.managementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.statusPanel.Controls.Add(this.pictureBox1);
            this.statusPanel.Controls.Add(this.addButton);
            this.statusPanel.Controls.Add(this.descriptionLabel);
            this.statusPanel.Controls.Add(this.managementLabel);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusPanel.Location = new System.Drawing.Point(0, 0);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(697, 83);
            this.statusPanel.TabIndex = 48;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::ICAL_Final.Properties.Resources.ManagementIcon;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.descriptionLabel.Location = new System.Drawing.Point(81, 49);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(350, 22);
            this.descriptionLabel.TabIndex = 31;
            this.descriptionLabel.Text = "Add mood";
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
            this.bodyPanel.Controls.Add(this.managementPanel);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bodyPanel.Location = new System.Drawing.Point(0, 36);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(697, 312);
            this.bodyPanel.TabIndex = 47;
            // 
            // managementPanel
            // 
            this.managementPanel.AutoScroll = true;
            this.managementPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.managementPanel.Controls.Add(this.moodComboBox);
            this.managementPanel.Controls.Add(this.uploadNewFaceButton);
            this.managementPanel.Controls.Add(this.facePictureBox);
            this.managementPanel.Controls.Add(this.moodLabel);
            this.managementPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managementPanel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementPanel.Location = new System.Drawing.Point(0, 0);
            this.managementPanel.Name = "managementPanel";
            this.managementPanel.Size = new System.Drawing.Size(697, 312);
            this.managementPanel.TabIndex = 14;
            // 
            // moodComboBox
            // 
            this.moodComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "happy",
            "sad"});
            this.moodComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.moodComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.moodComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.moodComboBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moodComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.moodComboBox.FormattingEnabled = true;
            this.moodComboBox.Items.AddRange(new object[] {
            "happy",
            "sad"});
            this.moodComboBox.Location = new System.Drawing.Point(21, 76);
            this.moodComboBox.Name = "moodComboBox";
            this.moodComboBox.Size = new System.Drawing.Size(656, 31);
            this.moodComboBox.TabIndex = 63;
            this.moodComboBox.Text = "happy";
            // 
            // uploadNewFaceButton
            // 
            this.uploadNewFaceButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uploadNewFaceButton.FlatAppearance.BorderSize = 0;
            this.uploadNewFaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadNewFaceButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadNewFaceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.uploadNewFaceButton.Location = new System.Drawing.Point(164, 135);
            this.uploadNewFaceButton.Name = "uploadNewFaceButton";
            this.uploadNewFaceButton.Size = new System.Drawing.Size(180, 45);
            this.uploadNewFaceButton.TabIndex = 61;
            this.uploadNewFaceButton.Text = "Upload a new face";
            this.uploadNewFaceButton.UseVisualStyleBackColor = false;
            this.uploadNewFaceButton.Click += new System.EventHandler(this.uploadNewFaceButton_Click);
            // 
            // facePictureBox
            // 
            this.facePictureBox.Location = new System.Drawing.Point(403, 135);
            this.facePictureBox.Name = "facePictureBox";
            this.facePictureBox.Size = new System.Drawing.Size(139, 141);
            this.facePictureBox.TabIndex = 60;
            this.facePictureBox.TabStop = false;
            // 
            // moodLabel
            // 
            this.moodLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moodLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.moodLabel.Location = new System.Drawing.Point(33, 55);
            this.moodLabel.Name = "moodLabel";
            this.moodLabel.Size = new System.Drawing.Size(68, 29);
            this.moodLabel.TabIndex = 36;
            this.moodLabel.Text = "Mood";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(497, 21);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(180, 50);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add Mood";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // MoodAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(697, 348);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.bodyPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MoodAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - New Mood";
            this.statusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bodyPanel.ResumeLayout(false);
            this.managementPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.facePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label managementLabel;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel managementPanel;
        private System.Windows.Forms.Button uploadNewFaceButton;
        private System.Windows.Forms.PictureBox facePictureBox;
        private System.Windows.Forms.Label moodLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox moodComboBox;
    }
}