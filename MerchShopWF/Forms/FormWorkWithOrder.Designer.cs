namespace MerchShopWF
{
    partial class FormWorkWithOrder
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
            labelTotalPrice = new Label();
            labelDeliveryAddress = new Label();
            labelStatus = new Label();
            labelCustomer = new Label();
            dateTimePicker = new DateTimePicker();
            textBoxTotalPrice = new TextBox();
            textBoxDeliveryAddress = new TextBox();
            comboBoxStatus = new ComboBox();
            comboBoxCustomer = new ComboBox();
            buttonAddEntry = new Button();
            buttonUpdateEntry = new Button();
            buttonBack = new Button();
            buttonAddCustomer = new Button();
            SuspendLayout();
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.Location = new Point(48, 28);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(68, 35);
            labelDate.TabIndex = 0;
            labelDate.Text = "Дата";
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalPrice.Location = new Point(48, 64);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(222, 35);
            labelTotalPrice.TabIndex = 1;
            labelTotalPrice.Text = "Общая стоимость";
            // 
            // labelDeliveryAddress
            // 
            labelDeliveryAddress.AutoSize = true;
            labelDeliveryAddress.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelDeliveryAddress.Location = new Point(48, 98);
            labelDeliveryAddress.Name = "labelDeliveryAddress";
            labelDeliveryAddress.Size = new Size(196, 35);
            labelDeliveryAddress.TabIndex = 2;
            labelDeliveryAddress.Text = "Адрес доставки";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelStatus.Location = new Point(48, 138);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(87, 35);
            labelStatus.TabIndex = 3;
            labelStatus.Text = "Статус";
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelCustomer.Location = new Point(48, 173);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(148, 35);
            labelCustomer.TabIndex = 4;
            labelCustomer.Text = "Покупатель";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Short;
            dateTimePicker.Location = new Point(344, 28);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.TabIndex = 5;
            // 
            // textBoxTotalPrice
            // 
            textBoxTotalPrice.Location = new Point(344, 72);
            textBoxTotalPrice.Name = "textBoxTotalPrice";
            textBoxTotalPrice.Size = new Size(250, 27);
            textBoxTotalPrice.TabIndex = 6;
            textBoxTotalPrice.TextChanged += textBoxTotalPrice_TextChanged;
            // 
            // textBoxDeliveryAddress
            // 
            textBoxDeliveryAddress.Location = new Point(344, 106);
            textBoxDeliveryAddress.Name = "textBoxDeliveryAddress";
            textBoxDeliveryAddress.Size = new Size(250, 27);
            textBoxDeliveryAddress.TabIndex = 7;
            textBoxDeliveryAddress.TextChanged += textBoxDeliveryAddress_TextChanged;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "В обработке", "Отправлен", "Доставлен" });
            comboBoxStatus.Location = new Point(344, 138);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(250, 28);
            comboBoxStatus.TabIndex = 8;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_TextChanged;
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(344, 180);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(250, 28);
            comboBoxCustomer.TabIndex = 9;
            comboBoxCustomer.SelectedIndexChanged += comboBoxCustomer_TextChanged;
            // 
            // buttonAddEntry
            // 
            buttonAddEntry.Enabled = false;
            buttonAddEntry.Location = new Point(48, 230);
            buttonAddEntry.Name = "buttonAddEntry";
            buttonAddEntry.Size = new Size(200, 67);
            buttonAddEntry.TabIndex = 10;
            buttonAddEntry.Text = "Добавить запись";
            buttonAddEntry.UseVisualStyleBackColor = true;
            buttonAddEntry.Visible = false;
            buttonAddEntry.Click += buttonAddEntry_Click;
            // 
            // buttonUpdateEntry
            // 
            buttonUpdateEntry.Enabled = false;
            buttonUpdateEntry.Location = new Point(48, 230);
            buttonUpdateEntry.Name = "buttonUpdateEntry";
            buttonUpdateEntry.Size = new Size(200, 67);
            buttonUpdateEntry.TabIndex = 11;
            buttonUpdateEntry.Text = "Изменить запись";
            buttonUpdateEntry.UseVisualStyleBackColor = true;
            buttonUpdateEntry.Visible = false;
            buttonUpdateEntry.Click += buttonUpdateEntry_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(344, 230);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(179, 67);
            buttonBack.TabIndex = 12;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.Location = new Point(627, 167);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(43, 34);
            buttonAddCustomer.TabIndex = 13;
            buttonAddCustomer.Text = "+";
            buttonAddCustomer.UseVisualStyleBackColor = true;
            buttonAddCustomer.Click += buttonAddCustomer_Click;
            // 
            // FormWorkWithOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 345);
            Controls.Add(buttonAddCustomer);
            Controls.Add(buttonBack);
            Controls.Add(buttonUpdateEntry);
            Controls.Add(buttonAddEntry);
            Controls.Add(comboBoxCustomer);
            Controls.Add(comboBoxStatus);
            Controls.Add(textBoxDeliveryAddress);
            Controls.Add(textBoxTotalPrice);
            Controls.Add(dateTimePicker);
            Controls.Add(labelCustomer);
            Controls.Add(labelStatus);
            Controls.Add(labelDeliveryAddress);
            Controls.Add(labelTotalPrice);
            Controls.Add(labelDate);
            Name = "FormWorkWithOrder";
            Text = "FormWorkWithOrder";
            Load += FormWorkWithOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDate;
        private Label labelTotalPrice;
        private Label labelDeliveryAddress;
        private Label labelStatus;
        private Label labelCustomer;
        private DateTimePicker dateTimePicker;
        private TextBox textBoxTotalPrice;
        private TextBox textBoxDeliveryAddress;
        private ComboBox comboBoxStatus;
        private ComboBox comboBoxCustomer;
        private Button buttonAddEntry;
        private Button buttonUpdateEntry;
        private Button buttonBack;
        private Button buttonAddCustomer;
    }
}