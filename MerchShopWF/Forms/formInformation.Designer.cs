namespace MerchShopWF
{
    partial class formInformation
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
            dataGridView1 = new DataGridView();
            buttonInteractiveAdd = new Button();
            buttonInteractiveUpdate = new Button();
            buttonBack = new Button();
            labelPerformer = new Label();
            comboBoxPerformer = new ComboBox();
            labelOrder = new Label();
            comboBoxOrder = new ComboBox();
            labelStatus = new Label();
            comboBoxStatus = new ComboBox();
            labelCustomer = new Label();
            labelTotalPrice = new Label();
            textBoxTotalPrice1 = new TextBox();
            textBoxTotalPrice2 = new TextBox();
            labelMinus = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(702, 569);
            dataGridView1.TabIndex = 0;
            // 
            // buttonInteractiveAdd
            // 
            buttonInteractiveAdd.Location = new Point(749, 12);
            buttonInteractiveAdd.Name = "buttonInteractiveAdd";
            buttonInteractiveAdd.Size = new Size(250, 53);
            buttonInteractiveAdd.TabIndex = 1;
            buttonInteractiveAdd.Text = "Интерактивное добавление";
            buttonInteractiveAdd.UseVisualStyleBackColor = true;
            buttonInteractiveAdd.Click += buttonInteractiveAdd_Click;
            // 
            // buttonInteractiveUpdate
            // 
            buttonInteractiveUpdate.Location = new Point(749, 78);
            buttonInteractiveUpdate.Name = "buttonInteractiveUpdate";
            buttonInteractiveUpdate.Size = new Size(250, 54);
            buttonInteractiveUpdate.TabIndex = 2;
            buttonInteractiveUpdate.Text = "Интерактивное редактирование";
            buttonInteractiveUpdate.UseVisualStyleBackColor = true;
            buttonInteractiveUpdate.Click += buttonInteractiveUpdate_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(749, 528);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(250, 53);
            buttonBack.TabIndex = 3;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelPerformer
            // 
            labelPerformer.AutoSize = true;
            labelPerformer.BackColor = Color.White;
            labelPerformer.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelPerformer.ForeColor = Color.Black;
            labelPerformer.Location = new Point(781, 135);
            labelPerformer.Name = "labelPerformer";
            labelPerformer.Size = new Size(166, 35);
            labelPerformer.TabIndex = 4;
            labelPerformer.Text = "Исполнитель";
            // 
            // comboBoxPerformer
            // 
            comboBoxPerformer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPerformer.FormattingEnabled = true;
            comboBoxPerformer.Location = new Point(749, 173);
            comboBoxPerformer.Name = "comboBoxPerformer";
            comboBoxPerformer.Size = new Size(250, 28);
            comboBoxPerformer.TabIndex = 5;
            comboBoxPerformer.SelectedIndexChanged += comboBoxPerformer_SelectedIndexChanged;
            // 
            // labelOrder
            // 
            labelOrder.AutoSize = true;
            labelOrder.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelOrder.ForeColor = Color.Black;
            labelOrder.Location = new Point(827, 214);
            labelOrder.Name = "labelOrder";
            labelOrder.Size = new Size(78, 35);
            labelOrder.TabIndex = 6;
            labelOrder.Text = "Заказ";
            // 
            // comboBoxOrder
            // 
            comboBoxOrder.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrder.FormattingEnabled = true;
            comboBoxOrder.Location = new Point(749, 252);
            comboBoxOrder.Name = "comboBoxOrder";
            comboBoxOrder.Size = new Size(250, 28);
            comboBoxOrder.TabIndex = 7;
            comboBoxOrder.SelectedIndexChanged += comboBoxOrder_SelectedIndexChanged;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelStatus.ForeColor = Color.Black;
            labelStatus.Location = new Point(827, 292);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(87, 35);
            labelStatus.TabIndex = 8;
            labelStatus.Text = "Статус";
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "В обработке", "Отправлен", "Доставлен" });
            comboBoxStatus.Location = new Point(749, 330);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(250, 28);
            comboBoxStatus.TabIndex = 9;
            comboBoxStatus.SelectedIndexChanged += comboBoxStatus_SelectedIndexChanged;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.ForeColor = Color.White;
            labelCustomer.Location = new Point(836, 357);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(0, 20);
            labelCustomer.TabIndex = 10;
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotalPrice.ForeColor = Color.Black;
            labelTotalPrice.Location = new Point(762, 377);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(222, 35);
            labelTotalPrice.TabIndex = 15;
            labelTotalPrice.Text = "Общая стоимость";
            // 
            // textBoxTotalPrice1
            // 
            textBoxTotalPrice1.Location = new Point(749, 429);
            textBoxTotalPrice1.Name = "textBoxTotalPrice1";
            textBoxTotalPrice1.Size = new Size(103, 27);
            textBoxTotalPrice1.TabIndex = 16;
            textBoxTotalPrice1.TextChanged += textBoxTotalPrice1_TextChanged;
            // 
            // textBoxTotalPrice2
            // 
            textBoxTotalPrice2.Location = new Point(900, 429);
            textBoxTotalPrice2.Name = "textBoxTotalPrice2";
            textBoxTotalPrice2.Size = new Size(99, 27);
            textBoxTotalPrice2.TabIndex = 17;
            // 
            // labelMinus
            // 
            labelMinus.AutoSize = true;
            labelMinus.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelMinus.ForeColor = Color.Black;
            labelMinus.Location = new Point(858, 421);
            labelMinus.Name = "labelMinus";
            labelMinus.Size = new Size(25, 35);
            labelMinus.TabIndex = 18;
            labelMinus.Text = "-";
            // 
            // button1
            // 
            button1.Location = new Point(749, 473);
            button1.Name = "button1";
            button1.Size = new Size(250, 49);
            button1.TabIndex = 19;
            button1.Text = "Применить фильтр по стоимости";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // formInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1102, 593);
            Controls.Add(button1);
            Controls.Add(labelMinus);
            Controls.Add(textBoxTotalPrice2);
            Controls.Add(textBoxTotalPrice1);
            Controls.Add(labelTotalPrice);
            Controls.Add(labelCustomer);
            Controls.Add(comboBoxStatus);
            Controls.Add(labelStatus);
            Controls.Add(comboBoxOrder);
            Controls.Add(labelOrder);
            Controls.Add(comboBoxPerformer);
            Controls.Add(labelPerformer);
            Controls.Add(buttonBack);
            Controls.Add(buttonInteractiveUpdate);
            Controls.Add(buttonInteractiveAdd);
            Controls.Add(dataGridView1);
            Name = "formInformation";
            Text = "Сводная информация";
            Load += formInformation_Load;
            VisibleChanged += formInformation_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonInteractiveAdd;
        private Button buttonInteractiveUpdate;
        private Button buttonBack;
        private Label labelPerformer;
        private ComboBox comboBoxPerformer;
        private Label labelOrder;
        private ComboBox comboBoxOrder;
        private Label labelStatus;
        private ComboBox comboBoxStatus;
        private Label labelCustomer;
        private Label labelTotalPrice;
        private TextBox textBoxTotalPrice1;
        private TextBox textBoxTotalPrice2;
        private Label labelMinus;
        private Button button1;
    }
}