using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace FileIO_Demo
{
    public abstract class Employee
    {

        public string EmpNo { get; set; }
        public string EmpName { get; set; }
        public string EmpDesignation { get; set; }
        public double EmpSalary { get; set; }

        public Employee(string p_empName, string p_empDesignation, double p_empSalary, string filepath)
        {
            this.EmpName = p_empName;
            this.EmpDesignation = p_empDesignation;
            this.EmpSalary = p_empSalary;
            FileStream empnoFile;
            StreamReader rd;
            StreamWriter wr;
            int empNo;
            int baseNo;
            if (filepath.EndsWith("ManNo.txt"))
            {
                baseNo = 500;
            }
            else if (filepath.EndsWith("DevNo.txt"))
            {
                baseNo = 2000;
            }
            else 
            {
                baseNo = 3000;
            }
            if (File.Exists(filepath) == false)
            {
            
                empnoFile = new FileStream(filepath, FileMode.Create, FileAccess.Write);
                wr = new StreamWriter(empnoFile);
                wr.WriteLine(baseNo); 
                wr.Close();
                empnoFile.Close();
            }
            else
            {

                empnoFile = new FileStream(filepath, FileMode.Open, FileAccess.Read);
                rd = new StreamReader(empnoFile);
                empNo = Convert.ToInt32(rd.ReadLine());
                rd.Close();
                empnoFile.Close();

                empNo++;
                empnoFile = new FileStream(filepath, FileMode.Create, FileAccess.Write);
                wr = new StreamWriter(empnoFile);
                wr.WriteLine(empNo);
                wr.Close();
                empnoFile.Close();

            }
            empnoFile = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            rd = new StreamReader(empnoFile);
            empNo = Convert.ToInt32(rd.ReadLine());
            rd.Close();
            empnoFile.Close();
            
            if (filepath.EndsWith("ManNo.txt"))
            {
                this.EmpNo = "MAN" + empNo.ToString();
                filepath = @"C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Day6\\Employee Details\\Manager Details\\" + this.EmpNo + ".txt";

            }
            else if (filepath.EndsWith("DevNo.txt"))
            {
                this.EmpNo = "DEV" + empNo.ToString();
                filepath = @"C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Day6\\Employee Details\\Developer Details\\" + this.EmpNo + ".txt";
            }
            else if(filepath.EndsWith("HRNo.txt"))
            {
                this.EmpNo = "HR" + empNo.ToString();
                filepath = @"C:\\Users\\varsha\\source\\repos\\Training-DotNet\\Day6\\Employee Details\\HR Details\\" + this.EmpNo + ".txt";
            }

            
            FileStream EmpDetails = new FileStream(filepath, FileMode.Create, FileAccess.Write);
            wr = new StreamWriter(EmpDetails);
            wr.WriteLine("Employee no : " + this.EmpNo);
            wr.WriteLine("Employee name : " + this.EmpName);
            wr.WriteLine("Employee designation : " + this.EmpDesignation);
            wr.WriteLine("Employee salary : " + this.EmpSalary.ToString());
            wr.Close();
            EmpDetails.Close();


        }
    }
}
