namespace GUI_Project_group_Work
{
    partial class Add_Book_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Book_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.dateTimePicker_PDate = new System.Windows.Forms.DateTimePicker();
            this.text_Quantity = new System.Windows.Forms.TextBox();
            this.text_Price = new System.Windows.Forms.TextBox();
            this.tex_Publication = new System.Windows.Forms.TextBox();
            this.text_Auther_name = new System.Windows.Forms.TextBox();
            this.text_Book_Name = new System.Windows.Forms.TextBox();
            this.lbl_Purches = new System.Windows.Forms.Label();
            this.lbl_Book_Quantity = new System.Windows.Forms.Label();
            this.lbl_Book_Price = new System.Windows.Forms.Label();
            this.lbl_Book_Publication = new System.Windows.Forms.Label();
            this.lbl_Book_Author = new System.Windows.Forms.Label();
            this.lbl_Book_Name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(735, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 517);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Black;
            this.panel.Controls.Add(this.button1);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.pictureBox2);
            this.panel.Location = new System.Drawing.Point(-1, -2);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(996, 115);
            this.panel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(964, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 35);
            this.button1.TabIndex = 23;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(445, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Books";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(333, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(109, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.Red;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.button_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Exit.Location = new System.Drawing.Point(597, 408);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(111, 32);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.button_Exit);
            this.panel1.Controls.Add(this.button_Save);
            this.panel1.Controls.Add(this.button_Cancel);
            this.panel1.Controls.Add(this.dateTimePicker_PDate);
            this.panel1.Controls.Add(this.text_Quantity);
            this.panel1.Controls.Add(this.text_Price);
            this.panel1.Controls.Add(this.tex_Publication);
            this.panel1.Controls.Add(this.text_Auther_name);
            this.panel1.Controls.Add(this.text_Book_Name);
            this.panel1.Controls.Add(this.lbl_Purches);
            this.panel1.Controls.Add(this.lbl_Book_Quantity);
            this.panel1.Controls.Add(this.lbl_Book_Price);
            this.panel1.Controls.Add(this.lbl_Book_Publication);
            this.panel1.Controls.Add(this.lbl_Book_Author);
            this.panel1.Controls.Add(this.lbl_Book_Name);
            this.panel1.Location = new System.Drawing.Point(-1, 113);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 494);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(31, 388);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Save.Location = new System.Drawing.Point(288, 408);
            this.button_Save.Margin = new System.Windows.Forms.Padding(2);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(111, 32);
            this.button_Save.TabIndex = 12;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Cancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.button_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Cancel.Location = new System.Drawing.Point(440, 408);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(111, 32);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Text = "Reset";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // dateTimePicker_PDate
            // 
            this.dateTimePicker_PDate.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_PDate.Location = new System.Drawing.Point(288, 325);
            this.dateTimePicker_PDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_PDate.Name = "dateTimePicker_PDate";
            this.dateTimePicker_PDate.Size = new System.Drawing.Size(421, 26);
            this.dateTimePicker_PDate.TabIndex = 11;
            // 
            // text_Quantity
            // 
            this.text_Quantity.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.text_Quantity.Location = new System.Drawing.Point(288, 269);
            this.text_Quantity.Margin = new System.Windows.Forms.Padding(2);
            this.text_Quantity.Name = "text_Quantity";
            this.text_Quantity.Size = new System.Drawing.Size(421, 26);
            this.text_Quantity.TabIndex = 10;
            // 
            // text_Price
            // 
            this.text_Price.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.text_Price.Location = new System.Drawing.Point(288, 212);
            this.text_Price.Margin = new System.Windows.Forms.Padding(2);
            this.text_Price.Name = "text_Price";
            this.text_Price.Size = new System.Drawing.Size(421, 26);
            this.text_Price.TabIndex = 9;
            // 
            // tex_Publication
            // 
            this.tex_Publication.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.tex_Publication.Location = new System.Drawing.Point(288, 155);
            this.tex_Publication.Margin = new System.Windows.Forms.Padding(2);
            this.tex_Publication.Name = "tex_Publication";
            this.tex_Publication.Size = new System.Drawing.Size(421, 26);
            this.tex_Publication.TabIndex = 8;
            // 
            // text_Auther_name
            // 
            this.text_Auther_name.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.text_Auther_name.Location = new System.Drawing.Point(288, 101);
            this.text_Auther_name.Margin = new System.Windows.Forms.Padding(2);
            this.text_Auther_name.Name = "text_Auther_name";
            this.text_Auther_name.Size = new System.Drawing.Size(421, 26);
            this.text_Auther_name.TabIndex = 7;
            // 
            // text_Book_Name
            // 
            this.text_Book_Name.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.text_Book_Name.Location = new System.Drawing.Point(288, 45);
            this.text_Book_Name.Margin = new System.Windows.Forms.Padding(2);
            this.text_Book_Name.Name = "text_Book_Name";
            this.text_Book_Name.Size = new System.Drawing.Size(421, 26);
            this.text_Book_Name.TabIndex = 6;
            // 
            // lbl_Purches
            // 
            this.lbl_Purches.AutoSize = true;
            this.lbl_Purches.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Purches.Location = new System.Drawing.Point(28, 325);
            this.lbl_Purches.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Purches.Name = "lbl_Purches";
            this.lbl_Purches.Size = new System.Drawing.Size(254, 19);
            this.lbl_Purches.TabIndex = 5;
            this.lbl_Purches.Text = "Book Purches Date";
            // 
            // lbl_Book_Quantity
            // 
            this.lbl_Book_Quantity.AutoSize = true;
            this.lbl_Book_Quantity.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Book_Quantity.Location = new System.Drawing.Point(28, 274);
            this.lbl_Book_Quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Book_Quantity.Name = "lbl_Book_Quantity";
            this.lbl_Book_Quantity.Size = new System.Drawing.Size(200, 19);
            this.lbl_Book_Quantity.TabIndex = 4;
            this.lbl_Book_Quantity.Text = "Book Quantity";
            // 
            // lbl_Book_Price
            // 
            this.lbl_Book_Price.AutoSize = true;
            this.lbl_Book_Price.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Book_Price.Location = new System.Drawing.Point(28, 218);
            this.lbl_Book_Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Book_Price.Name = "lbl_Book_Price";
            this.lbl_Book_Price.Size = new System.Drawing.Size(149, 19);
            this.lbl_Book_Price.TabIndex = 3;
            this.lbl_Book_Price.Text = "Book Price";
            // 
            // lbl_Book_Publication
            // 
            this.lbl_Book_Publication.AutoSize = true;
            this.lbl_Book_Publication.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Book_Publication.Location = new System.Drawing.Point(28, 161);
            this.lbl_Book_Publication.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Book_Publication.Name = "lbl_Book_Publication";
            this.lbl_Book_Publication.Size = new System.Drawing.Size(236, 19);
            this.lbl_Book_Publication.TabIndex = 2;
            this.lbl_Book_Publication.Text = "Book Publication";
            // 
            // lbl_Book_Author
            // 
            this.lbl_Book_Author.AutoSize = true;
            this.lbl_Book_Author.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Book_Author.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Book_Author.Location = new System.Drawing.Point(28, 107);
            this.lbl_Book_Author.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Book_Author.Name = "lbl_Book_Author";
            this.lbl_Book_Author.Size = new System.Drawing.Size(247, 19);
            this.lbl_Book_Author.TabIndex = 1;
            this.lbl_Book_Author.Text = "Book Author Name";
            // 
            // lbl_Book_Name
            // 
            this.lbl_Book_Name.AutoSize = true;
            this.lbl_Book_Name.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Name.Location = new System.Drawing.Point(28, 50);
            this.lbl_Book_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Book_Name.Name = "lbl_Book_Name";
            this.lbl_Book_Name.Size = new System.Drawing.Size(144, 19);
            this.lbl_Book_Name.TabIndex = 0;
            this.lbl_Book_Name.Text = "Book Name";
            this.lbl_Book_Name.Click += new System.EventHandler(this.lbl_Book_Name_Click);
            // 
            // Add_Book_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(994, 596);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Add_Book_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Book_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Purches;
        private System.Windows.Forms.Label lbl_Book_Quantity;
        private System.Windows.Forms.Label lbl_Book_Price;
        private System.Windows.Forms.Label lbl_Book_Publication;
        private System.Windows.Forms.Label lbl_Book_Author;
        private System.Windows.Forms.Label lbl_Book_Name;
        private System.Windows.Forms.DateTimePicker dateTimePicker_PDate;
        private System.Windows.Forms.TextBox text_Quantity;
        private System.Windows.Forms.TextBox text_Price;
        private System.Windows.Forms.TextBox tex_Publication;
        private System.Windows.Forms.TextBox text_Auther_name;
        private System.Windows.Forms.TextBox text_Book_Name;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}