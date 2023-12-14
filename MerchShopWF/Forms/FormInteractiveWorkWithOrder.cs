using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MerchShopWF
{
    public partial class FormInteractiveWorkWithOrder : Form
    {
        public int actionNumber;
        public int selectedOrderId;
        public FormInteractiveWorkWithOrder()
        {
            InitializeComponent();
        }

        private void FormInteractiveWorkWithOrder_Load(object sender, EventArgs e)
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
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.HeaderText = "Товар";
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.HeaderText = "Стоимость";
            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.HeaderText = "Количество";
            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            if (this.actionNumber == 1)
            {
                buttonCreateOrder.Visible = true;
            }
            else
            {
                buttonUpdateOrder.Visible = true;
                labelOrderId.Visible = true;
                textBoxOrderId.Visible = true;
                textBoxOrderId.Text = selectedOrderId.ToString();
                using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
                {
                    var q = from orders in dbContext.Orders
                            where orders.Id == this.selectedOrderId
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
                    var q1 = from items_order in dbContext.ItemOrders
                             join items in dbContext.Items on items_order.ItemId equals items.Id
                             where items_order.OrderId == this.selectedOrderId
                             select new itemWithUnits()
                             {
                                 Id = items.Id,
                                 Name = items.Name,
                                 Price = items.Price,
                                 Units = items_order.Units
                             };
                    var bindingList = q1.ToList();
                    for (int i = 0; i < bindingList.Count; i++)
                    {
                        dataGridView1.Rows.Add("1", "1", "1");
                        dataGridView1.Rows[i].Cells[0].Value = bindingList[i].Name;
                        dataGridView1.Rows[i].Cells[1].Value = bindingList[i].Price;
                        dataGridView1.Rows[i].Cells[2].Value = bindingList[i].Units;
                        comboBoxItem.Items.RemoveAt(bindingList[i].Id - 1);
                    }

                }
            }
        }

        private void buttonAddItemToOrder_Click(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from items in dbContext.Items
                        where items.Name.ToLower() == comboBoxItem.Text.ToLower()
                        select new Item()
                        {
                            Name = items.Name,
                            Price = items.Price,
                        };
                var selectedList = q.ToList();
                object[] rowValues = { selectedList[0].Name, selectedList[0].Price, 1 };
                dataGridView1.Rows.Add(rowValues);
                comboBoxItem.Items.RemoveAt(comboBoxItem.SelectedIndex);
                buttonAddItemToOrder.Enabled = false;
                buttonCalculate.Enabled = true;
            }

        }


        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxItem.SelectedIndex != -1)
            {
                buttonAddItemToOrder.Enabled = true;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                buttonAddUnit.Enabled = true;
                if (int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()) > 1)
                {
                    buttonRemoveUnit.Enabled = true;
                }
                else
                {
                    buttonRemoveUnit.Enabled = false;
                }
                buttonRemoveItem.Enabled = true;
            }
            else
            {
                buttonAddUnit.Enabled = false;
                buttonRemoveUnit.Enabled = false;
                buttonRemoveItem.Enabled = false;
                buttonCalculate.Enabled = false;
            }
        }

        private void buttonAddUnit_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedRows[0].Cells[2].Value = int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()) + 1;
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()) > 1)
            {
                buttonRemoveUnit.Enabled = true;
            }
            else
            {
                buttonRemoveUnit.Enabled = false;
            }
        }

        private void buttonRemoveUnit_Click(object sender, EventArgs e)
        {
            dataGridView1.SelectedRows[0].Cells[2].Value = int.Parse(dataGridView1.SelectedRows[0].Cells[2].Value.ToString()) - 1;
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
                {
                    var q = from items in dbContext.Items
                            where items.Name == dataGridView1.SelectedRows[0].Cells[0].Value
                            select new Item
                            {
                                Id = items.Id
                            };
                    var selectedList = q.ToList();
                    comboBoxItem.Items.Insert(selectedList[0].Id - 1, dataGridView1.SelectedRows[0].Cells[0].Value);
                }
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum += int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()) * int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            }
            textBoxTotalPrice.Text = sum.ToString();
        }

        private void textBoxTotalPrice_TextChanged(object sender, EventArgs e)
        {
            if (buttonCreateOrder.Visible)
            {
                if (textBoxTotalPrice.Text != "" && textBoxDeliveryAddress.Text != "" && comboBoxStatus.Text != "" && dataGridView1.RowCount > 0)
                {
                    buttonCreateOrder.Enabled = true;
                }
                else
                {
                    buttonCreateOrder.Enabled = false;
                }
            }
            else
            {
                if (textBoxTotalPrice.Text != "" && textBoxDeliveryAddress.Text != "" && comboBoxStatus.Text != "" && dataGridView1.RowCount > 0)
                {
                    buttonUpdateOrder.Enabled = true;
                }
                else
                {
                    buttonUpdateOrder.Enabled = false;
                }
            }
        }

        private void textBoxDeliveryAddress_TextChanged(object sender, EventArgs e)
        {
            if (buttonCreateOrder.Visible)
            {
                if (textBoxTotalPrice.Text != "" && textBoxDeliveryAddress.Text != "" && comboBoxStatus.Text != "" && dataGridView1.RowCount > 0)
                {
                    buttonCreateOrder.Enabled = true;
                }
                else
                {
                    buttonCreateOrder.Enabled = false;
                }
            }
            else
            {
                if (textBoxTotalPrice.Text != "" && textBoxDeliveryAddress.Text != "" && comboBoxStatus.Text != "" && dataGridView1.RowCount > 0)
                {
                    buttonUpdateOrder.Enabled = true;
                }
                else
                {
                    buttonUpdateOrder.Enabled = false;
                }
            }
        }

        private void comboBoxStatus_TextChanged(object sender, EventArgs e)
        {
            if (buttonCreateOrder.Visible)
            {
                if (textBoxTotalPrice.Text != "" && textBoxDeliveryAddress.Text != "" && comboBoxStatus.Text != "" && dataGridView1.RowCount > 0)
                {
                    buttonCreateOrder.Enabled = true;
                }
                else
                {
                    buttonCreateOrder.Enabled = false;
                }
            }
            else
            {
                if (textBoxTotalPrice.Text != "" && textBoxDeliveryAddress.Text != "" && comboBoxStatus.Text != "" && dataGridView1.RowCount > 0)
                {
                    buttonUpdateOrder.Enabled = true;
                }
                else
                {
                    buttonUpdateOrder.Enabled = false;
                }
            }
        }

        private void comboBoxCustomer_TextChanged(object sender, EventArgs e)
        {
            if (buttonCreateOrder.Visible)
            {
                if (textBoxTotalPrice.Text != "" && textBoxDeliveryAddress.Text != "" && comboBoxStatus.Text != "" && dataGridView1.RowCount > 0)
                {
                    buttonCreateOrder.Enabled = true;
                }
                else
                {
                    buttonCreateOrder.Enabled = false;
                }
            }
            else
            {
                if (textBoxTotalPrice.Text != "" && textBoxDeliveryAddress.Text != "" && comboBoxStatus.Text != "" && dataGridView1.RowCount > 0)
                {
                    buttonUpdateOrder.Enabled = true;
                }
                else
                {
                    buttonUpdateOrder.Enabled = false;
                }
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (buttonCreateOrder.Visible)
            {
                if (textBoxTotalPrice.Text != "" && textBoxDeliveryAddress.Text != "" && comboBoxStatus.Text != "" && dataGridView1.RowCount > 0)
                {
                    buttonCreateOrder.Enabled = true;
                }
                else
                {
                    buttonCreateOrder.Enabled = false;
                }
            }
            else
            {
                if (textBoxTotalPrice.Text != "" && textBoxDeliveryAddress.Text != "" && comboBoxStatus.Text != "" && dataGridView1.RowCount > 0)
                {
                    buttonUpdateOrder.Enabled = true;
                    buttonCalculate.Enabled = true;
                }
                else
                {
                    buttonUpdateOrder.Enabled = false;
                    buttonCalculate.Enabled = true;
                }
            }
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                int newOrderId = AdditionalLogic.CreateNewId(5);
                DateOnly newDate = DateOnly.FromDateTime(dateTimePicker.Value);
                if (!(int.TryParse(textBoxTotalPrice.Text, out int newTotalPrice)) || newTotalPrice < 1)
                {
                    MessageBox.Show("Введите корректную цену!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                string newDeliveryAddress = textBoxDeliveryAddress.Text.Trim();
                string newStatus = comboBoxStatus.Text;
                int newCustomerId = comboBoxCustomer.SelectedIndex + 1;
                Order newOrder = new Order(newOrderId, newDate, newTotalPrice, newDeliveryAddress, newStatus, newCustomerId);
                List<ItemOrder> itemOrderList = new List<ItemOrder> { };
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    List<int> itemList = dbContext.Items.Where(x => x.Name == dataGridView1.Rows[i].Cells[0].Value.ToString()).Select(x => x.Id).ToList();
                    int newItemId = itemList[0];
                    int newUnits = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    itemOrderList.Add(new ItemOrder(newItemId, newOrderId, newUnits));
                }
                DialogResult result = MessageBox.Show("Вы действительно хотите создать этот заказ?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dbContext.Orders.Add(newOrder);
                    foreach (ItemOrder itemOrder in itemOrderList)
                    {
                        dbContext.ItemOrders.Add(itemOrder);
                    }
                    dbContext.SaveChanges();
                    MessageBox.Show("Заказ создан. В таблицы \"Заказы\" и \"Товар_Заказ\" добавлены записи.", "Создание заказа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonUpdateOrder_Click(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                DateOnly updatedDate = DateOnly.FromDateTime(dateTimePicker.Value);
                if (!(int.TryParse(textBoxTotalPrice.Text, out int updatedTotalPrice)) || updatedTotalPrice < 1)
                {
                    MessageBox.Show("Введите корректную цену!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                string updatedDeliveryAddress = textBoxDeliveryAddress.Text.Trim();
                string updatedStatus = comboBoxStatus.Text;
                int updatedCustomerId = comboBoxCustomer.SelectedIndex + 1;
                List<int> item_order = dbContext.ItemOrders.Where(x => x.OrderId == selectedOrderId).Select(x => x.ItemId).ToList();
                foreach (int order_id in item_order)
                {
                    dbContext.ItemOrders.Remove(dbContext.ItemOrders.Where(x => x.OrderId == selectedOrderId && x.ItemId == order_id).FirstOrDefault());
                }
                Order updatedOrder = new Order(selectedOrderId, updatedDate, updatedTotalPrice, updatedDeliveryAddress, updatedStatus, updatedCustomerId);
                List<ItemOrder> itemOrderList = new List<ItemOrder> { };
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    List<int> itemList = dbContext.Items.Where(x => x.Name == dataGridView1.Rows[i].Cells[0].Value.ToString()).Select(x => x.Id).ToList();
                    int newItemId = itemList[0];
                    int newUnits = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    itemOrderList.Add(new ItemOrder(newItemId, selectedOrderId, newUnits));
                }
                DialogResult result = MessageBox.Show("Вы действительно хотите изменить этот заказ?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dbContext.Orders.Update(updatedOrder);
                    foreach (ItemOrder itemOrder in itemOrderList)
                    {
                        dbContext.ItemOrders.Add(itemOrder);
                    }
                    dbContext.SaveChanges();
                    MessageBox.Show("Заказ изменён. В таблице \"Заказы\" обновлена запись. В таблице \"Товар_Заказ\" добавлены записи.", "Изменение заказа", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var formInformation = (formInformation)Tag;
            formInformation.Show();
            Close();
        }
    }
}
