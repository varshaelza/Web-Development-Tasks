using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClientAPPMVC.Models;

namespace ClientAPPMVC.Controllers
{
    public class HomeController : Controller
    {
        Accounts obj = new Accounts();
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [AllowAnonymous]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult DownloadReports()
        {
            return View();
        }

        public ActionResult TransferMoney()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult TransferMoney(int sender,int receiver,double amount)
        {
            ViewBag.message=obj.TransferMoney(sender, receiver, amount);
            
            return View();
        }
    }
}