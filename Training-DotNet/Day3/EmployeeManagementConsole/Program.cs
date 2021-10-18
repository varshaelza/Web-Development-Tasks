using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementLIB;

namespace EmployeeManagementConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Employee Objects
            Employee emp1 = new Employee();
            emp1.EmpID = 101;
            emp1.EmpName = "Varsha Elza Gikku";
            emp1.EmpSalary = 50000;
            emp1.EmpDesignation = "SDE";
            emp1.EmpIspermanent = true;

            Employee emp2 = new Employee();
            emp2.EmpID = 102;
            emp2.EmpName = "Namitha S";
            emp2.EmpSalary = 50000;
            emp2.EmpDesignation = "SDET";
            emp2.EmpIspermanent = true;

            Employee emp3 = new Employee();
            emp3.EmpID = 103;
            emp3.EmpName = "Divya Ann Kurien";
            emp3.EmpSalary = 50000;
            emp3.EmpDesignation = "SDE";
            emp3.EmpIspermanent = true;

            Employee emp4 = new Employee();
            emp4.EmpID = 104;
            emp4.EmpName = "Akshay Raveendran";
            emp4.EmpSalary = 50000;
            emp4.EmpDesignation = "SDET";
            emp4.EmpIspermanent = true;

            Employee emp5 = new Employee();
            emp5.EmpID = 105;
            emp5.EmpName = "Akshay P";
            emp5.EmpSalary = 50000;
            emp5.EmpDesignation = "SDE";
            emp5.EmpIspermanent = true;

            List<Employee> empList = new List<Employee>();
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            empList.Add(emp4);
            empList.Add(emp5);
            #endregion

            #region Display Employees
            //int total_Employees = empList.Count;
            //double total_Salary = 0;
            //foreach (Employee item in empList)
            //{
            //    Console.WriteLine("Employee " + item.EmpID + " Details");
            //    Console.WriteLine("Name : " + item.EmpName);
            //    Console.WriteLine("Salary : " + item.EmpSalary);
            //    Console.WriteLine("Designation : " + item.EmpDesignation);
            //    Console.WriteLine("Is Employee permanent : " + item.EmpIspermanent);
            //    Console.WriteLine("\n----------------------------------------------------------------------\n");
            //    total_Salary += item.EmpSalary;
            //}
            #endregion

            #region Bonus
            List<double> bonus = new List<double>();
            
            foreach (Employee item in empList)
            {
                bonus.Add(item.GetBonus());
                Console.WriteLine("Salary  of " + item.EmpName + " is " +item.EmpSalary+" and bonus(10%) is "+ bonus[bonus.Count - 1]);
            }
            foreach (Employee item in empList)
            {
                
                bonus.Add(item.GetBonus(15));
                Console.WriteLine("Salary  of " + item.EmpName + " is " + item.EmpSalary + " and bonus(15%) is " + bonus[bonus.Count - 1]);
            }



            #endregion

            #region Greetings
            //MathCalculation mathObj1 = new MathCalculation();
            //Console.WriteLine("Please enter your name");
            //string guestName = Console.ReadLine();
            //string greetMessage=mathObj1.GreetUser(guestName);
            //Console.WriteLine(greetMessage);
            #endregion

            #region Maths Calculations
            //MathCalculation mathObj2 = new MathCalculation();
            //Console.WriteLine("Enter 2 numbers");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());
            //int secondNumber = Convert.ToInt32(Console.ReadLine());
            //int sum = mathObj2.Addition(firstNumber, secondNumber);
            //int difference = mathObj2.Subtraction(firstNumber, secondNumber);
            //int product = mathObj2.Multiplication(firstNumber, secondNumber);
            //double quotient = mathObj2.Division(firstNumber, secondNumber);
            //Console.WriteLine("Sum of " + firstNumber + " and " + secondNumber + " is " + sum);
            //Console.WriteLine("Difference of " + firstNumber + " and " + secondNumber + " is " + difference);
            //Console.WriteLine("Product of " + firstNumber + " and " + secondNumber + " is " + product);
            //Console.WriteLine("Quotient on division of " + firstNumber + " with " + secondNumber + " is " + quotient);
            //Console.WriteLine("Press enter to continue");
            //Console.ReadLine();
            //Console.Clear();
            #endregion

            #region Simple Interest
            //Console.WriteLine("Enter principle amount");
            //double principle = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter rate of interest");
            //double roi = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter duration");
            //int duration = Convert.ToInt32(Console.ReadLine());
            //double simpleInterest = mathObj2.SimpleInterest(principle,roi,duration);
            //Console.WriteLine("Simple Interest is " + simpleInterest);
            #endregion

        }
    }
}
