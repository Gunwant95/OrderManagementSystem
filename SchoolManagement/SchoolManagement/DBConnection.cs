using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SchoolManagement
{
    class DBConnection
    {
        public static SqlConnection con = new SqlConnection();
        public static SqlConnection dbcon1()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.ConnectionString = ("Data Source=HYDCTS52074926; Initial Catalog = School;Integrated Security = True");
            //Data Source = HYDCTS52074926; Initial Catalog = School; Integrated Security = True
            con.Open();
            return con;
        }
    }
}
