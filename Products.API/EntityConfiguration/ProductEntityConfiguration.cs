using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Products.API.Models;

namespace Products.API.EntityConfiguration
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(nameof(Product), nameof(Product));

            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Name).IsRequired();
        }
    }
}
