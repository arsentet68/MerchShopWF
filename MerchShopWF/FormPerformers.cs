using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FormPerformers : Form
    {
        public FormPerformers()
        {
            InitializeComponent();
        }

        private void FormPerformers_Load(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from performers in dbContext.Performers
                        select new Performer()
                        {
                            Id = performers.Id,
                            Name = performers.Name,
                            Country = performers.Country,
                            DebutYear = performers.DebutYear,
                            Albums = performers.Albums
                        };
                var InfoList = q.ToList();
                var bindingList = new BindingList<Performer>(InfoList);
                var source = new BindingSource(bindingList, null);
                dataGridView1.DataSource = source;
                dataGridView1.Columns["Albums"].Visible = false;
                dataGridView1.Columns[0].HeaderText = "ID";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormWorkWithPerformer formWorkWithPerformer = new FormWorkWithPerformer();
            formWorkWithPerformer.actionNumber = 1;
            formWorkWithPerformer.Text = "Добавление записи";
            formWorkWithPerformer.Show();
            Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int selectedId = dataGridView1.SelectedRows[0].Index + 1;
            FormWorkWithPerformer formWorkWithPerformer = new FormWorkWithPerformer();
            formWorkWithPerformer.actionNumber = 2;
            formWorkWithPerformer.selectedId = selectedId;
            formWorkWithPerformer.Text = "Изменение записи";
            formWorkWithPerformer.Show();
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
                    List<int> albums = dbContext.Albums.Where(x => x.PerformerId == selectedId).Select(x => x.Id).ToList();
                    foreach (int album in albums)
                    {
                        List<int> items = dbContext.Items.Where(x => x.AlbumId == album).Select(x => x.Id).ToList();
                        foreach (int item in items)
                        {
                            List<int> item_order = dbContext.ItemOrders.Where(x => x.ItemId == item).Select(x => x.ItemId).ToList();
                            foreach (int item_id in item_order)
                            {
                                dbContext.ItemOrders.Remove(dbContext.ItemOrders.Where(x => x.ItemId == item_id).FirstOrDefault());
                            }
                            dbContext.Items.Remove(dbContext.Items.Where(x => x.Id == item).FirstOrDefault());
                        }
                        dbContext.Albums.Remove(dbContext.Albums.Where(x => x.Id == album).FirstOrDefault());
                    }
                    dbContext.Performers.Remove(dbContext.Performers.Where(x => x.Id == selectedId).FirstOrDefault());
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
