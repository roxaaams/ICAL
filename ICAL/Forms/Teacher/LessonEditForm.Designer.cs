namespace ICAL_Final.Forms.Teacher
{
    partial class LessonEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LessonEditForm));
            this.lessonRichTextBox = new System.Windows.Forms.RichTextBox();
            this.chapterComboBox = new System.Windows.Forms.ComboBox();
            this.chapterLabel = new System.Windows.Forms.Label();
            this.uploadNewPictureButton = new System.Windows.Forms.Button();
            this.newPictureBox = new System.Windows.Forms.PictureBox();
            this.lessonLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.managementLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.managementPanel = new System.Windows.Forms.Panel();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.fontToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.boldToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.italicToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.underlineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.strikeOutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.foreColorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.backColorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.leftAlignToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.centerAlignToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.rightAlignToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.newPictureBox)).BeginInit();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.managementPanel.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lessonRichTextBox
            // 
            this.lessonRichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lessonRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lessonRichTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lessonRichTextBox.Location = new System.Drawing.Point(10, 59);
            this.lessonRichTextBox.Name = "lessonRichTextBox";
            this.lessonRichTextBox.Size = new System.Drawing.Size(649, 291);
            this.lessonRichTextBox.TabIndex = 64;
            this.lessonRichTextBox.Text = "";
            // 
            // chapterComboBox
            // 
            this.chapterComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4"});
            this.chapterComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chapterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chapterComboBox.Enabled = false;
            this.chapterComboBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.chapterComboBox.FormattingEnabled = true;
            this.chapterComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.chapterComboBox.Location = new System.Drawing.Point(19, 31);
            this.chapterComboBox.Name = "chapterComboBox";
            this.chapterComboBox.Size = new System.Drawing.Size(293, 31);
            this.chapterComboBox.TabIndex = 62;
            // 
            // chapterLabel
            // 
            this.chapterLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chapterLabel.Location = new System.Drawing.Point(29, 3);
            this.chapterLabel.Name = "chapterLabel";
            this.chapterLabel.Size = new System.Drawing.Size(520, 22);
            this.chapterLabel.TabIndex = 63;
            this.chapterLabel.Text = "Chapter";
            // 
            // uploadNewPictureButton
            // 
            this.uploadNewPictureButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.uploadNewPictureButton.FlatAppearance.BorderSize = 0;
            this.uploadNewPictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadNewPictureButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadNewPictureButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.uploadNewPictureButton.Location = new System.Drawing.Point(19, 157);
            this.uploadNewPictureButton.Name = "uploadNewPictureButton";
            this.uploadNewPictureButton.Size = new System.Drawing.Size(201, 45);
            this.uploadNewPictureButton.TabIndex = 61;
            this.uploadNewPictureButton.Text = "Upload a new picture";
            this.uploadNewPictureButton.UseVisualStyleBackColor = false;
            this.uploadNewPictureButton.Click += new System.EventHandler(this.uploadNewPictureButton_Click);
            // 
            // newPictureBox
            // 
            this.newPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.newPictureBox.Location = new System.Drawing.Point(11, 208);
            this.newPictureBox.Name = "newPictureBox";
            this.newPictureBox.Size = new System.Drawing.Size(293, 146);
            this.newPictureBox.TabIndex = 60;
            this.newPictureBox.TabStop = false;
            // 
            // lessonLabel
            // 
            this.lessonLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lessonLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lessonLabel.Location = new System.Drawing.Point(23, 34);
            this.lessonLabel.Name = "lessonLabel";
            this.lessonLabel.Size = new System.Drawing.Size(369, 22);
            this.lessonLabel.TabIndex = 45;
            this.lessonLabel.Text = "Lesson";
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.titleTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.titleTextBox.Location = new System.Drawing.Point(19, 102);
            this.titleTextBox.MaxLength = 32;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(293, 30);
            this.titleTextBox.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.descriptionLabel.Location = new System.Drawing.Point(81, 49);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(350, 22);
            this.descriptionLabel.TabIndex = 31;
            this.descriptionLabel.Text = "Edit lesson ";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.statusPanel.Controls.Add(this.deleteButton);
            this.statusPanel.Controls.Add(this.pictureBox1);
            this.statusPanel.Controls.Add(this.descriptionLabel);
            this.statusPanel.Controls.Add(this.saveButton);
            this.statusPanel.Controls.Add(this.managementLabel);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusPanel.Location = new System.Drawing.Point(0, 0);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(1007, 83);
            this.statusPanel.TabIndex = 50;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(815, 23);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(180, 50);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete Lesson";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::ICAL_Final.Properties.Resources._4_editare_lectii;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(603, 23);
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
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.titleLabel.Location = new System.Drawing.Point(29, 77);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(520, 22);
            this.titleLabel.TabIndex = 38;
            this.titleLabel.Text = "Title";
            // 
            // managementPanel
            // 
            this.managementPanel.AutoScroll = true;
            this.managementPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.managementPanel.Controls.Add(this.chapterComboBox);
            this.managementPanel.Controls.Add(this.chapterLabel);
            this.managementPanel.Controls.Add(this.uploadNewPictureButton);
            this.managementPanel.Controls.Add(this.newPictureBox);
            this.managementPanel.Controls.Add(this.titleTextBox);
            this.managementPanel.Controls.Add(this.titleLabel);
            this.managementPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.managementPanel.Font = new System.Drawing.Font("Calibri", 13F);
            this.managementPanel.Location = new System.Drawing.Point(665, 0);
            this.managementPanel.Name = "managementPanel";
            this.managementPanel.Size = new System.Drawing.Size(342, 362);
            this.managementPanel.TabIndex = 14;
            // 
            // bodyPanel
            // 
            this.bodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.bodyPanel.Controls.Add(this.toolStrip);
            this.bodyPanel.Controls.Add(this.lessonRichTextBox);
            this.bodyPanel.Controls.Add(this.managementPanel);
            this.bodyPanel.Controls.Add(this.lessonLabel);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bodyPanel.Location = new System.Drawing.Point(0, 89);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1007, 362);
            this.bodyPanel.TabIndex = 49;
            // 
            // toolStrip
            // 
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripButton,
            this.toolStripSeparator1,
            this.boldToolStripButton,
            this.italicToolStripButton,
            this.underlineToolStripButton,
            this.strikeOutToolStripButton,
            this.toolStripSeparator2,
            this.foreColorToolStripButton,
            this.backColorToolStripButton,
            this.toolStripSeparator3,
            this.leftAlignToolStripButton,
            this.centerAlignToolStripButton,
            this.rightAlignToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.toolStrip.Size = new System.Drawing.Size(665, 25);
            this.toolStrip.TabIndex = 66;
            this.toolStrip.Text = "toolStrip1";
            // 
            // fontToolStripButton
            // 
            this.fontToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.fontToolStripButton.BackgroundImage = global::ICAL_Final.Properties.Resources.format_text;
            this.fontToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fontToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fontToolStripButton.Image")));
            this.fontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fontToolStripButton.Name = "fontToolStripButton";
            this.fontToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.fontToolStripButton.Tag = "Font";
            this.fontToolStripButton.Click += new System.EventHandler(this.fontToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // boldToolStripButton
            // 
            this.boldToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.boldToolStripButton.BackgroundImage = global::ICAL_Final.Properties.Resources.format_bold;
            this.boldToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boldToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.boldToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("boldToolStripButton.Image")));
            this.boldToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.boldToolStripButton.Name = "boldToolStripButton";
            this.boldToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.boldToolStripButton.Tag = "Bold";
            this.boldToolStripButton.Click += new System.EventHandler(this.fontStyleToolStripButton_Click);
            // 
            // italicToolStripButton
            // 
            this.italicToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.italicToolStripButton.BackgroundImage = global::ICAL_Final.Properties.Resources.format_italic;
            this.italicToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.italicToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.italicToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("italicToolStripButton.Image")));
            this.italicToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.italicToolStripButton.Name = "italicToolStripButton";
            this.italicToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.italicToolStripButton.Tag = "Italic";
            this.italicToolStripButton.Click += new System.EventHandler(this.fontStyleToolStripButton_Click);
            // 
            // underlineToolStripButton
            // 
            this.underlineToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.underlineToolStripButton.BackgroundImage = global::ICAL_Final.Properties.Resources.format_underline;
            this.underlineToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.underlineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.underlineToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("underlineToolStripButton.Image")));
            this.underlineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.underlineToolStripButton.Name = "underlineToolStripButton";
            this.underlineToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.underlineToolStripButton.Tag = "Underline";
            this.underlineToolStripButton.Click += new System.EventHandler(this.fontStyleToolStripButton_Click);
            // 
            // strikeOutToolStripButton
            // 
            this.strikeOutToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.strikeOutToolStripButton.BackgroundImage = global::ICAL_Final.Properties.Resources.format_strikethrough;
            this.strikeOutToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.strikeOutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.strikeOutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("strikeOutToolStripButton.Image")));
            this.strikeOutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strikeOutToolStripButton.Name = "strikeOutToolStripButton";
            this.strikeOutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.strikeOutToolStripButton.Tag = "Strikeout";
            this.strikeOutToolStripButton.Click += new System.EventHandler(this.fontStyleToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // foreColorToolStripButton
            // 
            this.foreColorToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.foreColorToolStripButton.BackgroundImage = global::ICAL_Final.Properties.Resources.format_color_text;
            this.foreColorToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.foreColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.foreColorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("foreColorToolStripButton.Image")));
            this.foreColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.foreColorToolStripButton.Name = "foreColorToolStripButton";
            this.foreColorToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.foreColorToolStripButton.Tag = "Fore color";
            this.foreColorToolStripButton.Click += new System.EventHandler(this.colorToolStripButton_Click);
            // 
            // backColorToolStripButton
            // 
            this.backColorToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.backColorToolStripButton.BackgroundImage = global::ICAL_Final.Properties.Resources.format_color_fill;
            this.backColorToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.backColorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("backColorToolStripButton.Image")));
            this.backColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backColorToolStripButton.Name = "backColorToolStripButton";
            this.backColorToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.backColorToolStripButton.Tag = "Back color";
            this.backColorToolStripButton.Click += new System.EventHandler(this.colorToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // leftAlignToolStripButton
            // 
            this.leftAlignToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.leftAlignToolStripButton.BackgroundImage = global::ICAL_Final.Properties.Resources.format_align_left;
            this.leftAlignToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.leftAlignToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.leftAlignToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("leftAlignToolStripButton.Image")));
            this.leftAlignToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.leftAlignToolStripButton.Name = "leftAlignToolStripButton";
            this.leftAlignToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.leftAlignToolStripButton.Tag = "Left";
            this.leftAlignToolStripButton.Click += new System.EventHandler(this.alignToolStripButton_Click);
            // 
            // centerAlignToolStripButton
            // 
            this.centerAlignToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.centerAlignToolStripButton.BackgroundImage = global::ICAL_Final.Properties.Resources.format_align_center;
            this.centerAlignToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.centerAlignToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.centerAlignToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("centerAlignToolStripButton.Image")));
            this.centerAlignToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.centerAlignToolStripButton.Name = "centerAlignToolStripButton";
            this.centerAlignToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.centerAlignToolStripButton.Tag = "Center";
            this.centerAlignToolStripButton.Click += new System.EventHandler(this.alignToolStripButton_Click);
            // 
            // rightAlignToolStripButton
            // 
            this.rightAlignToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.rightAlignToolStripButton.BackgroundImage = global::ICAL_Final.Properties.Resources.format_align_right;
            this.rightAlignToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightAlignToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rightAlignToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("rightAlignToolStripButton.Image")));
            this.rightAlignToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightAlignToolStripButton.Name = "rightAlignToolStripButton";
            this.rightAlignToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.rightAlignToolStripButton.Tag = "Right";
            this.rightAlignToolStripButton.Click += new System.EventHandler(this.alignToolStripButton_Click);
            // 
            // LessonEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1007, 451);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.bodyPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LessonEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher - Edit User";
            this.Load += new System.EventHandler(this.LessonEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.newPictureBox)).EndInit();
            this.statusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.managementPanel.ResumeLayout(false);
            this.managementPanel.PerformLayout();
            this.bodyPanel.ResumeLayout(false);
            this.bodyPanel.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox lessonRichTextBox;
        private System.Windows.Forms.ComboBox chapterComboBox;
        private System.Windows.Forms.Label chapterLabel;
        private System.Windows.Forms.Button uploadNewPictureButton;
        private System.Windows.Forms.PictureBox newPictureBox;
        private System.Windows.Forms.Label lessonLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label managementLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel managementPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton fontToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton boldToolStripButton;
        private System.Windows.Forms.ToolStripButton italicToolStripButton;
        private System.Windows.Forms.ToolStripButton underlineToolStripButton;
        private System.Windows.Forms.ToolStripButton strikeOutToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton foreColorToolStripButton;
        private System.Windows.Forms.ToolStripButton backColorToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton leftAlignToolStripButton;
        private System.Windows.Forms.ToolStripButton centerAlignToolStripButton;
        private System.Windows.Forms.ToolStripButton rightAlignToolStripButton;
    }
}