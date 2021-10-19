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
    public partial class TransferAmount : Form
    {
        public TransferAmount()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectbanking"].ConnectionString);
            SqlTransaction transact;
            
            SqlCommand cmd_withdraw=new SqlCommand("update BankAccountsInfo set AccBalance=AccBalance-@amount where AccNo=@senderno and AccBalance>@amount");
            SqlCommand cmd_transactioncharge = new SqlCommand("update BankAccountsInfo set AccBalance=AccBalance-20 where AccNo=@senderno and AccBalance>20");
            SqlCommand cmd_deposit = new SqlCommand("update BankAccountsInfo set AccBalance=AccBalance+@amount where AccNo=@receiverno");
            con.Open();
            transact = con.BeginTransaction();
            try
            {
                cmd_withdraw.Connection = con;
                cmd_withdraw.Transaction = transact;
                cmd_withdraw.Parameters.AddWithValue("@amount", txt_amount.Text);
                cmd_withdraw.Parameters.AddWithValue("@senderno", txt_sender.Text);

                cmd_transactioncharge.Connection = con;
                cmd_transactioncharge.Transaction = transact;
                cmd_transactioncharge.Parameters.AddWithValue("@senderno", txt_sender.Text);

                cmd_deposit.Connection = con;
                cmd_deposit.Transaction = transact;
                cmd_deposit.Parameters.AddWithValue("@amount", txt_amount.Text);
                cmd_deposit.Parameters.AddWithValue("@receiverno", txt_receiver.Text);

                int line=cmd_withdraw.ExecuteNonQuery();
                if(line==0)
                {
                    throw new Exception("Withdrawal failed");
                }
                line=cmd_transactioncharge.ExecuteNonQuery();
                if (line == 0)
                {
                    throw new Exception("Insufficient funds");
                }
                line=cmd_deposit.ExecuteNonQuery();
                if (line == 0)
                {
                    throw new Exception("Receiver not found");
                }

                transact.Commit();
                MessageBox.Show("Transfer Successful");
            }
            catch(Exception ex)
            {
                transact.Rollback();
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


        }
    }
}
