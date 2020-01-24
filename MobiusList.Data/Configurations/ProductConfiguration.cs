using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobiusList.Core.Models;

namespace MobiusList.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasKey(p => p.ProductId);
            
            builder
                .Property(p => p.ProductId)
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
                .ToTable("Products");
        }
    }
}