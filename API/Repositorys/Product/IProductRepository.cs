using API.Models.Product;

namespace API.Repositorys.Product
{
    public interface IProductRepository
    {
        Task RegisterProductAsync(ProductModel model);
        Task<IEnumerable<ProductModel>> GetAllProductsAsync();
        Task<ProductModel?> GetProductByIdAsync(long id);
        Task DeleteProductByIdAsync(ProductModel model);
        Task UpdateProductAsync();
    }
}
