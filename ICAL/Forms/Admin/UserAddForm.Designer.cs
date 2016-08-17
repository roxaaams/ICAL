namespace ICAL_Final.Forms.Admin
{
    partial class UserAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAddForm));
            this.addButton = new System.Windows.Forms.Button();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.managementLabel = new System.Windows.Forms.Label();
            this.managementPanel = new System.Windows.Forms.Panel();
            this.uploadNewFaceButton = new System.Windows.Forms.Button();
            this.facePictureBox = new System.Windows.Forms.PictureBox();
            this.studentRadioButton = new System.Windows.Forms.RadioButton();
            this.teacherRadioButton = new System.Windows.Forms.RadioButton();
            this.administratorRadioButton = new System.Windows.Forms.RadioButton();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.managementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facePictureBox)).BeginInit();
            this.bodyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(262, 228);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(180, 50);
            this.addButton.TabIndex = 9;
            this.addButton.Text = "Add User";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lastNameTextBox.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lastNameTextBox.Location = new System.Drawing.Point(85, 256);
            this.lastNameTextBox.MaxLength = 16;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(522, 29);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.statusPanel.Controls.Add(this.pictureBox1);
            this.statusPanel.Controls.Add(this.descriptionLabel);
            this.statusPanel.Controls.Add(this.managementLabel);
            this.statusPanel.Location = new System.Drawing.Point(36, 12);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(700, 83);
            this.statusPanel.TabIndex = 46;
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
            this.descriptionLabel.Text = "Add user";
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
            // managementPanel
            // 
            this.managementPanel.AutoScroll = true;
            this.managementPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.managementPanel.Controls.Add(this.uploadNewFaceButton);
            this.managementPanel.Controls.Add(this.facePictureBox);
            this.managementPanel.Controls.Add(this.studentRadioButton);
            this.managementPanel.Controls.Add(this.teacherRadioButton);
            this.managementPanel.Controls.Add(this.administratorRadioButton);
            this.managementPanel.Controls.Add(this.lastNameTextBox);
            this.managementPanel.Controls.Add(this.lastNameLabel);
            this.managementPanel.Controls.Add(this.firstNameTextBox);
            this.managementPanel.Controls.Add(this.firstNameLabel);
            this.managementPanel.Controls.Add(this.passwordTextBox);
            this.managementPanel.Controls.Add(this.passwordLabel);
            this.managementPanel.Controls.Add(this.usernameTextBox);
            this.managementPanel.Controls.Add(this.usernameLabel);
            this.managementPanel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementPanel.Location = new System.Drawing.Point(3, 3);
            this.managementPanel.Name = "managementPanel";
            this.managementPanel.Size = new System.Drawing.Size(694, 207);
            this.managementPanel.TabIndex = 14;
            // 
            // uploadNewFaceButton
            // 
            this.uploadNewFaceButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uploadNewFaceButton.FlatAppearance.BorderSize = 0;
            this.uploadNewFaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadNewFaceButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadNewFaceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.uploadNewFaceButton.Location = new System.Drawing.Point(82, 338);
            this.uploadNewFaceButton.Name = "uploadNewFaceButton";
            this.uploadNewFaceButton.Size = new System.Drawing.Size(180, 45);
            this.uploadNewFaceButton.TabIndex = 61;
            this.uploadNewFaceButton.Text = "Upload a new face";
            this.uploadNewFaceButton.UseVisualStyleBackColor = false;
            this.uploadNewFaceButton.Click += new System.EventHandler(this.uploadNewFaceButton_Click);
            // 
            // facePictureBox
            // 
            this.facePictureBox.Location = new System.Drawing.Point(469, 338);
            this.facePictureBox.Name = "facePictureBox";
            this.facePictureBox.Size = new System.Drawing.Size(136, 141);
            this.facePictureBox.TabIndex = 60;
            this.facePictureBox.TabStop = false;
            // 
            // studentRadioButton
            // 
            this.studentRadioButton.AutoSize = true;
            this.studentRadioButton.Checked = true;
            this.studentRadioButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.studentRadioButton.Location = new System.Drawing.Point(518, 294);
            this.studentRadioButton.Name = "studentRadioButton";
            this.studentRadioButton.Size = new System.Drawing.Size(88, 27);
            this.studentRadioButton.TabIndex = 59;
            this.studentRadioButton.TabStop = true;
            this.studentRadioButton.Tag = "2";
            this.studentRadioButton.Text = "Student";
            this.studentRadioButton.UseVisualStyleBackColor = true;
            // 
            // teacherRadioButton
            // 
            this.teacherRadioButton.AutoSize = true;
            this.teacherRadioButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.teacherRadioButton.Location = new System.Drawing.Point(303, 294);
            this.teacherRadioButton.Name = "teacherRadioButton";
            this.teacherRadioButton.Size = new System.Drawing.Size(88, 27);
            this.teacherRadioButton.TabIndex = 58;
            this.teacherRadioButton.Tag = "1";
            this.teacherRadioButton.Text = "Teacher";
            this.teacherRadioButton.UseVisualStyleBackColor = true;
            // 
            // administratorRadioButton
            // 
            this.administratorRadioButton.AutoSize = true;
            this.administratorRadioButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.administratorRadioButton.Location = new System.Drawing.Point(82, 294);
            this.administratorRadioButton.Name = "administratorRadioButton";
            this.administratorRadioButton.Size = new System.Drawing.Size(132, 27);
            this.administratorRadioButton.TabIndex = 57;
            this.administratorRadioButton.Tag = "0";
            this.administratorRadioButton.Text = "Administrator";
            this.administratorRadioButton.UseVisualStyleBackColor = true;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.White;
            this.lastNameLabel.Location = new System.Drawing.Point(85, 229);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(520, 22);
            this.lastNameLabel.TabIndex = 45;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.firstNameTextBox.Location = new System.Drawing.Point(85, 186);
            this.firstNameTextBox.MaxLength = 32;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(522, 30);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.firstNameLabel.Location = new System.Drawing.Point(85, 159);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(520, 22);
            this.firstNameLabel.TabIndex = 43;
            this.firstNameLabel.Text = "First Name";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.passwordTextBox.Location = new System.Drawing.Point(87, 108);
            this.passwordTextBox.MaxLength = 32;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '•';
            this.passwordTextBox.Size = new System.Drawing.Size(520, 30);
            this.passwordTextBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.passwordLabel.Location = new System.Drawing.Point(87, 81);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(520, 22);
            this.passwordLabel.TabIndex = 38;
            this.passwordLabel.Text = "Password";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.usernameTextBox.Location = new System.Drawing.Point(87, 38);
            this.usernameTextBox.MaxLength = 16;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(520, 30);
            this.usernameTextBox.TabIndex = 2;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.usernameLabel.Location = new System.Drawing.Point(87, 11);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(520, 22);
            this.usernameLabel.TabIndex = 36;
            this.usernameLabel.Text = "Username";
            // 
            // bodyPanel
            // 
            this.bodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.bodyPanel.Controls.Add(this.managementPanel);
            this.bodyPanel.Controls.Add(this.addButton);
            this.bodyPanel.Location = new System.Drawing.Point(36, 101);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(700, 372);
            this.bodyPanel.TabIndex = 45;
            // 
            // UserAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(775, 391);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.bodyPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UserAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - New User";
            this.statusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.managementPanel.ResumeLayout(false);
            this.managementPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facePictureBox)).EndInit();
            this.bodyPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label managementLabel;
        private System.Windows.Forms.Panel managementPanel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Button uploadNewFaceButton;
        private System.Windows.Forms.PictureBox facePictureBox;
        private System.Windows.Forms.RadioButton studentRadioButton;
        private System.Windows.Forms.RadioButton teacherRadioButton;
        private System.Windows.Forms.RadioButton administratorRadioButton;
    }
}