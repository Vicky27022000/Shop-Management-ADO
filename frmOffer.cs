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
    public partial class frmOffer : Form
    {
        int OrderId;
        public frmOffer(string Username, string ProctName, int RealPrice, int orderId)
        {
            InitializeComponent();
            lblName.Text = Username;
            lblProNmae.Text = ProctName;
            lblRealprice.Text=RealPrice.ToString();
            OrderId = orderId;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsproduct obUpdate=new clsproduct(OrderId,txtDiscount.Text);
            obUpdate.updateDiscount();
            MessageBox.Show("Discount Update Successfully");

        }

        private void frmOffer_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnnewprice_Click(object sender, EventArgs e)
        {
            int Realprice =Convert.ToInt32(lblRealprice.Text);
            int Discount=Convert.ToInt32(txtDiscount.Text);

            int DiscountPrice=Realprice *Discount / 100;
            int NewDiscountPrice = Realprice - DiscountPrice;

            txtprice.Text = NewDiscountPrice.ToString();
        }
    }
}
