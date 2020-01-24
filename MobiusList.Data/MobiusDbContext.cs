using Microsoft.EntityFrameworkCore;
using MobiusList.Core.Models;
using MobiusList.Data.Configurations;

namespace MobiusList.Data
{
    public class MobiusDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public MobiusDbContext(DbContextOptions<MobiusDbContext> options) 
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}