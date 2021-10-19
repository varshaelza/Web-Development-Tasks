using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Transactions;
using System.Configuration;

namespace TransactionsManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_transact_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectbanking"].ConnectionString);
            SqlCommand cmd_one = new SqlCommand("insert into BankAccountsInfo values(118,'Gikku Ninan','Savings',77000,0)");
            SqlCommand cmd_two = new SqlCommand("insert into BankAccountsInfo values(119,'Meera Gikku','PF',97000,1)");
            SqlCommand cmd_three = new SqlCommand("insert into BankAccountsInfo values(115,'Aakash Gikku','Savings',80000,0)");
            SqlCommand cmd_four = new SqlCommand("insert into BankAccountsInfo values(116,'Ajith A','Current',5000,1)");
            SqlCommand cmd_five = new SqlCommand("insert into BankAccountsInfo values(117,'Megha Susan','Savings',67700,0)");
            SqlTransaction transact;
            con.Open();
            transact = con.BeginTransaction();
            try
            {
                cmd_one.Connection = con;
                cmd_one.Transaction = transact;
                cmd_two.Connection = con;
                cmd_two.Transaction = transact;
                cmd_three.Connection = con;
                cmd_three.Transaction = transact;
                cmd_four.Connection = con;
                cmd_four.Transaction = transact;
                cmd_five.Connection = con;
                cmd_five.Transaction = transact;

                cmd_one.ExecuteNonQuery();
                cmd_two.ExecuteNonQuery();
                cmd_three.ExecuteNonQuery();
                cmd_four.ExecuteNonQuery();
                cmd_five.ExecuteNonQuery();
                transact.Commit();
                MessageBox.Show("Successful");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                transact.Rollback();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
