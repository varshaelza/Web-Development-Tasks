using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoginMVC_StoredProcedure.Models;
using System.Web.Mvc;

namespace LoginMVC_StoredProcedure.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        UsersDetails userObj = new UsersDetails();
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult LoggedinPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username,string password)
        {
            int result = userObj.CheckLogin(username, password);
            //ViewBag.message = "hi";
            if(result==0)
            {
                ViewBag.message = "Invalid credentials";
                return View();
            }
            else
            {
                ViewBag.message = "Succesfully Logged in";
                return RedirectToAction("LoggedinPage","Login");
            }
            
        }
    }
}