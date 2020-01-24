using System;
using System.Threading.Tasks;

namespace MobiusList.Core.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        Task<int> CommitAsync();
    }
}