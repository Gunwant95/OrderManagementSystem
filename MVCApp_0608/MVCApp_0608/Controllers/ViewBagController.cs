using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp_0608.Controllers
{
    public class ViewBagController : Controller
    {
        // GET: ViewBag
     /*   public ActionResult Index()
        {
            List<string> cources = new List<string>();
            cources.Add("Java");
            cources.Add("Net");
            cources.Add("JavaScript");
            cources.Add("CPP");
            ViewData["cources"] = cources;
            return View();
        } */

        public ActionResult Index()
        {
            List<string> cources = new List<string>();
            cources.Add("Java");
            cources.Add("Net");
            cources.Add("JavaScript");
            cources.Add("CPP");
            //  ViewData["cources"] = cources;
            //   ViewBag.cources = cources;
            TempData["cources"] = cources;
            return View();
        }
    }
}