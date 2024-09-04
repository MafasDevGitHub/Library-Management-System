namespace GUI_Project_group_Work
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.student_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.add_student = new System.Windows.Forms.ToolStripMenuItem();
            this.view_student = new System.Windows.Forms.ToolStripMenuItem();
            this.book_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.add_book = new System.Windows.Forms.ToolStripMenuItem();
            this.view_book = new System.Windows.Forms.ToolStripMenuItem();
            this.issuebook_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.returnbook_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.totalbook_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_tool = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // student_tool
            // 
            this.student_tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_student,
            this.view_student});
            this.student_tool.Image = ((System.Drawing.Image)(resources.GetObject("student_tool.Image")));
            this.student_tool.Name = "student_tool";
            this.student_tool.Size = new System.Drawing.Size(152, 34);
            this.student_tool.Text = "Student";
            // 
            // add_student
            // 
            this.add_student.BackColor = System.Drawing.Color.Yellow;
            this.add_student.Image = ((System.Drawing.Image)(resources.GetObject("add_student.Image")));
            this.add_student.Name = "add_student";
            this.add_student.Size = new System.Drawing.Size(333, 36);
            this.add_student.Text = "Add Students ";
            this.add_student.Click += new System.EventHandler(this.add_student_Click);
            // 
            // view_student
            // 
            this.view_student.BackColor = System.Drawing.Color.Yellow;
            this.view_student.Image = ((System.Drawing.Image)(resources.GetObject("view_student.Image")));
            this.view_student.Name = "view_student";
            this.view_student.Size = new System.Drawing.Size(333, 36);
            this.view_student.Text = "View Students Info";
            this.view_student.Click += new System.EventHandler(this.view_student_Click);
            // 
            // book_tool
            // 
            this.book_tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add_book,
            this.view_book});
            this.book_tool.Image = ((System.Drawing.Image)(resources.GetObject("book_tool.Image")));
            this.book_tool.Name = "book_tool";
            this.book_tool.Size = new System.Drawing.Size(128, 34);
            this.book_tool.Text = "Books";
            // 
            // add_book
            // 
            this.add_book.BackColor = System.Drawing.Color.Yellow;
            this.add_book.Image = ((System.Drawing.Image)(resources.GetObject("add_book.Image")));
            this.add_book.Name = "add_book";
            this.add_book.Size = new System.Drawing.Size(249, 36);
            this.add_book.Text = "Add Books";
            this.add_book.Click += new System.EventHandler(this.add_book_Click);
            // 
            // view_book
            // 
            this.view_book.BackColor = System.Drawing.Color.Yellow;
            this.view_book.Image = ((System.Drawing.Image)(resources.GetObject("view_book.Image")));
            this.view_book.Name = "view_book";
            this.view_book.Size = new System.Drawing.Size(249, 36);
            this.view_book.Text = "View Books ";
            this.view_book.Click += new System.EventHandler(this.view_book_Click);
            // 
            // issuebook_tool
            // 
            this.issuebook_tool.Image = ((System.Drawing.Image)(resources.GetObject("issuebook_tool.Image")));
            this.issuebook_tool.Name = "issuebook_tool";
            this.issuebook_tool.Size = new System.Drawing.Size(194, 34);
            this.issuebook_tool.Text = "Issue Books";
            this.issuebook_tool.Click += new System.EventHandler(this.issuebook_tool_Click);
            // 
            // returnbook_tool
            // 
            this.returnbook_tool.Image = ((System.Drawing.Image)(resources.GetObject("returnbook_tool.Image")));
            this.returnbook_tool.Name = "returnbook_tool";
            this.returnbook_tool.Size = new System.Drawing.Size(222, 34);
            this.returnbook_tool.Text = "Return Books";
            this.returnbook_tool.Click += new System.EventHandler(this.returnbook_tool_Click);
            // 
            // totalbook_tool
            // 
            this.totalbook_tool.Image = ((System.Drawing.Image)(resources.GetObject("totalbook_tool.Image")));
            this.totalbook_tool.Name = "totalbook_tool";
            this.totalbook_tool.Size = new System.Drawing.Size(294, 34);
            this.totalbook_tool.Text = "Complete Book Info";
            this.totalbook_tool.Click += new System.EventHandler(this.totalbook_tool_Click);
            // 
            // exit_tool
            // 
            this.exit_tool.BackColor = System.Drawing.Color.Red;
            this.exit_tool.Image = ((System.Drawing.Image)(resources.GetObject("exit_tool.Image")));
            this.exit_tool.Name = "exit_tool";
            this.exit_tool.Size = new System.Drawing.Size(105, 34);
            this.exit_tool.Text = "Exit";
            this.exit_tool.Click += new System.EventHandler(this.exit_tool_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.menuStrip.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.menuStrip.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.menuStrip.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.student_tool,
            this.book_tool,
            this.issuebook_tool,
            this.returnbook_tool,
            this.totalbook_tool,
            this.exit_tool});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Margin = new System.Windows.Forms.Padding(5);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1122, 38);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 556);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem student_tool;
        private System.Windows.Forms.ToolStripMenuItem add_student;
        private System.Windows.Forms.ToolStripMenuItem view_student;
        private System.Windows.Forms.ToolStripMenuItem book_tool;
        private System.Windows.Forms.ToolStripMenuItem add_book;
        private System.Windows.Forms.ToolStripMenuItem view_book;
        private System.Windows.Forms.ToolStripMenuItem issuebook_tool;
        private System.Windows.Forms.ToolStripMenuItem returnbook_tool;
        private System.Windows.Forms.ToolStripMenuItem totalbook_tool;
        private System.Windows.Forms.ToolStripMenuItem exit_tool;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}