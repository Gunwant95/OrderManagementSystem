using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterSystems.Data.CacheClient;

namespace CacheConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*String str = "DSN=Amar;SERVER=127.0.0.1;PORT=56773;DATABASE=USER;UID=GSK;PWD=a123456&;Namespace=AMAR";
            String str = "Server=127.0.0.1;Port=56773;Namespace=AMAR;User ID=GSK;Password=a123456&;Database=AMAR";

            using (CacheConnection con = new CacheConnection(str))
            {
                //con.Open();
                // MessageBox.Show("Connect");
                CacheCommand cmd = new CacheCommand("SELECT ID, Name, Roll FROM SQLUser.GSKTest", con);
                CacheDataAdapter ad = new CacheDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                // MessageBox.Show("Data fetch successfully");
                // con.Close(); 

                /*  DataSet dt = new DataSet();
                  ad.Fill(dt);
                  dataGridView1.DataSource = dt.Tables[0]; */

            /*   CacheDataReader dr = cmd.ExecuteReader();
               dataGridView1.DataSource = dr;    */
              String str1 = "Server=127.0.0.1;Port=1972;Namespace = TEST;User ID=52074926;Password=GSK;Database=TEST";
          //  String str1 = "Server=127.0.0.1;Port=57772;Namespace = TEST;User ID=52074926;Password=GSK;Database=TEST";

            try
            {
                CacheConnection con = new CacheConnection(str1);
                con.Open();
                Console.WriteLine("Connection Successfull");
                CacheCommand cmd = new CacheCommand("SELECT ID, Name, Roll FROM GSK.Student",con);
                CacheDataAdapter ad = new CacheDataAdapter(cmd);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                /*  DataTable dt = new DataTable();
                  ad.Fill(dt);
                  dataGridView1.DataSource = dt; */

              /*  CacheDataReader dr = cmd.ExecuteReader();
                dataGridView1.DataSource = dr; */
               
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
