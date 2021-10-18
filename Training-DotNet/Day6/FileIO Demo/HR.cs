using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileIO_Demo
{
    public class HR:Employee
    {
        
        public HR(string p_empName, string p_empDesignation, double p_empSalary) : base(p_empName, p_empDesignation, p_empSalary, "C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Day6\\Employee Details\\HR Details\\HRNo.txt")
        {
            
        }
    }
}
