using APP.Dtos.Requests;
using APP.Util.CustomArgs;

namespace APP.Views.Register
{
    public interface IRegisterView
    {
        event EventHandler<CustomEventArgs<RegisterProductDTO>> RegisterClicked;
    }
}
