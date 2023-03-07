namespace Calculadora
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
            addButton = new Button();
            subtractButton = new Button();
            multiplyButton = new Button();
            divideButton = new Button();
            resultTextBox = new TextBox();
            deleteButton = new Button();
            equalButton = new Button();
            closeButton = new Button();
            operationTextBox = new TextBox();
            SuspendLayout();
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(51, 51, 51);
            addButton.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(62, 141);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 75);
            addButton.TabIndex = 0;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += Button1_Click;
            // 
            // subtractButton
            // 
            subtractButton.BackColor = Color.FromArgb(51, 51, 51);
            subtractButton.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            subtractButton.ForeColor = Color.White;
            subtractButton.Location = new Point(62, 222);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(75, 75);
            subtractButton.TabIndex = 1;
            subtractButton.Text = "-";
            subtractButton.UseVisualStyleBackColor = false;
            subtractButton.Click += SubtractButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.BackColor = Color.FromArgb(51, 51, 51);
            multiplyButton.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            multiplyButton.ForeColor = Color.White;
            multiplyButton.Location = new Point(143, 222);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(75, 75);
            multiplyButton.TabIndex = 2;
            multiplyButton.Text = "x";
            multiplyButton.UseVisualStyleBackColor = false;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // divideButton
            // 
            divideButton.BackColor = Color.FromArgb(51, 51, 51);
            divideButton.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            divideButton.ForeColor = Color.White;
            divideButton.Location = new Point(62, 303);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(75, 75);
            divideButton.TabIndex = 3;
            divideButton.Text = "%";
            divideButton.UseVisualStyleBackColor = false;
            divideButton.Click += divideButton_Click;
            // 
            // resultTextBox
            // 
            resultTextBox.BackColor = Color.FromArgb(85, 85, 85);
            resultTextBox.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            resultTextBox.ForeColor = Color.White;
            resultTextBox.Location = new Point(62, 85);
            resultTextBox.Name = "resultTextBox";
            resultTextBox.Size = new Size(156, 50);
            resultTextBox.TabIndex = 4;
            resultTextBox.TextAlign = HorizontalAlignment.Right;
            resultTextBox.TextChanged += textBox_TextChanged;
            resultTextBox.KeyPress += textBox_KeyPress;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(51, 51, 51);
            deleteButton.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(143, 141);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 75);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "CE";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += DeleteButton_Click;
            // 
            // equalButton
            // 
            equalButton.BackColor = Color.FromArgb(51, 51, 51);
            equalButton.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            equalButton.ForeColor = Color.White;
            equalButton.Location = new Point(143, 303);
            equalButton.Name = "equalButton";
            equalButton.Size = new Size(75, 75);
            equalButton.TabIndex = 6;
            equalButton.Text = "=";
            equalButton.UseVisualStyleBackColor = false;
            equalButton.Click += EqualButton_Click;
            // 
            // closeButton
            // 
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(273, 12);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(30, 30);
            closeButton.TabIndex = 7;
            closeButton.Text = "x";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += Button7_Click;
            // 
            // operationTextBox
            // 
            operationTextBox.BackColor = Color.FromArgb(85, 85, 85);
            operationTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            operationTextBox.ForeColor = Color.White;
            operationTextBox.Location = new Point(62, 44);
            operationTextBox.Name = "operationTextBox";
            operationTextBox.Size = new Size(156, 35);
            operationTextBox.TabIndex = 8;
            operationTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 17, 17);
            ClientSize = new Size(315, 442);
            Controls.Add(operationTextBox);
            Controls.Add(closeButton);
            Controls.Add(equalButton);
            Controls.Add(deleteButton);
            Controls.Add(resultTextBox);
            Controls.Add(divideButton);
            Controls.Add(multiplyButton);
            Controls.Add(subtractButton);
            Controls.Add(addButton);
            ForeColor = SystemColors.ControlDarkDark;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            ShowIcon = false;
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addButton;
        private Button subtractButton;
        private Button multiplyButton;
        private Button divideButton;
        private TextBox resultTextBox;
        private Button deleteButton;
        private Button equalButton;
        private Button closeButton;
        private TextBox operationTextBox;
    }
}