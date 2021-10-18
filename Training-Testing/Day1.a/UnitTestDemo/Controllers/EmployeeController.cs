using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnitTestDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public List<string> empList = new List<string>() { "Varsha", "Christina", "Malavika" };
        public ActionResult ViewEmployee()
        {
            
            return View();
        }
        public ActionResult AddEmployee()
        {
            empList.Add("Vi");
            return View();
        }
        public int Addition(int num1,int num2)
        {
            return num1 + num2;
        }
    }
}