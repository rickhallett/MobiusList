using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MobiusList.Core.Models;
using MobiusList.Data.Configurations;

namespace MobiusList.Data
{
    public class MobiusDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Category { get; set; }

        public MobiusDbContext(DbContextOptions<MobiusDbContext> options) 
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

//            modelBuilder.Entity<Category>().HasData(new List<Category>
//            {
//                new Category
//                {
//                    CategoryId = Guid.NewGuid(),
//                    Name = "Device"
//                },
//                new Category
//                {
//                    CategoryId = Guid.NewGuid(),
//                    Name = "Peripheral"
//                },
//                new Category
//                {
//                    CategoryId = Guid.NewGuid(),
//                    Name = "Education"
//                },
//            });
//
//            modelBuilder.Entity<Product>().HasData(new List<Product>
//            {
//                new Product
//                {
//                    Name = "Macbook Pro",
//                    Category = Categories.SingleOrDefault(c => c.Name == "Device")
//                }
//            });
        }
    }
}