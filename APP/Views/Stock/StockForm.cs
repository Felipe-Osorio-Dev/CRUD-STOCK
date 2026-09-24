using APP.Dtos.Responses;
using System.ComponentModel;

namespace APP.Views.Stock
{
    public partial class StockForm : Form, IStockView
    {
        private readonly BindingSource _bindingSource = new();
        private BindingList<ProductDTO> _products;

        public StockForm()
        {
            InitializeComponent();
            dtgvStock.DataSource = _bindingSource;
        }

        public BindingList<ProductDTO> Products
        {
            get => _products;
            set
            {
                _products = value;
                _bindingSource.DataSource = _products;
            }
        }

        public event EventHandler LoadProducts;
        public event EventHandler RegisterProduct;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadProducts?.Invoke(this, EventArgs.Empty);
        }

        private void btnRegisterProduct_Click(object sender, EventArgs e)
        {
            RegisterProduct?.Invoke(this, EventArgs.Empty);
        }
    }
}
