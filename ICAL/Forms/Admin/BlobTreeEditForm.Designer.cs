namespace ICAL_Final.Forms.Admin
{
    partial class BlobTreeEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlobTreeEditForm));
            this.statusPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.managementLabel = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.managementPanel = new System.Windows.Forms.Panel();
            this.uploadNewBlobTreeButton = new System.Windows.Forms.Button();
            this.blobTreePictureBox = new System.Windows.Forms.PictureBox();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.bodyPanel.SuspendLayout();
            this.managementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blobTreePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.statusPanel.Controls.Add(this.deleteButton);
            this.statusPanel.Controls.Add(this.logoPictureBox);
            this.statusPanel.Controls.Add(this.descriptionLabel);
            this.statusPanel.Controls.Add(this.saveButton);
            this.statusPanel.Controls.Add(this.managementLabel);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusPanel.Location = new System.Drawing.Point(0, 0);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(775, 83);
            this.statusPanel.TabIndex = 48;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(583, 21);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(180, 50);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete Blob Tree";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoPictureBox.Image = global::ICAL_Final.Properties.Resources.ManagementIcon;
            this.logoPictureBox.Location = new System.Drawing.Point(10, 10);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(63, 63);
            this.logoPictureBox.TabIndex = 29;
            this.logoPictureBox.TabStop = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.descriptionLabel.Location = new System.Drawing.Point(81, 49);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(178, 22);
            this.descriptionLabel.TabIndex = 31;
            this.descriptionLabel.Text = "Edit blob tree ";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(378, 21);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(180, 50);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
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
            this.bodyPanel.Location = new System.Drawing.Point(0, 89);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(775, 302);
            this.bodyPanel.TabIndex = 47;
            // 
            // managementPanel
            // 
            this.managementPanel.AutoScroll = true;
            this.managementPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.managementPanel.Controls.Add(this.uploadNewBlobTreeButton);
            this.managementPanel.Controls.Add(this.blobTreePictureBox);
            this.managementPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managementPanel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementPanel.Location = new System.Drawing.Point(0, 0);
            this.managementPanel.Name = "managementPanel";
            this.managementPanel.Size = new System.Drawing.Size(775, 302);
            this.managementPanel.TabIndex = 14;
            // 
            // uploadNewBlobTreeButton
            // 
            this.uploadNewBlobTreeButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uploadNewBlobTreeButton.FlatAppearance.BorderSize = 0;
            this.uploadNewBlobTreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadNewBlobTreeButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadNewBlobTreeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.uploadNewBlobTreeButton.Location = new System.Drawing.Point(10, 17);
            this.uploadNewBlobTreeButton.Name = "uploadNewBlobTreeButton";
            this.uploadNewBlobTreeButton.Size = new System.Drawing.Size(212, 56);
            this.uploadNewBlobTreeButton.TabIndex = 63;
            this.uploadNewBlobTreeButton.Text = "Upload a new blob tree";
            this.uploadNewBlobTreeButton.UseVisualStyleBackColor = false;
            this.uploadNewBlobTreeButton.Click += new System.EventHandler(this.uploadNewBlobTreeButton_Click);
            // 
            // blobTreePictureBox
            // 
            this.blobTreePictureBox.Location = new System.Drawing.Point(228, 17);
            this.blobTreePictureBox.Name = "blobTreePictureBox";
            this.blobTreePictureBox.Size = new System.Drawing.Size(535, 273);
            this.blobTreePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blobTreePictureBox.TabIndex = 62;
            this.blobTreePictureBox.TabStop = false;
            // 
            // BlobTreeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(775, 391);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.bodyPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BlobTreeEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Edit Blob Tree";
            this.Load += new System.EventHandler(this.BlobTreeEditForm_Load);
            this.statusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.bodyPanel.ResumeLayout(false);
            this.managementPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.blobTreePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label managementLabel;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel managementPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button uploadNewBlobTreeButton;
        private System.Windows.Forms.PictureBox blobTreePictureBox;
    }
}