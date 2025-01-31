﻿using SatvaPartyRegister.Data.Contract;
using SatvaPartyRegister.Domain.BaseClass;
using SatvaPartyRegister.Repository.Contract.BaseClass;
using SatvaPartyRegister.Utility.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SatvaPartyRegister.Repository.Implementation.BaseClass
{
    public class GenericRepository<T> : IGenericRepository<T>
        where T : BaseAuditableTenantEntity
    {
        private readonly IDataContext _dataContext;
        private readonly ITenantProvider _tenantProvider;

        public GenericRepository(IDataContext dataContext
            , ITenantProvider tenantProvider)
        {
            _dataContext = dataContext;
            _tenantProvider  = tenantProvider;
        }

        public IQueryable<T> Table => _dataContext.Entities<T>();

        public IQueryable<T> TableNoTracking => _dataContext.EntitiesNoTracking<T>();

        public Task<bool> AnyAsync(Expression<Func<T, bool>> predicate)
        {
            return _dataContext.AnyAsync<T>(predicate);
        }

        public void Delete(T entity)
        {
            _dataContext.Delete(entity);
        }

        public void Delete(IEnumerable<T> entity)
        {
            _dataContext.Delete(entity);
        }

        public T GetById(object id)
        {
            return _dataContext.GetById<T>(id);
        }

        public Task<T> GetByIdAsync(object id)
        {
            return _dataContext.GetByIdAsync<T>(id);
        }

        public void Insert(T entity)
        {
            entity.CreatedOn = DateTime.Now;
            entity.IsActive = true;
            entity.IsDeleted = false;
            entity.TenantId = _tenantProvider.TenantId;
            _dataContext.Insert<T>(entity);
        }

        public void Update(T entity)
        {
            entity.ModifiedOn = DateTime.Now;
            _dataContext.Update<T>(entity);
        }
    }
}
