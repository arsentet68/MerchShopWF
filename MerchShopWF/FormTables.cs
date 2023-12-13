using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerchShopWF
{
    public partial class FormTables : Form
    {
        public FormTables()
        {
            InitializeComponent();
        }

        private void buttonPerformer_Click(object sender, EventArgs e)
        {
            FormPerformers formPerformers = new FormPerformers();
            formPerformers.Show();
            Close();
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            FormAlbums formAlbums = new FormAlbums();
            formAlbums.Show();
            Close();
        }

        private void buttonItems_Click(object sender, EventArgs e)
        {
            FormItems formItems = new FormItems();
            formItems.Show();
            Close();
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            FormCustomers formCustomers = new FormCustomers();
            formCustomers.Show();
            Close();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            FormOrders formOrders = new FormOrders();
            formOrders.Show();
            Close();
        }

        private void buttonItem_Order_Click(object sender, EventArgs e)
        {
            FormItem_Order formItem_Order = new FormItem_Order();
            formItem_Order.Show();
            Close();
        }
    }
}
