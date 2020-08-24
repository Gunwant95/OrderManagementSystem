using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Auth_and_ExceptionHandle.Controllers
{
    public class MyRollController : Controller
    {
        // GET: MyRoll
        public ActionResult Index()
        {
            return View();
        }
    }
}