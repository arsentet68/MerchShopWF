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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from orders in dbContext.Orders
                        join customers in dbContext.Customers on orders.CustomerId equals customers.Id
                        orderby orders.Id
                        select new ExtendedOrderInfo()
                        {
                            Id = orders.Id,
                            Date = orders.Date,
                            TotalPrice = orders.TotalPrice,
                            DeliveryAddress = orders.DeliveryAddress,
                            Status = orders.Status,
                            CustomerId = orders.CustomerId,
                            CustomerName = customers.Name
                        };
                var OrderList = q.ToList();
                var bindingList = new BindingList<ExtendedOrderInfo>(OrderList);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                dataGridView1.Columns["CustomerId"].Visible = false;
                dataGridView1.Columns["Id"].HeaderText = "ID";
                dataGridView1.Columns["Date"].HeaderText = "Дата";
                dataGridView1.Columns["TotalPrice"].HeaderText = "Общая стоимость";
                dataGridView1.Columns["DeliveryAddress"].HeaderText = "Адрес доставки";
                dataGridView1.Columns["Status"].HeaderText = "Статус";
                dataGridView1.Columns["CustomerName"].HeaderText = "Покупатель";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormWorkWithOrder formWorkWithOrder = new FormWorkWithOrder();
            formWorkWithOrder.actionNumber = 1;
            formWorkWithOrder.Text = "Добавление записи";
            formWorkWithOrder.Tag = this;
            formWorkWithOrder.Show();
            Hide();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int selectedId = dataGridView1.SelectedRows[0].Index + 1;
            FormWorkWithOrder formWorkWithOrder = new FormWorkWithOrder();
            formWorkWithOrder.actionNumber = 2;
            formWorkWithOrder.selectedId = selectedId;
            formWorkWithOrder.Text = "Изменение записи";
            formWorkWithOrder.Tag = this;
            formWorkWithOrder.Show();
            Hide();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedId = dataGridView1.SelectedRows[0].Index + 1;
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
                {
                    List<int> item_order = dbContext.ItemOrders.Where(x => x.OrderId == selectedId).Select(x => x.OrderId).ToList();
                    foreach (int order_id in item_order)
                    {
                        dbContext.ItemOrders.Remove(dbContext.ItemOrders.Where(x => x.OrderId == order_id).FirstOrDefault());
                    }
                    dbContext.Orders.Remove(dbContext.Orders.Where(x => x.Id == selectedId).FirstOrDefault());
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

        private void FormOrders_VisibleChanged(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from orders in dbContext.Orders
                        join customers in dbContext.Customers on orders.CustomerId equals customers.Id
                        orderby orders.Id
                        select new ExtendedOrderInfo()
                        {
                            Id = orders.Id,
                            Date = orders.Date,
                            TotalPrice = orders.TotalPrice,
                            DeliveryAddress = orders.DeliveryAddress,
                            Status = orders.Status,
                            CustomerId = orders.CustomerId,
                            CustomerName = customers.Name
                        };
                var OrderList = q.ToList();
                var bindingList = new BindingList<ExtendedOrderInfo>(OrderList);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                dataGridView1.Columns["CustomerId"].Visible = false;
                dataGridView1.Columns["Id"].HeaderText = "ID";
                dataGridView1.Columns["Date"].HeaderText = "Дата";
                dataGridView1.Columns["TotalPrice"].HeaderText = "Общая стоимость";
                dataGridView1.Columns["DeliveryAddress"].HeaderText = "Адрес доставки";
                dataGridView1.Columns["Status"].HeaderText = "Статус";
                dataGridView1.Columns["CustomerName"].HeaderText = "Покупатель";
            }
        }
    }
}
