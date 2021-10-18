using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileIO_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Writing to File
            //FileStream myFile = new FileStream("C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Day6\\mytext.txt", FileMode.Create, FileAccess.Write);
            //StreamWriter pen = new StreamWriter(myFile);
            //pen.WriteLine("Hello !I am Varsha.");
            //pen.WriteLine("I am a S/W Engineer.");
            //pen.WriteLine("I work at SOTI.");
            //string text;
            //do
            //{
            //    text = Console.ReadLine();
            //    if (text != "")
            //    {
            //        pen.WriteLine(text);
            //    }
            //} while (text != "");
            //pen.Close();
            //myFile.Close();
            //Console.WriteLine("Details writtem to mytext.txt");
            #endregion


            #region Reading from File
            //FileStream myFile = new FileStream("C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Day6\\mytext.txt", FileMode.Open, FileAccess.Read);
            //StreamReader rd = new StreamReader(myFile);
            //Console.WriteLine(rd.ReadLine());
            //Console.WriteLine(rd.ReadLine());
            //Console.WriteLine(rd.ReadLine());
            //Console.WriteLine(rd.ReadLine());
            //Console.WriteLine(rd.ReadLine());
            //Console.WriteLine(rd.ReadLine()+"\n\n");
            //rd.Close();
            //myFile.Close();
            #endregion

            #region Read File to end
            //FileStream myFile = new FileStream("C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Day6\\mytext.txt", FileMode.Open, FileAccess.Read);
            //StreamReader rd = new StreamReader(myFile);
            //Console.WriteLine(rd.ReadToEnd());
            #endregion

            #region Account no File
            //FileStream accnoFile = new FileStream("C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Day6\\accountno.txt", FileMode.Create, FileAccess.Write);
            //StreamWriter wr = new StreamWriter(accnoFile);
            //wr.WriteLine(1);
            //wr.Close();
            //accnoFile.Close();

            //accnoFile=new FileStream("C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Day6\\accountno.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //StreamReader rd = new StreamReader(accnoFile);
            //int accNo = Convert.ToInt32(rd.ReadLine());
            //rd.Close();
            //accnoFile.Close();

            //accNo++;
            //accnoFile = new FileStream("C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Day6\\accountno.txt", FileMode.Create, FileAccess.Write);
            //wr = new StreamWriter(accnoFile);
            //wr.WriteLine(accNo);
            //wr.Close();
            //accnoFile.Close();
            #endregion

            #region Employee 
            //Employee empObj1 = new Employee("Varsha", "SDE", 10000);
            //Console.WriteLine("Employee Number -" + empObj1.EmpNo);
            #endregion

            #region Menu
            bool continuetask = true;
            while (continuetask == true)
            {
                Console.Clear();
                Console.WriteLine("Options\n1.Create Manager\n2.Create Developer \n3.Create HR\n4.Exit\nEnter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter designation");
                        string designation = Console.ReadLine();
                        Console.WriteLine("Enter salary");
                        double salary = Convert.ToDouble(Console.ReadLine());
                        Manager manObj1 = new Manager(name, designation, salary);
                        Console.WriteLine("Manager Number -" + manObj1.EmpNo);
                        //Console.WriteLine("Manager Name -" + manObj1.EmpName);
                        //Console.WriteLine("Manager Designation -" + manObj1.EmpDesignation);
                        //Console.WriteLine("Manager Salary -" + manObj1.EmpSalary);
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter name");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter designation");
                        designation = Console.ReadLine();
                        Console.WriteLine("Enter salary");
                        salary = Convert.ToDouble(Console.ReadLine());
                        Developer devObj1 = new Developer(name, designation, salary);
                        Console.WriteLine("\nDeveloper Number -" + devObj1.EmpNo);
                        //Console.WriteLine("Developer Name -" + devObj1.EmpName);
                        //Console.WriteLine("Developer Designation -" + devObj1.EmpDesignation);
                        //Console.WriteLine("Developer Salary -" + devObj1.EmpSalary);
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter name");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter designation");
                        designation = Console.ReadLine();
                        Console.WriteLine("Enter salary");
                        salary = Convert.ToDouble(Console.ReadLine());
                        HR hrObj1 = new HR(name, designation, salary);
                        Console.WriteLine("\nHR Number -" + hrObj1.EmpNo);
                        //Console.WriteLine("HR Name -" + hrObj1.EmpName);
                        //Console.WriteLine("HR Designation -" + hrObj1.EmpDesignation);
                        //Console.WriteLine("HR Salary -" + hrObj1.EmpSalary);
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        break;
                    case 4:
                        continuetask = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            #endregion
        }
    }
}
