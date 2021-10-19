using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace BankingApplicationMVC_ADO_Demo.Models
{
    public class Accounts
    {
        #region Properties
        public string AccNo { get; set; }
        public string AccName { get; set; }
        public string AccType { get; set; }
        public double AccBalance { get; set; }
        public bool AccIsActive { get; set; }

        public List<Accounts> AccList = new List<Accounts>();
        SqlConnection con = new SqlConnection("server=IND358;database=Banking_DB;integrated security=true");
        SqlCommand cmd_getalldata = new SqlCommand("select * from accountsInfo");
        SqlCommand cmd_getbyaccno = new SqlCommand("select * from accountsInfo where AccNo=@p_accNo");
        SqlCommand cmd_addacc = new SqlCommand("insert into accountsInfo values (@p_accNo,@p_accName , @p_accType , @p_accBalance , @p_accIsactive)");
        SqlCommand cmd_deleteacc = new SqlCommand("delete from accountsInfo where AccNo=@p_accNo");
        SqlCommand cmd_updateacc = new SqlCommand("update accountsInfo set AccName=@p_accName ,AccBalance=@p_accBalance where AccNo=@p_accNo");

        #endregion

        #region Constructors
        public Accounts()
        {

        }
        #endregion

        #region Methods
        public List<Accounts> GetAllData()
        {
            cmd_getalldata.Connection = con;
            SqlDataReader _read;
            con.Open();
            _read = cmd_getalldata.ExecuteReader();
            while(_read.Read())
            {
                AccList.Add(new Accounts() { AccNo =Convert.ToString( _read[0]), AccName = Convert.ToString(_read[1]), AccType = Convert.ToString(_read[2]), AccBalance = Convert.ToDouble(_read[3]), AccIsActive = Convert.ToBoolean(_read[4])});
            }
            _read.Close();
            con.Close();
            return AccList;
        }
        public Accounts GetByAccNo(string p_accNo)
        {
            cmd_getbyaccno.Connection = con;
            cmd_getbyaccno.Parameters.AddWithValue("@p_accNo", p_accNo);
            SqlDataReader _read;
            con.Open();
            _read = cmd_getbyaccno.ExecuteReader();
            _read.Read();
            var acc = (new Accounts() { AccNo = Convert.ToString(_read[0]), AccName = Convert.ToString(_read[1]), AccType = Convert.ToString(_read[2]), AccBalance = Convert.ToDouble(_read[3]), AccIsActive = Convert.ToBoolean(_read[4]) });
            _read.Close();
            con.Close();
            return acc;
        }
        public int AddAccount(string p_accNo, string p_accName, string p_accType, double p_accBalance, bool p_accIsactive)
        {
            cmd_addacc.Connection = con;
            cmd_addacc.Parameters.AddWithValue("@p_accNo", p_accNo);
            cmd_addacc.Parameters.AddWithValue("@p_accName", p_accName);
            cmd_addacc.Parameters.AddWithValue("@p_accType", p_accType);
            cmd_addacc.Parameters.AddWithValue("@p_accBalance", p_accBalance);
            cmd_addacc.Parameters.AddWithValue("@p_accIsactive", p_accIsactive);
            con.Open();
            int result = cmd_addacc.ExecuteNonQuery();//returns number of lines affected
            con.Close();
            return result;

        }
        public int DeleteAccount(string p_accNo)
        {
            cmd_deleteacc.Connection = con;
            cmd_deleteacc.Parameters.AddWithValue("@p_accNo", p_accNo);
            con.Open();
            int result = cmd_deleteacc.ExecuteNonQuery();//returns number of lines affected
            con.Close();
            return result;
        }
        public int  UpdateAccount(string p_accNo, string p_accName, double p_accBalance)
        {
            cmd_updateacc.Connection = con;
            cmd_updateacc.Parameters.AddWithValue("@p_accNo", p_accNo);
            cmd_updateacc.Parameters.AddWithValue("@p_accName", p_accName);
            cmd_updateacc.Parameters.AddWithValue("@p_accBalance", p_accBalance);
            con.Open();
            int result = cmd_updateacc.ExecuteNonQuery();//returns number of lines affected
            con.Close();
            return result;
            

        }
        #endregion
    }
}