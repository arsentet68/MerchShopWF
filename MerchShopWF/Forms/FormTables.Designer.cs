namespace MerchShopWF
{
    partial class FormTables
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
            buttonPerformer = new Button();
            buttonAlbums = new Button();
            buttonItems = new Button();
            buttonCustomers = new Button();
            buttonOrders = new Button();
            buttonItem_Order = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // buttonPerformer
            // 
            buttonPerformer.BackColor = Color.Silver;
            buttonPerformer.ForeColor = Color.Black;
            buttonPerformer.Location = new Point(235, 12);
            buttonPerformer.Name = "buttonPerformer";
            buttonPerformer.Size = new Size(295, 54);
            buttonPerformer.TabIndex = 0;
            buttonPerformer.Text = "Исполнители";
            buttonPerformer.UseVisualStyleBackColor = false;
            buttonPerformer.Click += buttonPerformer_Click;
            // 
            // buttonAlbums
            // 
            buttonAlbums.BackColor = Color.Silver;
            buttonAlbums.ForeColor = SystemColors.ControlText;
            buttonAlbums.Location = new Point(235, 82);
            buttonAlbums.Name = "buttonAlbums";
            buttonAlbums.Size = new Size(295, 56);
            buttonAlbums.TabIndex = 1;
            buttonAlbums.Text = "Альбомы";
            buttonAlbums.UseVisualStyleBackColor = false;
            buttonAlbums.Click += buttonAlbums_Click;
            // 
            // buttonItems
            // 
            buttonItems.BackColor = Color.Silver;
            buttonItems.Location = new Point(235, 154);
            buttonItems.Name = "buttonItems";
            buttonItems.Size = new Size(295, 50);
            buttonItems.TabIndex = 2;
            buttonItems.Text = "Товары";
            buttonItems.UseVisualStyleBackColor = false;
            buttonItems.Click += buttonItems_Click;
            // 
            // buttonCustomers
            // 
            buttonCustomers.BackColor = Color.Silver;
            buttonCustomers.Location = new Point(235, 226);
            buttonCustomers.Name = "buttonCustomers";
            buttonCustomers.Size = new Size(295, 56);
            buttonCustomers.TabIndex = 3;
            buttonCustomers.Text = "Покупатели";
            buttonCustomers.UseVisualStyleBackColor = false;
            buttonCustomers.Click += buttonCustomers_Click;
            // 
            // buttonOrders
            // 
            buttonOrders.BackColor = Color.Silver;
            buttonOrders.Location = new Point(235, 303);
            buttonOrders.Name = "buttonOrders";
            buttonOrders.Size = new Size(295, 53);
            buttonOrders.TabIndex = 4;
            buttonOrders.Text = "Заказы";
            buttonOrders.UseVisualStyleBackColor = false;
            buttonOrders.Click += buttonOrders_Click;
            // 
            // buttonItem_Order
            // 
            buttonItem_Order.BackColor = Color.Silver;
            buttonItem_Order.Location = new Point(235, 380);
            buttonItem_Order.Name = "buttonItem_Order";
            buttonItem_Order.Size = new Size(295, 58);
            buttonItem_Order.TabIndex = 5;
            buttonItem_Order.Text = "Товар_Заказ";
            buttonItem_Order.UseVisualStyleBackColor = false;
            buttonItem_Order.Click += buttonItem_Order_Click;
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.Silver;
            buttonBack.Location = new Point(600, 388);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(164, 50);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = false;
            buttonBack.Click += buttonBack_Click;
            // 
            // FormTables
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBack);
            Controls.Add(buttonItem_Order);
            Controls.Add(buttonOrders);
            Controls.Add(buttonCustomers);
            Controls.Add(buttonItems);
            Controls.Add(buttonAlbums);
            Controls.Add(buttonPerformer);
            Name = "FormTables";
            Text = "Таблицы";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonPerformer;
        private Button buttonAlbums;
        private Button buttonItems;
        private Button buttonCustomers;
        private Button buttonOrders;
        private Button buttonItem_Order;
        private Button buttonBack;
    }
}