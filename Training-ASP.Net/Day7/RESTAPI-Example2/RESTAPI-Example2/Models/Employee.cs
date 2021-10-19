using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTAPI_Example2.Models
{
    public class Employee
    {
        public int empNo { get; set; }
        public string empName { get; set; }
        public double empSalary { get; set; }
        public bool empIsPermanent { get; set; }
        public string empDesignation { get; set; }

        static List<Employee> eList = new List<Employee>();

        public void dummyData()
        {
            eList.Add(new Employee (){empNo=101, empName="Varsha",empSalary= 20000, empIsPermanent=true,empDesignation= "Manager"});
            eList.Add(new Employee() { empNo = 102, empName = "Vincy", empSalary = 25000, empIsPermanent = false, empDesignation = "HR" });
            eList.Add(new Employee() { empNo = 103, empName = "Christina", empSalary = 30000, empIsPermanent = true, empDesignation = "Developer" });
            eList.Add(new Employee() { empNo = 104, empName = "Malavika", empSalary = 35000, empIsPermanent = true, empDesignation = "HR" });
            eList.Add(new Employee() { empNo = 105, empName = "Aleena", empSalary = 40000, empIsPermanent = false, empDesignation = "Developer" });
        }
        public List<Employee> GetAllemployees()
        {
            if (eList.Count == 0)
                dummyData();
            return eList;
        }

        public Employee GetById(int id)
        {
            if (eList.Count == 0)
                dummyData();
            var emp = (from e in eList
                       where e.empNo == id
                       select e).Single();
            return emp;

        }
        public int AddEmployee(Employee newEmp)
        {
            if (eList.Count == 0)
                dummyData();
            eList.Add(newEmp);
            return 1;
        }
        public int UpdateEmployee(Employee empObj)
        {
            if (eList.Count == 0)
                dummyData();
            var emp = (from e in eList
                       where e.empNo == empObj.empNo
                       select e).Single();

            emp.empName = empObj.empName;
            emp.empDesignation = empObj.empDesignation;
            emp.empSalary = empObj.empSalary;

            return 1;
        }
        public int DeleteEmployee(int id)
        {
            if (eList.Count == 0)
                dummyData();
            var emp = (from e in eList
                       where e.empNo == id
                       select e).Single();
            eList.Remove(emp);
            return 1;
        }
    }
}