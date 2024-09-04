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

namespace GUI_Project_group_Work
{
    public partial class View_Student_Form : Form
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
        public View_Student_Form()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            DashBoard back = new DashBoard();
            back.Show();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void text_search_Enrole_TextChanged(object sender, EventArgs e)
        {
            string searchText = text_search_Enrole.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                // Display loading image
                Image loadingImage = Image.FromFile("D://gui photos/new loading.gif");
                pictureBox1.Image = loadingImage;

                SqlConnection con1 = new SqlConnection
                {
                    ConnectionString = "Data Source=DESKTOP-2K91IPS;Initial Catalog=LMS;Integrated Security=True"
                };

                SqlCommand cmd = new SqlCommand
                {
                    Connection = con1,
                    CommandText = "SELECT * FROM Add_Student WHERE Student_NIC LIKE @searchText"
                };

                cmd.Parameters.AddWithValue("@searchText", searchText + "%");

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);

                dataGridView.DataSource = ds.Tables[0];
            }
            else
            {
                // Display search image
                Image searchImage = Image.FromFile("D://gui photos/Search.gif");
                pictureBox1.Image = searchImage;

                SqlConnection con1 = new SqlConnection
                {
                    ConnectionString = "Data Source=DESKTOP-2K91IPS;Initial Catalog=LMS;Integrated Security=True"
                };

                SqlCommand cmd = new SqlCommand
                {
                    Connection = con1,
                    CommandText = "SELECT * FROM Add_Student"
                };

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);

                dataGridView.DataSource = ds.Tables[0];
            }
        }

        private void View_Student_Form_Load(object sender, EventArgs e)
        {
            panel_1.Visible = false;

            SqlConnection con1 = new SqlConnection
            {
                ConnectionString = "Data Source=DESKTOP-2K91IPS;Initial Catalog=LMS;Integrated Security=True"
            };

            SqlCommand cmd = new SqlCommand
            {
                Connection = con1,

                CommandText = "select * from Add_Student"
            };

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);

            dataGridView.DataSource = ds.Tables[0];
        }

        int b_id;
        Int64 rowid;
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                b_id = int.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel_1.Visible= true;

            SqlConnection con1 = new SqlConnection
            {
                ConnectionString = "Data Source=DESKTOP-2K91IPS;Initial Catalog=LMS;Integrated Security=True"
            };

            SqlCommand cmd = new SqlCommand
            {
                Connection = con1,

                CommandText = "select * from Add_Student where ID = " + b_id + ""
            };

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);

            rowid = int.Parse(ds.Tables[0].Rows[0][0].ToString());

            text_Student_Name_up.Text = ds.Tables[0].Rows[0][1].ToString();
            text_NIC_up.Text = ds.Tables[0].Rows[0][2].ToString();
            text_Address_up.Text = ds.Tables[0].Rows[0][3].ToString();
            text_Contact_up.Text = ds.Tables[0].Rows[0][4].ToString();
            text_DOB_up.Text = ds.Tables[0].Rows[0][5].ToString();
            text_Gender_up.Text = ds.Tables[0].Rows[0][6].ToString();
        }

        
        private void button_Save_S_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to data will be updated ???", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String Student_Name = text_Student_Name_up.Text;
                String Student_NIC = text_NIC_up.Text;
                String Student_Address = text_Address_up.Text;
                String Student_Contact = text_Contact_up.Text;
                String Student_DOB = text_DOB_up.Text;
                String Gender = text_Gender_up.Text;

                SqlConnection con1 = new SqlConnection
                {
                    ConnectionString = "Data Source=DESKTOP-2K91IPS;Initial Catalog=LMS;Integrated Security=True"
                };

                SqlCommand cmd = new SqlCommand
                {
                    Connection = con1,

                    CommandText = "update Add_Student set Student_Name = '" + Student_Name + "', Student_NIC = '" + Student_NIC + "', Student_Address = '" + Student_Address + "', Student_Contact = '" + Student_Contact + "', Student_DOB = '" + Student_DOB + "', Gender = '" + Gender + "' where ID='" + b_id + "'"
                };

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            DashBoard back = new DashBoard();
            back.Show();
        }

        private void button_grip_refresh_Click(object sender, EventArgs e)
        {
            text_search_Enrole.Clear();
            panel_1.Visible = false;
        }

        private void btn_Delete_S_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to data will be Deleted ???", "Conformation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                String Student_Name = text_Student_Name_up.Text;
                String Student_NIC = text_NIC_up.Text;
                String Student_Address = text_Address_up.Text;
                String Student_Contact = text_Contact_up.Text;
                String Student_DOB = text_DOB_up.Text;
                String Gender = text_Gender_up.Text;

                SqlConnection con1 = new SqlConnection
                {
                    ConnectionString = "Data Source=DESKTOP-2K91IPS;Initial Catalog=LMS;Integrated Security=True"
                };

                SqlCommand cmd = new SqlCommand
                {
                    Connection = con1,

                    CommandText = "delete from Add_Student where ID='" + b_id + "'"
                };

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
            }
        }

        private void btn_Cancel_S_Click(object sender, EventArgs e)
        {
           
        }

        private void View_Student_Form_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
