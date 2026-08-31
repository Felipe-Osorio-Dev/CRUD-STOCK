using API.DataContext;
using API.Models.Product;
using Microsoft.EntityFrameworkCore;

namespace API.Repositorys.Product
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _dbContext;

        public ProductRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<ProductModel>> GetAllProductsAsync()
        {
            return await _dbContext.Produtos.ToListAsync();
        }

        public async Task<ProductModel?> GetProductByIdAsync(long id)
        {
            return await _dbContext.Produtos.FindAsync(id);
        }

        public async Task RegisterProductAsync(ProductModel product)
        {
            _dbContext.Produtos.Add(product);
            await _dbContext.SaveChangesAsync();
        }
    }
}
