using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MobiusList.Core.Models;

namespace MobiusList.Core.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductById(Guid id);
        Task<IEnumerable<Product>> GetProductByCategory(string name);
        Task<Product> CreateProduct(Product newProduct);
        Task UpdateProduct(Product productToBeUpdated, Product product);
        Task DeleteProduct(Product product);
    }
}