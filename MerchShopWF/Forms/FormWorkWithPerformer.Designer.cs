namespace MerchShopWF
{
    partial class FormWorkWithPerformer
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
            textBoxName = new TextBox();
            labelCountry = new Label();
            textBoxCountry = new TextBox();
            labelDebutYear = new Label();
            textBoxDebutYear = new TextBox();
            buttonAddEntry = new Button();
            buttonBack = new Button();
            buttonUpdateEntry = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(61, 46);
            labelName.Name = "labelName";
            labelName.Size = new Size(125, 35);
            labelName.TabIndex = 0;
            labelName.Text = "Название";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(352, 55);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(192, 27);
            textBoxName.TabIndex = 1;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // labelCountry
            // 
            labelCountry.AutoSize = true;
            labelCountry.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelCountry.Location = new Point(62, 108);
            labelCountry.Name = "labelCountry";
            labelCountry.Size = new Size(95, 35);
            labelCountry.TabIndex = 2;
            labelCountry.Text = "Страна";
            // 
            // textBoxCountry
            // 
            textBoxCountry.Location = new Point(352, 117);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new Size(192, 27);
            textBoxCountry.TabIndex = 3;
            textBoxCountry.TextChanged += textBoxCountry_TextChanged;
            // 
            // labelDebutYear
            // 
            labelDebutYear.AutoSize = true;
            labelDebutYear.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelDebutYear.Location = new Point(62, 171);
            labelDebutYear.Name = "labelDebutYear";
            labelDebutYear.Size = new Size(249, 35);
            labelDebutYear.TabIndex = 4;
            labelDebutYear.Text = "Год начала карьеры";
            // 
            // textBoxDebutYear
            // 
            textBoxDebutYear.Location = new Point(352, 171);
            textBoxDebutYear.Name = "textBoxDebutYear";
            textBoxDebutYear.Size = new Size(192, 27);
            textBoxDebutYear.TabIndex = 5;
            textBoxDebutYear.TextChanged += textBoxDebutYear_TextChanged;
            // 
            // buttonAddEntry
            // 
            buttonAddEntry.Enabled = false;
            buttonAddEntry.Location = new Point(61, 233);
            buttonAddEntry.Name = "buttonAddEntry";
            buttonAddEntry.Size = new Size(232, 66);
            buttonAddEntry.TabIndex = 6;
            buttonAddEntry.Text = "Добавить запись";
            buttonAddEntry.UseVisualStyleBackColor = true;
            buttonAddEntry.Visible = false;
            buttonAddEntry.Click += buttonAddEntry_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(352, 229);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(192, 70);
            buttonBack.TabIndex = 7;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // buttonUpdateEntry
            // 
            buttonUpdateEntry.Enabled = false;
            buttonUpdateEntry.Location = new Point(61, 233);
            buttonUpdateEntry.Name = "buttonUpdateEntry";
            buttonUpdateEntry.Size = new Size(231, 66);
            buttonUpdateEntry.TabIndex = 8;
            buttonUpdateEntry.Text = "Изменить запись";
            buttonUpdateEntry.UseVisualStyleBackColor = true;
            buttonUpdateEntry.Visible = false;
            buttonUpdateEntry.Click += buttonUpdateEntry_Click;
            // 
            // FormWorkWithPerformer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 358);
            Controls.Add(buttonUpdateEntry);
            Controls.Add(buttonBack);
            Controls.Add(buttonAddEntry);
            Controls.Add(textBoxDebutYear);
            Controls.Add(labelDebutYear);
            Controls.Add(textBoxCountry);
            Controls.Add(labelCountry);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Name = "FormWorkWithPerformer";
            Text = "FormWorkWithPerformer";
            Load += FormWorkWithPerformer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private TextBox textBoxName;
        private Label labelCountry;
        private TextBox textBoxCountry;
        private Label labelDebutYear;
        private TextBox textBoxDebutYear;
        private Button buttonAddEntry;
        private Button buttonBack;
        private Button buttonUpdateEntry;
    }
}