using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Project_group_Work
{
    public partial class Return_Books : Form
    {
        public Return_Books()
        {
            InitializeComponent();
        }

        private void panel_Grid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_NIC_R_TextChanged(object sender, EventArgs e)
        {
            if (textBox_NIC_R.Text == "")
            {
                panel_Grid.Visible = false;
                dataGridView_Details.DataSource = null;

            }
        }

        private void button_Search_R_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-2K91IPS;Initial Catalog=LMS;Integrated Security=True";
            SqlCommand cmd = new SqlCommand(); 
            cmd.Connection = con;

            cmd.CommandText = "select * from Issue_Return where Student_NIC = '"+textBox_NIC_R.Text+ "' and Book_Return_Date is null";
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count != 0)
            {
                dataGridView_Details.DataSource = dataSet.Tables[0];
            }
            else
            {
                MessageBox.Show("Invalid NIC number OR Somthing want wrong plz Check !!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Return_Books_Load(object sender, EventArgs e)
        {
            panel_Grid.Visible = false;
            textBox_NIC_R.Clear();
        }

        //String book_name;
        //String book_i_date;
        Int64 rowid;
        private void dataGridView_Details_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel_Grid.Visible = true;

            if (dataGridView_Details.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView_Details.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-2K91IPS;Initial Catalog=LMS;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "update Issue_Return set Book_Return_Date = '"+ dateTimePicker_Return.Text+ "' where Student_NIC = '"+textBox_NIC_R.Text+"' and ID = "+rowid+"";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Book Returened ","Sucess",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Return_Books_Load(this,null);
        }

        private void button_Reset_R_Click(object sender, EventArgs e)
        {
            textBox_NIC_R.Clear();
            panel_Grid.Visible = false;
            dataGridView_Details.DataSource = null;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
