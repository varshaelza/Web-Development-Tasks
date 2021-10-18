using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileIO_Demo
{
    public class Manager:Employee
    {
        
        public Manager(string p_empName,string p_empDesignation,double p_empSalary):base(p_empName,p_empDesignation,p_empSalary, "C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Day6\\Employee Details\\Manager Details\\ManNo.txt")
        {
            
        }
    }
}
