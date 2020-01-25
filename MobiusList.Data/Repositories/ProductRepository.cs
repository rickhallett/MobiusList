using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MobiusList.Core.Models;
using MobiusList.Core.Repositories;

namespace MobiusList.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private MobiusDbContext MobiusDbContext => Context as MobiusDbContext;
        
        public ProductRepository(DbContext context) : base(context)
        {
            
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await MobiusDbContext.Products.ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await MobiusDbContext.Products.SingleOrDefaultAsync(p => p.ProductNumber == id);
        }

        public async Task<IEnumerable<Product>> GetProductsByCategoryNameAsync(string name)
        {
            return await MobiusDbContext.Products.Where(p => p.Category.Name == name).ToListAsync();
        }
    }
}