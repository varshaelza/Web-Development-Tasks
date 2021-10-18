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
    public partial class form_AddEmployee : Form
    {
        public form_AddEmployee()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(txt_empName.Text,txt_empDesig.Text,Convert.ToDouble(txt_empSal.Text));
            txt_empName.Text = "";
            txt_empDesig.Text = "";
            txt_empSal.Text = "";
            MessageBox.Show("Employee Added");
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_empName.Text = "";
            txt_empDesig.Text = "";
            txt_empSal.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
