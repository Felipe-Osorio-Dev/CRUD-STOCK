using API.Models.Product;

namespace API.Repositorys.Product
{
    public interface IProductRepository
    {
        Task RegisterProductAsync(ProductModel product);
        Task<IEnumerable<ProductModel>> GetAllProductsAsync();
        Task<ProductModel?> GetProductByIdAsync(long id);
    }
}
