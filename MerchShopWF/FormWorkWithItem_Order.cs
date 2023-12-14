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
                            Id = orders.Id,
                        };
                var orderList = q.ToList();
                foreach (Order order in orderList)
                {
                    comboBoxOrder.Items.Add(order.Id);
                }
            }
            if (this.actionNumber == 1)
            {
                buttonAddEntry.Visible = true;
            }
            else
            {
                buttonUpdateEntry.Visible = true;
                comboBoxItem.DropDownStyle = ComboBoxStyle.Simple;
                comboBoxOrder.DropDownStyle = ComboBoxStyle.Simple;
                comboBoxOrder.Enabled = false;
                comboBoxItem.Enabled = false;
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

        private void buttonAddEntry_Click(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                int newItemId = comboBoxItem.SelectedIndex + 1;
                int newOrderId = comboBoxOrder.SelectedIndex + 1;
                if (!(int.TryParse(textBoxUnits.Text, out int newUnits)) || newUnits < 1)
                {
                    MessageBox.Show("Введите корректное количество!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                ItemOrder newItemOrder = new ItemOrder(newItemId, newOrderId, newUnits);
                DialogResult result = MessageBox.Show("Вы действительно хотите добавить эту запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    dbContext.ItemOrders.Add(newItemOrder);
                    try
                    {
                        dbContext.SaveChanges();
                        MessageBox.Show("Запись добавлена.", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Запись с этой комбинацией товара и заказа уже есть!", "Ошибка при добавлении", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void buttonUpdateEntry_Click(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                int updatedItemId = comboBoxItem.SelectedIndex + 1;
                int updaedOrderId = comboBoxOrder.SelectedIndex + 1;
                if (!(int.TryParse(textBoxUnits.Text, out int updatedUnits)) || updatedUnits < 1)
                {
                    MessageBox.Show("Введите корректное количество!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ItemOrder updatedItemOrder = new ItemOrder(updatedItemId, updaedOrderId, updatedUnits);
                    DialogResult result = MessageBox.Show("Вы действительно хотите изменить эту запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dbContext.ItemOrders.Update(updatedItemOrder);
                        dbContext.SaveChanges();
                        MessageBox.Show("Запись изменена.", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var formItem_Order = (FormItem_Order)Tag;
            formItem_Order.Show();
            Close();
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            FormWorkWithItem formWorkWithItem = new FormWorkWithItem();
            formWorkWithItem.actionNumber = 1;
            formWorkWithItem.Text = "Добавление записи";
            formWorkWithItem.Show();
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            FormWorkWithOrder formWorkWithOrder = new FormWorkWithOrder();
            formWorkWithOrder.actionNumber = 1;
            formWorkWithOrder.Text = "Добавление записи";
            formWorkWithOrder.Show();
        }
        private void ComboBoxItem_TextChanged(object sender, EventArgs e)
        {
            if ((comboBoxItem.Text != "") && (comboBoxOrder.Text != "") && (textBoxUnits.Text != ""))
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
        private void ComboBoxOrder_TextChanged(object sender, EventArgs e)
        {
            if ((comboBoxItem.Text != "") && (comboBoxOrder.Text != "") && (textBoxUnits.Text != ""))
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

        private void textBoxUnits_TextChanged(object sender, EventArgs e)
        {
            if ((comboBoxItem.Text != "") && (comboBoxOrder.Text != "") && (textBoxUnits.Text != ""))
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
