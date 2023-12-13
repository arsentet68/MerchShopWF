using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MerchShopWF
{
    public partial class FormWorkWithItem_Order : Form
    {
        public int actionNumber;
        public int selectedItemId;
        public int selectedOrderId;
        public FormWorkWithItem_Order()
        {
            InitializeComponent();
            if (this.actionNumber == 1)
            {
                buttonAddEntry.Visible = true;
            }
            if (this.actionNumber == 2)
            {
                buttonUpdateEntry.Visible = true;
            }
        }

        private void FormWorkWithItem_Order_Load(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from items in dbContext.Items
                        select new Item()
                        {
                            Name = items.Name,
                        };
                var itemList = q.ToList();
                foreach (Item item in itemList)
                {
                    comboBoxItem.Items.Add(item.Name);
                }
            }
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from orders in dbContext.Orders
                        select new Order()
                        {
                            Date = orders.Date,
                        };
                var orderList = q.ToList();
                foreach (Order order in orderList)
                {
                    comboBoxOrder.Items.Add(order.Date);
                }
            }
            if (this.actionNumber == 1)
            {
                buttonAddEntry.Visible = true;
            }
            else
            {
                buttonUpdateEntry.Visible = true;
                using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
                {
                    var q = from item_order in dbContext.ItemOrders
                            where item_order.ItemId == this.selectedItemId &&
                                  item_order.OrderId == this.selectedOrderId
                            select new ItemOrder()
                            {
                                ItemId = item_order.ItemId,
                                OrderId = item_order.OrderId,
                                Units = item_order.Units
                            };
                    var selectedList = q.ToList();
                    comboBoxItem.SelectedIndex = selectedList[0].ItemId - 1;
                    comboBoxOrder.SelectedIndex = selectedList[0].OrderId - 1;
                    textBoxUnits.Text = selectedList[0].Units.ToString();
                }
            }
        }
    }
}
