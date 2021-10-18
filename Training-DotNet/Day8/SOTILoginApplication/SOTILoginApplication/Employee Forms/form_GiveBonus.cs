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
    public partial class form_GiveBonus : Form
    {
        public form_GiveBonus()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_bonus.Text = "";
            txt_empNo.Text = "";
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
          
            try
            {
                obj.Deserialize(txt_empNo.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Employee Not Found");
            }
            obj.GetBonus(Convert.ToInt32(txt_bonus.Text));
            if (string.Compare(obj.EmpNo, txt_empNo.Text) != 0)
            {
                MessageBox.Show("Employee Not Found");
            }
            
            else
            {
                MessageBox.Show("Bonus Given");
            }
            obj.SerializeEmp();
            txt_bonus.Text = "";
            txt_empNo.Text = "";
        }
    }
}
