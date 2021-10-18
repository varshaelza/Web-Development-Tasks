using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementLIB
{
    public class Manager:Employee
    {
        #region Variables
        static int man_autoNo = 2000;
        #endregion

        #region Constructors
        public Manager(string p_empName,string p_empDesignation,double p_empSalary):base(p_empName,p_empDesignation,p_empSalary)
        {
            man_autoNo++;
            this.EmpNo = "MAN"+man_autoNo;
            this.EmpName = p_empName;
            this.EmpDesignation = p_empDesignation;
            this.EmpSalary = p_empSalary;
        }

        #endregion
    }
}
