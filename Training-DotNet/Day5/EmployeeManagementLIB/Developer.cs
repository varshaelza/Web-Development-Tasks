using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementLIB
{
    public class Developer:Employee
    {
        #region Variables
        static int dev_autoNo=3000;
        #endregion 

        #region Constructors
        public Developer(string p_empName, string p_empDesignation, double p_empSalary) : base(p_empName, p_empDesignation, p_empSalary)
        {
            dev_autoNo++;
            this.EmpNo = "DEV"+dev_autoNo;
            this.EmpName = p_empName;
            this.EmpDesignation = p_empDesignation;
            this.EmpSalary = p_empSalary;
        }

        #endregion
    }
}
