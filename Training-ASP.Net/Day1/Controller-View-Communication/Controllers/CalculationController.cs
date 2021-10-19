using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controller_View_Communication.Controllers
{
    public class CalculationController : Controller
    {
        // GET: Calculation
        public ActionResult Calculate()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Calculate(int num1,int num2)
        {
            string text = "Sum : " + (num1 + num2) + ", Difference : " + (num1 - num2) + ", Product : " + (num1 * num2) + ", Quotient : " + num1 / num2;
            ViewBag.result = text;
            return View();
        }

        static List<string> tech=new List<string>();
        public ActionResult AddTech()
        {
            if (tech.Count == 0)
            {
                tech.Add(".Net");
                tech.Add("ASP.Net");
                tech.Add("ADO.Net");
                tech.Add("SQL Server");
            }
            ViewBag.tech = tech;
            return View();
        }

        [HttpPost]
        public ActionResult AddTech(string techno)
        {
            tech.Add(techno);
            ViewBag.tech = tech;
            return View();
        }
    }

    

}