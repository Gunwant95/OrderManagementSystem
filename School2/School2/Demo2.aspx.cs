using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace School2
{
    public partial class Demo2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DropDownList1.Items.Add("IND");
                DropDownList1.Items.Add("AUS");
                DropDownList1.Items.Add("NZ");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList2.Items.Clear();

            if(DropDownList1.SelectedIndex==1)
            {
                DropDownList2.Items.Add("Jalgaon");
                DropDownList2.Items.Add("Bhusawal");
                DropDownList2.Items.Add("Mumbai");
            }

            if (DropDownList1.SelectedIndex == 2)
            {
                DropDownList2.Items.Add("Perth");
                DropDownList2.Items.Add("Sydney");
                DropDownList2.Items.Add("Melbourne");
            }

            if (DropDownList1.SelectedIndex == 3)
            {
                DropDownList2.Items.Add("Auckland");
                DropDownList2.Items.Add("Wellington");
                DropDownList2.Items.Add("Hamilton");
            }

        }
    }
}