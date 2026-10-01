using APP.Dtos.Requests;
using APP.Dtos.Responses;
using APP.Util.Result;

namespace APP.Services.Api.Product
{
    internal interface IProductService
    {
        Task<Result<CreatedProductDTO>> RegisterProductAsync(RegisterProductDTO dto);
        Task<Result<List<ProductDTO>>> GetAllProductsAsync();
        Task<Result<ProductDTO>> PatchProductAsync(EditProductDTO dto);
        Task<Result<ProductDTO>> PutProductAsync(EditProductDTO dto);
    }
}
