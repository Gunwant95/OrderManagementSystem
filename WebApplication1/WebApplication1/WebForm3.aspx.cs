using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Lambda expressions
            /*  IEnumerable<Class1> query = Class1.GetAllStud().Where(newAlias => newAlias.gender == "Male");
               GridView1.DataSource = query;
              GridView1.DataBind(); */

            //SQL Expressions
            IEnumerable<Class1> query = from abc in Class1.GetAllStud()
                                        where abc.gender == "Female"
                                        select abc;
            GridView1.DataSource = query;
            GridView1.DataBind();
        }
    }
}