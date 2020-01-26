using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobiusList.Data.Models;

namespace MobiusList.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasKey(p => p.ProductNumber);
            
            builder
                .Property(p => p.ProductNumber)
                .UseIdentityColumn();
            
            builder
                .Property(p => p.ProductNumber)
                .IsRequired();
            
            builder
                .Property(p => p.Name)
                .IsRequired();

            builder
                .HasOne(p => p.Category);

            builder
                .ToTable("Product");
        }
    }
}