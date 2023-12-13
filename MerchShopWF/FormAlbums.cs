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
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormWorkWithAlbum formWorkWithAlbum = new FormWorkWithAlbum();
            formWorkWithAlbum.actionNumber = 1;
            formWorkWithAlbum.Text = "Добавление записи";
            formWorkWithAlbum.Show();
            Close();
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int selectedId = dataGridView1.SelectedRows[0].Index + 1;
            FormWorkWithAlbum formWorkWithAlbum = new FormWorkWithAlbum();
            formWorkWithAlbum.actionNumber = 2;
            formWorkWithAlbum.selectedId = selectedId;
            formWorkWithAlbum.Text = "Изменение записи";
            formWorkWithAlbum.Show();
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
                    Album deletingAlbum = new Album();
                    deletingAlbum.Id = selectedId;
                    dbContext.Albums.Remove(deletingAlbum);
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
