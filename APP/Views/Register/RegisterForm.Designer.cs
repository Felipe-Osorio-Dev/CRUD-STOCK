namespace APP.Views.Register
{
    partial class RegisterForm
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
            groupBox1 = new GroupBox();
            dateTimeValidate = new DateTimePicker();
            label4 = new Label();
            numericAmount = new NumericUpDown();
            label3 = new Label();
            txtBoxEan = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtBoxName = new TextBox();
            btnRegister = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericAmount).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimeValidate);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numericAmount);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtBoxEan);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtBoxName);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(429, 172);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produto";
            // 
            // dateTimeValidate
            // 
            dateTimeValidate.Format = DateTimePickerFormat.Short;
            dateTimeValidate.Location = new Point(246, 132);
            dateTimeValidate.Name = "dateTimeValidate";
            dateTimeValidate.Size = new Size(177, 23);
            dateTimeValidate.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 114);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 9;
            label4.Text = "Validade:";
            // 
            // numericAmount
            // 
            numericAmount.Location = new Point(6, 132);
            numericAmount.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            numericAmount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericAmount.Name = "numericAmount";
            numericAmount.Size = new Size(177, 23);
            numericAmount.TabIndex = 8;
            numericAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 114);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 7;
            label3.Text = "Quantidade:";
            // 
            // txtBoxEan
            // 
            txtBoxEan.Location = new Point(246, 60);
            txtBoxEan.Name = "txtBoxEan";
            txtBoxEan.Size = new Size(177, 23);
            txtBoxEan.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 42);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 5;
            label2.Text = "Cod.Ean:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 42);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "Nome:";
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(6, 60);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(177, 23);
            txtBoxName.TabIndex = 3;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(258, 207);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Cadastrar";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(360, 207);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Fechar";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(451, 246);
            Controls.Add(btnCancel);
            Controls.Add(btnRegister);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produto";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericAmount).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtBoxName;
        private DateTimePicker dateTimeValidate;
        private Label label4;
        private NumericUpDown numericAmount;
        private Label label3;
        private TextBox txtBoxEan;
        private Label label2;
        private Label label1;
        private Button btnRegister;
        private Button btnCancel;
    }
}