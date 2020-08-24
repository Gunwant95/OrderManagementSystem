using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp_0608.Controllers
{
    public class MusicController : Controller
    {
        // GET: Music
        [ActionName("store")]
        [OutputCache(Duration=5)]
        public ActionResult Index()
        {
            return View();
        }

        public new ActionResult View()
        {
            //return View();
            return base.View();
        }

        public ActionResult MyView()
        {
            return View();
            //return "Kapade";     // Not work
        }

        [Authorize]
        public string Welcome()        // Action Method
        {
            return "Hello, Gunwant";
        }

        public string Hello(string name)
        {
            return "Hello" + name + "Kapade";
        }
    }
}