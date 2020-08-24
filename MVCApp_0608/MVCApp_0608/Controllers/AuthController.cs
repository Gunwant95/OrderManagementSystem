using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApp_0608.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
       /* public ActionResult Index()
        {
            return View();
        }*/

        public ContentResult Index()
        {
            return Content("This is content view");
        }

        [Authorize]
        public ContentResult AuthorisedOnly()
        {
            return Content("Authorized only");
        }

        [Authorize]
        public ContentResult AuthorisedOnly2()
        {
            return Content("Authorized Action Name used");
        }
    }
}