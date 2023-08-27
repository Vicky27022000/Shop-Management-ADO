using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace shopy
{
    public partial class Login : Form
    {


        string text1;
        string text2;
        string text3;
        public int text4;

        SqlConnection Con = new SqlConnection("Data Source=INBOOK_X1_NEO;Initial Catalog=ShopManagement;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }
        public static string text;

        private void button1_Click(object sender, EventArgs e)
        {
            clsRegister objLogin = new clsRegister(cmbtype.Text, txtEmail.Text, Convert.ToInt32(txtPassword.Text));
            SqlDataReader dr;
            dr = objLogin.LoginData();
            while (dr.Read())
            {
               
                if (dr.HasRows == true)
                {
                    string UserType = dr["UserType"].ToString();
                    if (UserType == "Admin")
                    {
                        frmAdminlogin adminpage = new frmAdminlogin();
                        adminpage.Show();
                        MessageBox.Show("login sucessfull");
                    }
                   else  if (UserType == "Customer")
                    {
                        text1 = dr["UserName"].ToString();
                        text2 = dr["UserEmail"].ToString();
                        text3 = dr["Userphone"].ToString();
                        text4 =Convert.ToInt32( dr["UserId"].ToString());
                        order objCuster = new order(text1, text2, text3,text4);
                        objCuster.Show();

                        MessageBox.Show("login sucessfull");
                    }
          

                     else 
                    {
                        MessageBox.Show("login failed");

                    }


                }
            }
           

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void cmbtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            text = txtEmail.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
