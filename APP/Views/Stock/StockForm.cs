using APP.Dtos.Responses;
using APP.Util.CustomArgs;
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

            dtgvStock.SelectionChanged += ItemSelectionChanged;
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
        public event EventHandler<CustomEventArgs<ProductDTO>> EditProduct;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            LoadProducts?.Invoke(this, EventArgs.Empty);

        }

        private void btnRegisterProduct_Click(object sender, EventArgs e)
        {
            RegisterProduct?.Invoke(this, EventArgs.Empty);
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            var selectedProduct = (ProductDTO)dtgvStock.CurrentRow.DataBoundItem;

            EditProduct?.Invoke(this, new CustomEventArgs<ProductDTO>(selectedProduct));
        }

        private void ItemSelectionChanged(object sender, EventArgs e)
        {
            btnEditProduct.Enabled = dtgvStock.CurrentRow != null;
        }
    }
}
