using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorDemo_PartialView.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserRegForm()
        {
            return View();
        }

        public ActionResult MyView()
        {
            return View();
        }

        [HttpPost]
        public ContentResult Registration()
        {
            return Content(
                "User Name: = " + Request.Form["username"] + "<br/>" +
                "Email ID: = " + Request.Form["email"] + "<br/>"
                );
        }

        public ActionResult Registration1()
        {
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }
    }
}