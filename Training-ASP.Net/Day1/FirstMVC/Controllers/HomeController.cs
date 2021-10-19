using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "First ASP.Net Project";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Details";

            return View();
        }

        public ActionResult News()
        {
            ViewBag.newsId = 501;
            ViewBag.totalPeople = 10;
            ViewBag.headline = "Breaking News!!First ASP.Net Project Created!";
            ViewBag.news = "First ASP.Nt Project Cretaed on 6th September 2021";
            ViewBag.isCompleted = false;
            return View();
        }
    }
}