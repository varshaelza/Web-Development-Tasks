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
    public partial class form_applyleaves : Form
    {
        public form_applyleaves()
        {
            InitializeComponent();
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            int leaves=0;
            try
            {
                obj.Deserialize(txt_empNo.Text);
                leaves = obj.EmpLeaves;
            }
            catch(Exception)
            {
                MessageBox.Show("Employee Not Found");
            }
            obj.ApplyLeaves(Convert.ToInt32(txt_Leaves.Text));
            if(string.Compare(obj.EmpNo,txt_empNo.Text)!=0)
            {
                MessageBox.Show("Employee Not Found");
            }
            else if(obj.EmpLeaves==leaves)
            {
                MessageBox.Show("Insufficient Leave Balance");
            }
            else
            {
                MessageBox.Show("Leave Applied");
            }
            obj.SerializeEmp();
            txt_empNo.Text = "";
            txt_Leaves.Text = "";

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_empNo.Text = "";
            txt_Leaves.Text = "";
        }
    }
}
