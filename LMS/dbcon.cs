using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GUI_Project_group_Work
{
     class dbcon
    {
        public static SqlConnection con = null;

        public void db_connect()
        {
            con = new SqlConnection("Data source = DESKTOP-2K91IPS; initial catalog = Library_Managment; integrated ecurity = True;");
            con.Open();

            MessageBox.Show("Database Connected" );
        }
    }
}
