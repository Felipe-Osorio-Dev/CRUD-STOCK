using API.Models.Product;
using Microsoft.EntityFrameworkCore;

namespace API.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) {}


        public DbSet<ProductModel> Produtos { get; set; }
    }
}
