using APP.Dtos.Requests;
using APP.Dtos.Responses;
using APP.Util.CustomArgs;

namespace APP.Views.Register
{
    public interface IRegisterView
    {
        ProductDTO CreatedProduct { get; set; }
        DialogResult DialogResult { get; set; }
        event EventHandler<CustomEventArgs<RegisterProductDTO>> RegisterClicked;
    }
}
