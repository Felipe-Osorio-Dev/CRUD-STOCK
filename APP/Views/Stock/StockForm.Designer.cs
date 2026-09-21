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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Control;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dtgvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dtgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtgvStock.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, eanDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, validateDataGridViewTextBoxColumn });
            dtgvStock.DataSource = productDTOBindingSource;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = SystemColors.Window;
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dtgvStock.DefaultCellStyle = dataGridViewCellStyle13;
            dtgvStock.EnableHeadersVisualStyles = false;
            dtgvStock.Location = new Point(12, 48);
            dtgvStock.MultiSelect = false;
            dtgvStock.Name = "dtgvStock";
            dtgvStock.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = SystemColors.Control;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dtgvStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
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
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            nameDataGridViewTextBoxColumn.HeaderText = "Nome";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // eanDataGridViewTextBoxColumn
            // 
            eanDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            eanDataGridViewTextBoxColumn.DataPropertyName = "Ean";
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            eanDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            eanDataGridViewTextBoxColumn.HeaderText = "Cod.Produto";
            eanDataGridViewTextBoxColumn.Name = "eanDataGridViewTextBoxColumn";
            eanDataGridViewTextBoxColumn.ReadOnly = true;
            eanDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            amountDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            amountDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.False;
            // 
            // validateDataGridViewTextBoxColumn
            // 
            validateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            validateDataGridViewTextBoxColumn.DataPropertyName = "Validate";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            validateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
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