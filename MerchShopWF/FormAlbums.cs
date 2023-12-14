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
    public partial class FormAlbums : Form
    {
        public FormAlbums()
        {
            InitializeComponent();
        }

        private void FormAlbums_Load(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from albums in dbContext.Albums
                        join performers in dbContext.Performers on albums.PerformerId equals performers.Id
                        select new ExtendedAlbumInfo()
                        {
                            Id = albums.Id,
                            Name = albums.Name,
                            Year = albums.Year,
                            PerformerId = albums.PerformerId,
                            PerformerName = performers.Name
                        };
                var InfoList = q.ToList();
                var bindingList = new BindingList<ExtendedAlbumInfo>(InfoList);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                dataGridView1.Columns["PerformerId"].Visible = false;
                dataGridView1.Columns["Id"].HeaderText = "ID";
                dataGridView1.Columns["Name"].HeaderText = "Название";
                dataGridView1.Columns["Year"].HeaderText = "Год";
                dataGridView1.Columns["PerformerName"].HeaderText = "Исполнитель";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormWorkWithAlbum formWorkWithAlbum = new FormWorkWithAlbum();
            formWorkWithAlbum.actionNumber = 1;
            formWorkWithAlbum.Text = "Добавление записи";
            formWorkWithAlbum.Tag = this;
            formWorkWithAlbum.Show();
            Hide();
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int selectedId = dataGridView1.SelectedRows[0].Index + 1;
            FormWorkWithAlbum formWorkWithAlbum = new FormWorkWithAlbum();
            formWorkWithAlbum.actionNumber = 2;
            formWorkWithAlbum.selectedId = selectedId;
            formWorkWithAlbum.Text = "Изменение записи";
            formWorkWithAlbum.Tag = this;
            formWorkWithAlbum.Show();
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
                    List<int> items = dbContext.Items.Where(x => x.AlbumId == selectedId).Select(x => x.Id).ToList();
                    foreach (int item in items)
                    {
                        List<int> item_order = dbContext.ItemOrders.Where(x => x.ItemId == item).Select(x => x.ItemId).ToList();
                        foreach (int item_id in item_order)
                        {
                            dbContext.ItemOrders.Remove(dbContext.ItemOrders.Where(x => x.ItemId == item_id).FirstOrDefault());
                        }
                        dbContext.Items.Remove(dbContext.Items.Where(x => x.Id == item).FirstOrDefault());
                    }
                    dbContext.Albums.Remove(dbContext.Albums.Where(x => x.Id == selectedId).FirstOrDefault());
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

        private void FormAlbums_VisibleChanged(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from albums in dbContext.Albums
                        join performers in dbContext.Performers on albums.PerformerId equals performers.Id
                        select new ExtendedAlbumInfo()
                        {
                            Id = albums.Id,
                            Name = albums.Name,
                            Year = albums.Year,
                            PerformerId = albums.PerformerId,
                            PerformerName = performers.Name
                        };
                var InfoList = q.ToList();
                var bindingList = new BindingList<ExtendedAlbumInfo>(InfoList);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                dataGridView1.Columns["PerformerId"].Visible = false;
                dataGridView1.Columns["Id"].HeaderText = "ID";
                dataGridView1.Columns["Name"].HeaderText = "Название";
                dataGridView1.Columns["Year"].HeaderText = "Год";
                dataGridView1.Columns["PerformerName"].HeaderText = "Исполнитель";
            }
        }
    }
}
