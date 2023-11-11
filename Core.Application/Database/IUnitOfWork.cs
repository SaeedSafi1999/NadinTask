using Core.Application.Repositories;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Application.Database;

public interface IUnitOfWork : IDisposable, IAsyncDisposable
{
    IProductRepository Availabilities { get; }
    

    int Commit();
    Task<int> CommitAsync(CancellationToken cancellationToken = default);
}