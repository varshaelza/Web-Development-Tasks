using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplicationLIB
{
    public class Savings :Accounts
    {
        #region Variables
        #endregion

        #region Properties
        #endregion

        #region Methods
        public override void Withdraw(double amount)
        {
            if (amount > 20000)
            {
                Console.WriteLine("Cannot withdraw more than 20000");
            }
            else
            {
                base.Withdraw(amount);
            }
        }
        #endregion
    }
}
