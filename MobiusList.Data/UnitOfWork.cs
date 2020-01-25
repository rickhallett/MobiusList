using System.Threading.Tasks;
using MobiusList.Core.Repositories;
using MobiusList.Data.Repositories;

namespace MobiusList.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MobiusDbContext _context;
        private ProductRepository _productRepository;

        public UnitOfWork(MobiusDbContext context)
        {
            _context = context;
        }

        public IProductRepository Products =>
            _productRepository ??= new ProductRepository(_context);
        
        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }
        
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}