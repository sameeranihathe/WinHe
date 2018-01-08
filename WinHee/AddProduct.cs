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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        Products c = new Products();
       
        // dataGridView_products 

        private void button_add_product_Click(object sender, EventArgs e)
        {
            c.ProductName = textBox_product_name.Text;
            c.ProductDescription = textBox_product_description.Text;
            c.PurchsePrice = int.Parse(textBox_product_purchse_price.Text);
            c.SellingPrice = int.Parse(textBox_product_selling_price.Text);
            c.Quantity = int.Parse(textBox_quantity.Text);

            bool success = c.Insert(c);
            if (success == true)
            {
                MessageBox.Show("New Contact Successfully Inserted");
                Clear();
            }
            else
            {
                MessageBox.Show("Failed to Add New Contact");
            }
            //Load data into gridview
           // DataTable dt = c.Select();
           // dataGridView_products.DataSource = dt;


        }
        public void Clear()
        {
            textBox_product_id.Clear();
            textBox_product_name.Clear();
            textBox_product_description.Clear();
            textBox_product_purchse_price.Clear();
            textBox_product_selling_price.Clear();
            textBox_quantity.Clear();

        }

        private void button_clear_product_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
