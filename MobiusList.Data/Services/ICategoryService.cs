using System.Collections.Generic;
using System.Threading.Tasks;
using MobiusList.Data.Models;

namespace MobiusList.Data.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategories();
        Task<Category> GetCategoryById(int id);
        bool HasCategory(string name);
        bool HasId(int id);
        Task<Category> CreateCategory(Category newCategory);
        Task UpdateCategory(Category categoryToBeUpdated, Category category);
        Task DeleteCategory(Category product);
    }
}