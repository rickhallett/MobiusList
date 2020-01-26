using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MobiusList.Data.Models;

namespace MobiusList.Data.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly MobiusDbContext _context;

        public CategoryService(MobiusDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _context.Category.ToListAsync();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _context.Category.FindAsync(id);
        }

        public bool HasId(int id)
        {
            return _context.Category.Any(c => c.Id == id);
        }

        public bool HasCategory(string name)
        {
            return _context.Category.Any(c => c.Name == name);
        }

        public async Task<bool> CreateCategoryAsync(Category newCategory)
        {
            await _context.Category.AddAsync(newCategory);
            
            var changes = await _context.SaveChangesAsync();

            return changes > 0;
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