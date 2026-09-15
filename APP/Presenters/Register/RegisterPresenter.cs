using APP.Dtos.Requests;
using APP.Services.Api.Product;
using APP.Services.Navigation;
using APP.Util.CustomArgs;
using APP.Views.Register;

namespace APP.Presenters.Register
{
    internal class RegisterPresenter
    {
        private readonly IRegisterView _registerView;
        private readonly INavigationService _navigationService;
        private readonly IProductService _productService;

        public RegisterPresenter(IRegisterView registerView, INavigationService navigationService, IProductService productService)
        {
            _registerView = registerView;
            _navigationService = navigationService;
            _productService = productService;

            _registerView.RegisterClicked += OnRegisterClicked;
        }

        private async void OnRegisterClicked(object sender, CustomEventArgs<RegisterProductDTO> product)
        {
            var response = await _productService.RegisterProductAsync(product.Value);

            if (!response.IsSuccess)
            {
                MessageBox.Show(response.MessageError, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("O Produto " + response.Data.Name + " foi cadastrado com sucesso!",
                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
    }
}
