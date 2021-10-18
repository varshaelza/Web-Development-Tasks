using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Exception_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Calculations and Files exceptions
            Calculations calObj = new Calculations();
            bool continueAdd = true;
            FileStream myFile = null;
            StreamWriter wr = null;
            while (continueAdd)
            {
                int num1 = 0, num2 = 0;
                try
                {
                    Console.Clear();
                    Console.WriteLine("Enter First Number");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    int sum = calObj.Addition(num1, num2);
                    myFile = new FileStream("C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Day7\\Hello.txt", FileMode.Open, FileAccess.Write);
                    wr = new StreamWriter(myFile);
                    wr.WriteLine("Sum of " + num1 + "and " + num2 + "is " + sum);
                    wr.Close();
                    myFile.Close();

                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Format of input");
                    continueAdd = false;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Dividion by zero not possible");
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("File is not found");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continueAdd = false;
                }
                finally
                {
                    if (wr != null)
                    {
                        wr.Close();
                    }
                    if (myFile != null)
                    {
                        myFile.Close();
                    }
                    Console.WriteLine("Thankyou for visiting" + typeof(int));
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                }

            }
            #endregion

           
        }
    }
}
