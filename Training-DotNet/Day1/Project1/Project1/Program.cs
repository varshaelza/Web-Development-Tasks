using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Hello
            //Console.Writeline("hello everyone!this is .net!");
            //string name = "varsha elza gikku";
            //int age = 21;
            //double height = 5.1;
            //Console.Writeline("name - " + name + " , age - " + age + "height" + height+"\n");
            #endregion

            #region Calculation1
            //int num1=10;
            //int num2=5;
            //int sum = num1 + num2;
            //int diff = num1 - num2;
            //int prod = num1 * num2;
            //int quo = num1 / num2;
            //Console.WriteLine("Sum="+sum + " " +"Difference="+ diff + " " + "Product=" + prod + " " + "Quotient=" + quo);
            #endregion

            #region Calculation2
            //Console.WriteLine("Enter first number");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter second number");
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int sum = num1 + num2;
            //int diff = num1 - num2;
            //int prod = num1 * num2;
            //int quo = num1 / num2;
            //Console.WriteLine("Sum=" + sum + " " + "Difference=" + diff + " " + "Product=" + prod + " " + "Quotient=" + quo);
            #endregion

            #region Condition if-else
            //Console.WriteLine("Enter  number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num > 10)
            //    Console.WriteLine("Big");
            //else
            //    Console.WriteLine("Small");
            #endregion

            #region Condion Multilevel if-else
            //Console.WriteLine("Enter number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num <= 10)
            //    Console.WriteLine("Less than or equal to 10");
            //else if (num < 20)
            //    Console.WriteLine("Between 10 and 20");
            //else
            //    Console.WriteLine("Greater than or qual to 20");
            #endregion

            #region Iteration for loop 
            //int i ;
            //Console.WriteLine("Enter limit");
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (i = 1; i < n; i++) 
            //{
            //    Console.WriteLine(n + "x"+i+"="+(n*i));
            //}
            #endregion

            #region Iteration while loop 
            //Console.WriteLine("Enter message");
            //string n = Console.ReadLine();
            //while(n!="")
            //{
            //    Console.WriteLine(n);
            //    Console.WriteLine("Enter next message");
            //     n =Console.ReadLine();
            //}
            #endregion

            #region TASK1
            //int tot = 0, n = 0, p = 0, e = 0, o = 0;
            //Console.WriteLine("Enter number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //while (num != 0)
            //{
            //    if (num < 0)
            //        n++;
            //    else if (num > 0)
            //        p++;
            //    if (num % 2 == 0)
            //        e++;
            //    else
            //        o++;
            //    tot++;
            //    Console.WriteLine(num);
            //    Console.WriteLine("Enter next number");
            //    num = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("Total = " + tot);
            //Console.WriteLine("Negative = " + n);
            //Console.WriteLine("Positive = " + p);
            //Console.WriteLine("Odd = " + o);
            //Console.WriteLine("Even = " + e);
            #endregion

            #region  TASK2

            //int attempt = 1;
            //while (count < 4)
            //{
            //    Console.WriteLine("Enter Username :");
            //    string username = Console.ReadLine();
            //    Console.WriteLine("Enter Password :");
            //    string password = Console.ReadLine();
            //    if (username != "Varsha" || password != "training@12345")
            //    {

            //        Console.WriteLine("Invalid credentials.");
            //        Console.WriteLine("Press Enter to retry");
            //        Console.ReadLine();
            //        Console.Clear();
            //        attempt++;
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Welcome " + username);
            //        break;
            //    }
            //}
            //if (attempt == 4)
            //{
            //    Console.WriteLine("Account Locked .Contact admin to unlock .");
            //}

            #endregion

            #region Switchstatements
            int n = 3;
            switch (n)
            {
                case 1:
                    Console.WriteLine("one");
                    break;

                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
            }
                #endregion
             
            Console.ReadLine();
        }
    }
}
