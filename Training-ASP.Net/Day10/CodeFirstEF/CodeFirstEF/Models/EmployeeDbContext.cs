using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace CodeFirstEF.Models
{
    public class EmployeeDbContext:DbContext
    {
        public DbSet<Employee> Employees;
    }
}