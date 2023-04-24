namespace INFO_BEZ__1laba
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
            encodeButton = new Button();
            encodeValueTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            encodeResultTextBox = new TextBox();
            label3 = new Label();
            decodeValueTextBox = new TextBox();
            label4 = new Label();
            decodeButton = new Button();
            decodeResultTextBox = new TextBox();
            label5 = new Label();
            keyDataGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)keyDataGrid).BeginInit();
            SuspendLayout();
            // 
            // encodeButton
            // 
            encodeButton.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            encodeButton.Location = new Point(245, 39);
            encodeButton.Name = "encodeButton";
            encodeButton.Size = new Size(95, 38);
            encodeButton.TabIndex = 0;
            encodeButton.Text = "Зашифровать";
            encodeButton.UseVisualStyleBackColor = true;
            encodeButton.Click += button1_Click;
            // 
            // encodeValueTextBox
            // 
            encodeValueTextBox.Location = new Point(12, 39);
            encodeValueTextBox.Multiline = true;
            encodeValueTextBox.Name = "encodeValueTextBox";
            encodeValueTextBox.Size = new Size(227, 38);
            encodeValueTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(155, 30);
            label1.TabIndex = 3;
            label1.Text = "Введите текст:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 177);
            label2.Name = "label2";
            label2.Size = new Size(74, 30);
            label2.TabIndex = 4;
            label2.Text = "Ключ:";
            // 
            // encodeResultTextBox
            // 
            encodeResultTextBox.Location = new Point(346, 39);
            encodeResultTextBox.Multiline = true;
            encodeResultTextBox.Name = "encodeResultTextBox";
            encodeResultTextBox.Size = new Size(229, 38);
            encodeResultTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(346, 9);
            label3.Name = "label3";
            label3.Size = new Size(80, 30);
            label3.TabIndex = 6;
            label3.Text = "Шифр:";
            // 
            // decodeValueTextBox
            // 
            decodeValueTextBox.Location = new Point(12, 120);
            decodeValueTextBox.Multiline = true;
            decodeValueTextBox.Name = "decodeValueTextBox";
            decodeValueTextBox.Size = new Size(227, 38);
            decodeValueTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 87);
            label4.Name = "label4";
            label4.Size = new Size(157, 30);
            label4.TabIndex = 9;
            label4.Text = "Дэшифровать:";
            // 
            // decodeButton
            // 
            decodeButton.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            decodeButton.Location = new Point(245, 120);
            decodeButton.Name = "decodeButton";
            decodeButton.Size = new Size(95, 38);
            decodeButton.TabIndex = 10;
            decodeButton.Text = "Дэшифровать";
            decodeButton.UseVisualStyleBackColor = true;
            decodeButton.Click += button2_Click;
            // 
            // decodeResultTextBox
            // 
            decodeResultTextBox.Location = new Point(346, 120);
            decodeResultTextBox.Multiline = true;
            decodeResultTextBox.Name = "decodeResultTextBox";
            decodeResultTextBox.Size = new Size(229, 38);
            decodeResultTextBox.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(346, 87);
            label5.Name = "label5";
            label5.Size = new Size(111, 30);
            label5.TabIndex = 12;
            label5.Text = "Результат:";
            // 
            // keyDataGrid
            // 
            keyDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            keyDataGrid.ColumnHeadersVisible = false;
            keyDataGrid.Location = new Point(12, 207);
            keyDataGrid.Margin = new Padding(3, 2, 3, 2);
            keyDataGrid.Name = "keyDataGrid";
            keyDataGrid.RowHeadersVisible = false;
            keyDataGrid.RowHeadersWidth = 51;
            keyDataGrid.RowTemplate.Height = 29;
            keyDataGrid.Size = new Size(562, 167);
            keyDataGrid.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(580, 383);
            Controls.Add(keyDataGrid);
            Controls.Add(label5);
            Controls.Add(decodeResultTextBox);
            Controls.Add(decodeButton);
            Controls.Add(label4);
            Controls.Add(decodeValueTextBox);
            Controls.Add(label3);
            Controls.Add(encodeResultTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(encodeValueTextBox);
            Controls.Add(encodeButton);
            Name = "Form1";
            Text = "Омофоническая замена";
            ((System.ComponentModel.ISupportInitialize)keyDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button encodeButton;
        private TextBox encodeValueTextBox;
        private Label label1;
        private Label label2;
        private TextBox encodeResultTextBox;
        private Label label3;
        private TextBox decodeValueTextBox;
        private Label label4;
        private Button decodeButton;
        private TextBox decodeResultTextBox;
        private Label label5;
        private DataGridView keyDataGrid;
    }
}