using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementLIB
{
    public class HR:Employee
    {
        #region Variables
        static int hr_autoNo = 1000;
        #endregion
        #region Constructors
        public HR(string p_empName, string p_empDesignation, double p_empSalary) : base(p_empName, p_empDesignation, p_empSalary)
        {
            hr_autoNo++;
            this.EmpNo = "HR"+hr_autoNo;
            this.EmpName = p_empName;
            this.EmpDesignation = p_empDesignation;
            this.EmpSalary = p_empSalary;
        }

        #endregion
    }
}
