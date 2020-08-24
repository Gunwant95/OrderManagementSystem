using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RazorDemo_PartialView.Controllers
{
    public class MyViewController : Controller
    {
        // GET: MyView
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MyView2()
        {
            return View();
        }
    }
}