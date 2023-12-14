namespace MerchShopWF
{
    partial class FormWorkWithItem_Order
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
            labelItem = new Label();
            labelOrder = new Label();
            labelUnits = new Label();
            comboBoxItem = new ComboBox();
            comboBoxOrder = new ComboBox();
            buttonAddEntry = new Button();
            buttonUpdateEntry = new Button();
            buttonBack = new Button();
            buttonAddItem = new Button();
            buttonAddOrder = new Button();
            textBoxUnits = new TextBox();
            SuspendLayout();
            // 
            // labelItem
            // 
            labelItem.AutoSize = true;
            labelItem.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelItem.Location = new Point(48, 44);
            labelItem.Name = "labelItem";
            labelItem.Size = new Size(84, 35);
            labelItem.TabIndex = 0;
            labelItem.Text = "Товар";
            // 
            // labelOrder
            // 
            labelOrder.AutoSize = true;
            labelOrder.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelOrder.Location = new Point(51, 96);
            labelOrder.Name = "labelOrder";
            labelOrder.Size = new Size(78, 35);
            labelOrder.TabIndex = 1;
            labelOrder.Text = "Заказ";
            // 
            // labelUnits
            // 
            labelUnits.AutoSize = true;
            labelUnits.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelUnits.Location = new Point(51, 146);
            labelUnits.Name = "labelUnits";
            labelUnits.Size = new Size(150, 35);
            labelUnits.TabIndex = 2;
            labelUnits.Text = "Количество";
            // 
            // comboBoxItem
            // 
            comboBoxItem.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxItem.FormattingEnabled = true;
            comboBoxItem.Location = new Point(370, 44);
            comboBoxItem.Name = "comboBoxItem";
            comboBoxItem.Size = new Size(195, 28);
            comboBoxItem.TabIndex = 3;
            comboBoxItem.TextChanged += ComboBoxItem_TextChanged;
            // 
            // comboBoxOrder
            // 
            comboBoxOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrder.FormattingEnabled = true;
            comboBoxOrder.Location = new Point(370, 96);
            comboBoxOrder.Name = "comboBoxOrder";
            comboBoxOrder.Size = new Size(195, 28);
            comboBoxOrder.TabIndex = 4;
            comboBoxOrder.TextChanged += ComboBoxOrder_TextChanged;
            // 
            // buttonAddEntry
            // 
            buttonAddEntry.Enabled = false;
            buttonAddEntry.Location = new Point(60, 218);
            buttonAddEntry.Name = "buttonAddEntry";
            buttonAddEntry.Size = new Size(183, 64);
            buttonAddEntry.TabIndex = 5;
            buttonAddEntry.Text = "Добавить запись";
            buttonAddEntry.UseVisualStyleBackColor = true;
            buttonAddEntry.Visible = false;
            buttonAddEntry.Click += buttonAddEntry_Click;
            // 
            // buttonUpdateEntry
            // 
            buttonUpdateEntry.Enabled = false;
            buttonUpdateEntry.Location = new Point(60, 218);
            buttonUpdateEntry.Name = "buttonUpdateEntry";
            buttonUpdateEntry.Size = new Size(181, 64);
            buttonUpdateEntry.TabIndex = 6;
            buttonUpdateEntry.Text = "Изменить запись";
            buttonUpdateEntry.UseVisualStyleBackColor = true;
            buttonUpdateEntry.Visible = false;
            buttonUpdateEntry.Click += buttonUpdateEntry_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(410, 218);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(155, 55);
            buttonBack.TabIndex = 7;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonAddItem
            // 
            buttonAddItem.Location = new Point(610, 44);
            buttonAddItem.Name = "buttonAddItem";
            buttonAddItem.Size = new Size(40, 29);
            buttonAddItem.TabIndex = 8;
            buttonAddItem.Text = "+";
            buttonAddItem.UseVisualStyleBackColor = true;
            buttonAddItem.Click += buttonAddItem_Click;
            // 
            // buttonAddOrder
            // 
            buttonAddOrder.Location = new Point(610, 96);
            buttonAddOrder.Name = "buttonAddOrder";
            buttonAddOrder.Size = new Size(40, 29);
            buttonAddOrder.TabIndex = 9;
            buttonAddOrder.Text = "+";
            buttonAddOrder.UseVisualStyleBackColor = true;
            buttonAddOrder.Click += buttonAddOrder_Click;
            // 
            // textBoxUnits
            // 
            textBoxUnits.Location = new Point(370, 155);
            textBoxUnits.Name = "textBoxUnits";
            textBoxUnits.Size = new Size(195, 27);
            textBoxUnits.TabIndex = 10;
            textBoxUnits.TextChanged += textBoxUnits_TextChanged;
            // 
            // FormWorkWithItem_Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 342);
            Controls.Add(textBoxUnits);
            Controls.Add(buttonAddOrder);
            Controls.Add(buttonAddItem);
            Controls.Add(buttonBack);
            Controls.Add(buttonUpdateEntry);
            Controls.Add(buttonAddEntry);
            Controls.Add(comboBoxOrder);
            Controls.Add(comboBoxItem);
            Controls.Add(labelUnits);
            Controls.Add(labelOrder);
            Controls.Add(labelItem);
            Name = "FormWorkWithItem_Order";
            Text = "FormWorkWithItem_Order";
            Load += FormWorkWithItem_Order_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelItem;
        private Label labelOrder;
        private Label labelUnits;
        private ComboBox comboBoxItem;
        private ComboBox comboBoxOrder;
        private Button buttonAddEntry;
        private Button buttonUpdateEntry;
        private Button buttonBack;
        private Button buttonAddItem;
        private Button buttonAddOrder;
        private TextBox textBoxUnits;
    }
}