using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration_1
{
    public partial class User_Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_click(object sender, EventArgs e)
        {
            msg.Text = "Hello "+username.Text;
            msg.Text = msg.Text + " you succeed";
            showusername.Text = username.Text;
            showemail.Text = emailid.Text;

            if (radiobtn1.Checked)
            {
                showgender.Text = radiobtn1.Text;
            }
            else
                showgender.Text = radiobtn2.Text;

            var courses = "";

            if(chk1.Checked)
            {
                courses = courses+chk1.Text + " ";
            }
            
            if(chk2.Checked)
            {
                courses = courses+chk2.Text + " ";
            }
            
            if(chk3.Checked)
            {
                courses = courses+chk3.Text + " ";
            }

            ShowCourse.Text = courses;
            showusernamelbl.Text = "User Name";
            showEmailIdlbl.Text = "Email ID";
            showgenderlbl.Text = "Gender";
            showcourselbl.Text = "Courses";
            username.Text = "";
            emailid.Text = "";
            radiobtn1.Checked = false;
            radiobtn2.Checked = false;
            chk1.Checked = false;
            chk2.Checked = false;
            chk3.Checked = false;
        }

        protected void ressubmit_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtval1.Text);
            int b = Convert.ToInt32(txtval2.Text);
            txtval3.Text = (a + b).ToString();
        }
    }
}