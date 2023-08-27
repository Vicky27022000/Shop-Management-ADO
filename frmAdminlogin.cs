using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopy
{
    public partial class frmAdminlogin : Form
    {
        public frmAdminlogin()
        {
            InitializeComponent();
        }

        private void frmAdminlogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void allProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderProduct obj = new OrderProduct();
            obj.Show();
        }

        private void orderProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            All_Product obj = new All_Product();
            obj.Show();
        }
    }
}
