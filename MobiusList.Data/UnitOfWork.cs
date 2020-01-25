using System.Threading.Tasks;
using MobiusList.Core.Repositories;
using MobiusList.Data.Repositories;

namespace MobiusList.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public MobiusDbContext context;
        
        private ProductRepository _productRepository;
        private CategoryRepository _categoryRepository;

        public UnitOfWork(MobiusDbContext context)
        {
            this.context = context;
        }

        public IProductRepository Products => _productRepository ??= new ProductRepository(context);

        public ICategoryRepository Categories => _categoryRepository ??= new CategoryRepository(context);

        public async Task<int> CommitAsync()
        {
            return await context.SaveChangesAsync();
        }
        
        public void Dispose()
        {
            context.Dispose();
        }
    }
}