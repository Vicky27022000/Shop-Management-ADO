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
    public partial class ProductName : Form
    {
        public ProductName()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsproduct obj=new clsproduct(Convert.ToInt32(cmbtype1.SelectedValue.ToString()),cmbproduct.Text);
            obj.SaveProduct();
            MessageBox.Show("Product Save");
        }

        private void ProductName_Load(object sender, EventArgs e)
        {
            clsproduct objtype = new clsproduct();
            DataTable dt = new DataTable();
            dt = objtype.GetType();
            cmbtype1.DisplayMember = "Typename";
            cmbtype1.ValueMember = "Typeid";
            cmbtype1.DataSource = dt;
        }

        private void cmbtype1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
