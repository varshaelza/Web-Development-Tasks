using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Accounts> accList = new List<Accounts>() {
                new Accounts() { AccNo = 101, AccName = "Varsha", AccType = "Savings", AccBalance = 10000, AccIsActive = true },
                new Accounts() { AccNo = 102, AccName = "Gikku", AccType = "Current", AccBalance = 20000, AccIsActive = true },
                new Accounts() { AccNo = 103, AccName = "Meera", AccType = "PF", AccBalance = 10800, AccIsActive = false },
                new Accounts() { AccNo = 104, AccName = "Aakash", AccType = "PF", AccBalance = 250000, AccIsActive = true },
                new Accounts() { AccNo = 105, AccName = "Aleena", AccType = "Savings", AccBalance = 90000, AccIsActive = true },
                new Accounts() { AccNo = 106, AccName = "Vinaya", AccType = "Savings", AccBalance = 70000, AccIsActive = true },
                new Accounts() { AccNo = 107, AccName = "Aju", AccType = "Current", AccBalance = 50000, AccIsActive = false },
                new Accounts() { AccNo = 108, AccName = "Roshy", AccType = "Savings", AccBalance = 70600, AccIsActive = true },
                new Accounts() { AccNo = 109, AccName = "Harry", AccType = "Savings", AccBalance = 45000, AccIsActive = true },
                new Accounts() { AccNo = 110, AccName = "Sreelakshmi", AccType = "PF", AccBalance = 150000, AccIsActive = false },
                new Accounts() { AccNo = 111, AccName = "Ayona", AccType = "Savings", AccBalance = 85000, AccIsActive = true },
                new Accounts() { AccNo = 112, AccName = "Thomas", AccType = "Current", AccBalance = 86000, AccIsActive = true },
                new Accounts() { AccNo = 113, AccName = "Linu", AccType = "PF", AccBalance =88800, AccIsActive = false },
                new Accounts() { AccNo = 114, AccName = "Vinu", AccType = "PF", AccBalance =1000, AccIsActive = true },
                new Accounts() { AccNo = 115, AccName = "Manoj", AccType = "Savings", AccBalance = 9000, AccIsActive = true },
                new Accounts() { AccNo = 116, AccName = "Christina", AccType = "Savings", AccBalance = 78000, AccIsActive = true },
                new Accounts() { AccNo = 117, AccName = "Vincy", AccType = "Current", AccBalance = 5000, AccIsActive = false },
                new Accounts() { AccNo = 118, AccName = "Malavika", AccType = "Savings", AccBalance = 7600, AccIsActive = true },
                new Accounts() { AccNo = 119, AccName = "Devi", AccType = "Savings", AccBalance = 4000, AccIsActive = true },
                new Accounts() { AccNo = 120, AccName = "Sanjana", AccType = "PF", AccBalance = 190000, AccIsActive = false },

            };
            //var data = from a in accList select a;
            //Console.WriteLine(data.GetType());
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.AccNo);
            //    Console.WriteLine(item.AccName);
            //    Console.WriteLine(item.AccType);
            //    Console.WriteLine(item.AccBalance);
            //    Console.WriteLine(item.AccIsActive);
            //}
            //var data = from a in accList orderby a.AccName descending select a;
            //Console.WriteLine(data.GetType());
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.AccNo);
            //    Console.WriteLine(item.AccName);
            //    Console.WriteLine(item.AccType);
            //    Console.WriteLine(item.AccBalance);
            //    Console.WriteLine(item.AccIsActive);
            //}
            //var data = from a in accList where a.AccNo>115 select a;
            //Console.WriteLine(data.GetType());
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.AccNo);
            //    Console.WriteLine(item.AccName);
            //    Console.WriteLine(item.AccType);
            //    Console.WriteLine(item.AccBalance);
            //    Console.WriteLine(item.AccIsActive);
            //}
            //var data = from a in accList where a.AccNo > 115 && a.AccIsActive==true select a;
            //Console.WriteLine(data.GetType());
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.AccNo);
            //    Console.WriteLine(item.AccName);
            //    Console.WriteLine(item.AccType);
            //    Console.WriteLine(item.AccBalance);
            //    Console.WriteLine(item.AccIsActive);
            //}
            //var noofAccounts = (from a in accList select a).Count();
            //Console.WriteLine(noofAccounts.GetType());
            //Console.WriteLine(noofAccounts);
            //var totalbalance = (from a in accList where a.AccNo>119 select a.AccBalance).Sum();
            //Console.WriteLine(totalbalance.GetType());
            //Console.WriteLine(totalbalance);
            //var totalactive = (from a in accList where a.AccIsActive==true select a).Count();
            //Console.WriteLine(totalactive.GetType());
            //Console.WriteLine(totalactive);
            //var data = from a in accList where a.AccName.StartsWith("V") select a;
            //Console.WriteLine(data.GetType());
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.AccNo);
            //    Console.WriteLine(item.AccName);
            //    Console.WriteLine(item.AccType);
            //    Console.WriteLine(item.AccBalance);
            //    Console.WriteLine(item.AccIsActive);
            //}

            //var data = from a in accList select new { no = a.AccNo, name = a.AccName, bal = a.AccBalance, type = a.AccType, bonus = 500, active = a.AccIsActive };
            //Console.WriteLine(data.GetType());
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.no);
            //    Console.WriteLine(item.name);
            //    Console.WriteLine(item.type);
            //    Console.WriteLine(item.bal);
            //    Console.WriteLine(item.active);
            //    Console.WriteLine(item.bonus);
            //}
            
        }
    }
}
