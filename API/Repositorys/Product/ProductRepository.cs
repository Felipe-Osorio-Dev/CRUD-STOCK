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

        public async Task DeleteProductByIdAsync(ProductModel model)
        {
            _dbContext.Produtos.Remove(model);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductModel>> GetAllProductsAsync()
        {
            return await _dbContext.Produtos.ToListAsync();
        }

        public async Task<ProductModel?> GetProductByIdAsync(long id)
        {
            return await _dbContext.Produtos.FindAsync(id);
        }

        public async Task RegisterProductAsync(ProductModel model)
        {
            _dbContext.Produtos.Add(model);
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateProductAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
