using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Controller_View_Communication.Models
{
    public class Employee
    {
        #region Properties
        public string EmpNo { get; set; }
        public string  EmpName { get; set; }
        public string EmpDesignation { get; set; }
        public double EmpSalary { get; set; }
        public bool EmpisPermanent { get; set; }
        #endregion

        #region Constructors
        public Employee(string p_empNo,string p_empName,string p_EmpDesig,double p_empSalary,bool p_empisPermanent)
        {
            this.EmpNo = p_empNo;
            this.EmpName = p_empName;
            this.EmpDesignation = p_EmpDesig;
            this.EmpSalary = p_empSalary;
            this.EmpisPermanent = p_empisPermanent;
        }
        #endregion
    }
}