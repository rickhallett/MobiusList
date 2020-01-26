using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MobiusList.Data.Models;

namespace MobiusList.Data.Services
{
    public class CategoryService : ICategoryService
    {
      

        public CategoryService()
        {
            
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<Category> CreateCategory(Category newCategory)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateCategory(Category categoryToBeUpdated, Category category)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}