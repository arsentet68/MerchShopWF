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
            buttonPerformer.BackColor = Color.DimGray;
            buttonPerformer.ForeColor = Color.White;
            buttonPerformer.Location = new Point(306, 44);
            buttonPerformer.Name = "buttonPerformer";
            buttonPerformer.Size = new Size(137, 29);
            buttonPerformer.TabIndex = 0;
            buttonPerformer.Text = "Исполнители";
            buttonPerformer.UseVisualStyleBackColor = false;
            buttonPerformer.Click += buttonPerformer_Click;
            // 
            // buttonAlbums
            // 
            buttonAlbums.BackColor = Color.DimGray;
            buttonAlbums.ForeColor = Color.White;
            buttonAlbums.Location = new Point(306, 102);
            buttonAlbums.Name = "buttonAlbums";
            buttonAlbums.Size = new Size(137, 29);
            buttonAlbums.TabIndex = 1;
            buttonAlbums.Text = "Альбомы";
            buttonAlbums.UseVisualStyleBackColor = false;
            buttonAlbums.Click += buttonAlbums_Click;
            // 
            // buttonItems
            // 
            buttonItems.Location = new Point(327, 163);
            buttonItems.Name = "buttonItems";
            buttonItems.Size = new Size(94, 29);
            buttonItems.TabIndex = 2;
            buttonItems.Text = "Товары";
            buttonItems.UseVisualStyleBackColor = true;
            buttonItems.Click += buttonItems_Click;
            // 
            // buttonCustomers
            // 
            buttonCustomers.Location = new Point(327, 224);
            buttonCustomers.Name = "buttonCustomers";
            buttonCustomers.Size = new Size(116, 29);
            buttonCustomers.TabIndex = 3;
            buttonCustomers.Text = "Покупатели";
            buttonCustomers.UseVisualStyleBackColor = true;
            buttonCustomers.Click += buttonCustomers_Click;
            // 
            // buttonOrders
            // 
            buttonOrders.Location = new Point(327, 286);
            buttonOrders.Name = "buttonOrders";
            buttonOrders.Size = new Size(94, 29);
            buttonOrders.TabIndex = 4;
            buttonOrders.Text = "Заказы";
            buttonOrders.UseVisualStyleBackColor = true;
            buttonOrders.Click += buttonOrders_Click;
            // 
            // buttonItem_Order
            // 
            buttonItem_Order.Location = new Point(327, 350);
            buttonItem_Order.Name = "buttonItem_Order";
            buttonItem_Order.Size = new Size(116, 29);
            buttonItem_Order.TabIndex = 5;
            buttonItem_Order.Text = "Товар_Заказ";
            buttonItem_Order.UseVisualStyleBackColor = true;
            buttonItem_Order.Click += buttonItem_Order_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(641, 389);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(94, 29);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // FormTables
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
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