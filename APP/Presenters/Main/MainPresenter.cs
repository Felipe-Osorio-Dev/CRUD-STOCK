using APP.Presenters.Register;
using APP.Services.Navigation;
using APP.Views.Main;
using APP.Views.Register;

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

            _view.RegisterMenuItemClicked += NavigateTo;
        }

        private void NavigateTo(object sender, EventArgs e)
        {
            _navigationService.OpenDialog<RegisterForm, RegisterPresenter, EventArgs>(null);
        }
    }
}
