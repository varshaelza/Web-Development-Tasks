using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varsha_BankingLIB
{
    public class PF:Accounts
    {
        #region Variables
        //static int autopfNo=100; 
        #endregion

        #region Constructors

        public PF():base()
        {

        }
        public PF( string p_accName, double p_accBalance, bool p_accIsactive) : base(p_accName, p_accBalance, p_accIsactive, "C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Project\\Accounts\\PF Accounts\\autoPFNo.txt")
        {
            
        }
        #endregion
        #region Methods
        public override bool Withdraw(double amount)
        {
            if (amount > 50000)
            {
                Console.WriteLine("Unable to process request as maximum withdrawal amount is 50000");
                return false;
            }
            else
            {
                return base.Withdraw(amount);
            }
            
        }
        public override bool Deposit(double amount)
        {
             return base.Deposit(amount);
        }
        #endregion
    }
}
