using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Transactions;


namespace ClientAPPMVC.Models
{
    public class Accounts
    {
        public string TransferMoney(int sender, int receiver, double amount)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlbanking"].ConnectionString);
            SqlTransaction transact;
            con.Open();
            transact = con.BeginTransaction();
            SqlCommand cmd_withdraw = new SqlCommand("update BankAccountsInfo set AccBalance=AccBalance-@amount where AccNo=@sender and AccBalance>=@amount");
            SqlCommand cmd_charge = new SqlCommand("update BankAccountsInfo set AccBalance=AccBalance-20 where AccNo=@sender and AccBalance>=20");
            SqlCommand cmd_deposit = new SqlCommand("update BankAccountsInfo set AccBalance=AccBalance+@amount where AccNo=@receiver ");
            try
            {
            
                cmd_withdraw.Connection = con;
                cmd_withdraw.Transaction = transact;
                cmd_withdraw.Parameters.AddWithValue("@sender", sender);
                cmd_withdraw.Parameters.AddWithValue("@amount", amount);

                cmd_charge.Connection = con;
                cmd_charge.Transaction = transact;
                cmd_charge.Parameters.AddWithValue("@sender", sender);

                cmd_deposit.Connection = con;
                cmd_deposit.Transaction = transact;
                cmd_deposit.Parameters.AddWithValue("@receiver", receiver);
                cmd_deposit.Parameters.AddWithValue("@amount", amount);

                int lines = cmd_withdraw.ExecuteNonQuery();
                if (lines == 0)
                {
                    throw new Exception("Withdrawal failed");
                }
                lines = cmd_charge.ExecuteNonQuery();
                if (lines == 0)
                {
                    throw new Exception("Withdrawal failed");
                }
                lines = cmd_deposit.ExecuteNonQuery();
                if (lines == 0)
                {
                    throw new Exception("Receiver Not Found");
                }
                transact.Commit();
                con.Close();
                return "Transfer Successful";
            }
            catch(Exception ex)
            {
                transact.Rollback();
                con.Close();
                return ex.Message;
            }
            
            


        }
    }
}