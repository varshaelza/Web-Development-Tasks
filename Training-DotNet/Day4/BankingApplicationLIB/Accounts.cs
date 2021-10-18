using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplicationLIB
{
    public abstract class Accounts
    {
        #region Variables
        int v_accNo;
        string v_accName;
        double v_accBalance;
        bool v_accIsactive;
        #endregion

        #region Properties
        public int AccNo
        {
            get
            {
                return v_accNo;
            }
            set
            {
                v_accNo = value;
            }
        }
        public string AccName
        {
            get
            {
                return v_accName;
            }
            set
            {
                v_accName = value;
            }
        }
        public double AccBalance
        {
            get
            {
                return v_accBalance;
            }
            set
            {
                v_accBalance = value;
            }
        }
        public bool AccIsactive
        {
            get
            {
                return v_accIsactive;
            }
            set
            {
                v_accIsactive = value;
            }
        }

        #endregion

        #region Methods
        public virtual void Withdraw(double amount)
        {
            if(amount<0)
            {
                Console.WriteLine("Cannot withdraw a negative amount");
            }
            else if(amount>75000)
            {
                Console.WriteLine("Cannot withdraw more than 75000");
            }
            this.AccBalance = this.AccBalance - amount;

        }

        public void Deposit(double amount)
        {
            this.AccBalance = this.AccBalance + amount;
        }
        #endregion
    }
}
