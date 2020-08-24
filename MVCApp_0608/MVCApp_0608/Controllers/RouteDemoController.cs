using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp_0608.Controllers
{
    [RoutePrefix("Gunwant")]
    [Route("{action=index}")]
    public class RouteDemoController : Controller
    {
        // GET: RouteDemo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page";
            return View();
        }

        public ActionResult Contact(string name,string sname)
        {
            ViewBag.title = "Contact";
            ViewBag.Message = "your page " + name+ " "+sname;
            return View();
        }
    }
}