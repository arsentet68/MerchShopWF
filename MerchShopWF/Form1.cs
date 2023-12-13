namespace MerchShopWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {
            formInformation newForm = new formInformation();
            newForm.Show();
            Hide();
        }

        private void buttonChooseTable_Click(object sender, EventArgs e)
        {
            FormTables newForm = new FormTables();
            newForm.Show();
            Hide();
        }
    }
}