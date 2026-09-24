using System.ComponentModel;
using APP.Dtos.Responses;
using APP.Presenters.Register;
using APP.Services.Api.Product;
using APP.Services.Navigation;
using APP.Views.Register;
using APP.Views.Stock;

namespace APP.Presenters.Stock
{
    internal class StockPresenter
    {
        private readonly IStockView _view;
        private readonly IProductService _productService;
        private readonly INavigationService _navigationService;

        public StockPresenter(IStockView view, IProductService productService, INavigationService navigationService)
        {
            _view = view;
            _productService = productService;
            _navigationService = navigationService;

            _view.LoadProducts += OnLoadProducts;
            _view.RegisterProduct += OnRegisterProduct;
        }

        private async void OnLoadProducts(object sender, EventArgs e)
        {
            var result = await _productService.GetAllProductsAsync();

            if (!result.IsSuccess)
            {
                MessageBox.Show(result.MessageError);
                return;
            }

            _view.Products = new BindingList<ProductDTO>(result.Data);
            return;
        }

        private void OnRegisterProduct(object sender, EventArgs e)
        {
            var dialog = (RegisterForm) _navigationService.OpenDialog<RegisterForm, RegisterPresenter, EventArgs>(null);

            if(dialog.DialogResult == DialogResult.OK)
            {
                _view.Products.Add(dialog.CreatedProduct);
            }
        }
    }
}
