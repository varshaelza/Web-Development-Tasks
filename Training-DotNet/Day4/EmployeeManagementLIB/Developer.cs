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
        #endregion

        #region Properties
        #endregion

        #region Constructors
        public Developer(int p_empID, string p_empName, DeveloperDesignations p_empDesignation, double p_empSalary, int p_empAvailableleaves) : base(p_empID, p_empName, p_empDesignation.ToString(), p_empSalary, p_empAvailableleaves)
        {

        }
        #endregion

        #region Methods
        public override void ApplyLeaves(int days)
        {
            if (days > 8)
            {
                Console.WriteLine("Developer can only apply upto 8 leaves");
            }
            else
            {
                base.ApplyLeaves(days);
            }
        }
        public override void Bonus()
        {
            this.EmpSalary += (this.EmpSalary * 15) / 100;
        }

        #endregion
    }
}
