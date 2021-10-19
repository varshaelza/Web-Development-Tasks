using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutPage_Demo.Controllers
{
    public class BankingController : Controller
    {
        // GET: Banking
        public ActionResult Home()
        {
            ViewBag.message = "HDFC BANK -Home";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.message = "HDFC BANK is one of the biggest private banks in India";
            return View();
        }
    }
}