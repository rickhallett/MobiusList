using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MobiusList.Core.Models;

namespace MobiusList.Core.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category> GetCategoryById(int id);
        Task<Category> CreateCategory(Category newCategory);
        Task UpdateCategory(Category categoryToBeUpdated, Category category);
        Task DeleteCategory(Category product);
    }
}