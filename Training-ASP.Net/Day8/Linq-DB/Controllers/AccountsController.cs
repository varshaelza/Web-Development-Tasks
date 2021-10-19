using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Linq_DB.Models;

namespace Linq_DB.Controllers
{
    public class AccountsController : ApiController
    {
        Banking_DBEntities1 db = new Banking_DBEntities1();
        //public List<BankAccountsInfo> GetAllAccounts()
        //{
        //    var data = (from a in db.BankAccountsInfoes select a).ToList();
        //    return data;
        //}
        //public List<BankAccountsInfo> GetAccountbyType(string type)
        //{
        //    var data = (from a in db.BankAccountsInfoes where a.AccType == type select a).ToList();
        //    return data;
        //}
        public List<BankAccountsInfo> GetActiveAccount()
        {
            var data = (from a in db.BankAccountsInfoes where a.AccIsActive == true select a).ToList();
            return data;
        }
    }
}
