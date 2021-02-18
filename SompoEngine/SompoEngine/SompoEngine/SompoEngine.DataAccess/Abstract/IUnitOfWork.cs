using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SompoEngine.DataAccess.Abstract
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IServiceRequestResponseRepo ServiceRequestResponse { get; }
        Task<int> SaveChangesAsync();
        int SaveChanges();
    }
}
