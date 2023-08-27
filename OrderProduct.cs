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
    public partial class OrderProduct : Form
    {
        public OrderProduct()
        {
            InitializeComponent();
        }

        private void OrderProduct_Load(object sender, EventArgs e)
        {

            clsRegister objk = new clsRegister();
            DataTable dt = new DataTable();
            dt = objk.GetallData();
            dataGridView2.DataSource = dt;
            dataGridView2.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
