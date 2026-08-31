using API.DTO.Requests;
using API.DTO.Responses;
using API.Util.Result;

namespace API.Services.Product
{
    public interface IProductService
    {
        Task<Result<CreatedProductDTO>> RegisterProductAsync(RegisterProductDTO productDTO);
        Task<IEnumerable<ProductDTO>> GetAllProductsAsync();
        Task<Result<ProductDTO>> GetProductByIdAsync(long id);
    }
}
