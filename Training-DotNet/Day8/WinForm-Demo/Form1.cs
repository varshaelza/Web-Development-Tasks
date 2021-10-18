using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_Demo
{
    public partial class form_calculator : Form
    {
        public form_calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txt_firstNumber.Text);
            int num2 = Convert.ToInt32(txt_secondNumber.Text);
            lbl_sum.Text ="Sum : "+ Convert.ToString(num1 + num2);
            lbl_difference.Text = "Difference : " + Convert.ToString(num1 - num2);
            lbl_product.Text = "Product : " + Convert.ToString(num1 * num2);
            lbl_quotient.Text = "Quotient : " + Convert.ToString(num1 / num2);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            lbl_sum.Text = "Sum : ";
            lbl_difference.Text = "Difference : ";
            lbl_product.Text = "Product : ";
            lbl_quotient.Text = "Quotient : ";
        }
    }
}
