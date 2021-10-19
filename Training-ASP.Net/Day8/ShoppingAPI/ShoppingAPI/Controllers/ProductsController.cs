using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingAPI.Models;

namespace ShoppingAPI.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult ProductList()
        {
            return View();
        }
        public ActionResult ProductbyId()
        {
            return View();
        }
        
        public ActionResult AddProduct()
        {
            return View();
        }
       
        public ActionResult DeleteProduct()
        {
            return View();
        }
        
        public ActionResult UpdateProduct()
        {
            return View();
        }

    }
}