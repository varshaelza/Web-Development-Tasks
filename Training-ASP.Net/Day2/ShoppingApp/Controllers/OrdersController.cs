using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingApp.Controllers
{
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult Orders()
        {
            return View();
        }
        public ActionResult ViewOrders()
        {
            return View();
        }
        public ActionResult PastOrders()
        {
            return View();
        }
        public ActionResult OrderSummary()
        {
            return View();
        }
        public ActionResult CancelOrders()
        {
            return View();
        }
    }
}