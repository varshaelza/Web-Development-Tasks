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
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public Manager(int p_empID,string p_empName, ManagerDesignations p_empDesignation,double p_empSalary,int p_empAvailableleaves) : base(p_empID,p_empName,p_empDesignation.ToString(),p_empSalary,p_empAvailableleaves)
        {

        }
        #endregion
        #region Methods
        public override void ApplyLeaves(int days)
        {
            if (days > 5)
            {
                Console.WriteLine("Manager can only apply upto 5 leaves");
            }
            else
            {
                base.ApplyLeaves(days);
            }
        }
        public override void Bonus()
        {
            this.EmpSalary += (this.EmpSalary * 7.5) / 100;
        }
        #endregion
    }
}
