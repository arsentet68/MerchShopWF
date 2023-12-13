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
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormWorkWithOrder formWorkWithOrder = new FormWorkWithOrder();
            formWorkWithOrder.actionNumber = 1;
            formWorkWithOrder.Text = "Добавление записи";
            formWorkWithOrder.Show();
            Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int selectedId = dataGridView1.SelectedRows[0].Index + 1;
            FormWorkWithOrder formWorkWithOrder = new FormWorkWithOrder();
            formWorkWithOrder.actionNumber = 2;
            formWorkWithOrder.selectedId = selectedId;
            formWorkWithOrder.Text = "Изменение записи";
            formWorkWithOrder.Show();
            Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int selectedId = dataGridView1.SelectedRows[0].Index + 1;
            DialogResult result = MessageBox.Show("Вы действительно хотите удалить эту запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
                {
                    Order deletingOrder = new Order();
                    deletingOrder.Id = selectedId;
                    dbContext.Orders.Remove(deletingOrder);
                    dbContext.SaveChanges();
                    MessageBox.Show("Запись удалена.", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormTables formTables = new FormTables();
            formTables.Show();
            Close();
        }
    }
}
