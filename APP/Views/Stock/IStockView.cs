using APP.Dtos.Responses;
using APP.Util.CustomArgs;
using System.ComponentModel;

namespace APP.Views.Stock
{
    internal interface IStockView
    {
        BindingList<ProductDTO> Products { get; set; }
        event EventHandler LoadProducts;
        event EventHandler RegisterProduct;
        event EventHandler<CustomEventArgs<ProductDTO>> EditProduct;
    }
}
