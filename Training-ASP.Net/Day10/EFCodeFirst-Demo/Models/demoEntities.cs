using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;


namespace EFCodeFirst_Demo.Models
{
    public class demoEntities:DbContext
    {
        #region Properties
        public DbSet<Employee> Employees;
        public DbSet<Account> Accounts;
        //public demoEntities():base("")
        //{

        //}
        #endregion
    }
}