using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI_Project_group_Work
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
         );

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2K91IPS;Initial Catalog=LMS;Integrated Security=True");


        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_user_MouseClick(object sender, MouseEventArgs e)
        {
            if (text_user.Text == "User Name")
            {
                text_user.Clear();
            }
        }

        private void text_password_MouseClick(object sender, MouseEventArgs e)
        {
            if (text_password.Text == "Password")
            {

                text_password.Clear();
            }
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            String user_name, user_password;

            user_name = text_user.Text;
            user_password = text_password.Text;

            try
            {
                String qry = "select * from login_table where user_name = '" + text_user.Text + "' and password = '" + text_password.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(qry, con);

                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    user_name = text_user.Text;
                    user_password = text_password.Text;

                    //page that needed to be load next
                    DashBoard dsb = new DashBoard();
                    dsb.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User name OR Password Incorrect!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_user.Clear();
                    text_password.Clear();

                    //to focus user name
                    text_user.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error!!");
            }
            finally
            {
                con.Close();
            }
        }

        private void button_sign_Click(object sender, EventArgs e)
        {
            text_user.Clear();
            text_password.Clear();

            text_user.Focus();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void text_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void text_password_TextChanged(object sender, EventArgs e)
        {

        }



        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            /* button_Exit.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button_Exit.Width, button_Exit.Height, 30, 30));
             button_sign.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button_sign.Width, button_sign.Height, 80, 80));
             button_login.Region = Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, button_login.Width, button_login.Height, 30, 30));*/
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void checkBox_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShowPassword.Checked == true)
            {
                text_password.UseSystemPasswordChar = false;
            }
            else
            {
                text_password.UseSystemPasswordChar = true;
            }
        }
    }
}
