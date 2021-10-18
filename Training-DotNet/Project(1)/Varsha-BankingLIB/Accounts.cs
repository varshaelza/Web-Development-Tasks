using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varsha_BankingLIB
{
    public class Accounts
    {
        #region Variables
        int v_accNo;
        string v_accName;
        string v_accType;
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
        public string AccType
        {
            get
            {
                return v_accType;
            }
            set
            {
                v_accType = value;
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
        public void Withdraw(double amount)
        {
            this.AccBalance = this.AccBalance - amount;

        }

        public void Deposit(double amount)
        {
            this.AccBalance = this.AccBalance + amount;
        }
        #endregion
    }
}

