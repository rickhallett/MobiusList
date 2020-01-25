using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobiusList.Core.Models;

namespace MobiusList.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
                .HasKey(c => c.CategoryId);
            
            builder
                .Property(c => c.CategoryId)
                .UseIdentityColumn();
            
            builder
                .Property(c => c.CategoryId)
                .IsRequired();
            
            builder
                .Property(c => c.Name)
                .IsRequired();

            builder
                .ToTable("Category");
        }
    }
}