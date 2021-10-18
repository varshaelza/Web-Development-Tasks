using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnhancementsDemo
{
    class Class1
    {
        public int ID{ get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }

        public int Addition(int p_num1=20,int p_num2=30,params int[] nums)
        {
            int sum= p_num1 + p_num2;
            foreach(var num in nums)
            {
                sum += num;
            }
            return sum;
        }

        public double BuyNow(string productName,int qty,double price,string discountCode="")
        {
            if(discountCode=="AUG10")
            {
                return (price * qty * 90 )/ 100;
            }
            else if (discountCode == "AUG20")
            {
                return (price * qty * 80) / 100;
            }
            else
            {
                return (price * qty * 95) / 100;
            }
        }
        public double CalculateSimpleinterest(double principle,double roi=8,int duration=1)
        {
            return (principle * roi * duration) / 100;
        }
    }
}
