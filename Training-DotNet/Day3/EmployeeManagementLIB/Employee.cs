using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementLIB
{
    public class Employee
    {
        #region Variables
        string v_empName;
        int v_empID;
        double v_empSalary;
        string v_empDesignation;
        bool v_isempPermanent;
        #endregion

        #region Properties
        public string EmpName
        {
            get
            {
                return (v_empName);
            }
            set
            {
                v_empName = value;
            }
        }
        public int EmpID
        {
            get
            {
                return (v_empID);
            }
            set
            {
                v_empID = value;
            }
        }
        public double EmpSalary
        {
            get
            {
                return (v_empSalary);
            }
            set
            {
                v_empSalary = value;
            }
        }
        public string EmpDesignation
        {
            get
            {
                return (v_empDesignation);
            }
            set
            {
                v_empDesignation = value;
            }
        }

        public bool EmpIspermanent
        {
            get
            {
                return (v_isempPermanent);
            }
            set
            {
                v_isempPermanent = value;
            }
        }
        #endregion

        #region Methods
        public double GetBonus()
        {
            return(this.EmpSalary * 10) / 100;
        }
        public double  GetBonus(double percentage)
        {
            return ((this.EmpSalary * percentage) / 100);
        }
        #endregion
    }
}
