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
    public partial class Add_Book_Form : Form
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

        public Add_Book_Form()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2K91IPS;Initial Catalog=Library_Add_Boosk;Integrated Security=True");

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

        private void lbl_Book_Name_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            DashBoard back = new DashBoard();
            back.Show();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            String book_name = text_Book_Name.Text;
            String book_author = text_Auther_name.Text;
            String book_publication = tex_Publication.Text;
            Int32 book_price = Int32.Parse(text_Price.Text);
            Int32 book_quantity = Int32.Parse(text_Quantity.Text);
            String book_date = dateTimePicker_PDate.Text;

            SqlConnection con = new SqlConnection
            {
                ConnectionString = "Data Source=DESKTOP-2K91IPS;Initial Catalog=LMS;Integrated Security=True"
            };

            SqlCommand cmd = new SqlCommand
            {
                Connection = con
            };

            con.Open();
            cmd.CommandText = "insert into Add_Books (Book_Name,Book_Author,Book_Publication,Book_Price,Book_Quantity,Book_Date) values ('" + book_name + "','" + book_author + "','" + book_publication + "'," + book_price + "," + book_quantity + ",'" + book_date + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Saved","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);


            /* String bname = text_Book_Name.Text;
             String bauthor = text_Auther_name.Text; 
             String bpublication = tex_Publication.Text; 
             Int64 price = Int64.Parse(text_Price.Text);
             Int64 Quantity = Int64.Parse(text_Quantity.Text);
             String pdate = dateTimePicker_PDate.Text;*/


            /*SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-2K91IPS;Initial Catalog=Library_Add_Book;Integrated Security=True";

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into AddBook (bName,bAuthor,bPublic,bPrice,bQuantity,bDate) values ('" + bname + "','" + bauthor + "','" + bpublication + "'," + price + "," + Quantity + ",'" + pdate + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Data Saved","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);*/

            //String qry = "insert into AddBooks (bName,bAuthor,bPublic,bPrice,bQuantity,bDate) values ('"+bname+"','"+bauthor+"','"+bpublication+"',"+price+","+Quantity+",'"+pdate+"')";
            //SqlDataAdapter sda = new SqlDataAdapter(qry, con);

            // DataTable dataTable = new DataTable();
            //sda.Fill(dataTable);


        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {

            text_Book_Name.Clear();
            text_Auther_name.Clear();
            tex_Publication.Clear();
            text_Price.Clear();
            text_Quantity.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
