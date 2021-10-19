using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstEF.Models
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string EmpDesig { get; set; }
        public double EmpSalary { get; set; }
        public bool EmpIsPermanent { get; set; }
    }
}