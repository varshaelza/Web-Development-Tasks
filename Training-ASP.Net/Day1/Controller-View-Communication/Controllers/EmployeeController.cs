using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Controller_View_Communication.Models;


namespace Controller_View_Communication.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Greet()
        {
            return View();
        }
        //[HttpPost]
        //public ActionResult Greet(string username)
        //{
        //    string greetingMessage = "Dear " + username+ ", Hello and Welcome to TheMVC";
        //    ViewBag.greetings = greetingMessage;
        //    return View();
        //}
        [HttpPost]
        public ActionResult Greet(string firstname,string surname)
        {
            string greetingMessage = "Dear " + firstname + " "+surname+", Hello and Welcome to TheMVC";
            ViewBag.greetings = greetingMessage;
            return View();
        }

        public ActionResult EmployeeList()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Models.Employee("EMP101", "Varsha Elza Gikku", "Jr.Developer", 58000, true));
            empList.Add(new Models.Employee("EMP102", "Christina George", "Sr.Developer", 78000, true));
            empList.Add(new Models.Employee("EMP103", "Mlavika Manoj", "Jr.Manager", 58000, false));
            empList.Add(new Models.Employee("EMP104", "Vincy Mathew", "Client.HR", 58000, true));


            ViewBag.empList = empList;
            return View();

        }
        public ActionResult EmployeeDetails()
        {
            Models.Employee empObj = new Models.Employee("EMP101", "Varsha Elza Gikku", "Jr.Developer", 58000, true);
            ViewBag.empObj = empObj;
            return View();
        }
    }
}