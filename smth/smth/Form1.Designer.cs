namespace smth
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UserPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SearchByCategoryButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SearchRandomButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.SearchIntelligentButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.SearchByCategoryPanel = new System.Windows.Forms.Panel();
            this.CategoryTablePanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GanreLabel = new MaterialSkin.Controls.MaterialLabel();
            this.YearLabel = new MaterialSkin.Controls.MaterialLabel();
            this.CountryLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RatingLabel = new MaterialSkin.Controls.MaterialLabel();
            this.GanreComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryTablePanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.CountryComboBox = new System.Windows.Forms.ComboBox();
            this.RatingComboBox = new System.Windows.Forms.ComboBox();
            this.SearchByCategoryButtonPanel = new System.Windows.Forms.Panel();
            this.SearchByCategorySearchButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SearchByCategoryPanel.SuspendLayout();
            this.CategoryTablePanel1.SuspendLayout();
            this.CategoryTablePanel2.SuspendLayout();
            this.SearchByCategoryButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserPanel
            // 
            this.UserPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(85)))), ((int)(((byte)(95)))));
            this.UserPanel.Controls.Add(this.pictureBox7);
            this.UserPanel.Controls.Add(this.pictureBox6);
            this.UserPanel.Controls.Add(this.pictureBox5);
            this.UserPanel.Controls.Add(this.pictureBox4);
            this.UserPanel.Controls.Add(this.pictureBox3);
            this.UserPanel.Controls.Add(this.pictureBox2);
            this.UserPanel.Location = new System.Drawing.Point(0, 85);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(95, 527);
            this.UserPanel.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(85)))), ((int)(((byte)(95)))));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SearchByCategoryButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SearchRandomButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.SearchIntelligentButton, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(857, 60);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 56);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // SearchByCategoryButton
            // 
            this.SearchByCategoryButton.AutoSize = true;
            this.SearchByCategoryButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchByCategoryButton.Depth = 0;
            this.SearchByCategoryButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchByCategoryButton.Font = new System.Drawing.Font("Broadway", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchByCategoryButton.Location = new System.Drawing.Point(115, 6);
            this.SearchByCategoryButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SearchByCategoryButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchByCategoryButton.Name = "SearchByCategoryButton";
            this.SearchByCategoryButton.Primary = false;
            this.SearchByCategoryButton.Size = new System.Drawing.Size(240, 50);
            this.SearchByCategoryButton.TabIndex = 9;
            this.SearchByCategoryButton.Text = "Ты знаешь чего хочешь!";
            this.SearchByCategoryButton.UseVisualStyleBackColor = true;
            this.SearchByCategoryButton.Click += new System.EventHandler(this.SearchByCategoryButton_Click);
            // 
            // SearchRandomButton
            // 
            this.SearchRandomButton.AutoSize = true;
            this.SearchRandomButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchRandomButton.Depth = 0;
            this.SearchRandomButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchRandomButton.Location = new System.Drawing.Point(363, 6);
            this.SearchRandomButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SearchRandomButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchRandomButton.Name = "SearchRandomButton";
            this.SearchRandomButton.Primary = false;
            this.SearchRandomButton.Size = new System.Drawing.Size(240, 50);
            this.SearchRandomButton.TabIndex = 10;
            this.SearchRandomButton.Text = "Не знаешь что посмотреть?";
            this.SearchRandomButton.UseVisualStyleBackColor = true;
            // 
            // SearchIntelligentButton
            // 
            this.SearchIntelligentButton.AutoSize = true;
            this.SearchIntelligentButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchIntelligentButton.Depth = 0;
            this.SearchIntelligentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchIntelligentButton.Location = new System.Drawing.Point(611, 6);
            this.SearchIntelligentButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SearchIntelligentButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchIntelligentButton.Name = "SearchIntelligentButton";
            this.SearchIntelligentButton.Primary = false;
            this.SearchIntelligentButton.Size = new System.Drawing.Size(242, 50);
            this.SearchIntelligentButton.TabIndex = 11;
            this.SearchIntelligentButton.Text = "Посмотри на свои интересы";
            this.SearchIntelligentButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(28, 101);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(28, 158);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(28, 214);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(28, 270);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(40, 40);
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(28, 326);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 40);
            this.pictureBox7.TabIndex = 9;
            this.pictureBox7.TabStop = false;
            // 
            // SearchByCategoryPanel
            // 
            this.SearchByCategoryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.SearchByCategoryPanel.Controls.Add(this.SearchByCategoryButtonPanel);
            this.SearchByCategoryPanel.Controls.Add(this.CategoryTablePanel2);
            this.SearchByCategoryPanel.Controls.Add(this.CategoryTablePanel1);
            this.SearchByCategoryPanel.ForeColor = System.Drawing.Color.White;
            this.SearchByCategoryPanel.Location = new System.Drawing.Point(95, 85);
            this.SearchByCategoryPanel.Name = "SearchByCategoryPanel";
            this.SearchByCategoryPanel.Size = new System.Drawing.Size(762, 527);
            this.SearchByCategoryPanel.TabIndex = 9;
            this.SearchByCategoryPanel.Visible = false;
            // 
            // CategoryTablePanel1
            // 
            this.CategoryTablePanel1.ColumnCount = 4;
            this.CategoryTablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CategoryTablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CategoryTablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CategoryTablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CategoryTablePanel1.Controls.Add(this.GanreLabel, 0, 0);
            this.CategoryTablePanel1.Controls.Add(this.YearLabel, 1, 0);
            this.CategoryTablePanel1.Controls.Add(this.CountryLabel, 2, 0);
            this.CategoryTablePanel1.Controls.Add(this.RatingLabel, 3, 0);
            this.CategoryTablePanel1.Location = new System.Drawing.Point(0, 1);
            this.CategoryTablePanel1.Name = "CategoryTablePanel1";
            this.CategoryTablePanel1.RowCount = 1;
            this.CategoryTablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CategoryTablePanel1.Size = new System.Drawing.Size(762, 41);
            this.CategoryTablePanel1.TabIndex = 0;
            // 
            // GanreLabel
            // 
            this.GanreLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GanreLabel.AutoSize = true;
            this.GanreLabel.Depth = 0;
            this.GanreLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.GanreLabel.ForeColor = System.Drawing.Color.White;
            this.GanreLabel.Location = new System.Drawing.Point(71, 11);
            this.GanreLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.GanreLabel.Name = "GanreLabel";
            this.GanreLabel.Size = new System.Drawing.Size(48, 19);
            this.GanreLabel.TabIndex = 0;
            this.GanreLabel.Text = "Жанр";
            this.GanreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YearLabel
            // 
            this.YearLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YearLabel.AutoSize = true;
            this.YearLabel.Depth = 0;
            this.YearLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.YearLabel.ForeColor = System.Drawing.Color.White;
            this.YearLabel.Location = new System.Drawing.Point(235, 11);
            this.YearLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(100, 19);
            this.YearLabel.TabIndex = 1;
            this.YearLabel.Text = "Год выпуска";
            this.YearLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountryLabel
            // 
            this.CountryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Depth = 0;
            this.CountryLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.CountryLabel.ForeColor = System.Drawing.Color.White;
            this.CountryLabel.Location = new System.Drawing.Point(445, 11);
            this.CountryLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(59, 19);
            this.CountryLabel.TabIndex = 2;
            this.CountryLabel.Text = "Страна";
            this.CountryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RatingLabel
            // 
            this.RatingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Depth = 0;
            this.RatingLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.RatingLabel.ForeColor = System.Drawing.Color.White;
            this.RatingLabel.Location = new System.Drawing.Point(633, 11);
            this.RatingLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(66, 19);
            this.RatingLabel.TabIndex = 3;
            this.RatingLabel.Text = "Рейтинг";
            this.RatingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GanreComboBox
            // 
            this.GanreComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GanreComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.GanreComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GanreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.GanreComboBox.ForeColor = System.Drawing.Color.White;
            this.GanreComboBox.FormattingEnabled = true;
            this.GanreComboBox.Items.AddRange(new object[] {
            "Боевики",
            "Детективы",
            "Комедии",
            "Триллеры",
            "Драмы",
            "Криминальные",
            "Мюзиклы",
            "Семейные",
            "Ужасы",
            "Биографические",
            "Военные",
            "Исторические",
            "Мелодрамы",
            "Приключенческие",
            "Фантастичекие"});
            this.GanreComboBox.Location = new System.Drawing.Point(20, 37);
            this.GanreComboBox.Name = "GanreComboBox";
            this.GanreComboBox.Size = new System.Drawing.Size(150, 26);
            this.GanreComboBox.TabIndex = 1;
            this.GanreComboBox.Text = "-Не выбрано-";
            this.GanreComboBox.SelectedIndexChanged += new System.EventHandler(this.GanreComboBox_SelectedIndexChanged);
            // 
            // CategoryTablePanel2
            // 
            this.CategoryTablePanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CategoryTablePanel2.ColumnCount = 4;
            this.CategoryTablePanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CategoryTablePanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CategoryTablePanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CategoryTablePanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.CategoryTablePanel2.Controls.Add(this.YearComboBox, 1, 0);
            this.CategoryTablePanel2.Controls.Add(this.CountryComboBox, 2, 0);
            this.CategoryTablePanel2.Controls.Add(this.RatingComboBox, 3, 0);
            this.CategoryTablePanel2.Controls.Add(this.GanreComboBox, 0, 0);
            this.CategoryTablePanel2.Location = new System.Drawing.Point(0, 42);
            this.CategoryTablePanel2.Name = "CategoryTablePanel2";
            this.CategoryTablePanel2.RowCount = 1;
            this.CategoryTablePanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CategoryTablePanel2.Size = new System.Drawing.Size(762, 100);
            this.CategoryTablePanel2.TabIndex = 2;
            // 
            // YearComboBox
            // 
            this.YearComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YearComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.YearComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YearComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.YearComboBox.ForeColor = System.Drawing.Color.White;
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Items.AddRange(new object[] {
            "<1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018"});
            this.YearComboBox.Location = new System.Drawing.Point(210, 37);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(150, 26);
            this.YearComboBox.TabIndex = 2;
            this.YearComboBox.Text = "-Не выбрано-";
            // 
            // CountryComboBox
            // 
            this.CountryComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CountryComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.CountryComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CountryComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CountryComboBox.ForeColor = System.Drawing.Color.White;
            this.CountryComboBox.FormattingEnabled = true;
            this.CountryComboBox.Items.AddRange(new object[] {
            "Россия",
            "США",
            "Франция",
            "Германия"});
            this.CountryComboBox.Location = new System.Drawing.Point(400, 37);
            this.CountryComboBox.Name = "CountryComboBox";
            this.CountryComboBox.Size = new System.Drawing.Size(150, 26);
            this.CountryComboBox.TabIndex = 3;
            this.CountryComboBox.Text = "-Не выбрано-";
            // 
            // RatingComboBox
            // 
            this.RatingComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RatingComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.RatingComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RatingComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.RatingComboBox.ForeColor = System.Drawing.Color.White;
            this.RatingComboBox.FormattingEnabled = true;
            this.RatingComboBox.Items.AddRange(new object[] {
            "<5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.RatingComboBox.Location = new System.Drawing.Point(591, 37);
            this.RatingComboBox.Name = "RatingComboBox";
            this.RatingComboBox.Size = new System.Drawing.Size(150, 26);
            this.RatingComboBox.TabIndex = 4;
            this.RatingComboBox.Text = "-Не выбрано-";
            // 
            // SearchByCategoryButtonPanel
            // 
            this.SearchByCategoryButtonPanel.Controls.Add(this.SearchByCategorySearchButton);
            this.SearchByCategoryButtonPanel.Location = new System.Drawing.Point(0, 142);
            this.SearchByCategoryButtonPanel.Name = "SearchByCategoryButtonPanel";
            this.SearchByCategoryButtonPanel.Size = new System.Drawing.Size(762, 56);
            this.SearchByCategoryButtonPanel.TabIndex = 3;
            // 
            // SearchByCategorySearchButton
            // 
            this.SearchByCategorySearchButton.AutoSize = true;
            this.SearchByCategorySearchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SearchByCategorySearchButton.Depth = 0;
            this.SearchByCategorySearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchByCategorySearchButton.Location = new System.Drawing.Point(445, 14);
            this.SearchByCategorySearchButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SearchByCategorySearchButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SearchByCategorySearchButton.Name = "SearchByCategorySearchButton";
            this.SearchByCategorySearchButton.Primary = false;
            this.SearchByCategorySearchButton.Size = new System.Drawing.Size(59, 36);
            this.SearchByCategorySearchButton.TabIndex = 0;
            this.SearchByCategorySearchButton.Text = "Найти";
            this.SearchByCategorySearchButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(856, 610);
            this.Controls.Add(this.SearchByCategoryPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.UserPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MaximumSizeChanged += new System.EventHandler(this.Form1_MaximumSizeChanged);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.UserPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.SearchByCategoryPanel.ResumeLayout(false);
            this.CategoryTablePanel1.ResumeLayout(false);
            this.CategoryTablePanel1.PerformLayout();
            this.CategoryTablePanel2.ResumeLayout(false);
            this.SearchByCategoryButtonPanel.ResumeLayout(false);
            this.SearchByCategoryButtonPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel UserPanel;
        private MaterialSkin.Controls.MaterialFlatButton SearchByCategoryButton;
        public System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialFlatButton SearchRandomButton;
        private MaterialSkin.Controls.MaterialFlatButton SearchIntelligentButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel SearchByCategoryPanel;
        private System.Windows.Forms.TableLayoutPanel CategoryTablePanel1;
        private MaterialSkin.Controls.MaterialLabel GanreLabel;
        private MaterialSkin.Controls.MaterialLabel YearLabel;
        private MaterialSkin.Controls.MaterialLabel CountryLabel;
        private MaterialSkin.Controls.MaterialLabel RatingLabel;
        private System.Windows.Forms.TableLayoutPanel CategoryTablePanel2;
        private System.Windows.Forms.ComboBox GanreComboBox;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.ComboBox CountryComboBox;
        private System.Windows.Forms.ComboBox RatingComboBox;
        private System.Windows.Forms.Panel SearchByCategoryButtonPanel;
        private MaterialSkin.Controls.MaterialFlatButton SearchByCategorySearchButton;
    }
}

