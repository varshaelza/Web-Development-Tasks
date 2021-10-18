using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingApplicationLIB;

namespace BankingApplicationCON
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Objects
            Savings savObj = new Savings();
            Current curObj = new Current();
            PF pfObj = new PF();
            savObj.AccBalance = 100000;
            curObj.AccBalance = 100000;
            pfObj.AccBalance = 100000;
            #endregion

            #region Withdrawal
            Console.WriteLine("Initial balance of Savings account is " + savObj.AccBalance);
            Console.WriteLine("Enter amount to withdraw from savings account");
            int savAmount = Convert.ToInt32(Console.ReadLine());
            savObj.Withdraw(savAmount);
            Console.WriteLine("Final balance of Savings account is " + savObj.AccBalance);

            Console.WriteLine("-----------------------------------\nInitial balance of Current account is " + curObj.AccBalance);
            Console.WriteLine("Enter amount to withdraw from savings account");
            int curAmount = Convert.ToInt32(Console.ReadLine());
            curObj.Withdraw(curAmount);
            Console.WriteLine("Final balance of Current account is " + curObj.AccBalance);

            Console.WriteLine("-----------------------------------\nInitial balance of PF account is " + pfObj.AccBalance);
            Console.WriteLine("Enter amount to withdraw from savings account");
            int pfAmount = Convert.ToInt32(Console.ReadLine());
            pfObj.Withdraw(pfAmount);
            Console.WriteLine("Final balance of PF account is " + pfObj.AccBalance);
            #endregion

        }
    }
}
