using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace SatvaPartyRegister.Data.Contract
{
    public interface IDataContext
    {
        IQueryable<T> Entities<T>() where T : class;
        IQueryable<T> EntitiesNoTracking<T>() where T : class;
        Task<bool> AnyAsync<T>(Expression<Func<T, bool>> predicate) where T : class;
        T GetById<T>(object id) where T : class;
        Task<T> GetByIdAsync<T>(object id) where T : class;
        void Insert<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void Delete<T>(IEnumerable<T> entity) where T : class;
        int SaveChanges();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
