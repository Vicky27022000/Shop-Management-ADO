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

    internal class clsRegister
    {
        SqlConnection Con = new SqlConnection("Data Source=INBOOK_X1_NEO;Initial Catalog=ShopManagement;Integrated Security=True");
        public int UserId { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public int Typeid { get; set; }
        public int Productid { get; set; }
        public int Phoneno { get; set; }
        public string State { get; set; }
        public int Passward { get; set; }
        public string Status { get; set; }
        public int Sizeid { get; set; }
        public string Date { get; set; }
        public clsRegister(int uId1, int sizeid1, string status1)
        {
            UserId = uId1;
            Sizeid = sizeid1;
            Status = status1;

        }
        public clsRegister(string type, String name, int phoneno, String email, string gender, string state, int passward)
        {
            Type = type;
            Name = name;
            Email = email;
            Phoneno = phoneno;
            Gender = gender;
            State = state;
            Passward = passward;


        }
        public clsRegister()
        {

        }
        public clsRegister(string name)
        { 
            Name= name;
        }

        public clsRegister(string type, string email, int password)
        {
            Email = email;
            Passward = password;
            Type = type;

        }
        public clsRegister(int typeid, int productid)
        {
            UserId = typeid;
            Productid = productid;

        }
        public void ResisterData()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "RegisterData");
            cmd.Parameters.AddWithValue("@type", Type);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@phoneno", Phoneno);
            cmd.Parameters.AddWithValue("@gender", Gender);
            cmd.Parameters.AddWithValue("@State", State);
            cmd.Parameters.AddWithValue("@password", Passward);
            cmd.ExecuteNonQuery();

            Con.Close();
        }
        public SqlDataReader LoginData()
        {
            Con.Open();
            SqlCommand cnd = new SqlCommand("SPShopManagement", Con);
            cnd.CommandType = CommandType.StoredProcedure;
            cnd.Parameters.AddWithValue("@Flag", "login");
            cnd.Parameters.AddWithValue("@type", Type);
            cnd.Parameters.AddWithValue("@email", Email);

            cnd.Parameters.AddWithValue("@Password", Passward);
            SqlDataReader dr;
            dr = cnd.ExecuteReader();
            return dr;

            Con.Close();
        }
        public void OrderConfirm()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "OrderConfirm");
            cmd.Parameters.AddWithValue("@UserId", UserId);
            cmd.Parameters.AddWithValue("@Sizeid", Sizeid);
            cmd.Parameters.AddWithValue("@status", Status);
            cmd.Parameters.AddWithValue("@Date",DateTime.Now.ToString());
            cmd.ExecuteNonQuery();
            Con.Close();




        }
        public DataTable GetallData()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "GetOrderProduct");
            cmd.Parameters.AddWithValue("@Typeid", Typeid);
            cmd.Parameters.AddWithValue("@Productid", Productid);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            Con.Close();
        }
        public DataTable SearchName()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("SPShopManagement", Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "searchName");
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@Productname", Name);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
            Con.Close();
        }
    }

       
}