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
            //#List<Employee> empList = new List<Employee>();
            //Employee empObj1 = new Employee("Varsha", "SDE", 10000);
            //Employee empObj2 = new Employee("Namitha", "SDET", 20000);
            //Employee empObj3 = new Employee("Divya", "HR", 30000);
            //empList.Add(empObj1);
            //empList.Add(empObj2);
            //empList.Add(empObj3);
            //foreach(Employee emp in empList)
            //{
            //    Console.WriteLine(emp.EmpNo);
            //}
            HR hrObj1 = new HR("Varsha", "SrHr", 10000);
            HR hrObj2 = new HR("Namitha", "JrHr", 20000);
            HR hrObj3=new HR("Divya", "AsstHr", 30000);
            Console.WriteLine("HR\n"+hrObj1.EmpNo);
            Console.WriteLine(hrObj2.EmpNo);
            Console.WriteLine(hrObj3.EmpNo);

            Developer devObj1 = new Developer("Varsha", "SrDev", 10000);
            Developer devObj2 = new Developer("Namitha", "JrDev", 20000);
            Developer devObj3 = new Developer("Divya", "AsstDev", 30000);
            Console.WriteLine("\nDeveloper\n" + devObj1.EmpNo);
            Console.WriteLine(devObj2.EmpNo);
            Console.WriteLine(devObj3.EmpNo);

            Manager manObj1 = new Manager("Varsha", "SrMan", 10000);
            Manager manObj2 = new Manager("Namitha", "JrMan", 20000);
            Manager manObj3 = new Manager("Divya", "AsstMan", 30000);
            Console.WriteLine("\nManager\n" + manObj1.EmpNo);
            Console.WriteLine(manObj2.EmpNo);
            Console.WriteLine(manObj3.EmpNo);


        }
    }
}
