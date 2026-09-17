using APP.Dtos.Responses;
using System.ComponentModel;

namespace APP.Views.Stock
{
    public partial class StockForm : Form, IStockView
    {
        private readonly BindingSource _bindingSource = new();

        public StockForm()
        {
            InitializeComponent();
            dtgvStock.DataSource = _bindingSource;
        }

        BindingList<ProductDTO> IStockView.Products
        {
            get => new();
            set => _bindingSource.DataSource = value;
        }

        public event EventHandler LoadProducts;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadProducts?.Invoke(this, EventArgs.Empty);

            dtgvStock.DataBindingComplete += (s, e) =>
            {
                dtgvStock.Columns["Name"].HeaderText = "Nome";
                dtgvStock.Columns["Ean"].HeaderText = "Cod.Fabrica";
                dtgvStock.Columns["Amount"].HeaderText = "Quantidade";
                dtgvStock.Columns["Validate"].HeaderText = "Validade";
            };
        }
    }
}
