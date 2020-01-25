using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MobiusList.Core.Models;

namespace MobiusList.Core.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task<IEnumerable<Product>> GetProductsByCategoryNameAsync(string name);
    }
}