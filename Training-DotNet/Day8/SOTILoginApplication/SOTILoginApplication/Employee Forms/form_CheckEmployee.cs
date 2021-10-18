using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Serialization_Demo;

namespace SOTILoginApplication.Employee_Forms
{
    public partial class form_CheckEmployee : Form
    {
        public form_CheckEmployee()
        {
            InitializeComponent();
        }

        private void txt_empNo_Leave(object sender, EventArgs e)
        {
            try
            {
                Employee obj = new Employee();
                obj.Deserialize(txt_empNo.Text);
                txt_empName.Text = obj.EmpName;
                txt_empDesig.Text = obj.EmpDesignation;
                txt_empSal.Text = Convert.ToString(obj.EmpSalary);
            }
            catch(Exception)
            {
                MessageBox.Show("Employee not Found");
            }
            if(txt_empName.Text=="")
            {
                MessageBox.Show("Employee not Found");
            }
        }
    }
}
