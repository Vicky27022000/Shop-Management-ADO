using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopy
{
    public partial class Register : Form
    {
        SqlConnection Con=new SqlConnection("Data Source=INBOOK_X1_NEO;Initial Catalog=ShopManagement;Integrated Security=True");
        string Gender;
        string Email;
        int phoneno;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsRegister objRes=new clsRegister(cmbtype.Text,txtname.Text, Convert.ToInt32(txtphone.Text),txtemail.Text, Gender,cmbstate.Text,Convert.ToInt32( txtpassward.Text));
            objRes.ResisterData();

            MessageBox.Show("Resistered Successfully");
        }

        private void rdbtnmale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void rdbtnfemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void txtpassward_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
