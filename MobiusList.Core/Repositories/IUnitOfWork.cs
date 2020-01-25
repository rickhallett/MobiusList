using System;
using System.Threading.Tasks;

namespace MobiusList.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }
        Task<int> CommitAsync();
    }
}