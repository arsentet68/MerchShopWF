namespace MerchShopWF
{
    partial class FormWorkWithAlbum
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
            labelYear = new Label();
            labelPerformer = new Label();
            textBoxName = new TextBox();
            textBoxYear = new TextBox();
            comboBoxPerformer = new ComboBox();
            buttonAddEntry = new Button();
            buttonUpdateEntry = new Button();
            buttonBack = new Button();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(64, 41);
            labelName.Name = "labelName";
            labelName.Size = new Size(125, 35);
            labelName.TabIndex = 0;
            labelName.Text = "Название";
            // 
            // labelYear
            // 
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelYear.Location = new Point(64, 89);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(56, 35);
            labelYear.TabIndex = 1;
            labelYear.Text = "Год";
            // 
            // labelPerformer
            // 
            labelPerformer.AutoSize = true;
            labelPerformer.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            labelPerformer.Location = new Point(63, 135);
            labelPerformer.Name = "labelPerformer";
            labelPerformer.Size = new Size(166, 35);
            labelPerformer.TabIndex = 2;
            labelPerformer.Text = "Исполнитель";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(351, 49);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(169, 27);
            textBoxName.TabIndex = 3;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(351, 97);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(169, 27);
            textBoxYear.TabIndex = 4;
            textBoxYear.TextChanged += textBoxYear_TextChanged;
            // 
            // comboBoxPerformer
            // 
            comboBoxPerformer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPerformer.FormattingEnabled = true;
            comboBoxPerformer.Location = new Point(351, 142);
            comboBoxPerformer.Name = "comboBoxPerformer";
            comboBoxPerformer.Size = new Size(169, 28);
            comboBoxPerformer.TabIndex = 5;
            comboBoxPerformer.SelectedIndexChanged += comboBoxPerformer_TextChanged;
            // 
            // buttonAddEntry
            // 
            buttonAddEntry.Enabled = false;
            buttonAddEntry.Location = new Point(64, 219);
            buttonAddEntry.Name = "buttonAddEntry";
            buttonAddEntry.Size = new Size(223, 57);
            buttonAddEntry.TabIndex = 6;
            buttonAddEntry.Text = "Добавить запись";
            buttonAddEntry.UseVisualStyleBackColor = true;
            buttonAddEntry.Visible = false;
            buttonAddEntry.Click += buttonAddEntry_Click;
            // 
            // buttonUpdateEntry
            // 
            buttonUpdateEntry.Enabled = false;
            buttonUpdateEntry.Location = new Point(63, 219);
            buttonUpdateEntry.Name = "buttonUpdateEntry";
            buttonUpdateEntry.Size = new Size(224, 57);
            buttonUpdateEntry.TabIndex = 7;
            buttonUpdateEntry.Text = "Изменить запись";
            buttonUpdateEntry.UseVisualStyleBackColor = true;
            buttonUpdateEntry.Visible = false;
            buttonUpdateEntry.Click += buttonUpdateEntry_Click;
            // 
            // buttonBack
            // 
            buttonBack.Location = new Point(404, 223);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(189, 53);
            buttonBack.TabIndex = 8;
            buttonBack.Text = "Назад";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // FormWorkWithAlbum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 327);
            Controls.Add(buttonBack);
            Controls.Add(buttonUpdateEntry);
            Controls.Add(buttonAddEntry);
            Controls.Add(comboBoxPerformer);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxName);
            Controls.Add(labelPerformer);
            Controls.Add(labelYear);
            Controls.Add(labelName);
            Name = "FormWorkWithAlbum";
            Text = "FormWorkWithAlbum";
            Load += FormWorkWithAlbum_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelName;
        private Label labelYear;
        private Label labelPerformer;
        private TextBox textBoxName;
        private TextBox textBoxYear;
        private ComboBox comboBoxPerformer;
        private Button buttonAddEntry;
        private Button buttonUpdateEntry;
        private Button buttonBack;
    }
}