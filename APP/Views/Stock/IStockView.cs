using APP.Dtos.Responses;
using System.ComponentModel;

namespace APP.Views.Stock
{
    internal interface IStockView
    {
        BindingList<ProductDTO> Products { get; set; }
        event EventHandler LoadProducts;
        event EventHandler RegisterProduct;
    }
}
