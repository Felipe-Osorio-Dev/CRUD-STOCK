using APP.Views.Stock;

namespace APP.Presenters.Stock
{
    internal class StockPresenter
    {
        private readonly IStockView _view;
        public StockPresenter(IStockView view)
        {
            _view = view;
        }
    }
}
