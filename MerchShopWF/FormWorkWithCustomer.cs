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
    public partial class FormWorkWithCustomer : Form
    {
        public int actionNumber;
        public int selectedId;
        public FormWorkWithCustomer()
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
                int newId = AdditionalLogic.CreateNewId(4);
                string newName = textBoxName.Text.Trim();
                if (!AdditionalLogic.ValidEmail(textBoxEmail.Text))
                {
                    MessageBox.Show("Введите корректный e-mail!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string newEmail = textBoxEmail.Text.Trim();
                    Customer newCustomer = new Customer(newId, newName, newEmail);
                    DialogResult result = MessageBox.Show("Вы действительно хотите добавить эту запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dbContext.Customers.Add(newCustomer);
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
                if (!AdditionalLogic.ValidEmail(textBoxEmail.Text))
                {
                    MessageBox.Show("Введите корректный e-mail!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string updatedEmail = textBoxEmail.Text.Trim();
                    Customer updatedCustomer = new Customer(selectedId, updatedName, updatedEmail);
                    DialogResult result = MessageBox.Show("Вы действительно хотите изменить эту запись?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dbContext.Customers.Update(updatedCustomer);
                        dbContext.SaveChanges();
                        MessageBox.Show("Запись изменена.", "Изменение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormCustomers formCustomers = new FormCustomers();
            formCustomers.Show();
            Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxName.Text.Trim() != "") && (textBoxEmail.Text.Trim() != ""))
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

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if ((textBoxName.Text.Trim() != "") && (textBoxEmail.Text.Trim() != ""))
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

        private void FormWorkWithCustomer_Load(object sender, EventArgs e)
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
                    var q = from customers in dbContext.Customers
                            where customers.Id == this.selectedId
                            select new Customer()
                            {
                                Name = customers.Name,
                                Email = customers.Email,
                            };
                    var selectedList = q.ToList();
                    textBoxName.Text = selectedList[0].Name;
                    textBoxEmail.Text = selectedList[0].Email;
                }
            }
        }
    }
}
