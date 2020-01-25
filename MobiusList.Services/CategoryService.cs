using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MobiusList.Core.Models;
using MobiusList.Core.Repositories;
using MobiusList.Core.Services;

namespace MobiusList.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _unitOfWork.Categories.GetAllAsync();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _unitOfWork.Categories.SingleOrDefaultAsync(p => p.CategoryId == id);
        }

        public async Task<Category> CreateCategory(Category newCategory)
        {
            await _unitOfWork.Categories.AddAsync(newCategory);
            await _unitOfWork.CommitAsync();
            return newCategory;
        }

        public async Task UpdateCategory(Category categoryToBeUpdated, Category category)
        {
            categoryToBeUpdated.Name = category.Name;

            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteCategory(Category category)
        {
            _unitOfWork.Categories.Remove(category);

            await _unitOfWork.CommitAsync();
        }
    }
}