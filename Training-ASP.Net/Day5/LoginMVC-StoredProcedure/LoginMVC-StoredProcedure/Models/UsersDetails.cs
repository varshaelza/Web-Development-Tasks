using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace LoginMVC_StoredProcedure.Models
{
    public class UsersDetails
    {
        #region Properties
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public bool Loggedin{ get; set; }
        SqlConnection con = new SqlConnection("server=IND358;database=Banking_DB;integrated security=true");
        SqlCommand cmd_login = new SqlCommand("proc_logincheck");
        #endregion

        #region Methods
        public int CheckLogin(string username ,string password)
        {
            cmd_login.Connection = con;
            con.Open();
            cmd_login.CommandType = System.Data.CommandType.StoredProcedure;
            cmd_login.Parameters.AddWithValue("@username", username);
            cmd_login.Parameters.AddWithValue("@password", password);
            cmd_login.Parameters.Add("@result", System.Data.SqlDbType.Int, 4);
            cmd_login.Parameters["@result"].Direction = System.Data.ParameterDirection.Output;
            
            cmd_login.ExecuteNonQuery();
            int result = (int)cmd_login.Parameters["@result"].Value;
            con.Close();
            return result;
        }
        #endregion
    }
}