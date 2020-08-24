using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_2.Models;

namespace MVC_2.Controllers
{
    public class Test2Controller : Controller
    {
        // GET: Test2
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Person());
        }
    }
}