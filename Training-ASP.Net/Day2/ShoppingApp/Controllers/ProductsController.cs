using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingApp.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        static List<string> maleProducts = new List<string>();
        static List<string> femaleProducts = new List<string>();
        static List<string> festiveProducts = new List<string>();
        static List<string> kidsProducts = new List<string>();
        static List<string> offers = new List<string>();
        
        public ActionResult MaleProducts()
        {
            if (maleProducts.Count == 0)
            { 
            maleProducts.Add("Shoes");
            maleProducts.Add("Belt");
            maleProducts.Add("Shaving set");
            maleProducts.Add("Men's Shirt");
            maleProducts.Add("Wallet");
            }
            ViewBag.maleProducts = maleProducts;
            return View();
        }

        public ActionResult FemaleProducts()
        {
            if (femaleProducts.Count == 0)
            {
                femaleProducts.Add("Sandals");
                femaleProducts.Add("Kurti");
                femaleProducts.Add("Ladies Handbag");
                femaleProducts.Add("Skirt");
                femaleProducts.Add("Purse");
            }
            ViewBag.femaleProducts = femaleProducts;
            ViewBag.message = "";
            return View();
        }
        public ActionResult FestiveProducts()
        {
            if (festiveProducts.Count == 0)
            {
                festiveProducts.Add("Crackers");
                festiveProducts.Add("Decoraters");
                festiveProducts.Add("Fairy Lights");
                
            }
            ViewBag.festiveProducts = festiveProducts;
            ViewBag.message = "";
            return View();
        }
        public ActionResult KidsProducts()
        {
            if (kidsProducts.Count == 0)
            {
                kidsProducts.Add("Boy's Dress");
                kidsProducts.Add("Girls' Dress");
                kidsProducts.Add("Toys");
                kidsProducts.Add("Pram");
                kidsProducts.Add("Walker");

            }
            ViewBag.kidsProducts = kidsProducts;
            ViewBag.message = "";
            return View();
        }
        public ActionResult Offers()
        {
            if (offers.Count == 0)
            {
                offers.Add("Buy 1-Get 1 (Dress)");
                offers.Add("Buy 2-Get 1(Books)");
                offers.Add("Christmas Sale");
                offers.Add("New Year Sale");
                
            }
            ViewBag.offers = offers;
            return View();
        }
        public ActionResult Products()
        {
            return View();
        }
        [HttpPost]
        public ActionResult FemaleProducts(string item)
        {
            ViewBag.message = "Item already exists";
            ViewBag.femaleProducts = femaleProducts;
            if (!femaleProducts.Contains(item))
            {
                femaleProducts.Add(item);
                ViewBag.femaleProducts = femaleProducts;
                ViewBag.message = "Item Added";
               
            }
            
            return View();
        }

        [HttpPost]
        public ActionResult MaleProducts(string item)
        {
            ViewBag.maleProducts = maleProducts;
            ViewBag.message = "Item already exists";
            if (!maleProducts.Contains(item))
            {
                maleProducts.Add(item);
                ViewBag.maleProducts = maleProducts;

                ViewBag.message = "Item Added";

            }
            
            return View();
        }

        [HttpPost]
        public ActionResult FestiveProducts(string item)
        {
            ViewBag.festiveProducts = festiveProducts;
            ViewBag.message = "Item already exists";
            if (!festiveProducts.Contains(item))
            {
                festiveProducts.Add(item);
                ViewBag.festiveProducts = festiveProducts;

                ViewBag.message = "Item Added";

            }
            
            return View();
        }

        [HttpPost]
        public ActionResult KidsProducts(string item)
        {
            ViewBag.kidsProducts = kidsProducts;
            ViewBag.message = "Item already exists";
            if (!kidsProducts.Contains(item))
            {
                kidsProducts.Add(item);
                ViewBag.kidsProducts = kidsProducts;

                ViewBag.message = "Item Added";

            }
           
            return View();
        }

    }
}