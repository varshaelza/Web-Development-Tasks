using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Model_Demo.Models
{
    public class Employee
    {
        #region Properties and Static
        public string EmpNo { get; set; }
        public string EmpName { get; set; }
        public string EmpDesignation { get; set; }
        public double EmpSalary { get; set; }
        public bool EmpisPermanent { get; set; }
        public static List<Employee> EmpList = new List<Employee>();
        #endregion

        #region Constructors
        public Employee()
        {

        }

        #endregion

        #region Methods
        public void DefaultEmployeeList()
        {
            EmpList.Add(new Employee() { EmpNo = "EMP101", EmpName = "Varsha", EmpDesignation = "Sales", EmpisPermanent = true, EmpSalary = 6000 });
            EmpList.Add(new Employee() { EmpNo = "EMP102", EmpName = "Christina", EmpDesignation = "HR", EmpisPermanent = true, EmpSalary = 7000 });
            EmpList.Add(new Employee() { EmpNo = "EMP103", EmpName = "Vincy", EmpDesignation = "Sales", EmpisPermanent = false, EmpSalary = 6000 });
            EmpList.Add(new Employee() { EmpNo = "EMP104", EmpName = "Malavika", EmpDesignation = "Developer", EmpisPermanent = true, EmpSalary = 8000 });
            EmpList.Add(new Employee() { EmpNo = "EMP105", EmpName = "Sreelakshmi", EmpDesignation = "Developer", EmpisPermanent = false, EmpSalary = 8000 });
            EmpList.Add(new Employee() { EmpNo = "EMP106", EmpName = "Ayona ", EmpDesignation = "HR", EmpisPermanent = true, EmpSalary = 7000 });
        }
        public List<Employee> GetallEmployees()
        {
            if (EmpList.Count == 0)
            {
                DefaultEmployeeList();
            }
            return EmpList;
        }
        public Employee GetEmployeebyNo(string p_empNo)
        {
            var employee= (from e in EmpList
                           where e.EmpNo == p_empNo
                           select e).Single();
            return employee;
        }
        public bool AddEmployee(Employee emp)
        {
            if(emp.EmpNo.Length<3)
            {
                throw new Exception("Invalid Employee Name");
               
            }
            else if(emp.EmpNo.Length>1000)
            {
                throw new Exception("Invalid Employee Name");
                
            }
            EmpList.Add(emp);
            return true;
        }
        public bool DeleteEmployeebyNo(string p_empNo)
        {
            
            var employee=(from emp in EmpList where emp.EmpNo == p_empNo select emp).Single();
            EmpList.Remove(employee);
            if (employee != null)
            {
                return true;
            }
            return false;
        }

        public bool UpdateEmployeebyNo(string p_empNo, Employee p_emp)
        {
            var employee = (from emp in EmpList where emp.EmpNo == p_empNo select emp).Single();
            if (employee != null)
            {
                employee.EmpNo = p_emp.EmpNo;
                employee.EmpName = p_emp.EmpName;
                employee.EmpDesignation = p_emp.EmpDesignation;
                employee.EmpSalary = p_emp.EmpSalary;
                employee.EmpisPermanent = p_emp.EmpisPermanent;
                return true;
            }
            return false;
        }
        public bool UpdateStatus(string p_empNo, bool newstatus)
        {
            var employee = (from emp in EmpList where emp.EmpNo == p_empNo select emp).Single();
            if (employee != null)
            {
                if (newstatus == true)
                {
                    employee.EmpisPermanent = true;
                }
                else
                {
                    employee.EmpisPermanent = false;
                }
                return true;
            }
            return false;
        }

        public List<Employee> GetEmployeesbyStatus(string status)
        {
            List<Employee> result = new List<Employee>();
            bool statusbool;
            if(status=="Permanent")
            {
                statusbool = true;
            }
            else
            {
                statusbool = false;
            }
            result = (from emp in EmpList where emp.EmpisPermanent == statusbool select emp).ToList();
            return result;
        }
        public List<Employee> GetEmployeesbyDesignation(string designation)
        {
            List<Employee> result = new List<Employee>();
            result = (from emp in EmpList where emp.EmpDesignation == designation select emp).ToList();
            return result;
        }
        #endregion
    }
}