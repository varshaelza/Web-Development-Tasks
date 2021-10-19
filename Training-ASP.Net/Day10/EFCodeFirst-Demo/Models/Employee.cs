using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFCodeFirst_Demo.Models
{
    public class Employee
    {
        #region Properties
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string EmpDesig { get; set; }
        public double EmpSalary { get; set; }
        public bool EmpIsPermanent { get; set; }
        #endregion
    }
}