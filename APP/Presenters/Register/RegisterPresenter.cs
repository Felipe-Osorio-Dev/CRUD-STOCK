using APP.Dtos.Requests;
using APP.Dtos.Responses;
using APP.Services.Api.Product;
using APP.Services.Navigation;
using APP.Util.CustomArgs;
using APP.Views.Register;
using MapsterMapper;

namespace APP.Presenters.Register
{
    internal class RegisterPresenter
    {
        private readonly IRegisterView _registerView;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public RegisterPresenter(IRegisterView registerView, IProductService productService, IMapper mapper)
        {
            _registerView = registerView;
            _productService = productService;
            _mapper = mapper;

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

            _registerView.CreatedProduct = _mapper.Map<ProductDTO>(response.Data);

            MessageBox.Show("O Produto " + response.Data.Name + " foi cadastrado com sucesso!",
                "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            _registerView.DialogResult = DialogResult.OK;

            return;
        }
    }
}
