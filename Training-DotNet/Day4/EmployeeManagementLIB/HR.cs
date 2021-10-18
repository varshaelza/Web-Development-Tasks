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
        string v_hrEmail;
        #endregion

        #region Properties
        public string HREmail
        {
            get
            {
                return v_hrEmail;
            }
            set
            {
                v_hrEmail = value;
            }
        }
        #endregion

        #region Constructors
        public HR(int p_empID, string p_empName, HRDesignations p_empDesignation, double p_empSalary, int p_empAvailableleaves) : base(p_empID, p_empName, p_empDesignation.ToString(), p_empSalary, p_empAvailableleaves)
        {

        }
        #endregion

        #region Methods

        public override void ApplyLeaves(int days)
        {
            if(days>10)
            {
                Console.WriteLine("R can only apply upto 10 leaves");
            }
            else
            {
                base.ApplyLeaves(days);
            }
    
        }
        public override void Bonus()
        {
            this.EmpSalary += (this.EmpSalary * 20) / 100;
        }
        public void  ScheduleInterview()
        {
            Console.WriteLine("Interview Scheduling in process");
        }
        public void ArrangeFunctions()
        {
            Console.WriteLine("Function Arrangements in process");
        }
    #endregion
    }
}
