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
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormWorkWithCustomer formWorkWithCustomer = new FormWorkWithCustomer();
            formWorkWithCustomer.actionNumber = 1;
            formWorkWithCustomer.Text = "Добавление записи";
            formWorkWithCustomer.Show();
            Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int selectedId = dataGridView1.SelectedRows[0].Index + 1;
            FormWorkWithCustomer formWorkWithCustomer = new FormWorkWithCustomer();
            formWorkWithCustomer.actionNumber = 2;
            formWorkWithCustomer.selectedId = selectedId;
            formWorkWithCustomer.Text = "Изменение записи";
            formWorkWithCustomer.Show();
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
                    Customer deletingCustomer = new Customer();
                    deletingCustomer.Id = selectedId;
                    dbContext.Customers.Remove(deletingCustomer);
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
