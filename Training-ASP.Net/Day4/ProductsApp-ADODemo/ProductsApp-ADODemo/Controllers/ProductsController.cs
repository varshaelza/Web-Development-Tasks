using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductsApp_ADODemo.Models;

namespace ProductsApp_ADODemo.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        Products obj = new Products();
        #region Httpget
        public ActionResult AllProducts()
        {
            return View(obj.GetAllProducts());
        }
        public ActionResult SearchByCategory()
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
        #endregion

        #region HttpPost
        [HttpPost]
        public ActionResult SearchByCategory(string p_category)
        { 
            return View(obj.SearchByCategory(p_category));
        }
        [HttpPost]
        public ActionResult AddProduct(int p_id, string p_name, string p_category, int p_qty, double p_price, int p_discount)
        {
            var result =obj.AddProd(p_id, p_name, p_category, p_qty, p_price, p_discount);
            return View("AllProducts",obj.GetAllProducts());
        }
        [HttpPost]
        public ActionResult DeleteProduct(int p_id)
        {
            var result = obj.DeleteProd(p_id);
            return View("AllProducts", obj.GetAllProducts());
        }
        [HttpPost]
        public ActionResult UpdateProduct(int p_id, string p_name, string p_category, int p_qty, double p_price, int p_discount)
        {
            var result = obj.UpdateProd(p_id, p_name, p_category, p_qty, p_price, p_discount);
            return View("AllProducts", obj.GetAllProducts());
        }
        #endregion
    }
}