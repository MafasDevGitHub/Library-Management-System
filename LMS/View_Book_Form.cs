using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI_Project_group_Work
{
    public partial class View_Book_Form : Form
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
        public View_Book_Form()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void View_Book_Form_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;

            SqlConnection con1 = new SqlConnection
            {
                ConnectionString = "Data Source=DESKTOP-2K91IPS;Initial Catalog=LMS;Integrated Security=True"
            };

            SqlCommand cmd = new SqlCommand
            {
                Connection = con1,

                CommandText = "select * from Add_Books"
            };

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);

            dataGridView.DataSource = ds.Tables[0];


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            DashBoard back = new DashBoard();
            back.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (text_grip_book_name.Text != "")
            {
                Image image = Image.FromFile("D://gui photos/new loading.gif");
                pictureBox2.Image = image;

                SqlConnection con1 = new SqlConnection
                {
                    ConnectionString = "Data Source=DESKTOP-2K91IPS;Initial Catalog=LMS;Integrated Security=True"
                };

                SqlCommand cmd = new SqlCommand
                {
                    Connection = con1,

                    CommandText = "select * from Add_Books where Book_Name Like '" + text_grip_book_name.Text + "%'"
                };

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);

                dataGridView.DataSource = ds.Tables[0];
            }
            else
            {
                Image image = Image.FromFile("D://gui photos/Search.gif");
                pictureBox2.Image = image;

                SqlConnection con1 = new SqlConnection
                {
                    ConnectionString = "Data Source=DESKTOP-2K91IPS;Initial Catalog=LMS;Integrated Security=True"
                };

                SqlCommand cmd = new SqlCommand
                {
                    Connection = con1,

                    CommandText = "select * from Add_Books"
                };

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);

                dataGridView.DataSource = ds.Tables[0];


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        int Book_Id;
        readonly Int64 rowid;

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    Book_Id = int.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                }

                panel1.Visible = true;

                SqlConnection con1 = new SqlConnection
                {
                    ConnectionString = "Data Source=DESKTOP-2K91IPS;Initial Catalog=LMS;Integrated Security=True"
                };

                SqlCommand cmd = new SqlCommand
                {
                    Connection = con1,

                    CommandText = "select * from Add_Books where Book_id = " + Book_Id + ""
                };

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);

                //dataGridView.DataSource = ds.Tables[0];

                text_Book_Name_up.Text = ds.Tables[0].Rows[0][1].ToString();
                text_Author_up.Text = ds.Tables[0].Rows[0][2].ToString();
                text_publication_up.Text = ds.Tables[0].Rows[0][3].ToString();
                text_Price_up.Text = ds.Tables[0].Rows[0][4].ToString();
                text_Quantity_up.Text = ds.Tables[0].Rows[0][5].ToString();
                text_Date_up.Text = ds.Tables[0].Rows[0][6].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Plz Contact Devoloper");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button_grip_refresh_Click(object sender, EventArgs e)
        {
            text_grip_book_name.Clear();
            panel1.Visible = false;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            /*if (MessageBox.Show("Do you want to data will be updated ???", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String book_name = text_Book_Name_up.Text;
                String author_name = text_Author_up.Text;
                String publication = text_publication_up.Text;
                Int32 book_price = Int32.Parse(text_Price_up.Text);
                Int32 book_quantity = Int32.Parse(text_Quantity_up.Text);
                String date = text_Date_up.Text;

                SqlConnection con1 = new SqlConnection
                {
                    ConnectionString = "Data Source=DESKTOP-2K91IPS;Initial Catalog=LMS;Integrated Security=True"
                };

                SqlCommand cmd = new SqlCommand
                {
                    Connection = con1,

                    CommandText = "update Add_Books set Book_Name = '" + book_name + "' , Book_Author = '" + author_name + "' , Book_Publication = '" + publication + "' , Book_Price = " + book_price + " , Book_Quantity = " + book_quantity + " , Book_Date = '" + date + "' where  Book_Id = '" + rowid + "'"
                };
                //cmd.CommandText = "update Add_Books set ";
                //"update Add_Student set Student_Name = '"+Student_Name+"', Student_NIC = '"+Student_NIC+"', Student_Address = '"+Student_Address+"', Student_Contact = '"+Student_Contact+"', Student_DOB = '"+Student_DOB+"', Gender = '"+Gender+"' where ID='"+b_id+"'";
                //cmd.ExecuteNonQuery();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
            }*/
            if (MessageBox.Show("Do you want to data will be updated ???", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String Book_Name = text_Book_Name_up.Text;
                String Author_Name = text_Author_up.Text;
                String Book_Publication = text_publication_up.Text;
                Int32 Book_Price = Int32.Parse(text_Price_up.Text);
                Int32 Book_Quantity = Int32.Parse(text_Quantity_up.Text);
                String Book_Date = text_Date_up.Text;

                SqlConnection con1 = new SqlConnection
                {
                    ConnectionString = "Data Source=DESKTOP-2K91IPS;Initial Catalog=LMS;Integrated Security=True"
                };

                SqlCommand cmd = new SqlCommand
                {
                    Connection = con1,

                    CommandText = "update Add_Books set Book_Name = '" + Book_Name + "', Book_Author = '" + Author_Name + "', Book_Publication = '" + Book_Publication + "', Book_Price = '" + Book_Price + "', Book_Quantity = '" + Book_Quantity + "', Book_Date = '" + Book_Date + "' where Book_id='" + Book_Id + "'"
                };

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
            }
        }

        private void panel_head_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_grip_book_name_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void text_Date_up_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to data will be Deleted ???", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                String Book_Name = text_Book_Name_up.Text;
                String Author_Name = text_Author_up.Text;
                String Publication = text_publication_up.Text;
                Int32 Book_Price = Int32.Parse(text_Price_up.Text);
                Int32 Book_Quantity = Int32.Parse(text_Quantity_up.Text);
                String Book_Date = text_Date_up.Text;

                SqlConnection con1 = new SqlConnection
                {
                    ConnectionString = "Data Source=DESKTOP-2K91IPS;Initial Catalog=LMS;Integrated Security=True"
                };

                SqlCommand cmd = new SqlCommand
                {
                    Connection = con1,

                    CommandText = "delete from Add_Books where Book_id='" + Book_Id + "'"
                };

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
            }
        }

        private void lbl_Purches_Click(object sender, EventArgs e)
        {

        }

        private void text_Quantity_up_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Book_Quantity_Click(object sender, EventArgs e)
        {

        }

        private void text_Price_up_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Book_Price_Click(object sender, EventArgs e)
        {

        }

        private void text_publication_up_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Book_Publication_Click(object sender, EventArgs e)
        {

        }

        private void text_Author_up_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Book_Author_Click(object sender, EventArgs e)
        {

        }

        private void text_Book_Name_up_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Book_Name_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
