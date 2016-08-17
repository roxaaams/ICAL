namespace ICAL_Final.Forms.Student
{
    partial class AboutStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutStudentForm));
            this.statusPanel = new System.Windows.Forms.Panel();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.yourProfileLabel = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.avancedPictureBox = new System.Windows.Forms.PictureBox();
            this.intermediaryPictureBox = new System.Windows.Forms.PictureBox();
            this.beginnerPictureBox = new System.Windows.Forms.PictureBox();
            this.achievmentsLabel = new System.Windows.Forms.Label();
            this.totalScoreTextBox = new System.Windows.Forms.TextBox();
            this.totalScoreLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.updateProfilePanel = new System.Windows.Forms.Panel();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.confirmNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmNewPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            this.bodyPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avancedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intermediaryPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginnerPictureBox)).BeginInit();
            this.updateProfilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.statusPanel.Controls.Add(this.userPictureBox);
            this.statusPanel.Controls.Add(this.descriptionLabel);
            this.statusPanel.Controls.Add(this.yourProfileLabel);
            this.statusPanel.Location = new System.Drawing.Point(44, 12);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(700, 83);
            this.statusPanel.TabIndex = 48;
            // 
            // userPictureBox
            // 
            this.userPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userPictureBox.Image = global::ICAL_Final.Properties.Resources.ManagementIcon;
            this.userPictureBox.Location = new System.Drawing.Point(10, 10);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(63, 63);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPictureBox.TabIndex = 29;
            this.userPictureBox.TabStop = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Calibri", 13F);
            this.descriptionLabel.ForeColor = System.Drawing.Color.White;
            this.descriptionLabel.Location = new System.Drawing.Point(81, 49);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(350, 22);
            this.descriptionLabel.TabIndex = 31;
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // yourProfileLabel
            // 
            this.yourProfileLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourProfileLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.yourProfileLabel.Location = new System.Drawing.Point(79, 8);
            this.yourProfileLabel.Name = "yourProfileLabel";
            this.yourProfileLabel.Size = new System.Drawing.Size(350, 33);
            this.yourProfileLabel.TabIndex = 30;
            this.yourProfileLabel.Text = "YOUR PROFILE";
            this.yourProfileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bodyPanel
            // 
            this.bodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.bodyPanel.Controls.Add(this.panel2);
            this.bodyPanel.Controls.Add(this.saveButton);
            this.bodyPanel.Controls.Add(this.updateProfilePanel);
            this.bodyPanel.Location = new System.Drawing.Point(44, 101);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(700, 372);
            this.bodyPanel.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.avancedPictureBox);
            this.panel2.Controls.Add(this.intermediaryPictureBox);
            this.panel2.Controls.Add(this.beginnerPictureBox);
            this.panel2.Controls.Add(this.achievmentsLabel);
            this.panel2.Controls.Add(this.totalScoreTextBox);
            this.panel2.Controls.Add(this.totalScoreLabel);
            this.panel2.Font = new System.Drawing.Font("Calibri", 13F);
            this.panel2.Location = new System.Drawing.Point(363, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 369);
            this.panel2.TabIndex = 16;
            // 
            // avancedPictureBox
            // 
            this.avancedPictureBox.Location = new System.Drawing.Point(238, 141);
            this.avancedPictureBox.Name = "avancedPictureBox";
            this.avancedPictureBox.Size = new System.Drawing.Size(96, 180);
            this.avancedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avancedPictureBox.TabIndex = 40;
            this.avancedPictureBox.TabStop = false;
            // 
            // intermediaryPictureBox
            // 
            this.intermediaryPictureBox.Location = new System.Drawing.Point(130, 141);
            this.intermediaryPictureBox.Name = "intermediaryPictureBox";
            this.intermediaryPictureBox.Size = new System.Drawing.Size(96, 180);
            this.intermediaryPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.intermediaryPictureBox.TabIndex = 39;
            this.intermediaryPictureBox.TabStop = false;
            // 
            // beginnerPictureBox
            // 
            this.beginnerPictureBox.Location = new System.Drawing.Point(16, 141);
            this.beginnerPictureBox.Name = "beginnerPictureBox";
            this.beginnerPictureBox.Size = new System.Drawing.Size(96, 180);
            this.beginnerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.beginnerPictureBox.TabIndex = 38;
            this.beginnerPictureBox.TabStop = false;
            // 
            // achievmentsLabel
            // 
            this.achievmentsLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.achievmentsLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.achievmentsLabel.Location = new System.Drawing.Point(13, 114);
            this.achievmentsLabel.Name = "achievmentsLabel";
            this.achievmentsLabel.Size = new System.Drawing.Size(269, 22);
            this.achievmentsLabel.TabIndex = 37;
            this.achievmentsLabel.Text = "Trophies";
            // 
            // totalScoreTextBox
            // 
            this.totalScoreTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalScoreTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScoreTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.totalScoreTextBox.Location = new System.Drawing.Point(15, 38);
            this.totalScoreTextBox.MaxLength = 16;
            this.totalScoreTextBox.Name = "totalScoreTextBox";
            this.totalScoreTextBox.ReadOnly = true;
            this.totalScoreTextBox.Size = new System.Drawing.Size(295, 30);
            this.totalScoreTextBox.TabIndex = 2;
            // 
            // totalScoreLabel
            // 
            this.totalScoreLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalScoreLabel.ForeColor = System.Drawing.Color.White;
            this.totalScoreLabel.Location = new System.Drawing.Point(13, 9);
            this.totalScoreLabel.Name = "totalScoreLabel";
            this.totalScoreLabel.Size = new System.Drawing.Size(269, 22);
            this.totalScoreLabel.TabIndex = 36;
            this.totalScoreLabel.Text = "Total Score";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.saveButton.Location = new System.Drawing.Point(64, 314);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(180, 50);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // updateProfilePanel
            // 
            this.updateProfilePanel.AutoScroll = true;
            this.updateProfilePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.updateProfilePanel.Controls.Add(this.lastNameTextBox);
            this.updateProfilePanel.Controls.Add(this.lastNameLabel);
            this.updateProfilePanel.Controls.Add(this.firstNameTextBox);
            this.updateProfilePanel.Controls.Add(this.firstNameLabel);
            this.updateProfilePanel.Controls.Add(this.confirmNewPasswordTextBox);
            this.updateProfilePanel.Controls.Add(this.confirmNewPasswordLabel);
            this.updateProfilePanel.Controls.Add(this.newPasswordTextBox);
            this.updateProfilePanel.Controls.Add(this.newPasswordLabel);
            this.updateProfilePanel.Controls.Add(this.passwordTextBox);
            this.updateProfilePanel.Controls.Add(this.passwordLabel);
            this.updateProfilePanel.Font = new System.Drawing.Font("Calibri", 13F);
            this.updateProfilePanel.Location = new System.Drawing.Point(3, 3);
            this.updateProfilePanel.Name = "updateProfilePanel";
            this.updateProfilePanel.Size = new System.Drawing.Size(334, 295);
            this.updateProfilePanel.TabIndex = 14;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lastNameTextBox.Location = new System.Drawing.Point(16, 326);
            this.lastNameTextBox.MaxLength = 16;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(271, 30);
            this.lastNameTextBox.TabIndex = 46;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lastNameLabel.Location = new System.Drawing.Point(14, 299);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(269, 22);
            this.lastNameLabel.TabIndex = 47;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.firstNameTextBox.Location = new System.Drawing.Point(16, 254);
            this.firstNameTextBox.MaxLength = 16;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(269, 30);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.firstNameLabel.Location = new System.Drawing.Point(16, 227);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(269, 22);
            this.firstNameLabel.TabIndex = 45;
            this.firstNameLabel.Text = "First Name";
            // 
            // confirmNewPasswordTextBox
            // 
            this.confirmNewPasswordTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.confirmNewPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmNewPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.confirmNewPasswordTextBox.Location = new System.Drawing.Point(16, 184);
            this.confirmNewPasswordTextBox.MaxLength = 32;
            this.confirmNewPasswordTextBox.Name = "confirmNewPasswordTextBox";
            this.confirmNewPasswordTextBox.Size = new System.Drawing.Size(269, 30);
            this.confirmNewPasswordTextBox.TabIndex = 4;
            this.confirmNewPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // confirmNewPasswordLabel
            // 
            this.confirmNewPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmNewPasswordLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.confirmNewPasswordLabel.Location = new System.Drawing.Point(16, 157);
            this.confirmNewPasswordLabel.Name = "confirmNewPasswordLabel";
            this.confirmNewPasswordLabel.Size = new System.Drawing.Size(269, 22);
            this.confirmNewPasswordLabel.TabIndex = 43;
            this.confirmNewPasswordLabel.Text = "Confirm New Password";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.newPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.newPasswordTextBox.Location = new System.Drawing.Point(16, 106);
            this.newPasswordTextBox.MaxLength = 32;
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.PasswordChar = '•';
            this.newPasswordTextBox.Size = new System.Drawing.Size(271, 30);
            this.newPasswordTextBox.TabIndex = 3;
            this.newPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.newPasswordLabel.Location = new System.Drawing.Point(18, 79);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(269, 22);
            this.newPasswordLabel.TabIndex = 38;
            this.newPasswordLabel.Text = "New Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.passwordTextBox.Location = new System.Drawing.Point(16, 36);
            this.passwordTextBox.MaxLength = 16;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(271, 30);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.passwordLabel.Location = new System.Drawing.Point(18, 9);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(269, 22);
            this.passwordLabel.TabIndex = 36;
            this.passwordLabel.Text = "Password";
            // 
            // AboutStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(783, 477);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.bodyPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AboutStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student - Edit Profile";
            this.Load += new System.EventHandler(this.AboutStudentForm_Load);
            this.statusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            this.bodyPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avancedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intermediaryPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginnerPictureBox)).EndInit();
            this.updateProfilePanel.ResumeLayout(false);
            this.updateProfilePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label yourProfileLabel;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel updateProfilePanel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox confirmNewPasswordTextBox;
        private System.Windows.Forms.Label confirmNewPasswordLabel;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox totalScoreTextBox;
        private System.Windows.Forms.Label totalScoreLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.PictureBox avancedPictureBox;
        private System.Windows.Forms.PictureBox intermediaryPictureBox;
        private System.Windows.Forms.PictureBox beginnerPictureBox;
        private System.Windows.Forms.Label achievmentsLabel;
    }
}