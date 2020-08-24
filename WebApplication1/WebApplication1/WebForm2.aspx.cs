using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SampleDataContext datacontext = new SampleDataContext();
            /*   GridView1.DataSource = from student in datacontext.studs where student.gender=="Male" select student; */
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            GridView1.DataSource = from num1 in numbers
                                   where (num1 % 2) == 0
                                   select num1;
            GridView1.DataBind();
        }
    }
}