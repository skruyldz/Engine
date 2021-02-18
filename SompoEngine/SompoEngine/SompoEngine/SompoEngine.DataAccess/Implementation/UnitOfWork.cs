using Microsoft.EntityFrameworkCore;
using SompoEngine.DataAccess.Abstract;
using SompoEngine.DataAccess.Implementation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SompoEngine.DataAccess.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SompoengineContext _ctx;
        private ServiceRequestResponseRepo serviceRepository; 
        public UnitOfWork(SompoengineContext ctx)
        {
            _ctx = ctx;
        }
        public IServiceRequestResponseRepo ServiceRequestResponse => serviceRepository ?? new ServiceRequestResponseRepo(_ctx);

        public async ValueTask DisposeAsync()
        {
            await _ctx.DisposeAsync();
        }

        public int SaveChanges()
        {
            ProcessEntityControl();
            if (!_ctx.ChangeTracker.Entries().Any(x => x.State == EntityState.Modified || x.State == EntityState.Deleted || x.State == EntityState.Added))
                return 1;
            return _ctx.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            ProcessEntityControl();
            if (!_ctx.ChangeTracker.Entries().Any(p => p.State == EntityState.Modified || p.State == EntityState.Deleted || p.State == EntityState.Added))
                return 1;
            return await _ctx.SaveChangesAsync();
        }
        private void ProcessEntityControl()
        {
            var auditEntities = _ctx.ChangeTracker.Entries().Where(x => x.State != EntityState.Unchanged).Select(x => new { x.Entity, x.State });
            if (auditEntities != null)
            {
                foreach (var obj in auditEntities)
                {
                    var auditEntity = obj.Entity;
                    var properties = auditEntities.GetType()
                                                  .GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public)
                                                  .Where(x => x.CanWrite).ToDictionary(x => x.Name, x => x);
                    if (obj.State == EntityState.Added || obj.State == EntityState.Detached)
                    {
                        if (properties.ContainsKey("CreateDate"))
                            properties["CreateDate"].SetValue(auditEntity, DateTime.Now); 
                    }
                    if (properties.ContainsKey("UpdatedDate"))
                        properties["UpdateDate"].SetValue(auditEntity, DateTime.Now); 
                }
            }
        }
    }
}
