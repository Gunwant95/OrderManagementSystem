using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModelBind1.Models;

namespace ModelBind1
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Student> studentsGrid_GetData()
        {
            StudentModels db = new StudentModels();
            //var query = db.students.Include(s => s.Enrollments.Select(e => e.Course));
            // var query = db.students.Include(s => s.Enrollment.Select(e => e.course));
            return query;        
        } 
    }
}