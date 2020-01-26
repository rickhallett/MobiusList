using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MobiusList.Data;
using MobiusList.Data.Models;
using MobiusList.Data.Services;


namespace MobiusList.Services
{
    public class ProductService: IProductService
    {
        private readonly MobiusDbContext _context;
        
        public ProductService(MobiusDbContext mobiusDbContext)
        {
            _context = mobiusDbContext;
        }
        
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _context.Products.Include(p => p.Category).ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetProductsByCategory(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> CreateProduct(Product newProduct)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateProduct(Product productToBeUpdated, Product product)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}