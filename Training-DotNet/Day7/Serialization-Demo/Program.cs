using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Threading.Tasks;

namespace Serialization_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Binary Serialization and Deserialization
            //bool continueEmp = true;
            //int choice;
            //while (continueEmp == true)
            //{

            //    BinaryFormatter bf = new BinaryFormatter(); ;
            //    Console.Clear();
            //    Console.WriteLine("Options\n1.Add Employee - Binary\n2.View Employee - Binary\n3.Exit\nEnter your choice");
            //    choice = Convert.ToInt32(Console.ReadLine());
            //    switch(choice)
            //    {
            //        case 1:
            //            FileStream myFile = null;
            //            try
            //            {
            //                Employee empObj;
            //                Console.WriteLine("\nEnter employee name");
            //                string name = Console.ReadLine();
            //                Console.WriteLine("Enter employee designation");
            //                string designation = Console.ReadLine();
            //                Console.WriteLine("Enter employee salary");
            //                double salary = Convert.ToDouble(Console.ReadLine());
            //                empObj = new Employee(name, designation, salary);

            //                myFile= new FileStream("C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Day7\\Employees\\" + empObj.EmpNo + ".dat", FileMode.Create, FileAccess.Write);
            //                bf.Serialize(myFile, empObj);
            //                myFile.Close();
            //                Console.WriteLine("Object is Serialized");
            //            }
            //            catch (FileNotFoundException ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //            catch (IOException ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //            catch(System.Runtime.Serialization.SerializationException ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //            catch (Exception ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //            finally
            //            {
            //                if(myFile!=null)
            //                {
            //                    myFile.Close();
            //                }
            //                Console.WriteLine("Press Enter to continue");
            //                Console.ReadLine();
            //            }
            //            break;
            //        case 2:
            //            try
            //            {
            //                Employee empObj2;
            //                Console.WriteLine("Enter employee number");
            //                string num = Console.ReadLine();
            //                myFile = new FileStream("C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Day7\\Employees\\" + num + ".dat", FileMode.Open, FileAccess.Read);
            //                empObj2 = (Employee)bf.Deserialize(myFile);
            //                Console.WriteLine("\nEmployee Number - " + empObj2.EmpNo);
            //                Console.WriteLine("Employee Name - " + empObj2.EmpName);
            //                Console.WriteLine("Employee Designation - " + empObj2.EmpDesignation);
            //                Console.WriteLine("Employee Salary - " + empObj2.EmpSalary);
            //                Console.WriteLine("Employee Remaining Leaves - " + empObj2.EmpLeaves);
            //            }
            //            catch(FileNotFoundException ex)
            //            {
            //                Console.WriteLine("No Such Employee");
            //            }
            //            catch(Exception ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //            finally
            //            {
            //                Console.WriteLine("Press Enter to continue");
            //                Console.ReadLine();
            //            }
            //            break;
            //        case 3:
            //            continueEmp = false;
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Choice");
            //            Console.WriteLine("Press Enter to continue");
            //            Console.ReadLine();
            //            break;

            //    }

            //}

            #endregion

            #region XML Serialization and Deserialization
            //bool continueEmp = true;
            //int choice;
            //while (continueEmp == true)
            //{

            //    XmlSerializer xs = new XmlSerializer(typeof(Employee));
            //    Console.Clear();
            //    Console.WriteLine("Options\n1.Add Employee - XML\n2.View Employee - XML\n3.Exit\nEnter your choice");
            //    choice = Convert.ToInt32(Console.ReadLine());
            //    switch (choice)
            //    {
            //        case 1:
            //            FileStream myFile = null;
            //            try
            //            {
            //                Employee empObj;
            //                Console.WriteLine("\nEnter employee name");
            //                string name = Console.ReadLine();
            //                Console.WriteLine("Enter employee designation");
            //                string designation = Console.ReadLine();
            //                Console.WriteLine("Enter employee salary");
            //                double salary = Convert.ToDouble(Console.ReadLine());
            //                empObj = new Employee(name, designation, salary);

            //                myFile = new FileStream("C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Day7\\Employees\\" + empObj.EmpNo + ".xml", FileMode.Create, FileAccess.Write);
            //                xs.Serialize(myFile, empObj);
            //                myFile.Close();
            //                Console.WriteLine("Object is Serialized");
            //            }
            //            catch (FileNotFoundException ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //            catch (IOException ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //            catch (Exception ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //            finally
            //            {
            //                if (myFile != null)
            //                {
            //                    myFile.Close();
            //                }
            //                Console.WriteLine("Press Enter to continue");
            //                Console.ReadLine();
            //            }
            //            break;
            //        case 2:
            //            try
            //            {
            //                Employee empObj2;
            //                Console.WriteLine("Enter employee number");
            //                string num = Console.ReadLine();
            //                myFile = new FileStream("C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Day7\\Employees\\" + num + ".xml", FileMode.Open, FileAccess.Read);
            //                empObj2 = (Employee)xs.Deserialize(myFile);
            //                Console.WriteLine("\nEmployee Number - " + empObj2.EmpNo);
            //                Console.WriteLine("Employee Name - " + empObj2.EmpName);
            //                Console.WriteLine("Employee Designation - " + empObj2.EmpDesignation);
            //                Console.WriteLine("Employee Salary - " + empObj2.EmpSalary);
            //                Console.WriteLine("Employee Remaining Leaves - " + empObj2.EmpLeaves);
            //            }
            //            catch (FileNotFoundException ex)
            //            {
            //                Console.WriteLine("No Such Employee");
            //            }
            //            catch (Exception ex)
            //            {
            //                Console.WriteLine(ex.Message);
            //            }
            //            finally
            //            {
            //                Console.WriteLine("Press Enter to continue");
            //                Console.ReadLine();
            //            }
            //            break;
            //        case 3:
            //            continueEmp = false;
            //            break;
            //        default:
            //            Console.WriteLine("Invalid Choice");
            //            Console.WriteLine("Press Enter to continue");
            //            Console.ReadLine();
            //            break;

            //    }

            //}
            #endregion

            #region SOAP Serialization and Deserialization
            bool continueEmp = true;
            int choice;
            while (continueEmp == true)
            {

                SoapFormatter sf = new SoapFormatter();
                Console.Clear();
                Console.WriteLine("Options\n\n1.Add Employee - SOAP\n2.View Employee - SOAP\n3.Apply Leave\n4.Get Bonus\n5.Exit\n\nEnter your choice");
                choice = Convert.ToInt32(Console.ReadLine());
                FileStream myFile = null;
                Employee empObj;
                switch (choice)
                {
                    
                    case 1:
                        Console.WriteLine("\nEnter employee name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter employee designation");
                        string designation = Console.ReadLine();
                        Console.WriteLine("Enter employee salary");
                        double salary = Convert.ToDouble(Console.ReadLine());
                        empObj = new Employee(name, designation, salary);
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter employee number");
                        string num = Console.ReadLine();
                        empObj = new Employee();
                        empObj.Deserialize(num);
                        Console.WriteLine("\nEmployee Number - " + empObj.EmpNo);
                        Console.WriteLine("Employee Name - " + empObj.EmpName);
                        Console.WriteLine("Employee Designation - " + empObj.EmpDesignation);
                        Console.WriteLine("Employee Salary - " + empObj.EmpSalary);
                        Console.WriteLine("Employee Remaining Leaves - " + empObj.EmpLeaves);
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("\nEnter employee number");
                        num = Console.ReadLine();
                        empObj = new Employee();
                        empObj.Deserialize(num);
                        Console.WriteLine("Available Leaves is " + empObj.EmpLeaves);
                        Console.WriteLine("\nEnter number of leaves");
                        int leaves = Convert.ToInt32(Console.ReadLine());
                        empObj.ApplyLeaves(leaves);
                        empObj.SerializeEmp();
                        Console.WriteLine("Remaining Leaves is " + empObj.EmpLeaves);
                           
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("\nEnter employee number");
                        num = Console.ReadLine();
                        empObj = new Employee();
                        empObj.Deserialize(num);
                        Console.WriteLine("Current Salary is " + empObj.EmpSalary);
                        Console.WriteLine("\nEnter percentage of bonus");
                        double bonus = Convert.ToDouble(Console.ReadLine());
                        empObj.GetBonus(bonus);
                        Console.WriteLine("Updated Salary is " + empObj.EmpSalary);
                        empObj.SerializeEmp();

                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        break;
                    case 5:
                        continueEmp = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        Console.WriteLine("Press Enter to continue");
                        Console.ReadLine();
                        break;

                }

            }
            #endregion
        }
    }
}
