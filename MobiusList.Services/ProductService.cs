using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MobiusList.Core.Models;
using MobiusList.Core.Repositories;
using MobiusList.Core.Services;

namespace MobiusList.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        
        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var products = await _unitOfWork.Products.GetAllAsync();
            foreach (var product in products)
            {
                
            }
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _unitOfWork.Products.SingleOrDefaultAsync(p => p.ProductNumber == id);
        }

        public async Task<IEnumerable<Product>> GetProductsByCategory(string name)
        {
            return await _unitOfWork.Products.GetProductsByCategoryNameAsync(name);
        }

        public async Task<Product> CreateProduct(Product newProduct)
        {
            await _unitOfWork.Products.AddAsync(newProduct);
            await _unitOfWork.CommitAsync();
            return newProduct;
        }

        public async Task UpdateProduct(Product productToBeUpdated, Product product)
        {
            productToBeUpdated.Name = product.Name;
            productToBeUpdated.Description = product.Description;
            productToBeUpdated.Price = product.Price;
            productToBeUpdated.Category = product.Category;

            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteProduct(Product product)
        {
            _unitOfWork.Products.Remove(product);
            await _unitOfWork.CommitAsync();
        }
    }
}