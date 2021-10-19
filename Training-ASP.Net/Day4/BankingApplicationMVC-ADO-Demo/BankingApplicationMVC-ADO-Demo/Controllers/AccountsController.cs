using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BankingApplicationMVC_ADO_Demo.Models;

namespace BankingApplicationMVC_ADO_Demo.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        Accounts accObj = new Accounts();
        #region HTTPGet
        public ActionResult AllAccounts()
        {
            
            return View(accObj.GetAllData());
        }
        public ActionResult AccountbyNo()
        {
            return View();
        }
        public ActionResult AddAccount()
        {
            return View();
        }
        public ActionResult DeleteAccount()
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
        public ActionResult AccountbyNo(string p_accNo)
        {
            return View(accObj.GetByAccNo(p_accNo));
        }
        [HttpPost]
        public ActionResult AddAccount(string p_accNo, string p_accName, string p_accType, double p_accBalance, bool p_accIsactive)
        {
            var result = accObj.AddAccount(p_accNo, p_accName,p_accType,p_accBalance,p_accIsactive);
            return View("AllAccounts", accObj.GetAllData());
        }
        [HttpPost]
        public ActionResult DeleteAccount(string p_accNo)
        {
            var result = accObj.DeleteAccount(p_accNo);
            return View("AllAccounts", accObj.GetAllData());
        }
        [HttpPost]
        public ActionResult UpdateAccount(string p_accNo, string p_accName,  double p_accBalance)
        {
            var result = accObj.UpdateAccount(p_accNo, p_accName, p_accBalance);
            return View("AllAccounts", accObj.GetAllData());
        }

        #endregion
    }
}