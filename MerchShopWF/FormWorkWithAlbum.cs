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
    public partial class FormWorkWithAlbum : Form
    {
        public int actionNumber;
        public int selectedId;
        public FormWorkWithAlbum()
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

        private void FormWorkWithAlbum_Load(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from performers in dbContext.Performers
                        select new Performer()
                        {
                            Name = performers.Name,
                        };
                var PerformerList = q.ToList();
                foreach (Performer performer in PerformerList)
                {
                    comboBoxPerformer.Items.Add(performer.Name);
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
                    var q = from albums in dbContext.Albums
                            where albums.Id == this.selectedId
                            select new Album()
                            {
                                Name = albums.Name,
                                Year = albums.Year,
                                PerformerId = albums.PerformerId,
                            };
                    var selectedList = q.ToList();
                    textBoxName.Text = selectedList[0].Name;
                    textBoxYear.Text = selectedList[0].Year.ToString();
                    comboBoxPerformer.SelectedIndex = selectedList[0].PerformerId - 1;
                }
            }
        }
        private void buttonAddEntry_Click(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                int newId = AdditionalLogic.CreateNewId(2);
                string newName = textBoxName.Text.Trim();
                if (!(int.TryParse(textBoxYear.Text, out int newYear)) || newYear < 0 || newYear > DateTime.Now.Year)
                {
                    MessageBox.Show("Введите корректный год!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int newPerformerId = comboBoxPerformer.SelectedIndex + 1;
                    Album newAlbum = new Album(newId, newName, newYear, newPerformerId);
                    DialogResult result = MessageBox.Show("Вы действительно хотите добавить эту запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dbContext.Albums.Add(newAlbum);
                        dbContext.SaveChanges();
                        MessageBox.Show("Запись добавлена.", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void buttonUpdateEntry_Click(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                string updatedName = textBoxName.Text.Trim();
                if (!(int.TryParse(textBoxYear.Text, out int updatedYear)) || updatedYear < 0 || updatedYear > DateTime.Now.Year)
                {
                    MessageBox.Show("Введите корректный год!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int updatedPerformerId = comboBoxPerformer.SelectedIndex + 1;
                    Album updatedAlbum = new Album(selectedId, updatedName, updatedYear, updatedPerformerId);
                    DialogResult result = MessageBox.Show("Вы действительно хотите изменить эту запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dbContext.Albums.Update(updatedAlbum);
                        dbContext.SaveChanges();
                        MessageBox.Show("Запись изменена.", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormAlbums formAlbums = new FormAlbums();
            formAlbums.Show();
            Close();
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxName.Text.Trim() != "") && (textBoxYear.Text.Trim() != "") && (comboBoxPerformer.Text != ""))
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
        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxName.Text.Trim() != "") && (textBoxYear.Text.Trim() != "") && (comboBoxPerformer.Text != ""))
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
        private void comboBoxPerformer_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxName.Text.Trim() != "") && (textBoxYear.Text.Trim() != "") && (comboBoxPerformer.Text != ""))
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

        private void buttonAddPerformer_Click(object sender, EventArgs e)
        {
            FormWorkWithPerformer formWorkWithPerformer = new FormWorkWithPerformer();
            formWorkWithPerformer.actionNumber = 1;
            formWorkWithPerformer.Text = "Добавление записи";
            formWorkWithPerformer.Show();
        }
    }
}
