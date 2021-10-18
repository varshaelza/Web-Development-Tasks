using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Demo
{
    public class Calculations
    {
        public int Addition(int num1,int num2)
        {
            if(num1<0||num2<0)
            {
                throw new Exception("Number has to be positive");
            }
            else if (num2>num1)
            {
                throw new Exception("Second number has to be smaller than first number");
            }
            else
            {
                return num1 + num2;
            }
        }
    }
}
