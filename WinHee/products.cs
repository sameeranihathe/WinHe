using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinHee
{
    public partial class products : Form
    {
        public products()
        {
            InitializeComponent();
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            AddProductForm AddProduct = new AddProductForm();
            AddProduct.Show();
        }
    }
}
