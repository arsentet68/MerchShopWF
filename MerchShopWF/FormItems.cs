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
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormWorkWithItem formWorkWithItem = new FormWorkWithItem();
            formWorkWithItem.actionNumber = 1;
            formWorkWithItem.Text = "Добавление записи";
            formWorkWithItem.Show();
            Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int selectedId = dataGridView1.SelectedRows[0].Index + 1;
            FormWorkWithItem formWorkWithItem = new FormWorkWithItem();
            formWorkWithItem.actionNumber = 2;
            formWorkWithItem.selectedId = selectedId;
            formWorkWithItem.Text = "Изменение записи";
            formWorkWithItem.Show();
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
                    Item deletingItem = new Item();
                    deletingItem.Id = selectedId;
                    dbContext.Items.Remove(deletingItem);
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
