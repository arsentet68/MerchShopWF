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
    public partial class FormWorkWithPerformer : Form
    {
        public int actionNumber;
        public int selectedId;
        public FormWorkWithPerformer()
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
        private void buttonAddEntry_Click(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                int newId = AdditionalLogic.CreateNewId(1);
                string newName = textBoxName.Text.Trim();
                if (!AdditionalLogic.CyrillicOnly(textBoxCountry.Text))
                {
                    MessageBox.Show("Введите название страны по-русски!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string newCountry = textBoxCountry.Text.Trim();
                    newCountry = Char.ToUpper(newCountry[0]) + newCountry.Substring(1);
                    if (!(int.TryParse(textBoxDebutYear.Text, out int newDebutYear)) || newDebutYear < 0 || newDebutYear > DateTime.Now.Year)
                    {
                        MessageBox.Show("Введите корректный год начала карьеры!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Performer newPerformer = new Performer(newId, newName, newCountry, newDebutYear);
                        DialogResult result = MessageBox.Show("Вы действительно хотите добавить эту запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            dbContext.Performers.Add(newPerformer);
                            dbContext.SaveChanges();
                            MessageBox.Show("Запись добавлена.", "Добавление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            var formPerformers = (FormPerformers)Tag;
            formPerformers.Show();
            Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxName.Text.Trim() != "") && (textBoxCountry.Text.Trim() != "") && (textBoxDebutYear.Text.Trim() != ""))
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
        private void textBoxCountry_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxName.Text.Trim() != "") && (textBoxCountry.Text.Trim() != "") && (textBoxDebutYear.Text.Trim() != ""))
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
        private void textBoxDebutYear_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxName.Text.Trim() != "") && (textBoxCountry.Text.Trim() != "") && (textBoxDebutYear.Text.Trim() != ""))
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

        private void buttonUpdateEntry_Click(object sender, EventArgs e)
        {
            using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
            {
                string updatedName = textBoxName.Text.Trim();
                if (!AdditionalLogic.CyrillicOnly(textBoxCountry.Text))
                {
                    MessageBox.Show("Введите название страны по-русски!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string updatedCountry = textBoxCountry.Text.Trim();
                    updatedCountry = Char.ToUpper(updatedCountry[0]) + updatedCountry.Substring(1);
                    if (!(int.TryParse(textBoxDebutYear.Text, out int updatedDebutYear)) || updatedDebutYear < 0 || updatedDebutYear > DateTime.Now.Year)
                    {
                        MessageBox.Show("Введите корректный год начала карьеры!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Performer updatedPerformer = new Performer(selectedId, updatedName, updatedCountry, updatedDebutYear);
                        DialogResult result = MessageBox.Show("Вы действительно хотите изменить эту запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            dbContext.Performers.Update(updatedPerformer);
                            dbContext.SaveChanges();
                            MessageBox.Show("Запись изменена.", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void FormWorkWithPerformer_Load(object sender, EventArgs e)
        {
            if (this.actionNumber == 1)
            {
                buttonAddEntry.Visible = true;
            }
            else
            {
                buttonUpdateEntry.Visible = true;
                using (MerchShopDatabaseContext dbContext = new MerchShopDatabaseContext())
                {
                    var q = from performers in dbContext.Performers
                            where performers.Id == this.selectedId
                            select new Performer()
                            {
                                Name = performers.Name,
                                Country = performers.Country,
                                DebutYear = performers.DebutYear,
                            };
                    var selectedList = q.ToList();
                    textBoxName.Text = selectedList[0].Name;
                    textBoxCountry.Text = selectedList[0].Country;
                    textBoxDebutYear.Text = selectedList[0].DebutYear.ToString();
                }
            }
        }
    }
}
