using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RESTAPI_Example2.Models;

namespace RESTAPI_Example2.Controllers
{
    public class EmployeesController : ApiController
    {
        Employee empObj = new Employee();
        
       
        
        public Employee GetEmployee( int id)
        {
            return (empObj.GetById(id));
        }
        public List<Employee> GetEmployeeList()
        {
            return (empObj.GetAllemployees());
        }
        [HttpPost]
        public List<Employee> Post(Employee obj)
        {
            empObj.AddEmployee(obj);
            return (empObj.GetAllemployees());
        }
        [HttpDelete]
        public List<Employee> Delete(Employee obj)
        {
            empObj.DeleteEmployee(obj.empNo);
            return (empObj.GetAllemployees());
        }

    }
}
