using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using MVC_2.Models;

namespace MVC_2.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ContentResult Save(Student student)
        {
            string status = "";

            using (SqlConnection con = new SqlConnection("data source=.; database=Student; integrated security=SSPI"))
            {
                string query= "INSERT INTO student2(name,email,contact) VALUES(@name, @email, @contact)";
                using (SqlCommand cmd = new SqlCommand(query))
                {
                    cmd.Connection = con;

                }
            }

                return Content(status);
        }
    }
}