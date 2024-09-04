using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Project_group_Work
{
    public partial class DashBoard : Form
    {

        public DashBoard()
        {
            InitializeComponent();

        }

        private void add_student_Click(object sender, EventArgs e)
        {
            //page that needed to be load next
            Add_Student_Form asf = new Add_Student_Form();  
            asf.Show();
        }

        private void exit_tool_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void view_student_Click(object sender, EventArgs e)
        {
            View_Student_Form vsf = new View_Student_Form();    
            vsf.Show();
        }

        private void add_book_Click(object sender, EventArgs e)
        {
            Add_Book_Form abf = new Add_Book_Form();    
            abf.Show();
        }

        private void view_book_Click(object sender, EventArgs e)
        {
            View_Book_Form vbf = new View_Book_Form();
            vbf.Show();
        }

        private void issuebook_tool_Click(object sender, EventArgs e)
        {
            Issue_Books isb = new Issue_Books();    
            isb.Show();
        }

        private void returnbook_tool_Click(object sender, EventArgs e)
        {
            Return_Books rb = new Return_Books();
            rb.Show();
        }

        private void totalbook_tool_Click(object sender, EventArgs e)
        {
            Complete_Book_Deatails cbd = new Complete_Book_Deatails();
            cbd.Show();
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {

        }
    }
}
