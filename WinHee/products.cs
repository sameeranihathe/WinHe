using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinHee.ProductsClass;

namespace WinHee
{
    public partial class products : Form
    {
        public products()
        {
            InitializeComponent();
        }
        Products c = new Products();
        private void btn_add_product_Click(object sender, EventArgs e)
        {
            AddProductForm AddProduct = new AddProductForm();
            AddProduct.Show();
        }

        private void dataGridView_products_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get data from grid view from text boxes
           
            
        }

        private void products_Load(object sender, EventArgs e)
        {

        }
    }
}
