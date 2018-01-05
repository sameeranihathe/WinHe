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
    public partial class homeScreen : Form
    {
        public homeScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            products products = new products();
            products.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void customersButton_Click(object sender, EventArgs e)
        {
            customers customers = new customers();
            customers.Show();
        }

        private void InvoicesButton_Click(object sender, EventArgs e)
        {
            Invoices invoices = new Invoices();
            invoices.Show();
        }
    }
}
