using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementLIB;

namespace EmployeeManagementCON
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Objects
            //Employee empObj = new Employee();
            Manager manObj = new Manager(0,"",ManagerDesignations.AssistantManager,10000,15);
            HR hrObj = new HR(0, "", HRDesignations.ClientHR, 10000, 15);
            Developer devObj = new Developer(0, "", DeveloperDesignations.Backend, 10000, 15);
            #endregion

            #region Leave application


            Console.WriteLine("How many leaves does manager wish to apply");
            int manleaves = Convert.ToInt32(Console.ReadLine());
            manObj.ApplyLeaves(manleaves);
            Console.WriteLine("Remaining leaves= " + manObj.EmpAvailableleaves + "\n-----------------------");

            Console.WriteLine("How many leaves does HR wish to apply");
            int hrleaves = Convert.ToInt32(Console.ReadLine());
            hrObj.ApplyLeaves(hrleaves);
            Console.WriteLine("Remaining leaves= " + hrObj.EmpAvailableleaves + "\n-----------------------");

            Console.WriteLine("How many leaves does Developer wish to apply");
            int devleaves = Convert.ToInt32(Console.ReadLine());
            devObj.ApplyLeaves(devleaves);
            Console.WriteLine("Remaining leaves= " + devObj.EmpAvailableleaves + "\n-----------------------");
            #endregion

            #region Bonus Calculation
            Console.WriteLine("Initial Salary of Manager is " + manObj.EmpSalary);
            manObj.Bonus();
            Console.WriteLine("Final Salary of Manager is " + manObj.EmpSalary);

            Console.WriteLine("\nInitial Salary of Developer is " + devObj.EmpSalary);
            devObj.Bonus();
            Console.WriteLine("Final Salary of Developer is " + devObj.EmpSalary);

            Console.WriteLine("\nInitial Salary of HR is " + hrObj.EmpSalary);
            hrObj.Bonus();
            Console.WriteLine("Final Salary of HR is " + hrObj.EmpSalary);

            #endregion
        }
    }
}

