using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace shopy
{

    internal class clsproduct
    {

        SqlConnection Con = new SqlConnection("Data Source=INBOOK_X1_NEO;Initial Catalog=ShopManagement;Integrated Security=True");
       
        public string Typename { get; set; }
        public int  Typeid { get; set; }
        public string Productname { get; set; }
        public int Productid { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }
        public int Realprice { get; set; }
        public  int Sizeid { get; set; }
        public int Date { get; set; }
        public int UserId { get; set; }
        public int Orderid { get; set; }

        public int Isdeleted { get; set; }

        public clsproduct(string typename)
        {
            Typename = typename;
        }
        public clsproduct(int typeid)
        {
            Typeid= typeid;
        }
        public clsproduct()
        {

        }
        public clsproduct( int typeid, string productname)
        {
           
            Typeid = typeid;
            Productname = productname;
        }
        public clsproduct(int orderid, int isdeleted)
        {

            Orderid = orderid;
            Isdeleted = isdeleted;
                
        }
        public clsproduct(int typeid, int productid, string size, int prie, int realprice)
        {
            Typeid = typeid;
            Productid = productid;
            Size = size;
            Price = prie;
            Realprice = realprice;

        }
        public void SaveType()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveType");
            cmd.Parameters.AddWithValue("@Typename", Typename);
            cmd.ExecuteNonQuery();
            Con.Close();
        }
        public DataTable GetType()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetType");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt=new DataTable();
            adapter.Fill(dt);
            return dt;
            Con.Close();
        }
        public void SaveProduct()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveProduct");
            cmd.Parameters.AddWithValue("@Typeid", Typeid);
            cmd.Parameters.AddWithValue("@Productname", Productname);
            cmd.ExecuteNonQuery();
            Con.Close();
        }
        public DataTable GetProduct()
        {
        
            SqlCommand cmd = new SqlCommand("SPShopManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetProduct");
            cmd.Parameters.AddWithValue("@Typeid", Typeid);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;

           
        }
        public void SaveSize()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveSize");
            cmd.Parameters.AddWithValue("@Typeid", Typeid);
            cmd.Parameters.AddWithValue("@Productid", Productid);
            cmd.Parameters.AddWithValue("@Size",Size);
            cmd.Parameters.AddWithValue("@Price",Price);
            cmd.Parameters.AddWithValue("@Realprice",Realprice);
            cmd.ExecuteNonQuery();
            Con.Close();
        }
        public DataTable GetSize()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetSize");
            cmd.Parameters.AddWithValue("@Typeid", Typeid);
            SqlDataAdapter adpt= new SqlDataAdapter();  
            adpt.SelectCommand = cmd;
            DataTable dt =new DataTable();
            adpt.Fill(dt);
            return dt;
            Con.Close();
        }
        public SqlDataReader GetPrice()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetPrice");
            cmd.Parameters.AddWithValue("@Sizeid", Typeid);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
            Con.Close();

        }
        public void updateDiscount()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateDiscount");
            cmd.Parameters.AddWithValue("@Orderid", Typeid);
            cmd.Parameters.AddWithValue("@Discount", Productname);
            cmd.ExecuteNonQuery();
            Con.Close();
        }
        public void Isdelete()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Isdelete");
            cmd.Parameters.AddWithValue("@Orderid", Typeid);
            cmd.Parameters.AddWithValue("@IsDelete", Isdeleted);
            cmd.ExecuteNonQuery();
            Con.Close();
        }
       
    }
      
}

