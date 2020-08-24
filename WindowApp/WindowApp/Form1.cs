using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace WindowApp
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=HYDCTS52074926;Initial Catalog=Testing;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "insert into TestStud (Name,City,Country) values('"+textBox1.Text.ToString()+"','"+textBox2.Text.ToString()+"','"+textBox3.Text.ToString()+"')";
            SqlCommand cmd = new SqlCommand(str,con);            
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record inserted succefully");
            dispData();
            con.Close();
        }

        public void dispData()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            String str = "select * from TestStud";
            SqlCommand cmd = new SqlCommand(str,con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dispData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from TestStud where name='"+textBox1.Text.ToString()+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record successfully deleted");
            dispData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update TestStud set city ='"+textBox2.Text.ToString()+"' where name='"+textBox1.Text.ToString()+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Updated successfully");
            dispData();
        }
    }
}
