﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            throw new NotImplementedException();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            throw new NotImplementedException();
        }

        public bool HasCategory(string name)
        {
            return _context.Category.Any(c => c.Name == name);
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