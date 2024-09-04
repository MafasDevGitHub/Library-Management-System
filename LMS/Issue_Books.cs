using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace GUI_Project_group_Work
{
    public partial class Issue_Books : Form
    {
        public Issue_Books()
        {
            InitializeComponent();
        }

        private void Issue_Books_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-2K91IPS;Initial Catalog=LMS;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select Book_Name from Add_Books", con);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    comboBox_Book_Name.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();



        }

        private void textBox_NIC_TextChanged(object sender, EventArgs e)
        {

        }

        int count;

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (textBox_NIC.Text != "")
            {
                String NIC = textBox_NIC.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-2K91IPS;Initial Catalog=LMS;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from Add_Student where Student_NIC = '" + NIC + "'";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);

                //many book has been issued on this student nic number
                cmd.CommandText = "select count (Student_NIC) from Issue_Return where Student_NIC = '" + NIC + "' and Book_Return_Date is null";
                SqlDataAdapter sda1 = new SqlDataAdapter(cmd);
                DataSet ds2 = new DataSet();
                sda1.Fill(ds2);

                count = int.Parse(ds2.Tables[0].Rows[0][0].ToString());

                if (ds.Tables[0].Rows.Count != 0)
                {
                    textBox_Name.Text = ds.Tables[0].Rows[0][1].ToString();
                    textBox_Address.Text = ds.Tables[0].Rows[0][3].ToString();
                    textBox_Contact.Text = ds.Tables[0].Rows[0][4].ToString();
                    dateTimePicker_DOB.Text = ds.Tables[0].Rows[0][5].ToString();
                    textBox_Gender.Text = ds.Tables[0].Rows[0][6].ToString();
                }
                else
                {
                    textBox_Name.Clear();
                    textBox_Address.Clear();
                    textBox_Contact.Clear();
                    textBox_Gender.Clear();

                    MessageBox.Show("Invalid NIC !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            textBox_Name.Clear();
            textBox_Address.Clear();
            textBox_Contact.Clear();
            textBox_Gender.Clear();
            textBox_NIC.Clear();    
        }

        private void button_Issue_Click(object sender, EventArgs e)
        {
            if (comboBox_Book_Name.SelectedIndex != -1 && count <= 3)
            {
                String Student_NIC = textBox_NIC.Text;
                String Student_Name = textBox_Name.Text;
                String Student_Address = textBox_Address.Text;
                String Student_Contact = textBox_Contact.Text;
                String DOB = dateTimePicker_DOB.Text;
                String Gender = textBox_Gender.Text;
                String Book_Name = comboBox_Book_Name.Text;
                String Book_Issue_Date = dateTimePicker_B_I_Date.Text;

                String NIC = textBox_NIC.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-2K91IPS;Initial Catalog=LMS;Integrated Security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into Issue_Return (Student_NIC,Student_Name,Student_Address,Student_Contact,Student_DOB,Student_Gender,Book_Name,Book_Issue_Date) values ('" + Student_NIC + "','" + Student_Name + "','" + Student_Address + "','" + Student_Contact + "','" + DOB + "','" + Gender + "','" + Book_Name + "','" + Book_Issue_Date + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Book Issued", "Succued", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Maximum number of books has been issued OR Select Book Plz !!!", "books not selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
