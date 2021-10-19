//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmployeeManagement_EF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class employee_info
    {
        [Display(Name="Employee number")]
        public int e_No { get; set; }
        [Display(Name = "Employee name")]
        [Required(ErrorMessage ="Name should not be left blank")]
        [StringLength(15,MinimumLength =3,ErrorMessage ="Name length should be between 3 and 15")]
        public string e_Name { get; set; }
        [Display(Name = "Employee Designation")]
        public string e_Designation { get; set; }
        [Display(Name = "Employee Salary")]
        public Nullable<double> e_Salary { get; set; }
        [Display(Name = "Employee Depatment")]
        public Nullable<int> e_Dept { get; set; }
    
        public virtual dept_info dept_info { get; set; }
    }
}