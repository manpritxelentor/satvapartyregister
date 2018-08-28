using SatvaPartyRegister.Domain.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SatvaPartyRegister.Repository.Contract.BaseClass
{
    public interface IGenericRepository<T>
        where T : BaseEntity
    {
        IQueryable<T> Table { get; }
        IQueryable<T> TableNoTracking { get; }
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        T GetById(object id);
        Task<T> GetByIdAsync(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(IEnumerable<T> entity);
    }
}
