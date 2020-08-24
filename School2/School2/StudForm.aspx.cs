using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace School2
{
    public partial class StudForm : System.Web.UI.Page
    {
      public string constr = "Data Source=HYDCTS52074926\\SQLEXPRESS;Initial Catalog=School;Integrated Security=True";
        public bool check = false;
        int roll;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();
            

           

        string query = "select top(1)(rno) from stud";
            SqlDataAdapter ad = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            //count = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                roll = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                // roll = "New" + (count++).ToString("00");
                if (check == false)
                {
                    txtrno.Text = (roll + 1).ToString();
                }
            }
            else
            {
                txtrno.Text = roll.ToString();
                
            }
            
        }

        

        protected void btnclear_Click(object sender, EventArgs e)
            {
            txtname.Text = "";
            txtage.Text = "";
            txtrno.Text = "";
            rdbtn1.Checked = false;
            rdbtn2.Checked = false;
            dropdownlist1.SelectedIndex = -1;
        }
        public int getrollnumber()
        {
            DataTable dt;
            SqlConnection con1 = new SqlConnection(constr);
            try
            {

                con1.Open();
                dt = new DataTable();
                SqlCommand cmd = new SqlCommand("stud_show", con1);


                cmd.CommandType = CommandType.StoredProcedure;
                // cmd.CommandText = "stud_show";
                SqlDataAdapter da = new SqlDataAdapter(cmd);



                da.Fill(dt);
                              
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con1.Close();
            }
            return 1;
        }

        protected void pagechange(object sender, GridViewPageEventArgs e)
        {
            GridView3.PageIndex = e.NewPageIndex;
            GridView3.DataBind();
        }
        protected void btnshow_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);

            try
            {
                con.Open();                              
                SqlDataAdapter ad = new SqlDataAdapter("stud_show", con);                
                DataTable dt = new DataTable();
                ad.Fill(dt);
                GridView3.DataSource = dt;
                GridView3.DataBind();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection is not established " + ex.Message);
            }
            finally
            {
                 con.Close();
            }
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            string name = txtname.Text.ToString();
            string cls="";
            int age;
            string gender="";

            if (dropdownlist1.SelectedItem.Text == "First Class")
            {
                cls = "First Class";
            }
            else if (dropdownlist1.SelectedItem.Text == "Second Class")
            {
                cls = "Second Class";
            }
            else
                cls = "Third Class";

            if (cls == "First Class")
            {
                age = 20;
            }
            else if (cls == "Second Class")
            {
                age = 25;
            }
            else
                age = 27;

            if(rdbtn1.Checked)
            {
                gender = "Male";
            }

            if(rdbtn2.Checked)
            {
                gender = "Female";
            }            

            SqlConnection con = new SqlConnection(constr);

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("stud_insert",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name",name);
                cmd.Parameters.AddWithValue("@class",cls);
                cmd.Parameters.AddWithValue("@age",age);
                cmd.Parameters.AddWithValue("@gender",gender);

                cmd.ExecuteNonQuery();
                    
                SqlDataAdapter ad = new SqlDataAdapter("stud_show", con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                GridView3.DataSource = dt;
                GridView3.DataBind();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection is not established " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        protected void btnfind_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constr);
            con.Open();

            try
            {
                SqlCommand cmd = new SqlCommand("stud_find",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@rno",txtrno.Text);
                cmd.ExecuteNonQuery();

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);

                if(dt.Rows.Count>0)
                {
                    GridView3.DataSource = dt;
                    GridView3.DataBind();
                }
                else
                {
                    Console.WriteLine("Not found");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        protected void dropdownlist1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdownlist1.SelectedIndex == 1)
            {
                txtage.Text = "20";
            }
        }
    }
}