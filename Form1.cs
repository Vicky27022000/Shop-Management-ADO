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
    public partial class Form1 : Form
    {
        SqlConnection con=new SqlConnection("Data Source=INBOOK_X1_NEO;Initial Catalog=ShopManagement;Integrated Security=True");
        string Gender;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register objre = new Register();
            objre.MdiParent = this;
            objre.Show();
       

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login objhm = new Login();
            objhm.MdiParent = this;
            objhm.Show();
         

           
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ProductName objre = new ProductName();
            objre.MdiParent = this;
            objre.Show();
           
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Type objre = new Type();
            objre.MdiParent = this;
            objre.Show();
     
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size objre = new Size();
            objre.MdiParent = this;
            objre.Show();

        }
    }
}
