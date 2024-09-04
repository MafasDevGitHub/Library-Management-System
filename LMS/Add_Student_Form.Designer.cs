namespace GUI_Project_group_Work
{
    partial class Add_Student_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Student_Form));
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.dateTimePicker_dob = new System.Windows.Forms.DateTimePicker();
            this.text_Contact = new System.Windows.Forms.TextBox();
            this.text_Address = new System.Windows.Forms.TextBox();
            this.text_nic = new System.Windows.Forms.TextBox();
            this.text_Student_Name = new System.Windows.Forms.TextBox();
            this.lbl_Purches = new System.Windows.Forms.Label();
            this.lbl_Book_Quantity = new System.Windows.Forms.Label();
            this.lbl_Book_Price = new System.Windows.Forms.Label();
            this.lbl_Book_Publication = new System.Windows.Forms.Label();
            this.lbl_Book_Author = new System.Windows.Forms.Label();
            this.lbl_Book_Name = new System.Windows.Forms.Label();
            this.radioButtonmale = new System.Windows.Forms.RadioButton();
            this.radioButtonfemale = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(71, 502);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.Red;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Exit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.button_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Exit.Location = new System.Drawing.Point(788, 522);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(111, 32);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.ForeColor = System.Drawing.Color.Black;
            this.button_Save.Location = new System.Drawing.Point(423, 522);
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
            this.button_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Cancel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F);
            this.button_Cancel.ForeColor = System.Drawing.Color.Black;
            this.button_Cancel.Location = new System.Drawing.Point(606, 522);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(2);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(111, 32);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Text = "Reset";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // dateTimePicker_dob
            // 
            this.dateTimePicker_dob.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dateTimePicker_dob.CalendarMonthBackground = System.Drawing.Color.Navy;
            this.dateTimePicker_dob.CalendarTitleBackColor = System.Drawing.Color.Navy;
            this.dateTimePicker_dob.CalendarTrailingForeColor = System.Drawing.Color.Navy;
            this.dateTimePicker_dob.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker_dob.Location = new System.Drawing.Point(423, 378);
            this.dateTimePicker_dob.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker_dob.Name = "dateTimePicker_dob";
            this.dateTimePicker_dob.Size = new System.Drawing.Size(477, 26);
            this.dateTimePicker_dob.TabIndex = 11;
            // 
            // text_Contact
            // 
            this.text_Contact.BackColor = System.Drawing.Color.White;
            this.text_Contact.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.text_Contact.ForeColor = System.Drawing.Color.Black;
            this.text_Contact.Location = new System.Drawing.Point(423, 324);
            this.text_Contact.Margin = new System.Windows.Forms.Padding(2);
            this.text_Contact.Name = "text_Contact";
            this.text_Contact.Size = new System.Drawing.Size(477, 26);
            this.text_Contact.TabIndex = 9;
            // 
            // text_Address
            // 
            this.text_Address.BackColor = System.Drawing.Color.White;
            this.text_Address.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.text_Address.Location = new System.Drawing.Point(423, 270);
            this.text_Address.Margin = new System.Windows.Forms.Padding(2);
            this.text_Address.Name = "text_Address";
            this.text_Address.Size = new System.Drawing.Size(477, 26);
            this.text_Address.TabIndex = 8;
            // 
            // text_nic
            // 
            this.text_nic.BackColor = System.Drawing.Color.White;
            this.text_nic.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.text_nic.Location = new System.Drawing.Point(423, 215);
            this.text_nic.Margin = new System.Windows.Forms.Padding(2);
            this.text_nic.Name = "text_nic";
            this.text_nic.Size = new System.Drawing.Size(477, 26);
            this.text_nic.TabIndex = 7;
            // 
            // text_Student_Name
            // 
            this.text_Student_Name.BackColor = System.Drawing.Color.White;
            this.text_Student_Name.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.text_Student_Name.Location = new System.Drawing.Point(423, 161);
            this.text_Student_Name.Margin = new System.Windows.Forms.Padding(2);
            this.text_Student_Name.Name = "text_Student_Name";
            this.text_Student_Name.Size = new System.Drawing.Size(477, 26);
            this.text_Student_Name.TabIndex = 6;
            // 
            // lbl_Purches
            // 
            this.lbl_Purches.AutoSize = true;
            this.lbl_Purches.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Purches.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Purches.ForeColor = System.Drawing.Color.Black;
            this.lbl_Purches.Location = new System.Drawing.Point(68, 385);
            this.lbl_Purches.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Purches.Name = "lbl_Purches";
            this.lbl_Purches.Size = new System.Drawing.Size(185, 19);
            this.lbl_Purches.TabIndex = 5;
            this.lbl_Purches.Text = "Date of birth";
            // 
            // lbl_Book_Quantity
            // 
            this.lbl_Book_Quantity.AutoSize = true;
            this.lbl_Book_Quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Book_Quantity.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Book_Quantity.ForeColor = System.Drawing.Color.Black;
            this.lbl_Book_Quantity.Location = new System.Drawing.Point(68, 447);
            this.lbl_Book_Quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Book_Quantity.Name = "lbl_Book_Quantity";
            this.lbl_Book_Quantity.Size = new System.Drawing.Size(105, 19);
            this.lbl_Book_Quantity.TabIndex = 4;
            this.lbl_Book_Quantity.Text = "gender";
            // 
            // lbl_Book_Price
            // 
            this.lbl_Book_Price.AutoSize = true;
            this.lbl_Book_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Book_Price.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Book_Price.ForeColor = System.Drawing.Color.Black;
            this.lbl_Book_Price.Location = new System.Drawing.Point(68, 330);
            this.lbl_Book_Price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Book_Price.Name = "lbl_Book_Price";
            this.lbl_Book_Price.Size = new System.Drawing.Size(222, 19);
            this.lbl_Book_Price.TabIndex = 3;
            this.lbl_Book_Price.Text = "Contact Number";
            this.lbl_Book_Price.Click += new System.EventHandler(this.lbl_Book_Price_Click);
            // 
            // lbl_Book_Publication
            // 
            this.lbl_Book_Publication.AutoSize = true;
            this.lbl_Book_Publication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Book_Publication.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Book_Publication.ForeColor = System.Drawing.Color.Black;
            this.lbl_Book_Publication.Location = new System.Drawing.Point(68, 275);
            this.lbl_Book_Publication.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Book_Publication.Name = "lbl_Book_Publication";
            this.lbl_Book_Publication.Size = new System.Drawing.Size(115, 19);
            this.lbl_Book_Publication.TabIndex = 2;
            this.lbl_Book_Publication.Text = "Address";
            // 
            // lbl_Book_Author
            // 
            this.lbl_Book_Author.AutoSize = true;
            this.lbl_Book_Author.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Book_Author.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_Book_Author.ForeColor = System.Drawing.Color.Black;
            this.lbl_Book_Author.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Book_Author.Location = new System.Drawing.Point(68, 221);
            this.lbl_Book_Author.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Book_Author.Name = "lbl_Book_Author";
            this.lbl_Book_Author.Size = new System.Drawing.Size(155, 19);
            this.lbl_Book_Author.TabIndex = 1;
            this.lbl_Book_Author.Text = "NIC Number";
            // 
            // lbl_Book_Name
            // 
            this.lbl_Book_Name.AutoSize = true;
            this.lbl_Book_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Book_Name.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book_Name.ForeColor = System.Drawing.Color.Black;
            this.lbl_Book_Name.Location = new System.Drawing.Point(68, 167);
            this.lbl_Book_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Book_Name.Name = "lbl_Book_Name";
            this.lbl_Book_Name.Size = new System.Drawing.Size(188, 19);
            this.lbl_Book_Name.TabIndex = 0;
            this.lbl_Book_Name.Text = "Student Name";
            // 
            // radioButtonmale
            // 
            this.radioButtonmale.AutoSize = true;
            this.radioButtonmale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioButtonmale.Checked = true;
            this.radioButtonmale.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonmale.ForeColor = System.Drawing.Color.Black;
            this.radioButtonmale.Location = new System.Drawing.Point(423, 445);
            this.radioButtonmale.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonmale.Name = "radioButtonmale";
            this.radioButtonmale.Size = new System.Drawing.Size(89, 23);
            this.radioButtonmale.TabIndex = 13;
            this.radioButtonmale.TabStop = true;
            this.radioButtonmale.Text = "Male";
            this.radioButtonmale.UseVisualStyleBackColor = false;
            this.radioButtonmale.CheckedChanged += new System.EventHandler(this.radioButtonmale_CheckedChanged);
            // 
            // radioButtonfemale
            // 
            this.radioButtonfemale.AutoSize = true;
            this.radioButtonfemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.radioButtonfemale.Font = new System.Drawing.Font("Engravers MT", 12F, System.Drawing.FontStyle.Bold);
            this.radioButtonfemale.ForeColor = System.Drawing.Color.Black;
            this.radioButtonfemale.Location = new System.Drawing.Point(602, 445);
            this.radioButtonfemale.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonfemale.Name = "radioButtonfemale";
            this.radioButtonfemale.Size = new System.Drawing.Size(117, 23);
            this.radioButtonfemale.TabIndex = 14;
            this.radioButtonfemale.Text = "Female";
            this.radioButtonfemale.UseVisualStyleBackColor = false;
            this.radioButtonfemale.CheckedChanged += new System.EventHandler(this.radioButtonfemale_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(950, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 35);
            this.button1.TabIndex = 22;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 141);
            this.panel1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(451, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 49);
            this.label1.TabIndex = 24;
            this.label1.Text = "Add Students";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(303, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // Add_Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(980, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.radioButtonfemale);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.radioButtonmale);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbl_Book_Name);
            this.Controls.Add(this.dateTimePicker_dob);
            this.Controls.Add(this.lbl_Book_Author);
            this.Controls.Add(this.text_Contact);
            this.Controls.Add(this.lbl_Book_Publication);
            this.Controls.Add(this.text_Address);
            this.Controls.Add(this.lbl_Book_Price);
            this.Controls.Add(this.text_nic);
            this.Controls.Add(this.lbl_Purches);
            this.Controls.Add(this.text_Student_Name);
            this.Controls.Add(this.lbl_Book_Quantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Add_Student_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Student_Form";
            this.Load += new System.EventHandler(this.Add_Student_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dob;
        private System.Windows.Forms.TextBox text_Contact;
        private System.Windows.Forms.TextBox text_Address;
        private System.Windows.Forms.TextBox text_nic;
        private System.Windows.Forms.TextBox text_Student_Name;
        private System.Windows.Forms.Label lbl_Purches;
        private System.Windows.Forms.Label lbl_Book_Quantity;
        private System.Windows.Forms.Label lbl_Book_Price;
        private System.Windows.Forms.Label lbl_Book_Publication;
        private System.Windows.Forms.Label lbl_Book_Author;
        private System.Windows.Forms.Label lbl_Book_Name;
        private System.Windows.Forms.RadioButton radioButtonfemale;
        private System.Windows.Forms.RadioButton radioButtonmale;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}