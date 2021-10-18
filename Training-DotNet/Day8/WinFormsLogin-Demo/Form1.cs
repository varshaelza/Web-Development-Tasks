using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsLogin_Demo
{
    public partial class form_login : Form
    {
        public form_login()
        {
            InitializeComponent();
        }

        private void form_login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(txt_userName.Text=="Varsha Elza"&&txt_passWord.Text=="SOTI@12345")
            {
                MessageBox.Show("Welcome");
            }
            else if(txt_userName.Text!="Varsha Elza")
            {
                MessageBox.Show("Invalid Username");
            }
            else if (txt_passWord.Text != "SOTI@12345")
            {
                MessageBox.Show("Invalid Password");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_userName.Text = "";
            txt_passWord.Text = "";
        }
    }
}
