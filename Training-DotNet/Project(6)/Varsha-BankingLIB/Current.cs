using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varsha_BankingLIB
{
    public class Current:Accounts
    {
        #region Variables
        //static int autocurNo = 100;
        #endregion

        #region Constructors

        public Current():base()
        {

        }
        public Current(string p_accName, double p_accBalance, bool p_accIsactive):base( p_accName, p_accBalance, p_accIsactive, "C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Project\\Accounts\\Current Accounts\\autoCurNo.txt")
        {
           
        }
        #endregion
        #region Methods
        public override bool Withdraw(double amount)
        {
            if (amount > 25000)
            {
                Console.WriteLine("Unable to process request as maximum withdrawal amount is 25000");
                return false;
            }
            else
            {
                return base .Withdraw(amount);
            }
            
        }
        public override bool Deposit(double amount)
        {
            if (amount > 75000)
            {
                Console.WriteLine("Unable to process request as maximum deposit amount is 75000");
                return false;
            }
            else
            {
                return base.Deposit(amount);
            }
            
        }
        #endregion
    }
}
