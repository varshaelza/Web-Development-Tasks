using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankingMVC_StoredProceduresDemo.Models;

namespace BankingMVC_StoredProceduresDemo.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        Accounts accObj = new Accounts();
        #region HTTPGet
        public ActionResult AllAccounts()
        {
            return View(accObj.GetAllAccounts());
        }
        public ActionResult SearchAccount()
        {
            return View();
        }
        public ActionResult AccountByNo()
        {
            return View();
        }
        public ActionResult AccountByType()
        {
            
            return View();
        }
        public ActionResult DeleteAccount()
        {
            return View();
        }
        public ActionResult AddAccount()
        {
            
            return View(); 
        }
        public ActionResult UpdateAccount()
        {
            return View();
        }
        #endregion

        #region HTTPPost
        [HttpPost]
        public ActionResult SearchAccount(string searchby)
        {
            if(searchby=="Account Number")
            {
                return View("AccountByNo");
            }
            else
            {
                return View("AccountByType");
            }
        }
        [HttpPost]
        public ActionResult AccountByNo(int p_accno)
        {
            return View(accObj.GetAccountByNo(p_accno));
        }
        [HttpPost]
        public ActionResult AccountByType(string p_accType)
        {
            ViewBag.message = p_accType;
            return View(accObj.GetAccountByType(p_accType));
        }
        [HttpPost]
        public ActionResult DeleteAccount(int p_accno)
        {
            var result = accObj.DeleteAccount(p_accno);
            return View("AllAccounts",accObj.GetAllAccounts());
        }
        [HttpPost]
        public ActionResult AddAccount(string p_accname,string p_acctype,double p_accbalance,bool p_accisactive)
        {
            var result = accObj.AddAccount(p_accname,p_acctype,p_accbalance,p_accisactive);
            ViewBag.accno = result;
            return View();
        }
        [HttpPost]
        public ActionResult UpdateAccount(int p_accno,string p_accname, string p_acctype, double p_accbalance, bool p_accisactive)
        {
            var result = accObj.UpdateAccount(p_accno,p_accname, p_acctype, p_accbalance, p_accisactive);
            return View("AllAccounts", accObj.GetAllAccounts());
        }
        #endregion
    }
}