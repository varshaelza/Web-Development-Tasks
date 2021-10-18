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
        int v_empID;
        string v_empName;
        string v_empDesignation;
        double v_empSalary;
        int v_empAvailableleaves;
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

        public int EmpAvailableleaves
        {
            get
            {
                return (v_empAvailableleaves);

            }
            set
            {
                v_empAvailableleaves = value;
            }
        }
        #endregion

        #region Constructors
        public Employee(int p_empID,string p_empName,string p_empDesignation,double p_empSalary,int p_empAvailableleaves)
        {
            this.EmpID = p_empID;
            this.EmpName = p_empName;
            this.EmpDesignation = p_empDesignation;
            this.EmpSalary = p_empSalary;
            this.EmpAvailableleaves = p_empAvailableleaves;
        }
        #endregion

        #region Methods
        public virtual void ApplyLeaves(int days)
        {
            if(days<1)
            {
                Console.WriteLine("You need to appy for aleast 1 day.");
            }
            else
            {
                this.EmpAvailableleaves = this.EmpAvailableleaves - days;
            }

        }
        public virtual void Bonus()
        {
            this.EmpSalary = this.EmpSalary + (this.EmpSalary * 5) / 100;
        }

        #endregion

    }

}
