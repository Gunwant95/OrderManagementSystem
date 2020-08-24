using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string gender;
        string query;
        public bool check = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            Screen scr = Screen.PrimaryScreen;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            this.Left = (scr.WorkingArea.Width - this.Width) / 2;
            this.Top = (scr.WorkingArea.Height - this.Height) / 2;
            label7.Text = DateTime.Now.ToString();
            AddCmb();
        }
        public void AddCmb()   // Dynamically add value into combobox
        {
            cmb1.Items.Add(1);
            cmb1.Items.Add(2);
            cmb1.Items.Add(3);
            cmb1.Items.Add(4);
            cmb1.Items.Add(5);
            
            if(rdb_M.Checked == true)
            {
                gender = "M";
            }
            else if (rdb_F.Checked == true)
            {
                gender = "F";
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_age.Text = "";
            txt_name.Text = "";
            txt_roll.Text = "";
            cmb1.Text = "";
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

        private void btn_Show_All_Click(object sender, EventArgs e)
        {
            show();
        }

        public void show()
        {
            gridview();
            int index = dataGridView1.Rows.Count;
            DBConnection.dbcon1();
            query = "select top(5)* from Registration";
            SqlDataAdapter ad = new SqlDataAdapter(query, DBConnection.con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                dataGridView1.Rows.Insert(index, index + 1, dt.Rows[index]["Rollno"].ToString(), dt.Rows[index]["regdate"].ToString(), dt.Rows[index]["name"].ToString(),
                    dt.Rows[index]["class"].ToString(), dt.Rows[index]["age"].ToString(), dt.Rows[index]["gender"].ToString());
            }
            index++;            
        }
        public void gridview() // dynamically add gridview column header
        {
            dataGridView1.ColumnCount = 7;

            dataGridView1.Columns[0].HeaderText = "SLNO";
            dataGridView1.Columns[1].HeaderText = "ROLL NO";
            dataGridView1.Columns[2].HeaderText = "DATE";
            dataGridView1.Columns[3].HeaderText = "STUDENT NAME";
            dataGridView1.Columns[4].HeaderText = "CLASS";
            dataGridView1.Columns[5].HeaderText = "AGE";
            dataGridView1.Columns[6].HeaderText = "GENDER";

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersHeight = 35;
            dataGridView1.ForeColor = Color.Black;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            add();
        }
        public void add()  // insert data into database
        {
            DBConnection.dbcon1();
            query = "select count(*) from registration where rollno ='" + txt_roll.Text + "'";

            SqlCommand cmd = new SqlCommand(query,DBConnection.con);
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            query = "insert into Registration values('"+txt_roll.Text+"','"+Convert.ToDateTime(label7.Text)+"','"+txt_name.Text+"','"+Convert.ToChar(gender)+"','"+cmb1.Text+"','"+txt_age.Text+"')";
            SqlCommand cmd1 = new SqlCommand(query,DBConnection.con);

            if(count ==0 )
            {
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Record Inserted");
            }
            else
            {
                MessageBox.Show("Duplicate value");
            }
            show();
        }

        private void txt_roll_TextChanged(object sender, EventArgs e)
        {
            this.txt_roll.ReadOnly = true;
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            DBConnection.dbcon1();
            int roll = 1011101;
            query = "select top(1)(rollno) from registration";
            SqlDataAdapter ad = new SqlDataAdapter(query,DBConnection.con);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            //count = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
            if(ds.Tables[0].Rows.Count > 0)
            {
                roll = Convert.ToInt32(ds.Tables[0].Rows[0][0].ToString());
                // roll = "New" + (count++).ToString("00");
                if(check == false)
                {
                    txt_roll.Text = (roll + 1).ToString();
                }
            }
            else
            {
                txt_roll.Text = roll.ToString();
            }
        }

        private void rdb_M_CheckedChanged(object sender, EventArgs e)
        {
            gender = "M";
        }

        private void rdb_F_CheckedChanged(object sender, EventArgs e)
        {
            gender = "F";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            check = true;
            txt_roll.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_name.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmb1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_age.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            label7.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Update();
        }

        public void update()
        {
            DBConnection.dbcon1();
            try
            {
                query = "update Registration set rollno='" + txt_roll.Text + "',regdate='" + Convert.ToDateTime(label7.Text)+"',name = '"+txt_name.Text+"',gender = '"+Convert.ToChar(gender)+"',Class = '"+cmb1.Text+"',age = '"+txt_age.Text+"'where Rollno='"+txt_roll.Text+"'";
                SqlCommand cmd = new SqlCommand(query,DBConnection.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            delete();
        }
        public void delete()
        {
            try
            {
                DBConnection.dbcon1();
                query = "delete from registration where rollno ='"+txt_roll.Text+"'";
                SqlCommand cmd = new SqlCommand(query,DBConnection.con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Deleted");
                show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            search();
        }
        public void search()
        {
            DBConnection.dbcon1();
            try
            {
                query = "select * from registration where rollno ='"+txt_roll.Text+"'";
                SqlDataAdapter ad = new SqlDataAdapter(query,DBConnection.con);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("Record Found");
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}















