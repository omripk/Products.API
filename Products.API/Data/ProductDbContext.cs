using Microsoft.EntityFrameworkCore;
using Products.API.EntityConfiguration;
using Products.API.Models;

namespace Products.API.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}