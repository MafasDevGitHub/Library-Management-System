namespace GUI_Project_group_Work
{
    partial class View_Book_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Book_Form));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel_head = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_grip_book_name = new System.Windows.Forms.TextBox();
            this.label_grip_book_name = new System.Windows.Forms.Label();
            this.button_grip_refresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.text_Date_up = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.lbl_Purches = new System.Windows.Forms.Label();
            this.text_Quantity_up = new System.Windows.Forms.TextBox();
            this.lbl_Book_Quantity = new System.Windows.Forms.Label();
            this.text_Price_up = new System.Windows.Forms.TextBox();
            this.lbl_Book_Price = new System.Windows.Forms.Label();
            this.text_publication_up = new System.Windows.Forms.TextBox();
            this.lbl_Book_Publication = new System.Windows.Forms.Label();
            this.text_Author_up = new System.Windows.Forms.TextBox();
            this.lbl_Book_Author = new System.Windows.Forms.Label();
            this.text_Book_Name_up = new System.Windows.Forms.TextBox();
            this.lbl_Book_Name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.InfoText;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(-2, 198);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(755, 548);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(2, 102);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel_head
            // 
            this.panel_head.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_head.BackColor = System.Drawing.Color.Black;
            this.panel_head.Controls.Add(this.pictureBox1);
            this.panel_head.Controls.Add(this.pictureBox2);
            this.panel_head.Controls.Add(this.label1);
            this.panel_head.Controls.Add(this.pictureBox3);
            this.panel_head.Location = new System.Drawing.Point(-2, -2);
            this.panel_head.Margin = new System.Windows.Forms.Padding(2);
            this.panel_head.Name = "panel_head";
            this.panel_head.Size = new System.Drawing.Size(1523, 155);
            this.panel_head.TabIndex = 23;
            this.panel_head.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_head_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(462, -10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(251, 178);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(695, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 65);
            this.label1.TabIndex = 22;
            this.label1.Text = "BOOK DETAILS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_grip_book_name
            // 
            this.text_grip_book_name.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.text_grip_book_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_grip_book_name.Location = new System.Drawing.Point(1247, 157);
            this.text_grip_book_name.Margin = new System.Windows.Forms.Padding(2);
            this.text_grip_book_name.Name = "text_grip_book_name";
            this.text_grip_book_name.Size = new System.Drawing.Size(168, 26);
            this.text_grip_book_name.TabIndex = 25;
            this.text_grip_book_name.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label_grip_book_name
            // 
            this.label_grip_book_name.AutoSize = true;
            this.label_grip_book_name.BackColor = System.Drawing.Color.Black;
            this.label_grip_book_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_grip_book_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label_grip_book_name.Location = new System.Drawing.Point(1149, 161);
            this.label_grip_book_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_grip_book_name.Name = "label_grip_book_name";
            this.label_grip_book_name.Size = new System.Drawing.Size(89, 19);
            this.label_grip_book_name.TabIndex = 24;
            this.label_grip_book_name.Text = "Book Name";
            this.label_grip_book_name.Click += new System.EventHandler(this.label_grip_book_name_Click);
            // 
            // button_grip_refresh
            // 
            this.button_grip_refresh.BackColor = System.Drawing.Color.Black;
            this.button_grip_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_grip_refresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_grip_refresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_grip_refresh.Location = new System.Drawing.Point(1431, 159);
            this.button_grip_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.button_grip_refresh.Name = "button_grip_refresh";
            this.button_grip_refresh.Size = new System.Drawing.Size(81, 25);
            this.button_grip_refresh.TabIndex = 26;
            this.button_grip_refresh.Text = "REFRESH";
            this.button_grip_refresh.UseVisualStyleBackColor = false;
            this.button_grip_refresh.Click += new System.EventHandler(this.button_grip_refresh_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.text_Date_up);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button_Save);
            this.panel1.Controls.Add(this.lbl_Purches);
            this.panel1.Controls.Add(this.text_Quantity_up);
            this.panel1.Controls.Add(this.lbl_Book_Quantity);
            this.panel1.Controls.Add(this.text_Price_up);
            this.panel1.Controls.Add(this.lbl_Book_Price);
            this.panel1.Controls.Add(this.text_publication_up);
            this.panel1.Controls.Add(this.lbl_Book_Publication);
            this.panel1.Controls.Add(this.text_Author_up);
            this.panel1.Controls.Add(this.lbl_Book_Author);
            this.panel1.Controls.Add(this.text_Book_Name_up);
            this.panel1.Controls.Add(this.lbl_Book_Name);
            this.panel1.Location = new System.Drawing.Point(748, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 577);
            this.panel1.TabIndex = 27;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // text_Date_up
            // 
            this.text_Date_up.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_Date_up.BackColor = System.Drawing.Color.Navy;
            this.text_Date_up.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.text_Date_up.ForeColor = System.Drawing.Color.White;
            this.text_Date_up.Location = new System.Drawing.Point(395, 402);
            this.text_Date_up.Margin = new System.Windows.Forms.Padding(2);
            this.text_Date_up.Name = "text_Date_up";
            this.text_Date_up.Size = new System.Drawing.Size(344, 26);
            this.text_Date_up.TabIndex = 36;
            this.text_Date_up.TextChanged += new System.EventHandler(this.text_Date_up_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Navy;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(619, 469);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 32);
            this.button2.TabIndex = 35;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(368, 469);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 32);
            this.button1.TabIndex = 34;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Navy;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Save.Location = new System.Drawing.Point(119, 469);
            this.button_Save.Margin = new System.Windows.Forms.Padding(2);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(128, 32);
            this.button_Save.TabIndex = 33;
            this.button_Save.Text = "UPDATE";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // lbl_Purches
            // 
            this.lbl_Purches.AutoSize = true;
            this.lbl_Purches.BackColor = System.Drawing.Color.Navy;
            this.lbl_Purches.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Purches.ForeColor = System.Drawing.Color.White;
            this.lbl_Purches.Location = new System.Drawing.Point(115, 409);
            this.lbl_Purches.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Purches.Name = "lbl_Purches";
            this.lbl_Purches.Size = new System.Drawing.Size(254, 19);
            this.lbl_Purches.TabIndex = 31;
            this.lbl_Purches.Text = "Book Purches Date";
            this.lbl_Purches.Click += new System.EventHandler(this.lbl_Purches_Click);
            // 
            // text_Quantity_up
            // 
            this.text_Quantity_up.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_Quantity_up.BackColor = System.Drawing.Color.Navy;
            this.text_Quantity_up.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.text_Quantity_up.ForeColor = System.Drawing.Color.White;
            this.text_Quantity_up.Location = new System.Drawing.Point(395, 337);
            this.text_Quantity_up.Margin = new System.Windows.Forms.Padding(2);
            this.text_Quantity_up.Name = "text_Quantity_up";
            this.text_Quantity_up.Size = new System.Drawing.Size(344, 26);
            this.text_Quantity_up.TabIndex = 30;
            this.text_Quantity_up.TextChanged += new System.EventHandler(this.text_Quantity_up_TextChanged);
            // 
            // lbl_Book_Quantity
            // 
            this.lbl_Book_Quantity.AutoSize = true;
            this.lbl_Book_Quantity.BackColor = System.Drawing.Color.Navy;
            this.lbl_Book_Quantity.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Book_Quantity.ForeColor = System.Drawing.Color.White;
            this.lbl_Book_Quantity.Location = new System.Drawing.Point(115, 344);
            this.lbl_Book_Quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Book_Quantity.Name = "lbl_Book_Quantity";
            this.lbl_Book_Quantity.Size = new System.Drawing.Size(200, 19);
            this.lbl_Book_Quantity.TabIndex = 29;
            this.lbl_Book_Quantity.Text = "Book Quantity";
            this.lbl_Book_Quantity.Click += new System.EventHandler(this.lbl_Book_Quantity_Click);
            // 
            // text_Price_up
            // 
            this.text_Price_up.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_Price_up.BackColor = System.Drawing.Color.Navy;
            this.text_Price_up.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.text_Price_up.ForeColor = System.Drawing.Color.White;
            this.text_Price_up.Location = new System.Drawing.Point(395, 276);
            this.text_Price_up.Margin = new System.Windows.Forms.Padding(2);
            this.text_Price_up.Name = "text_Price_up";
            this.text_Price_up.Size = new System.Drawing.Size(344, 26);
            this.text_Price_up.TabIndex = 28;
            this.text_Price_up.TextChanged += new System.EventHandler(this.text_Price_up_TextChanged);
            // 
            // lbl_Book_Price
            // 
            this.lbl_Book_Price.AutoSize = true;
            this.lbl_Book_Price.BackColor = System.Drawing.Color.Navy;
            this.lbl_Book_Price.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Book_Price.ForeColor = System.Drawing.Color.White;
            this.lbl_Book_Price.Location = new System.Drawing.Point(115, 283);
            this.lbl_Book_Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Book_Price.Name = "lbl_Book_Price";
            this.lbl_Book_Price.Size = new System.Drawing.Size(149, 19);
            this.lbl_Book_Price.TabIndex = 27;
            this.lbl_Book_Price.Text = "Book Price";
            this.lbl_Book_Price.Click += new System.EventHandler(this.lbl_Book_Price_Click);
            // 
            // text_publication_up
            // 
            this.text_publication_up.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_publication_up.BackColor = System.Drawing.Color.Navy;
            this.text_publication_up.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.text_publication_up.ForeColor = System.Drawing.Color.White;
            this.text_publication_up.Location = new System.Drawing.Point(395, 216);
            this.text_publication_up.Margin = new System.Windows.Forms.Padding(2);
            this.text_publication_up.Name = "text_publication_up";
            this.text_publication_up.Size = new System.Drawing.Size(344, 26);
            this.text_publication_up.TabIndex = 26;
            this.text_publication_up.TextChanged += new System.EventHandler(this.text_publication_up_TextChanged);
            // 
            // lbl_Book_Publication
            // 
            this.lbl_Book_Publication.AutoSize = true;
            this.lbl_Book_Publication.BackColor = System.Drawing.Color.Navy;
            this.lbl_Book_Publication.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Book_Publication.ForeColor = System.Drawing.Color.White;
            this.lbl_Book_Publication.Location = new System.Drawing.Point(115, 223);
            this.lbl_Book_Publication.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Book_Publication.Name = "lbl_Book_Publication";
            this.lbl_Book_Publication.Size = new System.Drawing.Size(236, 19);
            this.lbl_Book_Publication.TabIndex = 25;
            this.lbl_Book_Publication.Text = "Book Publication";
            this.lbl_Book_Publication.Click += new System.EventHandler(this.lbl_Book_Publication_Click);
            // 
            // text_Author_up
            // 
            this.text_Author_up.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_Author_up.BackColor = System.Drawing.Color.Navy;
            this.text_Author_up.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.text_Author_up.ForeColor = System.Drawing.Color.White;
            this.text_Author_up.Location = new System.Drawing.Point(395, 155);
            this.text_Author_up.Margin = new System.Windows.Forms.Padding(2);
            this.text_Author_up.Name = "text_Author_up";
            this.text_Author_up.Size = new System.Drawing.Size(344, 26);
            this.text_Author_up.TabIndex = 24;
            this.text_Author_up.TextChanged += new System.EventHandler(this.text_Author_up_TextChanged);
            // 
            // lbl_Book_Author
            // 
            this.lbl_Book_Author.AutoSize = true;
            this.lbl_Book_Author.BackColor = System.Drawing.Color.Navy;
            this.lbl_Book_Author.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Book_Author.ForeColor = System.Drawing.Color.White;
            this.lbl_Book_Author.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Book_Author.Location = new System.Drawing.Point(115, 162);
            this.lbl_Book_Author.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Book_Author.Name = "lbl_Book_Author";
            this.lbl_Book_Author.Size = new System.Drawing.Size(247, 19);
            this.lbl_Book_Author.TabIndex = 23;
            this.lbl_Book_Author.Text = "Book Author Name";
            this.lbl_Book_Author.Click += new System.EventHandler(this.lbl_Book_Author_Click);
            // 
            // text_Book_Name_up
            // 
            this.text_Book_Name_up.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_Book_Name_up.BackColor = System.Drawing.Color.Navy;
            this.text_Book_Name_up.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.text_Book_Name_up.ForeColor = System.Drawing.Color.White;
            this.text_Book_Name_up.Location = new System.Drawing.Point(395, 95);
            this.text_Book_Name_up.Margin = new System.Windows.Forms.Padding(2);
            this.text_Book_Name_up.Name = "text_Book_Name_up";
            this.text_Book_Name_up.Size = new System.Drawing.Size(344, 26);
            this.text_Book_Name_up.TabIndex = 22;
            this.text_Book_Name_up.TextChanged += new System.EventHandler(this.text_Book_Name_up_TextChanged);
            // 
            // lbl_Book_Name
            // 
            this.lbl_Book_Name.AutoSize = true;
            this.lbl_Book_Name.BackColor = System.Drawing.Color.Navy;
            this.lbl_Book_Name.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Book_Name.Location = new System.Drawing.Point(115, 102);
            this.lbl_Book_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Book_Name.Name = "lbl_Book_Name";
            this.lbl_Book_Name.Size = new System.Drawing.Size(144, 19);
            this.lbl_Book_Name.TabIndex = 21;
            this.lbl_Book_Name.Text = "Book Name";
            this.lbl_Book_Name.Click += new System.EventHandler(this.lbl_Book_Name_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(743, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 559);
            this.panel2.TabIndex = 28;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(1, 189);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 562);
            this.panel3.TabIndex = 29;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(4, 189);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(747, 10);
            this.panel4.TabIndex = 30;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(10, 741);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(740, 10);
            this.panel5.TabIndex = 31;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1457, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 61);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // View_Book_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1521, 751);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_grip_refresh);
            this.Controls.Add(this.text_grip_book_name);
            this.Controls.Add(this.label_grip_book_name);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel_head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "View_Book_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Book_Form";
            this.Load += new System.EventHandler(this.View_Book_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel_head.ResumeLayout(false);
            this.panel_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel_head;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_grip_book_name;
        private System.Windows.Forms.Label label_grip_book_name;
        private System.Windows.Forms.Button button_grip_refresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label lbl_Purches;
        private System.Windows.Forms.TextBox text_Quantity_up;
        private System.Windows.Forms.Label lbl_Book_Quantity;
        private System.Windows.Forms.TextBox text_Price_up;
        private System.Windows.Forms.Label lbl_Book_Price;
        private System.Windows.Forms.TextBox text_publication_up;
        private System.Windows.Forms.Label lbl_Book_Publication;
        private System.Windows.Forms.TextBox text_Author_up;
        private System.Windows.Forms.Label lbl_Book_Author;
        private System.Windows.Forms.TextBox text_Book_Name_up;
        private System.Windows.Forms.Label lbl_Book_Name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox text_Date_up;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}