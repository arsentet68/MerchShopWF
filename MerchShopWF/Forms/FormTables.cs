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
            formPerformers.Tag = this;
            formPerformers.Show();
            Hide();
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            FormAlbums formAlbums = new FormAlbums();
            formAlbums.Tag = this;
            formAlbums.Show();
            Hide();
        }

        private void buttonItems_Click(object sender, EventArgs e)
        {
            FormItems formItems = new FormItems();
            formItems.Tag = this;
            formItems.Show();
            Hide();
        }

        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            FormCustomers formCustomers = new FormCustomers();
            formCustomers.Tag = this;
            formCustomers.Show();
            Hide();
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            FormOrders formOrders = new FormOrders();
            formOrders.Tag = this;
            formOrders.Show();
            Hide();
        }

        private void buttonItem_Order_Click(object sender, EventArgs e)
        {
            FormItem_Order formItem_Order = new FormItem_Order();
            formItem_Order.Tag = this;
            formItem_Order.Show();
            Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var form1 = (Form1)Tag;
            form1.Show();
            Close();
        }
    }
}
