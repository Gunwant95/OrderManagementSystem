using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp_0608.Controllers
{
    public class AVController : Controller
    {
        // GET: AV
        [HttpPost]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Welcome()
        {
            return View();
        }
    }
}