using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["sqlconn1"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("select rno, name, age, gender from dbo.stud where gender='Male'",con);
            List<Student> stud1 = new List<Student>();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                Student stud = new Student();
                stud.rno = Convert.ToInt32(sdr["rno"]);
                stud.name = sdr["name"].ToString();
                stud.age = Convert.ToInt32(sdr["age"]);
                stud.gender = sdr["gender"].ToString();
                stud1.Add(stud);
            }
            con.Close();

            GridView1.DataSource = stud1;
            GridView1.DataBind();
        }
    }

    public class Student
    {
        public int rno { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
    }
}