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
    public partial class FormWorkWithOrder : Form
    {
        public int actionNumber;
        public int selectedId;
        public FormWorkWithOrder()
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

        private void FormWorkWithOrder_Load(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from customers in dbContext.Customers
                        select new Customer()
                        {
                            Name = customers.Name,
                        };
                var CustomerList = q.ToList();
                foreach (Customer customer in CustomerList)
                {
                    comboBoxCustomer.Items.Add(customer.Name);
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
                    var q = from orders in dbContext.Orders
                            where orders.Id == this.selectedId
                            select new Order()
                            {
                                Date = orders.Date,
                                TotalPrice = orders.TotalPrice,
                                DeliveryAddress = orders.DeliveryAddress,
                                Status = orders.Status,
                                CustomerId = orders.CustomerId,
                            };
                    var selectedList = q.ToList();
                    dateTimePicker.Value = selectedList[0].Date.ToDateTime(TimeOnly.Parse("12:00 AM"));
                    textBoxTotalPrice.Text = selectedList[0].TotalPrice.ToString();
                    textBoxDeliveryAddress.Text = selectedList[0].DeliveryAddress;
                    comboBoxStatus.Text = selectedList[0].Status;
                    comboBoxCustomer.SelectedIndex = selectedList[0].CustomerId - 1;
                }
            }
        }

        private void buttonAddEntry_Click(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                int newId = AdditionalLogic.CreateNewId(5);
                DateOnly newDate = DateOnly.FromDateTime(dateTimePicker.Value);
                if (!(int.TryParse(textBoxTotalPrice.Text, out int newTotalPrice)) || newTotalPrice < 1)
                {
                    MessageBox.Show("Введите корректную цену!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                string newDeliveryAddress = textBoxDeliveryAddress.Text.Trim();
                string newStatus = comboBoxStatus.Text;
                int newCustomerId = comboBoxCustomer.SelectedIndex + 1;
                Order newOrder = new Order(newId, newDate, newTotalPrice, newDeliveryAddress, newStatus, newCustomerId);
                DialogResult result = MessageBox.Show("Вы действительно хотите добавить эту запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dbContext.Orders.Add(newOrder);
                    dbContext.SaveChanges();
                    MessageBox.Show("Запись добавлена.", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonUpdateEntry_Click(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                DateOnly updatedDate = DateOnly.FromDateTime(dateTimePicker.Value);
                if (!(int.TryParse(textBoxTotalPrice.Text, out int updatedTotalPrice)) || updatedTotalPrice < 1)
                {
                    MessageBox.Show("Введите корректную цену!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string updatedDeliveryAddress = textBoxDeliveryAddress.Text.Trim();
                    string updatedStatus = comboBoxStatus.Text;
                    int updatedCustomerId = comboBoxCustomer.SelectedIndex + 1;
                    Order updatedOrder = new Order(selectedId, updatedDate, updatedTotalPrice, updatedDeliveryAddress, updatedStatus, updatedCustomerId);
                    DialogResult result = MessageBox.Show("Вы действительно хотите изменить эту запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dbContext.Orders.Update(updatedOrder);
                        dbContext.SaveChanges();
                        MessageBox.Show("Запись изменена.", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            FormWorkWithCustomer formWorkWithCustomer = new FormWorkWithCustomer();
            formWorkWithCustomer.actionNumber = 1;
            formWorkWithCustomer.Text = "Добавление записи";
            formWorkWithCustomer.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var formOrders = (FormOrders)Tag;
            formOrders.Show();
            Close();
        }

        private void textBoxTotalPrice_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxTotalPrice.Text.Trim() != "") && (textBoxDeliveryAddress.Text.Trim() != "") && (comboBoxStatus.Text != "") && (comboBoxCustomer.Text != ""))
            {
                if (buttonAddEntry.Visible == true)
                {
                    buttonAddEntry.Enabled = true;
                }
                else if (buttonUpdateEntry.Visible == true)
                {
                    buttonUpdateEntry.Enabled = true;
                }
            }
            else
            {
                if (buttonAddEntry.Visible == true)
                {
                    buttonAddEntry.Enabled = false;
                }
                else if (buttonUpdateEntry.Visible == true)
                {
                    buttonUpdateEntry.Enabled = false;
                }
            }
        }

        private void textBoxDeliveryAddress_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxTotalPrice.Text.Trim() != "") && (textBoxDeliveryAddress.Text.Trim() != "") && (comboBoxStatus.Text != "") && (comboBoxCustomer.Text != ""))
            {
                if (buttonAddEntry.Visible == true)
                {
                    buttonAddEntry.Enabled = true;
                }
                else if (buttonUpdateEntry.Visible == true)
                {
                    buttonUpdateEntry.Enabled = true;
                }
            }
            else
            {
                if (buttonAddEntry.Visible == true)
                {
                    buttonAddEntry.Enabled = false;
                }
                else if (buttonUpdateEntry.Visible == true)
                {
                    buttonUpdateEntry.Enabled = false;
                }
            }
        }

        private void comboBoxStatus_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxTotalPrice.Text.Trim() != "") && (textBoxDeliveryAddress.Text.Trim() != "") && (comboBoxStatus.Text != "") && (comboBoxCustomer.Text != ""))
            {
                if (buttonAddEntry.Visible == true)
                {
                    buttonAddEntry.Enabled = true;
                }
                else if (buttonUpdateEntry.Visible == true)
                {
                    buttonUpdateEntry.Enabled = true;
                }
            }
            else
            {
                if (buttonAddEntry.Visible == true)
                {
                    buttonAddEntry.Enabled = false;
                }
                else if (buttonUpdateEntry.Visible == true)
                {
                    buttonUpdateEntry.Enabled = false;
                }
            }
        }

        private void comboBoxCustomer_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxTotalPrice.Text.Trim() != "") && (textBoxDeliveryAddress.Text.Trim() != "") && (comboBoxStatus.Text != "") && (comboBoxCustomer.Text != ""))
            {
                if (buttonAddEntry.Visible == true)
                {
                    buttonAddEntry.Enabled = true;
                }
                else if (buttonUpdateEntry.Visible == true)
                {
                    buttonUpdateEntry.Enabled = true;
                }
            }
            else
            {
                if (buttonAddEntry.Visible == true)
                {
                    buttonAddEntry.Enabled = false;
                }
                else if (buttonUpdateEntry.Visible == true)
                {
                    buttonUpdateEntry.Enabled = false;
                }
            }
        }
    }
}
