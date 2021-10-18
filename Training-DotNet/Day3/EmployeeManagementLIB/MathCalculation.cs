using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementLIB
{
    public class MathCalculation
    {
        #region Maths Operations
        public int Addition(int num1,int num2)
        {
            return num1 + num2;
        }

        public int Subtraction(int num1,int num2)
        {
            return num1 - num2;
        }

        public int Multiplication(int num1,int num2)
        {
            return num1 * num2;
        }

        public double Division (int num1,int num2)
        {
            double quotient= num1*1.0 / num2;
            return quotient;
        }
        #endregion
        #region Interest Calculation
        public double SimpleInterest(double principle,double roi, int duration)
        {
            return (principle * roi * duration) / 100;
        }
        #endregion
        #region Greet User
        public string GreetUser(string guestName)
        {
            return ("Hello " + guestName + "!");
        }
        #endregion
    }
}
