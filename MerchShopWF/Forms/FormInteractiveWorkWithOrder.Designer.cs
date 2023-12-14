namespace MerchShopWF
{
    partial class FormInteractiveWorkWithOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelDate = new Label();
            dateTimePicker = new DateTimePicker();
            labelTotalCost = new Label();
            textBoxTotalPrice = new TextBox();
            buttonCalculate = new Button();
            labelDeliveryAddress = new Label();
            textBoxDeliveryAddress = new TextBox();
            labelStatus = new Label();
            comboBoxStatus = new ComboBox();
            labelCustomer = new Label();
            comboBoxCustomer = new ComboBox();
            labelItem = new Label();
            comboBoxItem = new ComboBox();
            dataGridView1 = new DataGridView();
            labelOrderId = new Label();
            textBoxOrderId = new TextBox();
            buttonAddItemToOrder = new Button();
            buttonAddUnit = new Button();
            buttonRemoveUnit = new Button();
            buttonRemoveItem = new Button();
            buttonCreateOrder = new Button();
            buttonUpdateOrder = new Button();
            buttonBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(24, 35);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(41, 20);
            labelDate.TabIndex = 0;
            labelDate.Text = "Дата";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(132, 30);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(382, 27);
            dateTimePicker.TabIndex = 1;
            // 
            // labelTotalCost
            // 
            labelTotalCost.AutoSize = true;
            labelTotalCost.Location = new Point(24, 76);
            labelTotalCost.Name = "labelTotalCost";
            labelTotalCost.Size = new Size(133, 20);
            labelTotalCost.TabIndex = 2;
            labelTotalCost.Text = "Общая стоимость";
            // 
            // textBoxTotalPrice
            // 
            textBoxTotalPrice.Location = new Point(163, 72);
            textBoxTotalPrice.Name = "textBoxTotalPrice";
            textBoxTotalPrice.Size = new Size(387, 27);
            textBoxTotalPrice.TabIndex = 3;
            textBoxTotalPrice.TextChanged += textBoxTotalPrice_TextChanged;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Enabled = false;
            buttonCalculate.Location = new Point(612, 76);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(94, 29);
            buttonCalculate.TabIndex = 4;
            buttonCalculate.Text = "Вычислить";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelDeliveryAddress
            // 
            labelDeliveryAddress.AutoSize = true;
            labelDeliveryAddress.Location = new Point(24, 116);
            labelDeliveryAddress.Name = "labelDeliveryAddress";
            labelDeliveryAddress.Size = new Size(117, 20);
            labelDeliveryAddress.TabIndex = 5;
            labelDeliveryAddress.Text = "Адрес доставки";
            // 
            // textBoxDeliveryAddress
            // 
            textBoxDeliveryAddress.Location = new Point(163, 113);
            textBoxDeliveryAddress.Name = "textBoxDeliveryAddress";
            textBoxDeliveryAddress.Size = new Size(387, 27);
            textBoxDeliveryAddress.TabIndex = 6;
            textBoxDeliveryAddress.TextChanged += textBoxDeliveryAddress_TextChanged;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(24, 162);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(52, 20);
            labelStatus.TabIndex = 7;
            labelStatus.Text = "Статус";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "В обработке", "Отправлен", "Доставлен" });
            comboBoxStatus.Location = new Point(163, 154);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(387, 28);
            comboBoxStatus.TabIndex = 8;
            comboBoxStatus.TextChanged += comboBoxStatus_TextChanged;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Location = new Point(24, 210);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(90, 20);
            labelCustomer.TabIndex = 9;
            labelCustomer.Text = "Покупатель";
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(163, 206);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(387, 28);
            comboBoxCustomer.TabIndex = 10;
            comboBoxCustomer.TextChanged += comboBoxCustomer_TextChanged;
            // 
            // labelItem
            // 
            labelItem.AutoSize = true;
            labelItem.Location = new Point(24, 260);
            labelItem.Name = "labelItem";
            labelItem.Size = new Size(51, 20);
            labelItem.TabIndex = 12;
            labelItem.Text = "Товар";
            // 
            // comboBoxItem
            // 
            comboBoxItem.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxItem.FormattingEnabled = true;
            comboBoxItem.Location = new Point(163, 257);
            comboBoxItem.Name = "comboBoxItem";
            comboBoxItem.Size = new Size(387, 28);
            comboBoxItem.TabIndex = 13;
            comboBoxItem.SelectedIndexChanged += comboBoxItem_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 305);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(429, 188);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.RowsAdded += dataGridView1_RowsAdded;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // labelOrderId
            // 
            labelOrderId.AutoSize = true;
            labelOrderId.Location = new Point(520, 30);
            labelOrderId.Name = "labelOrderId";
            labelOrderId.Size = new Size(74, 20);
            labelOrderId.TabIndex = 15;
            labelOrderId.Text = "ID Заказа";
            labelOrderId.Visible = false;
            // 
            // textBoxOrderId
            // 
            textBoxOrderId.Enabled = false;
            textBoxOrderId.Location = new Point(612, 30);
            textBoxOrderId.Name = "textBoxOrderId";
            textBoxOrderId.ReadOnly = true;
            textBoxOrderId.Size = new Size(125, 27);
            textBoxOrderId.TabIndex = 16;
            textBoxOrderId.Visible = false;
            // 
            // buttonAddItemToOrder
            // 
            buttonAddItemToOrder.Enabled = false;
            buttonAddItemToOrder.Location = new Point(612, 256);
            buttonAddItemToOrder.Name = "buttonAddItemToOrder";
            buttonAddItemToOrder.Size = new Size(184, 29);
            buttonAddItemToOrder.TabIndex = 18;
            buttonAddItemToOrder.Text = "Добавить к заказу";
            buttonAddItemToOrder.UseVisualStyleBackColor = true;
            buttonAddItemToOrder.Click += buttonAddItemToOrder_Click;
            // 
            // buttonAddUnit
            // 
            buttonAddUnit.Enabled = false;
            buttonAddUnit.Location = new Point(545, 329);
            buttonAddUnit.Name = "buttonAddUnit";
            buttonAddUnit.Size = new Size(217, 42);
            buttonAddUnit.TabIndex = 19;
            buttonAddUnit.Text = "Увеличить количество";
            buttonAddUnit.UseVisualStyleBackColor = true;
            buttonAddUnit.Click += buttonAddUnit_Click;
            // 
            // buttonRemoveUnit
            // 
            buttonRemoveUnit.Enabled = false;
            buttonRemoveUnit.Location = new Point(545, 387);
            buttonRemoveUnit.Name = "buttonRemoveUnit";
            buttonRemoveUnit.Size = new Size(217, 37);
            buttonRemoveUnit.TabIndex = 20;
            buttonRemoveUnit.Text = "Уменьшить количество";
            buttonRemoveUnit.UseVisualStyleBackColor = true;
            buttonRemoveUnit.Click += buttonRemoveUnit_Click;
            // 
            // buttonRemoveItem
            // 
            buttonRemoveItem.Enabled = false;
            buttonRemoveItem.Location = new Point(545, 441);
            buttonRemoveItem.Name = "buttonRemoveItem";
            buttonRemoveItem.Size = new Size(217, 35);
            buttonRemoveItem.TabIndex = 21;
            buttonRemoveItem.Text = "Удалить";
            buttonRemoveItem.UseVisualStyleBackColor = true;
            buttonRemoveItem.Click += buttonRemoveItem_Click;
            // 
            // buttonCreateOrder
            // 
            buttonCreateOrder.Enabled = false;
            buttonCreateOrder.Location = new Point(24, 512);
            buttonCreateOrder.Name = "buttonCreateOrder";
            buttonCreateOrder.Size = new Size(176, 48);
            buttonCreateOrder.TabIndex = 22;
            buttonCreateOrder.Text = "Создать заказ";
            buttonCreateOrder.UseVisualStyleBackColor = true;
            buttonCreateOrder.Visible = false;
            buttonCreateOrder.Click += buttonCreateOrder_Click;
            // 
            // buttonUpdateOrder
            // 
            buttonUpdateOrder.Enabled = false;
            buttonUpdateOrder.Location = new Point(25, 512);
            buttonUpdateOrder.Name = "buttonUpdateOrder";
            buttonUpdateOrder.Size = new Size(175, 48);
            buttonUpdateOrder.TabIndex = 23;
            buttonUpdateOrder.Text = "Изменить заказ";
            buttonUpdateOrder.UseVisualStyleBackColor = true;
            buttonUpdateOrder.Visible = false;
            buttonUpdateOrder.Click += buttonUpdateOrder_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(571, 512);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(182, 48);
            buttonBack.TabIndex = 24;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // FormInteractiveWorkWithOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 602);
            Controls.Add(buttonBack);
            Controls.Add(buttonUpdateOrder);
            Controls.Add(buttonCreateOrder);
            Controls.Add(buttonRemoveItem);
            Controls.Add(buttonRemoveUnit);
            Controls.Add(buttonAddUnit);
            Controls.Add(buttonAddItemToOrder);
            Controls.Add(textBoxOrderId);
            Controls.Add(labelOrderId);
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxItem);
            Controls.Add(labelItem);
            Controls.Add(comboBoxCustomer);
            Controls.Add(labelCustomer);
            Controls.Add(comboBoxStatus);
            Controls.Add(labelStatus);
            Controls.Add(textBoxDeliveryAddress);
            Controls.Add(labelDeliveryAddress);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxTotalPrice);
            Controls.Add(labelTotalCost);
            Controls.Add(dateTimePicker);
            Controls.Add(labelDate);
            Name = "FormInteractiveWorkWithOrder";
            Text = "FormInteractiveWorkWithOrder";
            Load += FormInteractiveWorkWithOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDate;
        private DateTimePicker dateTimePicker;
        private Label labelTotalCost;
        private TextBox textBoxTotalPrice;
        private Button buttonCalculate;
        private Label labelDeliveryAddress;
        private TextBox textBoxDeliveryAddress;
        private Label labelStatus;
        private ComboBox comboBoxStatus;
        private Label labelCustomer;
        private ComboBox comboBoxCustomer;
        private Label labelItem;
        private ComboBox comboBoxItem;
        private DataGridView dataGridView1;
        private Label labelOrderId;
        private TextBox textBoxOrderId;
        private Button buttonAddItemToOrder;
        private Button buttonAddUnit;
        private Button buttonRemoveUnit;
        private Button buttonRemoveItem;
        private Button buttonCreateOrder;
        private Button buttonUpdateOrder;
        private Button buttonBack;
    }
}