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
            labelItem.Location = new Point(48, 44);
            labelItem.Name = "labelItem";
            labelItem.Size = new Size(51, 20);
            labelItem.TabIndex = 0;
            labelItem.Text = "Товар";
            // 
            // labelOrder
            // 
            labelOrder.AutoSize = true;
            labelOrder.Location = new Point(51, 96);
            labelOrder.Name = "labelOrder";
            labelOrder.Size = new Size(47, 20);
            labelOrder.TabIndex = 1;
            labelOrder.Text = "Заказ";
            // 
            // labelUnits
            // 
            labelUnits.AutoSize = true;
            labelUnits.Location = new Point(52, 158);
            labelUnits.Name = "labelUnits";
            labelUnits.Size = new Size(90, 20);
            labelUnits.TabIndex = 2;
            labelUnits.Text = "Количество";
            // 
            // comboBoxItem
            // 
            comboBoxItem.FormattingEnabled = true;
            comboBoxItem.Location = new Point(145, 43);
            comboBoxItem.Name = "comboBoxItem";
            comboBoxItem.Size = new Size(151, 28);
            comboBoxItem.TabIndex = 3;
            // 
            // comboBoxOrder
            // 
            comboBoxOrder.FormattingEnabled = true;
            comboBoxOrder.Location = new Point(145, 93);
            comboBoxOrder.Name = "comboBoxOrder";
            comboBoxOrder.Size = new Size(151, 28);
            comboBoxOrder.TabIndex = 4;
            // 
            // buttonAddEntry
            // 
            buttonAddEntry.Location = new Point(60, 218);
            buttonAddEntry.Name = "buttonAddEntry";
            buttonAddEntry.Size = new Size(136, 29);
            buttonAddEntry.TabIndex = 5;
            buttonAddEntry.Text = "Добавить запись";
            buttonAddEntry.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateEntry
            // 
            buttonUpdateEntry.Location = new Point(224, 218);
            buttonUpdateEntry.Name = "buttonUpdateEntry";
            buttonUpdateEntry.Size = new Size(145, 29);
            buttonUpdateEntry.TabIndex = 6;
            buttonUpdateEntry.Text = "Изменить запись";
            buttonUpdateEntry.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(617, 366);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(94, 29);
            buttonBack.TabIndex = 7;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonAddItem
            // 
            buttonAddItem.Location = new Point(329, 40);
            buttonAddItem.Name = "buttonAddItem";
            buttonAddItem.Size = new Size(40, 29);
            buttonAddItem.TabIndex = 8;
            buttonAddItem.Text = "+";
            buttonAddItem.UseVisualStyleBackColor = true;
            // 
            // buttonAddOrder
            // 
            buttonAddOrder.Location = new Point(329, 92);
            buttonAddOrder.Name = "buttonAddOrder";
            buttonAddOrder.Size = new Size(40, 29);
            buttonAddOrder.TabIndex = 9;
            buttonAddOrder.Text = "+";
            buttonAddOrder.UseVisualStyleBackColor = true;
            // 
            // textBoxUnits
            // 
            textBoxUnits.Location = new Point(171, 155);
            textBoxUnits.Name = "textBoxUnits";
            textBoxUnits.Size = new Size(125, 27);
            textBoxUnits.TabIndex = 10;
            // 
            // FormWorkWithItem_Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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