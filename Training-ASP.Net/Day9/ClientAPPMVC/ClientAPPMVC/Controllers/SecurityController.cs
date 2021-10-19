using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ClientAPPMVC.Controllers
{
    public class SecurityController : Controller
    {
        // GET: Security
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Logout()
        {


            FormsAuthentication.SignOut();
            
            return RedirectToAction("Login");
        }
        public ActionResult ResetPassword()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult ForgotPassword()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string username,string password)
        {
            
            if(username=="Varsha"&&password=="password@123")
            {
                FormsAuthentication.RedirectFromLoginPage(username, true);
                
            }
            return View();
        }

    }
}