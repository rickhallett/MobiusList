using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MobiusList.Data.Configurations;
using MobiusList.Data.Models;

namespace MobiusList.Data
{
    public class MobiusDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<Order> Orders { get; set; }

        public MobiusDbContext(DbContextOptions<MobiusDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder) {}
    }
}