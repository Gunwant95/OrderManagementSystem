using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Auth_and_ExceptionHandle.Controllers
{
    
    public class RollController : Controller
    {
        // GET: Roll
        [Authorize(Roles ="Super Administrator")]
        public ActionResult Roll()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page Gunwant.";

            return View();
        }

        public ActionResult MyName()
        {
            ViewBag.Message = "My Name is ";
            return View();
        }
    }
}