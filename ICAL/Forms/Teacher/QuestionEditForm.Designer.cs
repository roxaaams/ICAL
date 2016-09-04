namespace ICAL_Final.Forms.Teacher
{
    partial class QuestionEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionEditForm));
            this.statusPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.managementLabel = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.managementPanel = new System.Windows.Forms.Panel();
            this.questionRichTextBox = new System.Windows.Forms.RichTextBox();
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
            this.thirdAnsRadioButton = new System.Windows.Forms.RadioButton();
            this.secondAnsRadioButton = new System.Windows.Forms.RadioButton();
            this.firstAnsRadioButton = new System.Windows.Forms.RadioButton();
            this.chapterComboBox = new System.Windows.Forms.ComboBox();
            this.thirdAnswerLabel = new System.Windows.Forms.Label();
            this.chapterLabel = new System.Windows.Forms.Label();
            this.thirdAnswerTextBox = new System.Windows.Forms.TextBox();
            this.secondAnswerLabel = new System.Windows.Forms.Label();
            this.secondAnswerTextBox = new System.Windows.Forms.TextBox();
            this.firstAnswerLabel = new System.Windows.Forms.Label();
            this.firstAnswerTextBox = new System.Windows.Forms.TextBox();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.statusPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.bodyPanel.SuspendLayout();
            this.managementPanel.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.statusPanel.Controls.Add(this.deleteButton);
            this.statusPanel.Controls.Add(this.logoBox);
            this.statusPanel.Controls.Add(this.descriptionLabel);
            this.statusPanel.Controls.Add(this.saveButton);
            this.statusPanel.Controls.Add(this.managementLabel);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusPanel.Location = new System.Drawing.Point(0, 0);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(1007, 83);
            this.statusPanel.TabIndex = 46;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteButton.Location = new System.Drawing.Point(815, 21);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(180, 50);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "Delete Question";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // logoBox
            // 
            this.logoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.logoBox.Image = global::ICAL_Final.Properties.Resources._5_editare_intrebari_pentru_teste;
            this.logoBox.Location = new System.Drawing.Point(10, 10);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(63, 63);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoBox.TabIndex = 29;
            this.logoBox.TabStop = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.descriptionLabel.Location = new System.Drawing.Point(81, 49);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(167, 22);
            this.descriptionLabel.TabIndex = 31;
            this.descriptionLabel.Text = "Edit question ";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(134)))), ((int)(((byte)(44)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.saveButton.Location = new System.Drawing.Point(608, 21);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(180, 50);
            this.saveButton.TabIndex = 4;
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
            this.bodyPanel.AutoScroll = true;
            this.bodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.bodyPanel.Controls.Add(this.managementPanel);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bodyPanel.Location = new System.Drawing.Point(0, 100);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1007, 351);
            this.bodyPanel.TabIndex = 45;
            // 
            // managementPanel
            // 
            this.managementPanel.AutoScroll = true;
            this.managementPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.managementPanel.Controls.Add(this.questionRichTextBox);
            this.managementPanel.Controls.Add(this.toolStrip);
            this.managementPanel.Controls.Add(this.thirdAnsRadioButton);
            this.managementPanel.Controls.Add(this.secondAnsRadioButton);
            this.managementPanel.Controls.Add(this.firstAnsRadioButton);
            this.managementPanel.Controls.Add(this.chapterComboBox);
            this.managementPanel.Controls.Add(this.thirdAnswerLabel);
            this.managementPanel.Controls.Add(this.chapterLabel);
            this.managementPanel.Controls.Add(this.thirdAnswerTextBox);
            this.managementPanel.Controls.Add(this.secondAnswerLabel);
            this.managementPanel.Controls.Add(this.secondAnswerTextBox);
            this.managementPanel.Controls.Add(this.firstAnswerLabel);
            this.managementPanel.Controls.Add(this.firstAnswerTextBox);
            this.managementPanel.Controls.Add(this.levelComboBox);
            this.managementPanel.Controls.Add(this.questionLabel);
            this.managementPanel.Controls.Add(this.levelLabel);
            this.managementPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managementPanel.Location = new System.Drawing.Point(0, 0);
            this.managementPanel.Name = "managementPanel";
            this.managementPanel.Size = new System.Drawing.Size(1007, 351);
            this.managementPanel.TabIndex = 14;
            // 
            // questionRichTextBox
            // 
            this.questionRichTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.questionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.questionRichTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.questionRichTextBox.Location = new System.Drawing.Point(10, 124);
            this.questionRichTextBox.Name = "questionRichTextBox";
            this.questionRichTextBox.Size = new System.Drawing.Size(968, 109);
            this.questionRichTextBox.TabIndex = 74;
            this.questionRichTextBox.Text = "";
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
            this.toolStrip.Size = new System.Drawing.Size(990, 25);
            this.toolStrip.TabIndex = 73;
            this.toolStrip.Text = "toolStrip1";
            // 
            // fontToolStripButton
            // 
            this.fontToolStripButton.BackColor = System.Drawing.Color.Transparent;
            this.fontToolStripButton.BackgroundImage = global::ICAL_Final.Properties.Resources.format_text;
            this.fontToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.fontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fontToolStripButton.Enabled = false;
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
            this.boldToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.boldToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.boldToolStripButton.Enabled = false;
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
            this.italicToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.italicToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.italicToolStripButton.Enabled = false;
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
            this.underlineToolStripButton.Enabled = false;
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
            this.strikeOutToolStripButton.Enabled = false;
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
            this.foreColorToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.foreColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.foreColorToolStripButton.Enabled = false;
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
            this.backColorToolStripButton.Enabled = false;
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
            this.leftAlignToolStripButton.Enabled = false;
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
            this.centerAlignToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.centerAlignToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.centerAlignToolStripButton.Enabled = false;
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
            this.rightAlignToolStripButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rightAlignToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.rightAlignToolStripButton.Enabled = false;
            this.rightAlignToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("rightAlignToolStripButton.Image")));
            this.rightAlignToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.rightAlignToolStripButton.Name = "rightAlignToolStripButton";
            this.rightAlignToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.rightAlignToolStripButton.Tag = "Right";
            this.rightAlignToolStripButton.Click += new System.EventHandler(this.alignToolStripButton_Click);
            // 
            // thirdAnsRadioButton
            // 
            this.thirdAnsRadioButton.AutoSize = true;
            this.thirdAnsRadioButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdAnsRadioButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.thirdAnsRadioButton.Location = new System.Drawing.Point(835, 409);
            this.thirdAnsRadioButton.Name = "thirdAnsRadioButton";
            this.thirdAnsRadioButton.Size = new System.Drawing.Size(14, 13);
            this.thirdAnsRadioButton.TabIndex = 72;
            this.thirdAnsRadioButton.Tag = "c)";
            this.thirdAnsRadioButton.UseVisualStyleBackColor = true;
            this.thirdAnsRadioButton.CheckedChanged += new System.EventHandler(this.answersRadioButton_CheckedChanged);
            // 
            // secondAnsRadioButton
            // 
            this.secondAnsRadioButton.AutoSize = true;
            this.secondAnsRadioButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondAnsRadioButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.secondAnsRadioButton.Location = new System.Drawing.Point(835, 352);
            this.secondAnsRadioButton.Name = "secondAnsRadioButton";
            this.secondAnsRadioButton.Size = new System.Drawing.Size(14, 13);
            this.secondAnsRadioButton.TabIndex = 71;
            this.secondAnsRadioButton.Tag = "b)";
            this.secondAnsRadioButton.UseVisualStyleBackColor = true;
            this.secondAnsRadioButton.CheckedChanged += new System.EventHandler(this.answersRadioButton_CheckedChanged);
            // 
            // firstAnsRadioButton
            // 
            this.firstAnsRadioButton.AutoSize = true;
            this.firstAnsRadioButton.Checked = true;
            this.firstAnsRadioButton.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstAnsRadioButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.firstAnsRadioButton.Location = new System.Drawing.Point(835, 278);
            this.firstAnsRadioButton.Name = "firstAnsRadioButton";
            this.firstAnsRadioButton.Size = new System.Drawing.Size(14, 13);
            this.firstAnsRadioButton.TabIndex = 70;
            this.firstAnsRadioButton.TabStop = true;
            this.firstAnsRadioButton.Tag = "a)";
            this.firstAnsRadioButton.UseVisualStyleBackColor = true;
            this.firstAnsRadioButton.CheckedChanged += new System.EventHandler(this.answersRadioButton_CheckedChanged);
            // 
            // chapterComboBox
            // 
            this.chapterComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.chapterComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.chapterComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chapterComboBox.Enabled = false;
            this.chapterComboBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.chapterComboBox.FormattingEnabled = true;
            this.chapterComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.chapterComboBox.Location = new System.Drawing.Point(10, 55);
            this.chapterComboBox.Name = "chapterComboBox";
            this.chapterComboBox.Size = new System.Drawing.Size(413, 31);
            this.chapterComboBox.TabIndex = 48;
            this.chapterComboBox.Text = "1";
            // 
            // thirdAnswerLabel
            // 
            this.thirdAnswerLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdAnswerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.thirdAnswerLabel.Location = new System.Drawing.Point(12, 376);
            this.thirdAnswerLabel.Name = "thirdAnswerLabel";
            this.thirdAnswerLabel.Size = new System.Drawing.Size(789, 22);
            this.thirdAnswerLabel.TabIndex = 27;
            this.thirdAnswerLabel.Text = "Third answer";
            // 
            // chapterLabel
            // 
            this.chapterLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chapterLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.chapterLabel.Location = new System.Drawing.Point(13, 30);
            this.chapterLabel.Name = "chapterLabel";
            this.chapterLabel.Size = new System.Drawing.Size(154, 22);
            this.chapterLabel.TabIndex = 47;
            this.chapterLabel.Text = "Chapter";
            // 
            // thirdAnswerTextBox
            // 
            this.thirdAnswerTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.thirdAnswerTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdAnswerTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.thirdAnswerTextBox.Location = new System.Drawing.Point(8, 401);
            this.thirdAnswerTextBox.MaxLength = 32;
            this.thirdAnswerTextBox.Multiline = true;
            this.thirdAnswerTextBox.Name = "thirdAnswerTextBox";
            this.thirdAnswerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.thirdAnswerTextBox.Size = new System.Drawing.Size(821, 29);
            this.thirdAnswerTextBox.TabIndex = 26;
            // 
            // secondAnswerLabel
            // 
            this.secondAnswerLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondAnswerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.secondAnswerLabel.Location = new System.Drawing.Point(12, 319);
            this.secondAnswerLabel.Name = "secondAnswerLabel";
            this.secondAnswerLabel.Size = new System.Drawing.Size(789, 22);
            this.secondAnswerLabel.TabIndex = 25;
            this.secondAnswerLabel.Text = "Second answer";
            // 
            // secondAnswerTextBox
            // 
            this.secondAnswerTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.secondAnswerTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondAnswerTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.secondAnswerTextBox.Location = new System.Drawing.Point(10, 344);
            this.secondAnswerTextBox.MaxLength = 32;
            this.secondAnswerTextBox.Multiline = true;
            this.secondAnswerTextBox.Name = "secondAnswerTextBox";
            this.secondAnswerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.secondAnswerTextBox.Size = new System.Drawing.Size(819, 29);
            this.secondAnswerTextBox.TabIndex = 24;
            // 
            // firstAnswerLabel
            // 
            this.firstAnswerLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstAnswerLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.firstAnswerLabel.Location = new System.Drawing.Point(12, 245);
            this.firstAnswerLabel.Name = "firstAnswerLabel";
            this.firstAnswerLabel.Size = new System.Drawing.Size(785, 22);
            this.firstAnswerLabel.TabIndex = 23;
            this.firstAnswerLabel.Text = "First answer";
            // 
            // firstAnswerTextBox
            // 
            this.firstAnswerTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.firstAnswerTextBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstAnswerTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.firstAnswerTextBox.Location = new System.Drawing.Point(10, 270);
            this.firstAnswerTextBox.MaxLength = 32;
            this.firstAnswerTextBox.Multiline = true;
            this.firstAnswerTextBox.Name = "firstAnswerTextBox";
            this.firstAnswerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.firstAnswerTextBox.Size = new System.Drawing.Size(819, 29);
            this.firstAnswerTextBox.TabIndex = 22;
            // 
            // levelComboBox
            // 
            this.levelComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "easy",
            "medium",
            "hard",
            "very hard"});
            this.levelComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.levelComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.levelComboBox.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Items.AddRange(new object[] {
            "easy",
            "medium",
            "hard",
            "very hard"});
            this.levelComboBox.Location = new System.Drawing.Point(506, 55);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(470, 31);
            this.levelComboBox.TabIndex = 20;
            this.levelComboBox.Text = "easy";
            // 
            // questionLabel
            // 
            this.questionLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.questionLabel.Location = new System.Drawing.Point(12, 99);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(520, 22);
            this.questionLabel.TabIndex = 16;
            this.questionLabel.Text = "Question";
            // 
            // levelLabel
            // 
            this.levelLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.levelLabel.Location = new System.Drawing.Point(511, 30);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(172, 22);
            this.levelLabel.TabIndex = 14;
            this.levelLabel.Text = "Level";
            // 
            // QuestionEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1007, 451);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.bodyPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "QuestionEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher - Edit Question";
            this.Load += new System.EventHandler(this.QuestionEditForm_Load);
            this.statusPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.bodyPanel.ResumeLayout(false);
            this.managementPanel.ResumeLayout(false);
            this.managementPanel.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label managementLabel;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel managementPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ComboBox chapterComboBox;
        private System.Windows.Forms.Label thirdAnswerLabel;
        private System.Windows.Forms.Label chapterLabel;
        private System.Windows.Forms.TextBox thirdAnswerTextBox;
        private System.Windows.Forms.Label secondAnswerLabel;
        private System.Windows.Forms.TextBox secondAnswerTextBox;
        private System.Windows.Forms.Label firstAnswerLabel;
        private System.Windows.Forms.TextBox firstAnswerTextBox;
        private System.Windows.Forms.ComboBox levelComboBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.RadioButton thirdAnsRadioButton;
        private System.Windows.Forms.RadioButton secondAnsRadioButton;
        private System.Windows.Forms.RadioButton firstAnsRadioButton;
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
        private System.Windows.Forms.RichTextBox questionRichTextBox;
    }
}