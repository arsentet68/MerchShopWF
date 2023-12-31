﻿namespace MerchShopWF
{
    partial class FormWorkWithItem
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
            labelName = new Label();
            labelPrice = new Label();
            labelAlbum = new Label();
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            comboBoxAlbum = new ComboBox();
            buttonAddEntry = new Button();
            buttonUpdateEntry = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(75, 52);
            labelName.Name = "labelName";
            labelName.Size = new Size(125, 35);
            labelName.TabIndex = 0;
            labelName.Text = "Название";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrice.Location = new Point(75, 106);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(74, 35);
            labelPrice.TabIndex = 1;
            labelPrice.Text = "Цена";
            // 
            // labelAlbum
            // 
            labelAlbum.AutoSize = true;
            labelAlbum.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelAlbum.Location = new Point(75, 170);
            labelAlbum.Name = "labelAlbum";
            labelAlbum.Size = new Size(104, 35);
            labelAlbum.TabIndex = 2;
            labelAlbum.Text = "Альбом";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(352, 61);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(207, 27);
            textBoxName.TabIndex = 3;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(352, 125);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(207, 27);
            textBoxPrice.TabIndex = 4;
            textBoxPrice.TextChanged += textBoxPrice_TextChanged;
            // 
            // comboBoxAlbum
            // 
            comboBoxAlbum.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxAlbum.FormattingEnabled = true;
            comboBoxAlbum.Location = new Point(352, 179);
            comboBoxAlbum.Name = "comboBoxAlbum";
            comboBoxAlbum.Size = new Size(207, 28);
            comboBoxAlbum.TabIndex = 6;
            comboBoxAlbum.TextChanged += comboBoxAlbum_TextChanged;
            // 
            // buttonAddEntry
            // 
            buttonAddEntry.Enabled = false;
            buttonAddEntry.Location = new Point(75, 246);
            buttonAddEntry.Name = "buttonAddEntry";
            buttonAddEntry.Size = new Size(213, 56);
            buttonAddEntry.TabIndex = 7;
            buttonAddEntry.Text = "Добавить запись";
            buttonAddEntry.UseVisualStyleBackColor = true;
            buttonAddEntry.Visible = false;
            buttonAddEntry.Click += buttonAddEntry_Click;
            // 
            // buttonUpdateEntry
            // 
            buttonUpdateEntry.Enabled = false;
            buttonUpdateEntry.Location = new Point(75, 246);
            buttonUpdateEntry.Name = "buttonUpdateEntry";
            buttonUpdateEntry.Size = new Size(213, 56);
            buttonUpdateEntry.TabIndex = 8;
            buttonUpdateEntry.Text = "Изменить запись";
            buttonUpdateEntry.UseVisualStyleBackColor = true;
            buttonUpdateEntry.Visible = false;
            buttonUpdateEntry.Click += buttonUpdateEntry_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(352, 242);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(207, 60);
            buttonBack.TabIndex = 9;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // FormWorkWithItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 341);
            Controls.Add(buttonBack);
            Controls.Add(buttonUpdateEntry);
            Controls.Add(buttonAddEntry);
            Controls.Add(comboBoxAlbum);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(labelAlbum);
            Controls.Add(labelPrice);
            Controls.Add(labelName);
            Name = "FormWorkWithItem";
            Text = "FormWorkWithItem";
            Load += FormWorkWithItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelPrice;
        private Label labelAlbum;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private ComboBox comboBoxAlbum;
        private Button buttonAddEntry;
        private Button buttonUpdateEntry;
        private Button buttonBack;
    }
}