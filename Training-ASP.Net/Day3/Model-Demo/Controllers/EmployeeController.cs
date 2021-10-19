using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model_Demo.Models;

namespace Model_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public Employee emp = new Employee();
        public ActionResult AllEmployees()
        {
            return View(emp.GetallEmployees());
        }

        public ActionResult SearchbyID()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult SearchbyID(string p_empNo)
        {
            
            return View(emp.GetEmployeebyNo(p_empNo));
        }

        public ActionResult AddEmployee()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee newemp)
        {
            ViewBag.result = emp.AddEmployee(newemp);
            return View("AllEmployees",emp.GetallEmployees());
        }

        public ActionResult DeleteEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DeleteEmployee(string p_empno)
        {
            ViewBag.result = emp.DeleteEmployeebyNo(p_empno);
            return View("AllEmployees", emp.GetallEmployees());
        }

        public ActionResult UpdateEmployee()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult UpdateEmployee(Employee newemp)
        {
            ViewBag.result = emp.UpdateEmployeebyNo(newemp.EmpNo,newemp);
            return View("AllEmployees", emp.GetallEmployees());
        }


        public ActionResult UpdateEmployeeStatus()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateEmployeeStatus(string p_empno,bool newstatus)
        {
            ViewBag.result = emp.UpdateStatus(p_empno, newstatus);
            return View("AllEmployees",emp.GetallEmployees());
        }

        public ActionResult GetEmployeesbyStatus()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetEmployeesbyStatus(bool status)
        {
            string statusstr;
            if(status==true)
            {
                statusstr = "Permanent";
            }
            else
            {
                statusstr = "Contract";
            }
            
            return View(emp.GetEmployeesbyStatus(statusstr));
        }
        public ActionResult GetEmployeesbyDesignation()
        {
           
            return View();
        }
        [HttpPost]
        public ActionResult GetEmployeesbyDesignation(string designation)
        {
           
            return View(emp.GetEmployeesbyDesignation(designation));
        }

    }
}