using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ProductsApp_ADODemo.Models
{
    public class Products
    {
        #region Properties
        public int PID { get; set; }
        public string PName { get; set; }
        public string PCategory { get; set; }
        public int PQty { get; set; }
        public double PPrice { get; set; }
        public int PDiscount { get; set; }
        SqlConnection con = new SqlConnection("server=IND358;database=Products_DB;integrated security=true");
        SqlCommand cmd_getallprod=new SqlCommand("select * from ProductsInfo");
        SqlCommand cmd_getprodbycat = new SqlCommand("select * from ProductsInfo where pCategory=@p_category");
        SqlCommand cmd_addprod = new SqlCommand("insert into ProductsInfo values (@p_id,@p_name,@p_category,@p_qty,@p_price,@p_discount)");
        SqlCommand cmd_deleteprod = new SqlCommand("delete from ProductsInfo where pID=@p_id");
        SqlCommand cmd_updateprod = new SqlCommand("update ProductsInfo set pName=@p_name,pCategory=@p_category,pQty=@p_qty,pPrice=@p_price,pDiscount=@p_discount where pID=@p_id");


        #endregion

        #region Constructors
        public Products()
        {

        }
        #endregion

        #region Methods
        public List<Products> GetAllProducts()
        {
            List<Products> pList = new List<Products>();
            cmd_getallprod.Connection = con;
            con.Open();
            SqlDataReader _read;
            _read = cmd_getallprod.ExecuteReader();
            while(_read.Read())
            {
                pList.Add(new Products() { PID = Convert.ToInt32(_read[0]), PName = Convert.ToString(_read[1]), PCategory = Convert.ToString(_read[2]), PQty = Convert.ToInt32(_read[3]), PPrice = Convert.ToDouble(_read[4]), PDiscount = Convert.ToInt32(_read[5]) });

            }
            _read.Close();
            con.Close();
            return pList;
        }

        public List<Products> SearchByCategory(string p_Category)
        {
            List<Products> pList = new List<Products>();
            cmd_getprodbycat.Connection = con;
            cmd_getprodbycat.Parameters.AddWithValue("@p_category", p_Category);
            SqlDataReader _read;
            con.Open();
            _read = cmd_getprodbycat.ExecuteReader();
            while (_read.Read())
            {
                pList.Add(new Products() { PID = Convert.ToInt32(_read[0]), PName = Convert.ToString(_read[1]), PCategory = Convert.ToString(_read[2]), PQty = Convert.ToInt32(_read[3]), PPrice = Convert.ToDouble(_read[4]), PDiscount = Convert.ToInt32(_read[5]) });

            }
            _read.Close();
            con.Close();
            return pList;

        }
        public int DeleteProd(int p_ID)
        {
            cmd_deleteprod.Connection = con;
            con.Open();
            cmd_deleteprod.Parameters.AddWithValue("@p_id", p_ID);
            int lines = cmd_deleteprod.ExecuteNonQuery();
            con.Close();
            return lines;
        }
        public int AddProd(int p_ID,string p_Name,string p_Category,int p_Qty,double p_Price,int p_Discount)
        {
            cmd_addprod.Connection = con;
            con.Open();
            cmd_addprod.Parameters.AddWithValue("@p_id", p_ID);
            cmd_addprod.Parameters.AddWithValue("@p_name", p_Name);
            cmd_addprod.Parameters.AddWithValue("@p_category", p_Category);
            cmd_addprod.Parameters.AddWithValue("@p_qty", p_Qty);
            cmd_addprod.Parameters.AddWithValue("@p_price", p_Price);
            cmd_addprod.Parameters.AddWithValue("@p_discount", p_Discount);
            int lines = cmd_addprod.ExecuteNonQuery();
            con.Close();
            return lines;
        }
        public int UpdateProd(int p_ID, string p_Name, string p_Category, int p_Qty, double p_Price, int p_Discount)
        {
            cmd_updateprod.Connection = con;
            con.Open();
            cmd_updateprod.Parameters.AddWithValue("@p_id", p_ID);
            cmd_updateprod.Parameters.AddWithValue("@p_name", p_Name);
            cmd_updateprod.Parameters.AddWithValue("@p_category", p_Category);
            cmd_updateprod.Parameters.AddWithValue("@p_qty", p_Qty);
            cmd_updateprod.Parameters.AddWithValue("@p_price", p_Price);
            cmd_updateprod.Parameters.AddWithValue("@p_discount", p_Discount);
            int lines = cmd_updateprod.ExecuteNonQuery();
            con.Close();
            return lines;
        }
        #endregion
    }
}