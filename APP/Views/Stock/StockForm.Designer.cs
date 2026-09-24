namespace APP.Views.Stock
{
    partial class StockForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            dtgvStock = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            validateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDTOBindingSource = new BindingSource(components);
            btnRegisterProduct = new Button();
            btnEditProduct = new Button();
            btnDeleteProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dtgvStock
            // 
            dtgvStock.AllowUserToAddRows = false;
            dtgvStock.AllowUserToDeleteRows = false;
            dtgvStock.AllowUserToResizeColumns = false;
            dtgvStock.AllowUserToResizeRows = false;
            dtgvStock.AutoGenerateColumns = false;
            dtgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvStock.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgvStock.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, eanDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, validateDataGridViewTextBoxColumn });
            dtgvStock.DataSource = productDTOBindingSource;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dtgvStock.DefaultCellStyle = dataGridViewCellStyle6;
            dtgvStock.EnableHeadersVisualStyles = false;
            dtgvStock.Location = new Point(12, 48);
            dtgvStock.MultiSelect = false;
            dtgvStock.Name = "dtgvStock";
            dtgvStock.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dtgvStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dtgvStock.RowHeadersVisible = false;
            dtgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvStock.ShowEditingIcon = false;
            dtgvStock.Size = new Size(776, 346);
            dtgvStock.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            nameDataGridViewTextBoxColumn.HeaderText = "Nome";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // eanDataGridViewTextBoxColumn
            // 
            eanDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            eanDataGridViewTextBoxColumn.DataPropertyName = "Ean";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eanDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            eanDataGridViewTextBoxColumn.HeaderText = "Cod.Produto";
            eanDataGridViewTextBoxColumn.Name = "eanDataGridViewTextBoxColumn";
            eanDataGridViewTextBoxColumn.ReadOnly = true;
            eanDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            amountDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            amountDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // validateDataGridViewTextBoxColumn
            // 
            validateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            validateDataGridViewTextBoxColumn.DataPropertyName = "Validate";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            validateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            validateDataGridViewTextBoxColumn.HeaderText = "Validade";
            validateDataGridViewTextBoxColumn.Name = "validateDataGridViewTextBoxColumn";
            validateDataGridViewTextBoxColumn.ReadOnly = true;
            validateDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // productDTOBindingSource
            // 
            productDTOBindingSource.DataSource = typeof(Dtos.Responses.ProductDTO);
            // 
            // btnRegisterProduct
            // 
            btnRegisterProduct.Location = new Point(551, 415);
            btnRegisterProduct.Name = "btnRegisterProduct";
            btnRegisterProduct.Size = new Size(75, 23);
            btnRegisterProduct.TabIndex = 1;
            btnRegisterProduct.Text = "Cadastrar";
            btnRegisterProduct.UseVisualStyleBackColor = true;
            btnRegisterProduct.Click += btnRegisterProduct_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(632, 415);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(75, 23);
            btnEditProduct.TabIndex = 2;
            btnEditProduct.Text = "Editar";
            btnEditProduct.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Location = new Point(713, 415);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(75, 23);
            btnDeleteProduct.TabIndex = 3;
            btnDeleteProduct.Text = "Remover";
            btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // StockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnEditProduct);
            Controls.Add(btnRegisterProduct);
            Controls.Add(dtgvStock);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "StockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)dtgvStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)productDTOBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvStock;
        private BindingSource productDTOBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn validateDataGridViewTextBoxColumn;
        private Button btnRegisterProduct;
        private Button btnEditProduct;
        private Button btnDeleteProduct;
    }
}