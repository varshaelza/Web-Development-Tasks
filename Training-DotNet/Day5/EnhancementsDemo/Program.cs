using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnhancementsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region var
            var obj1 = new Class1() { ID = 101, Name = "Varsha", Designation = "HR" };
            //Console.WriteLine(obj1.GetType());
            //Console.WriteLine(obj1.ID + " " + obj1.Name + " " + obj1.Designation);
            #endregion

            #region Optional parameters and Params int[]
            Console.WriteLine("Sum is - " + obj1.Addition(1,2));
            //Console.WriteLine("You need to pay rupees - " + obj1.BuyNow("Phone",5,1000));
            //Console.WriteLine("You need to pay rupees - " + obj1.BuyNow("Phone", 5, 1000,"AUG10"));
            //Console.WriteLine("You need to pay rupees - " + obj1.BuyNow("Phone", 5, 1000,"AUG20"));
            #endregion

            #region Simple Interest
            Console.WriteLine("Enter principle");
            double principle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ROI=9,Duration=10,SI= " + obj1.CalculateSimpleinterest(principle, 9, 10));
            Console.WriteLine("ROI=default,Duration=default,SI= " + obj1.CalculateSimpleinterest(principle));
            #endregion
            #region Anonymous Object
            //var obj2 = new { No = 1, Name = "Varsha" };
            //Console.WriteLine(obj2.GetType());
            //Console.WriteLine(obj2.No + " " + obj2.Name + " " );
            #endregion

        }
    }
}
