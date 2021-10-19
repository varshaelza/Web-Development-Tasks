using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RESTAPI_Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Comments()
        {
            return View();
        }
        public ActionResult Users()
        {
            return View();
        }
        public ActionResult Photos()
        {
            return View();
        }
        public ActionResult Post()
        {
            return View();
        }
    }
}
