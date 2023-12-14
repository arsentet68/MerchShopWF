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
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from customers in dbContext.Customers
                        select new Customer()
                        {
                            Id = customers.Id,
                            Name = customers.Name,
                            Email = customers.Email
                        };
                var CustomerList = q.ToList();
                var bindingList = new BindingList<Customer>(CustomerList);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                dataGridView1.Columns["Orders"].Visible = false;
                dataGridView1.Columns["Id"].HeaderText = "ID";
                dataGridView1.Columns["Name"].HeaderText = "Имя";
                dataGridView1.Columns["Email"].HeaderText = "E-mail";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormWorkWithCustomer formWorkWithCustomer = new FormWorkWithCustomer();
            formWorkWithCustomer.actionNumber = 1;
            formWorkWithCustomer.Text = "Добавление записи";
            formWorkWithCustomer.Tag = this;
            formWorkWithCustomer.Show();
            Hide();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int selectedId = dataGridView1.SelectedRows[0].Index + 1;
            FormWorkWithCustomer formWorkWithCustomer = new FormWorkWithCustomer();
            formWorkWithCustomer.actionNumber = 2;
            formWorkWithCustomer.selectedId = selectedId;
            formWorkWithCustomer.Text = "Изменение записи";
            formWorkWithCustomer.Tag = this;
            formWorkWithCustomer.Show();
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
                    List<int> orders = dbContext.Orders.Where(x => x.CustomerId == selectedId).Select(x => x.Id).ToList();
                    foreach (int order in orders)
                    {
                        List<int> item_order = dbContext.ItemOrders.Where(x => x.OrderId == order).Select(x => x.OrderId).ToList();
                        foreach (int order_id in item_order)
                        {
                            dbContext.ItemOrders.Remove(dbContext.ItemOrders.Where(x => x.OrderId == order_id).FirstOrDefault());
                        }
                        dbContext.Orders.Remove(dbContext.Orders.Where(x => x.Id == order).FirstOrDefault());
                    }
                    dbContext.Customers.Remove(dbContext.Customers.Where(x => x.Id == selectedId).FirstOrDefault());
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

        private void FormCustomers_VisibleChanged(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from customers in dbContext.Customers
                        select new Customer()
                        {
                            Id = customers.Id,
                            Name = customers.Name,
                            Email = customers.Email
                        };
                var CustomerList = q.ToList();
                var bindingList = new BindingList<Customer>(CustomerList);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                dataGridView1.Columns["Orders"].Visible = false;
                dataGridView1.Columns["Id"].HeaderText = "ID";
                dataGridView1.Columns["Name"].HeaderText = "Имя";
                dataGridView1.Columns["Email"].HeaderText = "E-mail";
            }
        }
    }
}
