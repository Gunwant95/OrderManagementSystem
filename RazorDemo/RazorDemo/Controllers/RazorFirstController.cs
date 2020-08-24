using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorDemo.Controllers
{
    public class RazorFirstController : Controller
    {
        // GET: RazorFirst
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult HtmlHelperDemo()
        {
            return View();
        }

        [HttpPost]
        public ContentResult UserRegistration()
        {
            return Content(
            "User Name = " + Request.Form["username"]+"<br/>"+
            "Email ID = " + Request.Form["email"] + "<br/>"+
            "Gender = " + Request.Form["gender"] + "<br/>" +
            "Courses = " + Request.Form.GetValues("C#")[0] + " "+Request.Form.GetValues("asp.net")[0] + " " + Request.Form.GetValues("ado.net")[0] + "<br/>" +
            "Contact = " +Request.Form["contact"] + "<br/>"
                );
        }
    }
}