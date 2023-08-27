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
    public partial class All_Product : Form
    {
        string UserName;
        string ProductName;
        int RealPrice;
        int OrderId;
        public All_Product()
        {
            InitializeComponent();
        }

        private void dgallproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if (dgallproduct.Columns[e.ColumnIndex].HeaderText == "Offer")
            {
                dgallproduct.AutoGenerateColumns = false;
                UserName = dgallproduct.CurrentRow.Cells[3].Value.ToString();
                ProductName = dgallproduct.CurrentRow.Cells[7].Value.ToString();
                RealPrice = Convert.ToInt32(dgallproduct.CurrentRow.Cells[10].Value.ToString());
                OrderId = Convert.ToInt32(dgallproduct.CurrentRow.Cells[2].Value.ToString());
                frmOffer ob = new frmOffer(UserName, ProductName, RealPrice,OrderId);
                ob.Show();

            }
        }

        private void All_Product_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn objbtn=new DataGridViewButtonColumn();
            dgallproduct.Columns.Add(objbtn);
            objbtn.HeaderText = "Offer";
            objbtn.Text = "Discount";
            objbtn.UseColumnTextForButtonValue = true;
            objbtn.Name = "btnDiscount";

            
        


            clsRegister objk = new clsRegister();
            DataTable dt = new DataTable();
            dt = objk.GetallData();
            dgallproduct.DataSource = dt;
            dgallproduct.Show();


        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtproduct_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            
                clsRegister objp = new clsRegister(txtname.Text);
                DataTable dt = new DataTable();
                dt = objp.SearchName();
                dgallproduct.DataSource = dt;
                dgallproduct.Show();
            
                
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgallproduct.Rows.Count; i++)
            {

                if (dgallproduct.Rows[i].Cells[0].Value != null)
                {
                    bool a = (bool)dgallproduct.Rows[i].Cells[0].Value;
                    if (a == true)
                    {
                        int orderid =Convert.ToInt32( dgallproduct.Rows[i].Cells[2].Value.ToString());
                       clsproduct obj=new clsproduct(orderid);
                        obj.Isdelete();
                        MessageBox.Show("Deleted Sucessefully");
                    }
                    else
                    {
                        int orderid = Convert.ToInt32(dgallproduct.Rows[i].Cells[2].Value.ToString());
                        clsproduct obj = new clsproduct(orderid);
                        obj.Isdelete();
                    }
                    
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            clsRegister objk = new clsRegister();        
           DataTable refresh = objk.GetallData();
            dgallproduct.DataSource = refresh;
            dgallproduct.Show();
        }
    }
}
