using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplicationLIB
{
    public class PF:Accounts
    {
        #region Variables
        #endregion

        #region Properties
        #endregion

        #region Methods
        public override void Withdraw(double amount)
        {
            if (amount > 75000)
            {
                Console.WriteLine("Cannot withdraw more than 75000");
            }
            else
            {
                base.Withdraw(amount);
            }
        }
        #endregion
    }
}
