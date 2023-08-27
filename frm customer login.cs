using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace shopy
{
    public partial class order : Form
    {
        public int UserId = 0;
        

        SqlConnection Con = new SqlConnection("Data Source=INBOOK_X1_NEO;Initial Catalog=ShopManagement;Integrated Security=True");
    
        public order()
        {
            InitializeComponent();
        }
            
        public order(string Name,string Email,string phone,int uid)
        {
            InitializeComponent();
            txtname.Text = Name;
            txtemail.Text = Email;
            txtphone.Text=phone;
            UserId = uid;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void order_Load(object sender, EventArgs e)
        {
            clsproduct objtype = new clsproduct();

            DataTable dt = new DataTable();         
            dt = objtype.GetType();
            cmbtype.DisplayMember = "Typename";
            cmbtype.ValueMember = "Typeid";
            cmbtype.DataSource = dt;
            dt = objtype.GetProduct();
            cmbproduct.DisplayMember = "Productname";
            cmbproduct.ValueMember = "Productid";
            cmbproduct.DataSource = dt;

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Product Type",100,HorizontalAlignment.Center);
            listView1.Columns.Add("Product Name", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Product Size", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Product Price ", 100, HorizontalAlignment.Center);
           listView1.Columns.Add("Product Sizeid ", 100, HorizontalAlignment.Center);


            //txtemail.Text = Login.text;
        
        }

        private void cmbtype1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsproduct sz = new clsproduct(Convert.ToInt32(cmbtype.SelectedValue.ToString()));
            DataTable dt= new DataTable();
            dt =sz.GetProduct();
            cmbproduct.DisplayMember = "ProductName";
            cmbproduct.ValueMember = "Productid";
            cmbproduct.DataSource= dt;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gd.SelectedRows.Count > 0)
            {
                string sizeid1 = gd.SelectedRows[0].Cells[0].Value.ToString();
                string size=gd.SelectedRows[0].Cells[1].Value.ToString();   
                string type=cmbtype.Text;
                string product=cmbproduct.Text;
                string price=txtprice.Text;
                Add(type, product, size, price, sizeid1);


            }
        }

        private void gd_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int Sized = Convert.ToInt32(gd.SelectedRows[0].Cells[0].Value.ToString());
            clsproduct objPrice=new clsproduct(Sized);


            SqlDataReader dr;
            dr = objPrice.GetPrice();

            while(dr.Read())
            {
                txtprice.Text = dr["Price(MRP)"].ToString();
            }
            dr.Close();
        }

        private void cmbproduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            clsproduct sz =new clsproduct(Convert.ToInt32(cmbproduct.SelectedValue.ToString()));
            DataTable dt =new DataTable();
            dt = sz.GetSize();
            gd.DataSource= dt;
            gd.Show();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            
            for (int i=0;i<listView1.Items.Count;i++)
            {
               int  SizeID = (Convert.ToInt32(listView1.Items[i].SubItems[4].Text));
                string Status = "Confirmed";
                clsRegister objg=new clsRegister(UserId,SizeID, Status);
                objg.OrderConfirm();
            }
            MessageBox.Show("Order Confirm");
        }

        private void log_Click(object sender, EventArgs e)
        {

        }

        public void Add(string type1,string product1,string size1,string price1,string sizeid2)
        {
            if(price1 != null)
            {
                ListViewItem lst=new ListViewItem(type1);
                lst.SubItems.Add(product1);
                lst.SubItems.Add(size1);
                lst.SubItems.Add(price1);
                lst.SubItems.Add(sizeid2);

                listView1.Items.Add(lst);
                listView1.Columns[4].Width = 0;
                
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void totala_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach(ListViewItem item in listView1.Items)
            {
                sum+=int.Parse(item.SubItems[3].Text);

            }
            txttotal.Text = Convert.ToString(sum);
        }
    }
}
