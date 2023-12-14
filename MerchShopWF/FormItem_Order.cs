using Microsoft.EntityFrameworkCore;
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
    public partial class FormItem_Order : Form
    {
        public FormItem_Order()
        {
            InitializeComponent();
        }

        private void FormItem_Order_Load(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from item_orders in dbContext.ItemOrders
                        join items in dbContext.Items on item_orders.ItemId equals items.Id
                        join orders in dbContext.Orders on item_orders.OrderId equals orders.Id
                        select new ExtendedItem_OrderInfo()
                        {
                            ItemId = item_orders.ItemId,
                            ItemName = items.Name,
                            OrderId = item_orders.OrderId,
                            Units = item_orders.Units
                        };
                var Item_OrderList = q.ToList();
                var bindingList = new BindingList<ExtendedItem_OrderInfo>(Item_OrderList);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                dataGridView1.Columns["ItemId"].Visible = false;
                dataGridView1.Columns["ItemName"].HeaderText = "Товар";
                dataGridView1.Columns["OrderId"].HeaderText = "Заказ";
                dataGridView1.Columns["Units"].HeaderText = "Количество";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormWorkWithItem_Order formWorkWithItem_Order = new FormWorkWithItem_Order();
            formWorkWithItem_Order.actionNumber = 1;
            formWorkWithItem_Order.Text = "Добавление записи";
            formWorkWithItem_Order.Tag = this;
            formWorkWithItem_Order.Show();
            Hide();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int selectedItemId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            int selectedOrderId = int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            FormWorkWithItem_Order formWorkWithItem_Order = new FormWorkWithItem_Order();
            formWorkWithItem_Order.actionNumber = 2;
            formWorkWithItem_Order.selectedItemId = selectedItemId;
            formWorkWithItem_Order.selectedOrderId = selectedOrderId;
            formWorkWithItem_Order.Text = "Изменение записи";
            formWorkWithItem_Order.Tag = this;
            formWorkWithItem_Order.Show();
            Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedItemId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            int selectedOrderId = int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
                {
                    dbContext.ItemOrders.Remove(dbContext.ItemOrders.Where(x => x.ItemId == selectedItemId && x.OrderId == selectedOrderId).FirstOrDefault());
                    dbContext.SaveChanges();
                    MessageBox.Show("Запись удалена.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.OnLoad(EventArgs.Empty);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var formTables = (FormTables)Tag;
            formTables.Show();
            Close();
        }

        private void FormItem_Order_VisibleChanged(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from item_orders in dbContext.ItemOrders
                        join items in dbContext.Items on item_orders.ItemId equals items.Id
                        join orders in dbContext.Orders on item_orders.OrderId equals orders.Id
                        select new ExtendedItem_OrderInfo()
                        {
                            ItemId = item_orders.ItemId,
                            ItemName = items.Name,
                            OrderId = item_orders.OrderId,
                            Units = item_orders.Units
                        };
                var Item_OrderList = q.ToList();
                var bindingList = new BindingList<ExtendedItem_OrderInfo>(Item_OrderList);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                dataGridView1.Columns["ItemId"].Visible = false;
                dataGridView1.Columns["ItemName"].HeaderText = "Товар";
                dataGridView1.Columns["OrderId"].HeaderText = "Заказ";
                dataGridView1.Columns["Units"].HeaderText = "Количество";
            }
        }
    }
}
