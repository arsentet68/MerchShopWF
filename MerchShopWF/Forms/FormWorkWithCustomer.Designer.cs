﻿namespace MerchShopWF
{
    partial class FormWorkWithCustomer
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
            labelEmail = new Label();
            textBoxName = new TextBox();
            textBoxEmail = new TextBox();
            buttonAddEntry = new Button();
            buttonUpdateEntry = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(69, 44);
            labelName.Name = "labelName";
            labelName.Size = new Size(65, 35);
            labelName.TabIndex = 0;
            labelName.Text = "Имя";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelEmail.Location = new Point(71, 97);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(85, 35);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "E-mail";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(185, 52);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(230, 27);
            textBoxName.TabIndex = 2;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(185, 106);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(230, 27);
            textBoxEmail.TabIndex = 3;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // buttonAddEntry
            // 
            buttonAddEntry.Enabled = false;
            buttonAddEntry.Location = new Point(69, 181);
            buttonAddEntry.Name = "buttonAddEntry";
            buttonAddEntry.Size = new Size(205, 52);
            buttonAddEntry.TabIndex = 4;
            buttonAddEntry.Text = "Добавить запись";
            buttonAddEntry.UseVisualStyleBackColor = true;
            buttonAddEntry.Visible = false;
            buttonAddEntry.Click += buttonAddEntry_Click;
            // 
            // buttonUpdateEntry
            // 
            buttonUpdateEntry.Enabled = false;
            buttonUpdateEntry.Location = new Point(69, 181);
            buttonUpdateEntry.Name = "buttonUpdateEntry";
            buttonUpdateEntry.Size = new Size(203, 52);
            buttonUpdateEntry.TabIndex = 5;
            buttonUpdateEntry.Text = "Изменить запись";
            buttonUpdateEntry.UseVisualStyleBackColor = true;
            buttonUpdateEntry.Visible = false;
            buttonUpdateEntry.Click += buttonUpdateEntry_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(352, 173);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(189, 60);
            buttonBack.TabIndex = 6;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // FormWorkWithCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 275);
            Controls.Add(buttonBack);
            Controls.Add(buttonUpdateEntry);
            Controls.Add(buttonAddEntry);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxName);
            Controls.Add(labelEmail);
            Controls.Add(labelName);
            Name = "FormWorkWithCustomer";
            Text = "FormWorkWithCustomer";
            Load += FormWorkWithCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelEmail;
        private TextBox textBoxName;
        private TextBox textBoxEmail;
        private Button buttonAddEntry;
        private Button buttonUpdateEntry;
        private Button buttonBack;
    }
}