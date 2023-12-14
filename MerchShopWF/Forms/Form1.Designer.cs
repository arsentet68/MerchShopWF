namespace MerchShopWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelWelcome = new Label();
            buttonInformation = new Button();
            buttonChooseTable = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            labelWelcome.ForeColor = Color.White;
            labelWelcome.Location = new Point(217, 53);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(358, 40);
            labelWelcome.TabIndex = 0;
            labelWelcome.Text = "Добро пожаловать!";
            // 
            // buttonInformation
            // 
            buttonInformation.BackColor = Color.DimGray;
            buttonInformation.Font = new Font("Century Schoolbook", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInformation.ForeColor = Color.White;
            buttonInformation.Location = new Point(217, 132);
            buttonInformation.Name = "buttonInformation";
            buttonInformation.Size = new Size(358, 66);
            buttonInformation.TabIndex = 1;
            buttonInformation.Text = "Показать сводную информацию";
            buttonInformation.UseVisualStyleBackColor = false;
            buttonInformation.Click += buttonInformation_Click;
            // 
            // buttonChooseTable
            // 
            buttonChooseTable.BackColor = Color.DimGray;
            buttonChooseTable.Font = new Font("Century Schoolbook", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonChooseTable.ForeColor = Color.White;
            buttonChooseTable.Location = new Point(217, 223);
            buttonChooseTable.Name = "buttonChooseTable";
            buttonChooseTable.Size = new Size(358, 66);
            buttonChooseTable.TabIndex = 2;
            buttonChooseTable.Text = "Выбрать таблицу";
            buttonChooseTable.UseVisualStyleBackColor = false;
            buttonChooseTable.Click += buttonChooseTable_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.DimGray;
            buttonExit.Font = new Font("Century Schoolbook", 15F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(217, 315);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(358, 66);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExit);
            Controls.Add(buttonChooseTable);
            Controls.Add(buttonInformation);
            Controls.Add(labelWelcome);
            Name = "Form1";
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWelcome;
        private Button buttonInformation;
        private Button buttonChooseTable;
        private Button buttonExit;
    }
}