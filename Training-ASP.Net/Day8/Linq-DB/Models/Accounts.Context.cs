﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Linq_DB.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Banking_DBEntities1 : DbContext
    {
        public Banking_DBEntities1()
            : base("name=Banking_DBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BankAccountsInfo> BankAccountsInfoes { get; set; }
    
        public virtual int proc_AddNewAccount(string p_accname, string p_acctype, Nullable<double> p_accbalance, Nullable<bool> p_accisactive, ObjectParameter p_accno)
        {
            var p_accnameParameter = p_accname != null ?
                new ObjectParameter("p_accname", p_accname) :
                new ObjectParameter("p_accname", typeof(string));
    
            var p_acctypeParameter = p_acctype != null ?
                new ObjectParameter("p_acctype", p_acctype) :
                new ObjectParameter("p_acctype", typeof(string));
    
            var p_accbalanceParameter = p_accbalance.HasValue ?
                new ObjectParameter("p_accbalance", p_accbalance) :
                new ObjectParameter("p_accbalance", typeof(double));
    
            var p_accisactiveParameter = p_accisactive.HasValue ?
                new ObjectParameter("p_accisactive", p_accisactive) :
                new ObjectParameter("p_accisactive", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_AddNewAccount", p_accnameParameter, p_acctypeParameter, p_accbalanceParameter, p_accisactiveParameter, p_accno);
        }
    
        public virtual int proc_DeleteAccount(Nullable<int> p_accno)
        {
            var p_accnoParameter = p_accno.HasValue ?
                new ObjectParameter("p_accno", p_accno) :
                new ObjectParameter("p_accno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_DeleteAccount", p_accnoParameter);
        }
    
        public virtual ObjectResult<proc_GetAccountByNo_Result> proc_GetAccountByNo(Nullable<int> p_accno)
        {
            var p_accnoParameter = p_accno.HasValue ?
                new ObjectParameter("p_accno", p_accno) :
                new ObjectParameter("p_accno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetAccountByNo_Result>("proc_GetAccountByNo", p_accnoParameter);
        }
    
        public virtual ObjectResult<proc_GetAccountByType_Result> proc_GetAccountByType(string accType)
        {
            var accTypeParameter = accType != null ?
                new ObjectParameter("accType", accType) :
                new ObjectParameter("accType", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetAccountByType_Result>("proc_GetAccountByType", accTypeParameter);
        }
    
        public virtual ObjectResult<proc_GetAllAccounts_Result> proc_GetAllAccounts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<proc_GetAllAccounts_Result>("proc_GetAllAccounts");
        }
    
        public virtual int proc_UpdateAccount(Nullable<int> p_accno, string p_accname, string p_acctype, Nullable<double> p_accbalance, Nullable<bool> p_accisactive)
        {
            var p_accnoParameter = p_accno.HasValue ?
                new ObjectParameter("p_accno", p_accno) :
                new ObjectParameter("p_accno", typeof(int));
    
            var p_accnameParameter = p_accname != null ?
                new ObjectParameter("p_accname", p_accname) :
                new ObjectParameter("p_accname", typeof(string));
    
            var p_acctypeParameter = p_acctype != null ?
                new ObjectParameter("p_acctype", p_acctype) :
                new ObjectParameter("p_acctype", typeof(string));
    
            var p_accbalanceParameter = p_accbalance.HasValue ?
                new ObjectParameter("p_accbalance", p_accbalance) :
                new ObjectParameter("p_accbalance", typeof(double));
    
            var p_accisactiveParameter = p_accisactive.HasValue ?
                new ObjectParameter("p_accisactive", p_accisactive) :
                new ObjectParameter("p_accisactive", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("proc_UpdateAccount", p_accnoParameter, p_accnameParameter, p_acctypeParameter, p_accbalanceParameter, p_accisactiveParameter);
        }
    }
}
