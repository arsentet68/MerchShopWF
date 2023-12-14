using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MerchShopWF
{
    public partial class formInformation : Form
    {
        public formInformation()
        {
            InitializeComponent();
        }

        private void formInformation_Load(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from orders in dbContext.Orders
                        join customers in dbContext.Customers on orders.CustomerId equals customers.Id
                        join item_order in dbContext.ItemOrders on orders.Id equals item_order.OrderId
                        join items in dbContext.Items on item_order.ItemId equals items.Id
                        join albums in dbContext.Albums on items.AlbumId equals albums.Id
                        join performers in dbContext.Performers on albums.PerformerId equals performers.Id
                        orderby orders.Id
                        select new GlobalInfo()
                        {
                            OrderID = orders.Id,
                            Date = orders.Date,
                            TotalPrice = orders.TotalPrice,
                            Status = orders.Status,
                            Customer = customers.Name,
                            Performer = performers.Name,
                            Album = albums.Name,
                            Item = items.Name,
                            Price = items.Price,
                            Units = item_order.Units
                        };
                var InfoList = q.ToList();
                var bindingList = new BindingList<GlobalInfo>(InfoList);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                dataGridView1.Columns["OrderId"].HeaderText = "Заказ";
                dataGridView1.Columns["Date"].HeaderText = "Дата";
                dataGridView1.Columns["TotalPrice"].HeaderText = "Общая стоимость";
                dataGridView1.Columns["Status"].HeaderText = "Статус";
                dataGridView1.Columns["Customer"].HeaderText = "Покупатель";
                dataGridView1.Columns["Performer"].HeaderText = "Исполнитель";
                dataGridView1.Columns["Album"].HeaderText = "Альбом";
                dataGridView1.Columns["Item"].HeaderText = "Товар";
                dataGridView1.Columns["Price"].HeaderText = "Цена";
                dataGridView1.Columns["Units"].HeaderText = "Количество";
                var q1 = from performers in dbContext.Performers
                         select new Performer()
                         {
                             Name = performers.Name,
                         };
                var PerformerList = q1.ToList();
                foreach (Performer performer in PerformerList)
                {
                    comboBoxPerformer.Items.Add(performer.Name);
                }
                var q2 = from orders in dbContext.Orders
                         select new Order()
                         {
                             Id = orders.Id,
                         };
                var OrderList = q2.ToList();
                foreach (Order order in OrderList)
                {
                    comboBoxOrder.Items.Add(order.Id);
                }
            }
        }

        private void buttonInteractiveAdd_Click(object sender, EventArgs e)
        {
            FormInteractiveWorkWithOrder formInteractiveWorkWithOrder = new FormInteractiveWorkWithOrder();
            formInteractiveWorkWithOrder.Text = "Интерактивное создание заказа";
            formInteractiveWorkWithOrder.actionNumber = 1;
            formInteractiveWorkWithOrder.Tag = this;
            formInteractiveWorkWithOrder.Show();
            Hide();
        }

        private void buttonInteractiveUpdate_Click(object sender, EventArgs e)
        {
            int selectedOrderId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            FormInteractiveWorkWithOrder formInteractiveWorkWithOrder = new FormInteractiveWorkWithOrder();
            formInteractiveWorkWithOrder.Text = "Интерактивное изменение заказа";
            formInteractiveWorkWithOrder.actionNumber = 2;
            formInteractiveWorkWithOrder.selectedOrderId = selectedOrderId;
            formInteractiveWorkWithOrder.Tag = this;
            formInteractiveWorkWithOrder.Show();
            Hide();
        }

        private void formInformation_VisibleChanged(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from orders in dbContext.Orders
                        join customers in dbContext.Customers on orders.CustomerId equals customers.Id
                        join item_order in dbContext.ItemOrders on orders.Id equals item_order.OrderId
                        join items in dbContext.Items on item_order.ItemId equals items.Id
                        join albums in dbContext.Albums on items.AlbumId equals albums.Id
                        join performers in dbContext.Performers on albums.PerformerId equals performers.Id
                        orderby orders.Id
                        select new GlobalInfo()
                        {
                            OrderID = orders.Id,
                            Date = orders.Date,
                            TotalPrice = orders.TotalPrice,
                            Status = orders.Status,
                            Customer = customers.Name,
                            Performer = performers.Name,
                            Album = albums.Name,
                            Item = items.Name,
                            Price = items.Price,
                            Units = item_order.Units
                        };
                var InfoList = q.ToList();
                var bindingList = new BindingList<GlobalInfo>(InfoList);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                dataGridView1.Columns["OrderId"].HeaderText = "Заказ";
                dataGridView1.Columns["Date"].HeaderText = "Дата";
                dataGridView1.Columns["TotalPrice"].HeaderText = "Общая стоимость";
                dataGridView1.Columns["Status"].HeaderText = "Статус";
                dataGridView1.Columns["Customer"].HeaderText = "Покупатель";
                dataGridView1.Columns["Performer"].HeaderText = "Исполнитель";
                dataGridView1.Columns["Album"].HeaderText = "Альбом";
                dataGridView1.Columns["Item"].HeaderText = "Товар";
                dataGridView1.Columns["Price"].HeaderText = "Цена";
                dataGridView1.Columns["Units"].HeaderText = "Количество";
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var form1 = (Form1)Tag;
            form1.Show();
            Close();
        }

        private void comboBoxPerformer_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxOrder.Text = "";
            comboBoxStatus.Text = "";
            textBoxTotalPrice1.Text = "";
            textBoxTotalPrice2.Text = "";
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from orders in dbContext.Orders
                        join customers in dbContext.Customers on orders.CustomerId equals customers.Id
                        join item_order in dbContext.ItemOrders on orders.Id equals item_order.OrderId
                        join items in dbContext.Items on item_order.ItemId equals items.Id
                        join albums in dbContext.Albums on items.AlbumId equals albums.Id
                        join performers in dbContext.Performers on albums.PerformerId equals performers.Id
                        where comboBoxPerformer.Text == performers.Name
                        orderby orders.Id
                        select new GlobalInfo()
                        {
                            OrderID = orders.Id,
                            Date = orders.Date,
                            TotalPrice = orders.TotalPrice,
                            Status = orders.Status,
                            Customer = customers.Name,
                            Performer = performers.Name,
                            Album = albums.Name,
                            Item = items.Name,
                            Price = items.Price,
                            Units = item_order.Units
                        };
                var InfoList = q.ToList();
                var bindingList = new BindingList<GlobalInfo>(InfoList);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                dataGridView1.Columns["OrderId"].HeaderText = "Заказ";
                dataGridView1.Columns["Date"].HeaderText = "Дата";
                dataGridView1.Columns["TotalPrice"].HeaderText = "Общая стоимость";
                dataGridView1.Columns["Status"].HeaderText = "Статус";
                dataGridView1.Columns["Customer"].HeaderText = "Покупатель";
                dataGridView1.Columns["Performer"].HeaderText = "Исполнитель";
                dataGridView1.Columns["Album"].HeaderText = "Альбом";
                dataGridView1.Columns["Item"].HeaderText = "Товар";
                dataGridView1.Columns["Price"].HeaderText = "Цена";
                dataGridView1.Columns["Units"].HeaderText = "Количество";
            }
        }

        private void comboBoxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPerformer.SelectedIndex = -1;
            comboBoxStatus.SelectedIndex = -1;
            textBoxTotalPrice1.Text = "";
            textBoxTotalPrice2.Text = "";
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from orders in dbContext.Orders
                        join customers in dbContext.Customers on orders.CustomerId equals customers.Id
                        join item_order in dbContext.ItemOrders on orders.Id equals item_order.OrderId
                        join items in dbContext.Items on item_order.ItemId equals items.Id
                        join albums in dbContext.Albums on items.AlbumId equals albums.Id
                        join performers in dbContext.Performers on albums.PerformerId equals performers.Id
                        where comboBoxOrder.Text == orders.Id.ToString()
                        orderby orders.Id
                        select new GlobalInfo()
                        {
                            OrderID = orders.Id,
                            Date = orders.Date,
                            TotalPrice = orders.TotalPrice,
                            Status = orders.Status,
                            Customer = customers.Name,
                            Performer = performers.Name,
                            Album = albums.Name,
                            Item = items.Name,
                            Price = items.Price,
                            Units = item_order.Units
                        };
                var InfoList = q.ToList();
                var bindingList = new BindingList<GlobalInfo>(InfoList);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                dataGridView1.Columns["OrderId"].HeaderText = "Заказ";
                dataGridView1.Columns["Date"].HeaderText = "Дата";
                dataGridView1.Columns["TotalPrice"].HeaderText = "Общая стоимость";
                dataGridView1.Columns["Status"].HeaderText = "Статус";
                dataGridView1.Columns["Customer"].HeaderText = "Покупатель";
                dataGridView1.Columns["Performer"].HeaderText = "Исполнитель";
                dataGridView1.Columns["Album"].HeaderText = "Альбом";
                dataGridView1.Columns["Item"].HeaderText = "Товар";
                dataGridView1.Columns["Price"].HeaderText = "Цена";
                dataGridView1.Columns["Units"].HeaderText = "Количество";
            }
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPerformer.SelectedIndex = -1;
            comboBoxOrder.SelectedIndex = -1;
            textBoxTotalPrice1.Text = "";
            textBoxTotalPrice2.Text = "";
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from orders in dbContext.Orders
                        join customers in dbContext.Customers on orders.CustomerId equals customers.Id
                        join item_order in dbContext.ItemOrders on orders.Id equals item_order.OrderId
                        join items in dbContext.Items on item_order.ItemId equals items.Id
                        join albums in dbContext.Albums on items.AlbumId equals albums.Id
                        join performers in dbContext.Performers on albums.PerformerId equals performers.Id
                        where comboBoxStatus.Text == orders.Status
                        orderby orders.Id
                        select new GlobalInfo()
                        {
                            OrderID = orders.Id,
                            Date = orders.Date,
                            TotalPrice = orders.TotalPrice,
                            Status = orders.Status,
                            Customer = customers.Name,
                            Performer = performers.Name,
                            Album = albums.Name,
                            Item = items.Name,
                            Price = items.Price,
                            Units = item_order.Units
                        };
                var InfoList = q.ToList();
                var bindingList = new BindingList<GlobalInfo>(InfoList);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                dataGridView1.Columns["OrderId"].HeaderText = "Заказ";
                dataGridView1.Columns["Date"].HeaderText = "Дата";
                dataGridView1.Columns["TotalPrice"].HeaderText = "Общая стоимость";
                dataGridView1.Columns["Status"].HeaderText = "Статус";
                dataGridView1.Columns["Customer"].HeaderText = "Покупатель";
                dataGridView1.Columns["Performer"].HeaderText = "Исполнитель";
                dataGridView1.Columns["Album"].HeaderText = "Альбом";
                dataGridView1.Columns["Item"].HeaderText = "Товар";
                dataGridView1.Columns["Price"].HeaderText = "Цена";
                dataGridView1.Columns["Units"].HeaderText = "Количество";
            }
        }

        private void textBoxTotalPrice1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int TotalPrice1 = 0;
            int TotalPrice2 = -1;
            if (!(int.TryParse(textBoxTotalPrice1.Text, out TotalPrice1)) || !(int.TryParse(textBoxTotalPrice2.Text, out TotalPrice2)))
            {
                MessageBox.Show("Введите корректную стоимость!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (TotalPrice1 > TotalPrice2)
            {
                MessageBox.Show("Введите корректную стоимость!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
                {
                    var q = from orders in dbContext.Orders
                            join customers in dbContext.Customers on orders.CustomerId equals customers.Id
                            join item_order in dbContext.ItemOrders on orders.Id equals item_order.OrderId
                            join items in dbContext.Items on item_order.ItemId equals items.Id
                            join albums in dbContext.Albums on items.AlbumId equals albums.Id
                            join performers in dbContext.Performers on albums.PerformerId equals performers.Id
                            where orders.TotalPrice >= TotalPrice1 && orders.TotalPrice <= TotalPrice2
                            orderby orders.Id
                            select new GlobalInfo()
                            {
                                OrderID = orders.Id,
                                Date = orders.Date,
                                TotalPrice = orders.TotalPrice,
                                Status = orders.Status,
                                Customer = customers.Name,
                                Performer = performers.Name,
                                Album = albums.Name,
                                Item = items.Name,
                                Price = items.Price,
                                Units = item_order.Units
                            };
                    var InfoList = q.ToList();
                    var bindingList = new BindingList<GlobalInfo>(InfoList);
                    var source = new BindingSource(bindingList, null);
                    dataGridView1.DataSource = source;
                    dataGridView1.Columns["OrderId"].HeaderText = "Заказ";
                    dataGridView1.Columns["Date"].HeaderText = "Дата";
                    dataGridView1.Columns["TotalPrice"].HeaderText = "Общая стоимость";
                    dataGridView1.Columns["Status"].HeaderText = "Статус";
                    dataGridView1.Columns["Customer"].HeaderText = "Покупатель";
                    dataGridView1.Columns["Performer"].HeaderText = "Исполнитель";
                    dataGridView1.Columns["Album"].HeaderText = "Альбом";
                    dataGridView1.Columns["Item"].HeaderText = "Товар";
                    dataGridView1.Columns["Price"].HeaderText = "Цена";
                    dataGridView1.Columns["Units"].HeaderText = "Количество";
                }
            }
        }
    }
}
