using System.Collections.Generic;
using System.Threading.Tasks;
using MobiusList.Data.Models;

namespace MobiusList.Data.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductById(int id);
        Task<IEnumerable<Product>> GetProductsByCategoryAsync(string name);
        Task<bool> CreateProductAsync(Product newProduct);
        Task UpdateProduct(Product productToBeUpdated, Product product);
        Task DeleteProduct(Product product);
    }
}