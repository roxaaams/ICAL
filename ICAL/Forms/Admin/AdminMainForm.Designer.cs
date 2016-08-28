namespace ICAL_Final.Forms.Admin
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.headerLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.dashboardPanel = new System.Windows.Forms.Panel();
            this.addMoodButton = new System.Windows.Forms.Button();
            this.viewMoodsButton = new System.Windows.Forms.Button();
            this.viewBlobTreesButton = new System.Windows.Forms.Button();
            this.addNewBlobTreeButton = new System.Windows.Forms.Button();
            this.viewUsersButton = new System.Windows.Forms.Button();
            this.addNewUserButton = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.headerLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.dashboardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.headerLayoutPanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1022, 70);
            this.panel2.TabIndex = 3;
            // 
            // headerLayoutPanel
            // 
            this.headerLayoutPanel.ColumnCount = 4;
            this.headerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.264462F));
            this.headerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.73553F));
            this.headerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.headerLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.headerLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.headerLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.headerLayoutPanel.Name = "headerLayoutPanel";
            this.headerLayoutPanel.RowCount = 1;
            this.headerLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.headerLayoutPanel.Size = new System.Drawing.Size(1022, 70);
            this.headerLayoutPanel.TabIndex = 3;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = global::ICAL_Final.Properties.Resources._7_aplicatie_iconita;
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(64, 64);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.AutoScroll = true;
            this.dashboardPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dashboardPanel.Controls.Add(this.addMoodButton);
            this.dashboardPanel.Controls.Add(this.viewMoodsButton);
            this.dashboardPanel.Controls.Add(this.viewBlobTreesButton);
            this.dashboardPanel.Controls.Add(this.addNewBlobTreeButton);
            this.dashboardPanel.Controls.Add(this.viewUsersButton);
            this.dashboardPanel.Controls.Add(this.addNewUserButton);
            this.dashboardPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboardPanel.Location = new System.Drawing.Point(0, 70);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(109, 435);
            this.dashboardPanel.TabIndex = 4;
            // 
            // addMoodButton
            // 
            this.addMoodButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.addMoodButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addMoodButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addMoodButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.addMoodButton.FlatAppearance.BorderSize = 2;
            this.addMoodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMoodButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMoodButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addMoodButton.Location = new System.Drawing.Point(0, 353);
            this.addMoodButton.Name = "addMoodButton";
            this.addMoodButton.Size = new System.Drawing.Size(109, 73);
            this.addMoodButton.TabIndex = 41;
            this.addMoodButton.Tag = "2";
            this.addMoodButton.Text = "Add New Mood";
            this.addMoodButton.UseVisualStyleBackColor = false;
            this.addMoodButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // viewMoodsButton
            // 
            this.viewMoodsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.viewMoodsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewMoodsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewMoodsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.viewMoodsButton.FlatAppearance.BorderSize = 2;
            this.viewMoodsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewMoodsButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewMoodsButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.viewMoodsButton.Location = new System.Drawing.Point(0, 280);
            this.viewMoodsButton.Name = "viewMoodsButton";
            this.viewMoodsButton.Size = new System.Drawing.Size(109, 73);
            this.viewMoodsButton.TabIndex = 40;
            this.viewMoodsButton.Tag = "2";
            this.viewMoodsButton.Text = "View Moods\r\n";
            this.viewMoodsButton.UseVisualStyleBackColor = false;
            this.viewMoodsButton.Click += new System.EventHandler(this.viewDataButton_Click);
            // 
            // viewBlobTreesButton
            // 
            this.viewBlobTreesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.viewBlobTreesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewBlobTreesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewBlobTreesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.viewBlobTreesButton.FlatAppearance.BorderSize = 2;
            this.viewBlobTreesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewBlobTreesButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewBlobTreesButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.viewBlobTreesButton.Location = new System.Drawing.Point(0, 207);
            this.viewBlobTreesButton.Name = "viewBlobTreesButton";
            this.viewBlobTreesButton.Size = new System.Drawing.Size(109, 73);
            this.viewBlobTreesButton.TabIndex = 39;
            this.viewBlobTreesButton.Tag = "1";
            this.viewBlobTreesButton.Text = "View Blob Trees";
            this.viewBlobTreesButton.UseVisualStyleBackColor = false;
            this.viewBlobTreesButton.Click += new System.EventHandler(this.viewDataButton_Click);
            // 
            // addNewBlobTreeButton
            // 
            this.addNewBlobTreeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.addNewBlobTreeButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addNewBlobTreeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.addNewBlobTreeButton.FlatAppearance.BorderSize = 2;
            this.addNewBlobTreeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewBlobTreeButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBlobTreeButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addNewBlobTreeButton.Location = new System.Drawing.Point(0, 138);
            this.addNewBlobTreeButton.Name = "addNewBlobTreeButton";
            this.addNewBlobTreeButton.Size = new System.Drawing.Size(109, 69);
            this.addNewBlobTreeButton.TabIndex = 38;
            this.addNewBlobTreeButton.Tag = "1";
            this.addNewBlobTreeButton.Text = "Add New Blob Tree";
            this.addNewBlobTreeButton.UseVisualStyleBackColor = false;
            this.addNewBlobTreeButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // viewUsersButton
            // 
            this.viewUsersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.viewUsersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viewUsersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.viewUsersButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.viewUsersButton.FlatAppearance.BorderSize = 2;
            this.viewUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewUsersButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewUsersButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.viewUsersButton.Location = new System.Drawing.Point(0, 69);
            this.viewUsersButton.Name = "viewUsersButton";
            this.viewUsersButton.Size = new System.Drawing.Size(109, 69);
            this.viewUsersButton.TabIndex = 35;
            this.viewUsersButton.Tag = "0";
            this.viewUsersButton.Text = "View Users";
            this.viewUsersButton.UseVisualStyleBackColor = false;
            this.viewUsersButton.Click += new System.EventHandler(this.viewDataButton_Click);
            // 
            // addNewUserButton
            // 
            this.addNewUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.addNewUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addNewUserButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.addNewUserButton.FlatAppearance.BorderSize = 2;
            this.addNewUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewUserButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewUserButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.addNewUserButton.Location = new System.Drawing.Point(0, 0);
            this.addNewUserButton.Name = "addNewUserButton";
            this.addNewUserButton.Size = new System.Drawing.Size(109, 69);
            this.addNewUserButton.TabIndex = 33;
            this.addNewUserButton.Tag = "0";
            this.addNewUserButton.Text = "Add New User";
            this.addNewUserButton.UseVisualStyleBackColor = false;
            this.addNewUserButton.Click += new System.EventHandler(this.addDataButton_Click);
            // 
            // dataView
            // 
            this.dataView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataView.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dataView.Location = new System.Drawing.Point(109, 70);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(913, 435);
            this.dataView.TabIndex = 5;
            this.dataView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataView_MouseDoubleClick);
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 505);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.dashboardPanel);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin - Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.AdminMainForm_Shown);
            this.panel2.ResumeLayout(false);
            this.headerLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.dashboardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel dashboardPanel;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button addNewUserButton;
        private System.Windows.Forms.TableLayoutPanel headerLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Button viewUsersButton;
        private System.Windows.Forms.Button addNewBlobTreeButton;
        private System.Windows.Forms.Button viewBlobTreesButton;
        private System.Windows.Forms.Button addMoodButton;
        private System.Windows.Forms.Button viewMoodsButton;
    }
}