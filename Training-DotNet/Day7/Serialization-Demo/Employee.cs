using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Threading.Tasks;

namespace Serialization_Demo
{
    [Serializable]
    public class Employee
    {
        #region Properties
        public string EmpNo { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }
        public string EmpDesignation { get; set; }
        public int EmpLeaves { get; set; }
        #endregion

        #region Methods
        public void GetBonus(double percentage)
        {
            this.EmpSalary += (percentage * this.EmpSalary) / 100;

        }

        public void ApplyLeaves(int days)
        {
            if(days<1)
            {
                Console.WriteLine("Leaves should be greater than 0");
                return;
            }
            if(this.EmpLeaves<days)
            {
                Console.WriteLine("More than available leaves requested");
                return;
            }
            this.EmpLeaves -= days;
        }
        #endregion

        #region Serialize and Deserialize
        public void SerializeEmp()
        {
            FileStream myFile=null;
            try
            {
                myFile = new FileStream("C:\\Users\\vgikku\\OneDrive - SOTI Inc\\Training-DotNet\\Day7\\Employees\\" + this.EmpNo + ".xml", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(myFile, this);
                myFile.Close();
                //Console.WriteLine("Object is Serialized");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (myFile != null)
                {
                    myFile.Close();
                }
            }
        }

        public void Deserialize(string num)
        {
            SoapFormatter sf = new SoapFormatter();
            FileStream myFile = null;
            try
            {
                myFile = new FileStream("C:\\Users\\vgikku\\OneDrive - SOTI Inc\\Training-DotNet\\Day7\\Employees\\" + num + ".xml", FileMode.Open, FileAccess.Read);
                Employee obj = (Employee)sf.Deserialize(myFile);
                this.EmpNo = obj.EmpNo;
                this.EmpName = obj.EmpName;
                this.EmpDesignation = obj.EmpDesignation;
                this.EmpLeaves = obj.EmpLeaves;
                this.EmpSalary = obj.EmpSalary;
                myFile.Close();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No Such Employee");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (myFile != null)
                {
                    myFile.Close();
                }
            }
        }
        #endregion

        #region Constructors
        public Employee()
        {
           
        }
        public Employee(string p_name,string p_designation,double p_salary)
        {
            this.EmpName = p_name;
            this.EmpDesignation = p_designation;
            this.EmpSalary = p_salary;
            this.EmpLeaves = 15;
            int num;
            FileStream autoNo;
            StreamWriter wr;
            StreamReader rd;

            if (!File.Exists("C:\\Users\\vgikku\\OneDrive - SOTI Inc\\Training-DotNet\\Day7\\Employees\\EmpNo.txt"))
            {
                autoNo = new FileStream("C:\\Users\\vgikku\\OneDrive - SOTI Inc\\Training-DotNet\\Day7\\Employees\\EmpNo.txt", FileMode.Create, FileAccess.Write);
                wr = new StreamWriter(autoNo);
                wr.WriteLine(100);
                wr.Close();
                autoNo.Close();
            }
            
            autoNo = new FileStream("C:\\Users\\vgikku\\OneDrive - SOTI Inc\\Training-DotNet\\Day7\\Employees\\EmpNo.txt", FileMode.Open, FileAccess.Read);
            rd = new StreamReader(autoNo);
            num = Convert.ToInt32(rd.ReadLine());
            num++;
            rd.Close();
            autoNo.Close();
            
            autoNo = new FileStream("C:\\Users\\vgikku\\OneDrive - SOTI Inc\\Training-DotNet\\Day7\\Employees\\EmpNo.txt", FileMode.Create, FileAccess.Write);
            wr = new StreamWriter(autoNo);
            wr.WriteLine(num);
            wr.Close();
            autoNo.Close();
            this.EmpNo = "EMP"+Convert.ToString(num);
            this.SerializeEmp();
        }

        #endregion
    }
}
