using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MobiusList.Core.Models;
using MobiusList.Core.Repositories;

namespace MobiusList.Data.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private MobiusDbContext MobiusDbContext => Context as MobiusDbContext;
        
        public CategoryRepository(DbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            return await MobiusDbContext.Category.ToListAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await MobiusDbContext.Category.FindAsync(id);
        }
    }
}