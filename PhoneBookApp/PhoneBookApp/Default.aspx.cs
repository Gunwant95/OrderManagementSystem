using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace PhoneBookApp
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=HYDCTS52074926;Initial Catalog=Phonebook;Integrated Security=True";
            con.Open();

            if(!Page.IsPostBack)
            {
                dataShow();
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Insert into tbPhoneBook (Name,PhoneNum,Address) values('" + txtName.Text.ToString() + "','"+txtPhoneNum.Text.ToString()+"','"+txtAddress.Text.ToString()+"')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            dataShow();
            clrScreen();
        }
        public void dataShow()
        {
            ds = new DataSet();
            cmd.CommandText = "Select * from tbPhoneBook";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            cmd.ExecuteNonQuery();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "update tbPhoneBook set PhoneNum = '" + txtPhoneNum.Text.ToString() + "',Address='" + txtAddress.Text.ToString() + "' where Name='" + txtName.Text.ToString() + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            //con.Close();
            dataShow();
            clrScreen();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            cmd.CommandText = "Delete from tbPhoneBook where Name = '" + txtName.Text.ToString() + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            dataShow();
            clrScreen();
        }
        public void clrScreen()
        {
            txtName.Text = "";
            txtPhoneNum.Text = "";
            txtAddress.Text = "";
        }

        protected void btnIns_Click(object sender, EventArgs e)
        {
            string str = "Data Source=HYDCTS52074926;Initial Catalog=Phonebook;Integrated Security=True";
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("sp_ins_phone",conn);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("Name",txtName.Text);
            cmd1.Parameters.AddWithValue("phone", txtPhoneNum.Text);
            cmd1.Parameters.AddWithValue("Address",txtAddress.Text);
            cmd1.ExecuteNonQuery();
            dataShow();
            conn.Close();            
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            if(con.State == ConnectionState.Closed)
            con.Open();
            cmd = new SqlCommand("sp_del_phone2",con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name",txtName.Text);
            cmd.ExecuteNonQuery();
            dataShow();            
        }
    }
}