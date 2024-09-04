using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI_Project_group_Work
{
    public partial class Add_Student_Form : Form
    {
        // public string Gender { get; private set; }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
         );


        public Add_Student_Form()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void lbl_Book_Price_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Exit_Click(object sender, EventArgs e)
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

        String Gender = String.Empty;

        private void button_Save_Click(object sender, EventArgs e)
        {
            /* String Student_Name = text_Student_Name.Text;
             String Student_NIC = text_nic.Text;
             String Student_Address = text_Address.Text;
             String Student_Contact = text_Contact.Text;
             String Student_DOB = dateTimePicker_dob.Text;
             String Gender = Gender;*/

            SqlConnection con = new SqlConnection
            {
                ConnectionString = "Data Source=DESKTOP-2K91IPS;Initial Catalog=LMS;Integrated Security=True"
            };

            SqlCommand cmd = new SqlCommand
            {
                Connection = con
            };

            con.Open();
            cmd.CommandText = "insert into Add_Student (Student_Name,Student_NIC,Student_Address,Student_Contact,Student_DOB,Gender) values ('" + text_Student_Name.Text + "','" + text_nic.Text + "','" + text_Address.Text + "','"+ text_Contact.Text + "','"+ dateTimePicker_dob.Text + "','" + Gender + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            DashBoard back = new DashBoard();
            back.Show();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            text_Student_Name.Clear();
            text_nic.Clear();
            text_Address.Clear();
            text_Contact.Clear();
            
        }

        private void radioButtonmale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButtonfemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void Add_Student_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
