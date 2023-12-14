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
            formInformation formInformation = new formInformation();
            formInformation.Tag = this;
            formInformation.Show();
            Hide();
        }

        private void buttonChooseTable_Click(object sender, EventArgs e)
        {
            FormTables formTables = new FormTables();
            formTables.Tag = this;
            formTables.Show();
            Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}