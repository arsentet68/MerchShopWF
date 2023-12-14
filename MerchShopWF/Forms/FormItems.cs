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
    public partial class FormItems : Form
    {
        public FormItems()
        {
            InitializeComponent();
        }

        private void FormItems_Load(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from items in dbContext.Items
                        join albums in dbContext.Albums on items.AlbumId equals albums.Id
                        select new ExtendedItemInfo()
                        {
                            Id = items.Id,
                            Name = items.Name,
                            Price = items.Price,
                            AlbumId = items.AlbumId,
                            AlbumName = albums.Name
                        };
                var InfoList = q.ToList();
                var bindingList = new BindingList<ExtendedItemInfo>(InfoList);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                dataGridView1.Columns["AlbumId"].Visible = false;
                dataGridView1.Columns["Id"].HeaderText = "ID";
                dataGridView1.Columns["Name"].HeaderText = "Название";
                dataGridView1.Columns["Price"].HeaderText = "Цена";
                dataGridView1.Columns["AlbumName"].HeaderText = "Альбом";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormWorkWithItem formWorkWithItem = new FormWorkWithItem();
            formWorkWithItem.actionNumber = 1;
            formWorkWithItem.Text = "Добавление записи";
            formWorkWithItem.Tag = this;
            formWorkWithItem.Show();
            Hide();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int selectedId = dataGridView1.SelectedRows[0].Index + 1;
            FormWorkWithItem formWorkWithItem = new FormWorkWithItem();
            formWorkWithItem.actionNumber = 2;
            formWorkWithItem.selectedId = selectedId;
            formWorkWithItem.Text = "Изменение записи";
            formWorkWithItem.Tag = this;
            formWorkWithItem.Show();
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
                    List<int> item_order = dbContext.ItemOrders.Where(x => x.ItemId == selectedId).Select(x => x.ItemId).ToList();
                    foreach (int item_id in item_order)
                    {
                        dbContext.ItemOrders.Remove(dbContext.ItemOrders.Where(x => x.ItemId == item_id).FirstOrDefault());
                    }
                    dbContext.Items.Remove(dbContext.Items.Where(x => x.Id == selectedId).FirstOrDefault());
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

        private void FormItems_VisibleChanged(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from items in dbContext.Items
                        join albums in dbContext.Albums on items.AlbumId equals albums.Id
                        select new ExtendedItemInfo()
                        {
                            Id = items.Id,
                            Name = items.Name,
                            Price = items.Price,
                            AlbumId = items.AlbumId,
                            AlbumName = albums.Name
                        };
                var InfoList = q.ToList();
                var bindingList = new BindingList<ExtendedItemInfo>(InfoList);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                dataGridView1.Columns["AlbumId"].Visible = false;
                dataGridView1.Columns["Id"].HeaderText = "ID";
                dataGridView1.Columns["Name"].HeaderText = "Название";
                dataGridView1.Columns["Price"].HeaderText = "Цена";
                dataGridView1.Columns["AlbumName"].HeaderText = "Альбом";
            }
        }
    }
}
