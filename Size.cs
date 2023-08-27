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
    public partial class Size : Form
    {
        public Size()
        {
            InitializeComponent();
        }

        private void Size_Load(object sender, EventArgs e)
        {
            clsproduct objtype = new clsproduct();
             
            DataTable dt= new DataTable();
            dt= objtype.GetProduct();
            cmbproduct.DisplayMember = "Productname";
            cmbproduct.ValueMember = "Productid";
            cmbproduct.DataSource = dt;
          
            dt = objtype.GetType();
            cmbtype.DisplayMember = "Typename";
            cmbtype.ValueMember = "Typeid";
            cmbtype.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsproduct obj = new clsproduct(Convert.ToInt32(cmbtype.SelectedValue.ToString()), Convert.ToInt32(cmbproduct.SelectedValue.ToString()), txtsize.Text,Convert.ToInt32( txtprice.Text),Convert. ToInt32  (txtrealprice.Text)); 
            obj.SaveSize();
            MessageBox.Show("Save Successfully");
        }

        private void cmbproduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsproduct sz = new clsproduct(Convert.ToInt32(cmbtype.SelectedValue.ToString()));
            DataTable dt = new DataTable();
            dt = sz.GetProduct();
            cmbproduct.DisplayMember = "ProductName";
            cmbproduct.ValueMember = "Productid";
            cmbproduct.DataSource = dt;
        }
    }
}
