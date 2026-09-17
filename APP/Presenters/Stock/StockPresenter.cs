using System.ComponentModel;
using APP.Dtos.Responses;
using APP.Services.Api.Product;
using APP.Views.Stock;

namespace APP.Presenters.Stock
{
    internal class StockPresenter
    {
        private readonly IStockView _view;
        private readonly IProductService _productService;

        public StockPresenter(IStockView view, IProductService productService)
        {
            _view = view;
            _productService = productService;

            _view.LoadProducts += OnLoadProducts;
        }

        private async void OnLoadProducts(object sender, EventArgs e)
        {
            var result = await _productService.GetAllProductsAsync();

            if(!result.IsSuccess)
            {
               MessageBox.Show(result.MessageError);
               return;
            }

            _view.Products = new BindingList<ProductDTO>(result.Data);
            return;
        }
    }
}
