using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementLIB
{
    public abstract class Employee
    {
        #region Variables
        static int autoNumber = 100;
        String v_empNo;
        string v_empName;
        string v_EmpDesignation;
        double v_empSalary;
        #endregion

        #region Properties
        public string EmpNo
        {
            get
            {
                return v_empNo;
            }
            set
            {
                v_empNo = value;
            }
        }
        public string EmpName
        {
            get
            {
                return v_empName;
            }
            set
            {
                v_empName = value;
            }
        }
        public string EmpDesignation
        {
            get
            {
                return v_EmpDesignation;
            }
            set
            {
                v_EmpDesignation = value;
            }
        }
        public double EmpSalary
        {
            get
            {
                return v_empSalary;
            }
            set
            {
                v_empSalary = value;
            }
        }
        #endregion

        #region Constructors
        public Employee(string p_empName,string p_empDesignation,double p_empSalary)
        {
            autoNumber = autoNumber + 1;
            this.EmpNo = "EMP"+autoNumber;
            this.EmpName = p_empName;
            this.EmpDesignation = p_empDesignation;
            this.EmpSalary = p_empSalary;
        }
        #endregion
    }
}
