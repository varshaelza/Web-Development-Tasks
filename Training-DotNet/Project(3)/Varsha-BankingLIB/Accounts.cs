using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varsha_BankingLIB
{
    public abstract class Accounts
    {
        //#region Variables
        //string v_accNo;
        //string v_accName;
        ////string v_accType;
        //double v_accBalance;
        //bool v_accIsactive;
        //#endregion

        #region Properties
        public string AccNo { get; set; }

        public string AccName { get; set; }

        public double AccBalance { get; set; }

        public bool AccIsactive { get; set; }

        //public string AccNo
        //{
        //    get
        //    {
        //        return v_accNo;
        //    }
        //    set
        //    {
        //        v_accNo = value;
        //    }
        //}
        //public string AccName
        //{
        //    get
        //    {
        //        return v_accName;
        //    }
        //    set
        //    {
        //        v_accName = value;
        //    }
        //}
        //public string AccType
        //{
        //    get
        //    {
        //        return v_accType;
        //    }
        //    set
        //    {
        //        v_accType = value;
        //    }
        //}
        //public double AccBalance
        //{
        //    get
        //    {
        //        return v_accBalance;
        //    }
        //    set
        //    {
        //        v_accBalance = value;
        //    }
        //}
        //public bool AccIsactive
        //{
        //    get
        //    {
        //        return v_accIsactive;
        //    }
        //    set
        //    {
        //        v_accIsactive = value;
        //    }
        //}

        #endregion

        #region Constructors
        public Accounts(string p_accName,double p_accBalance,bool p_accIsactive)
        {
            
            this.AccName = p_accName;
            this.AccBalance = p_accBalance;
            this.AccIsactive = p_accIsactive;
        }
        #endregion
        #region Methods
        public virtual bool Withdraw(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Cannot withdraw amount less than 0");
                return false;
            }
            else
            {
                this.AccBalance = this.AccBalance - amount;
                return true;
            }
        }

        public virtual bool Deposit(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Cannot deposit amount less than 0");
                return false;
            }
            else
            {
                this.AccBalance = this.AccBalance + amount;
                return true;
            }
        }
        #endregion
    }
}

