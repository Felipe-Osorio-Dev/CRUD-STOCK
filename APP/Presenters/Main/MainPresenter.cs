using APP.Presenters.Register;
using APP.Presenters.Stock;
using APP.Services.Navigation;
using APP.Views.Main;
using APP.Views.Register;
using APP.Views.Stock;

namespace APP.Presenters.Main
{
    internal class MainPresenter
    {
        private readonly IMainView _view;
        private readonly INavigationService _navigationService;

        public MainPresenter(IMainView view, INavigationService navigationService)
        {
            _view = view;
            _navigationService = navigationService;

            _navigationService.SetMainForm((Form) _view);

            _view.RegisterMenuItemClicked += OnRegisterMenuItemClicked;
            _view.StockMenuItemClicked += OnStockMenuItemClicked;
        }

        private void OnRegisterMenuItemClicked(object sender, EventArgs e)
        {
            _navigationService.OpenDialog<RegisterForm, RegisterPresenter, EventArgs>(null);
        }

        private void OnStockMenuItemClicked(object sender, EventArgs e)
        {
            _navigationService.NavigateTo<StockForm, StockPresenter, EventArgs>(null);
        }
    }
}
