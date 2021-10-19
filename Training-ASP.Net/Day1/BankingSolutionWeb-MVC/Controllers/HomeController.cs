using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingSolutionWeb_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Accounts()
        {
            return View();

        }
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult Transactions()
        {
            return View();
        }
        public ActionResult News()
        {
            ViewBag.newsId = 1;
            ViewBag.newsHeadline = "HDFC Opens new Branch in Peruva!";
            ViewBag.news = "HDFC Bank opens it's brand new branch in Peruva,Kottayam,on 6th September 2021,Monday.";
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "About HDFC BANK";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Details";

            return View();
        }
    }
}