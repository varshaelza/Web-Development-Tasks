using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace BankingMVC_StoredProceduresDemo.Models
{
    public class Accounts
    {
        #region Properties
        public int AccNo { get; set; }
        public string AccName { get; set; }
        public string AccType { get; set; }
        public double AccBalance { get; set; }
        public bool AccIsActive { get; set; }

        public List<Accounts> AccList = new List<Accounts>();
        SqlConnection con = new SqlConnection("server=IND358;database=Banking_DB;integrated security=true");
        SqlCommand cmd_getalldata = new SqlCommand("proc_GetAllAccounts");
        SqlCommand cmd_getbyaccno = new SqlCommand("proc_GetAccountByNo");
        SqlCommand cmd_getbyacctype = new SqlCommand("proc_GetAccountByType");
        SqlCommand cmd_addacc = new SqlCommand("proc_AddNewAccount");
        SqlCommand cmd_deleteacc = new SqlCommand("proc_DeleteAccount");
        SqlCommand cmd_updateacc = new SqlCommand("proc_UpdateAccount");

        #endregion

        #region Constructor
        public Accounts()
        {

        }
        #endregion

        #region Methods
        public List<Accounts> GetAllAccounts()
        {
            List<Accounts> accList = new List<Accounts>();
            cmd_getalldata.Connection = con;
            con.Open();
            cmd_getalldata.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader _read;
            _read = cmd_getalldata.ExecuteReader();
            while(_read.Read())
            {
                accList.Add(new Accounts() { AccNo = Convert.ToInt32(_read[0]), AccName = Convert.ToString(_read[1]), AccType = Convert.ToString(_read[2]), AccBalance = Convert.ToDouble(_read[3]), AccIsActive = Convert.ToBoolean(_read[4]) });
            }
            _read.Close();
            con.Close();
            return accList;


        }
        public List<Accounts> GetAccountByType(string p_acctype)
        {
            List<Accounts> accList = new List<Accounts>();
            cmd_getbyacctype.Connection = con;
            con.Open();
            cmd_getbyacctype.CommandType = System.Data.CommandType.StoredProcedure;
            cmd_getbyacctype.Parameters.AddWithValue("@accType", p_acctype);
            SqlDataReader _read;
            _read = cmd_getbyacctype.ExecuteReader();
            while (_read.Read())
            {
                accList.Add(new Accounts() { AccNo = Convert.ToInt32(_read[0]), AccName = Convert.ToString(_read[1]), AccType = Convert.ToString(_read[2]), AccBalance = Convert.ToDouble(_read[3]), AccIsActive = Convert.ToBoolean(_read[4]) });
            }
            _read.Close();
            con.Close();
            return accList;


        }
        public Accounts GetAccountByNo(int p_accno)
        {
            cmd_getbyaccno.Connection = con;
            con.Open();
            cmd_getbyaccno.CommandType = System.Data.CommandType.StoredProcedure;
            cmd_getbyaccno.Parameters.AddWithValue("@p_accno", p_accno);
            SqlDataReader _read;
            _read = cmd_getbyaccno.ExecuteReader();
            _read.Read();
            Accounts obj= (new Accounts() { AccNo = Convert.ToInt32(_read[0]), AccName = Convert.ToString(_read[1]), AccType = Convert.ToString(_read[2]), AccBalance = Convert.ToDouble(_read[3]), AccIsActive = Convert.ToBoolean(_read[4]) });
            _read.Close();
            con.Close();
            return obj;
        }
        public int AddAccount(string p_accname, string p_acctype, double p_accbalance, bool p_accisactive)
        {
            cmd_addacc.Connection = con;
            con.Open();
            cmd_addacc.Parameters.Add("@p_accno", System.Data.SqlDbType.Int,4);
            cmd_addacc.Parameters["@p_accno"].Direction = System.Data.ParameterDirection.Output;
            cmd_addacc.Parameters.AddWithValue("@p_accname",p_accname);
            cmd_addacc.Parameters.AddWithValue("@p_acctype",p_acctype);
            cmd_addacc.Parameters.AddWithValue("@p_accbalance",p_accbalance);
            cmd_addacc.Parameters.AddWithValue("@p_accisactive",p_accisactive);
            cmd_addacc.CommandType = System.Data.CommandType.StoredProcedure;
            cmd_addacc.ExecuteNonQuery();
            int result = (Convert.ToInt32(cmd_addacc.Parameters["@p_accno"].Value));
            con.Close();
            return result;
            
        }
        public int DeleteAccount(int p_accno)
        {
            cmd_deleteacc.Connection = con;
            con.Open();
            cmd_deleteacc.Parameters.AddWithValue("@p_accno", p_accno);
            cmd_deleteacc.CommandType = System.Data.CommandType.StoredProcedure;
            int result=cmd_deleteacc.ExecuteNonQuery();
            con.Close();
            return result;

        }
        public int UpdateAccount(int p_accno,string p_accname, string p_acctype, double p_accbalance, bool p_accisactive)
        {
            cmd_updateacc.Connection = con;
            con.Open();
            cmd_updateacc.Parameters.AddWithValue("@p_accno", p_accno);
            cmd_updateacc.Parameters.AddWithValue("@p_accname", p_accname);
            cmd_updateacc.Parameters.AddWithValue("@p_acctype", p_acctype);
            cmd_updateacc.Parameters.AddWithValue("@p_accbalance", p_accbalance);
            cmd_updateacc.Parameters.AddWithValue("@p_accisactive", p_accisactive);
            cmd_updateacc.CommandType = System.Data.CommandType.StoredProcedure;
            var result = cmd_updateacc.ExecuteNonQuery();
            con.Close();
            return result;

        }
        #endregion
    }
}