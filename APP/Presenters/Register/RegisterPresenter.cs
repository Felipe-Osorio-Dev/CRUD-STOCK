using APP.Services.Navigation;
using APP.Views.Register;

namespace APP.Presenters.Register
{
    internal class RegisterPresenter
    {
        private readonly IRegisterView _registerView;
        private readonly INavigationService _navigationService;

        public RegisterPresenter(IRegisterView registerView, INavigationService navigationService)
        {
            _registerView = registerView;
            _navigationService = navigationService;

            _registerView.RegisterClicked += OnRegisterClicked;
        }

        private void OnRegisterClicked(object sender, EventArgs e)
        {
            
        }
    }
}
