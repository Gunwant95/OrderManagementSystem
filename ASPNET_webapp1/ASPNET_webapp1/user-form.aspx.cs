using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPNET_webapp1
{
    public partial class user_form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowCourses.Text = "None";
        }

        protected void submit_click(object sender, EventArgs e)
        {
            userinput.Text = UserName.Text;
        }

        protected void btn1_click(object sender, EventArgs e)
        {
            lbl1.Text = "You clicked Me";
        }

        protected void radio_btn_click(object sender, EventArgs e)
        {
            if(radiobtn1.Checked == true)
            {
                lbl5.Text = "Gender is Male";
            }
            else if(radiobtn2.Checked == true)
            {
                lbl5.Text = "Gender is Female";
            }            
        }

        protected void Cal1_change(object sender, EventArgs e)
        {
            cal.Text = Calendar1.SelectedDate.ToString();
        }

        protected void chk_click(object sender, EventArgs e)
        {
            var msg = "";
            if(chk1.Checked == true)
            {
                msg = msg+chk1.Text + " ";
            }
            if(chk2.Checked==true)
            {
                msg = msg+chk2.Text + " ";
            }
            if(chk3.Checked == true)
            {
                msg = msg+chk3.Text;
            }
            ShowCourses.Text = msg;
        }
    }
}