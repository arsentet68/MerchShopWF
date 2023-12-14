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
    public partial class FormWorkWithItem : Form
    {
        public int actionNumber;
        public int selectedId;
        public FormWorkWithItem()
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

        private void FormWorkWithItem_Load(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                var q = from albums in dbContext.Albums
                        select new Album()
                        {
                            Name = albums.Name,
                        };
                var AlbumList = q.ToList();
                foreach (Album album in AlbumList)
                {
                    comboBoxAlbum.Items.Add(album.Name);
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
                    var q = from items in dbContext.Items
                            where items.Id == this.selectedId
                            select new Item()
                            {
                                Name = items.Name,
                                Price = items.Price,
                                AlbumId = items.AlbumId,
                            };
                    var selectedList = q.ToList();
                    textBoxName.Text = selectedList[0].Name;
                    textBoxPrice.Text = selectedList[0].Price.ToString();
                    comboBoxAlbum.SelectedIndex = selectedList[0].AlbumId - 1;
                }
            }
        }

        private void buttonAddEntry_Click(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                int newId = AdditionalLogic.CreateNewId(3);
                string newName = textBoxName.Text.Trim();
                if (!(int.TryParse(textBoxPrice.Text, out int newPrice)) || newPrice < 1)
                {
                    MessageBox.Show("Введите корректную цену!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int newAlbumId = comboBoxAlbum.SelectedIndex + 1;
                    Item newItem = new Item(newId, newName, newPrice, newAlbumId);
                    DialogResult result = MessageBox.Show("Вы действительно хотите добавить эту запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dbContext.Items.Add(newItem);
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
                if (!(int.TryParse(textBoxPrice.Text, out int updatedPrice)) || updatedPrice < 1)
                {
                    MessageBox.Show("Введите корректную цену!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int updatedAlbumId = comboBoxAlbum.SelectedIndex + 1;
                    Item updatedItem = new Item(selectedId, updatedName, updatedPrice, updatedAlbumId);
                    DialogResult result = MessageBox.Show("Вы действительно хотите изменить эту запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dbContext.Items.Update(updatedItem);
                        dbContext.SaveChanges();
                        MessageBox.Show("Запись изменена.", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void buttonAddAlbum_Click(object sender, EventArgs e)
        {
            FormWorkWithAlbum formWorkWithAlbum = new FormWorkWithAlbum();
            formWorkWithAlbum.actionNumber = 1;
            formWorkWithAlbum.Text = "Добавление записи";
            formWorkWithAlbum.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var formItems = (FormItems)Tag;
            formItems.Show();
            Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxName.Text.Trim() != "") && (textBoxPrice.Text.Trim() != "") && (comboBoxAlbum.Text != ""))
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

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxName.Text.Trim() != "") && (textBoxPrice.Text.Trim() != "") && (comboBoxAlbum.Text != ""))
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

        private void comboBoxAlbum_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxName.Text.Trim() != "") && (textBoxPrice.Text.Trim() != "") && (comboBoxAlbum.Text != ""))
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
