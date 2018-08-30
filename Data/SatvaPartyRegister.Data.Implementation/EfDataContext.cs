using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SatvaPartyRegister.Data.Contract;
using SatvaPartyRegister.Data.Implementation.Configuration;
using SatvaPartyRegister.Utility.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

namespace SatvaPartyRegister.Data.Implementation
{
    public class EfDataContext : DbContext, IDataContext
    {
        private readonly ITenantProvider _tenantProvider;

        public EfDataContext(DbContextOptions options
            , ITenantProvider tenantProvider)
           : base(options)
        {
            _tenantProvider = tenantProvider;
        }

        public Task<bool> AnyAsync<T>(Expression<Func<T, bool>> predicate) where T : class
        {
            return Set<T>().AnyAsync(predicate);
        }

        public void Delete<T>(T entity) where T : class
        {
            Set<T>().Remove(entity);
        }

        public void Delete<T>(IEnumerable<T> entity) where T : class
        {
            Set<T>().RemoveRange(entity);
        }

        public IQueryable<T> Entities<T>() where T : class
        {
            return Set<T>();
        }

        public IQueryable<T> EntitiesNoTracking<T>() where T : class
        {
            return Set<T>().AsNoTracking();
        }

        public T GetById<T>(object id) where T : class
        {
            return Set<T>().Find(id);
        }

        public Task<T> GetByIdAsync<T>(object id) where T : class
        {
            return Set<T>().FindAsync(id);
        }

        public void Insert<T>(T entity) where T : class
        {
            Set<T>().Add(entity);
        }

        public Task InsertAsync<T>(T entity) where T : class
        {
            return Set<T>().AddAsync(entity);
        }

        void IDataContext.Update<T>(T entity)
        {
            // No code need over here
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var types = typeof(TenantEntityMap).Assembly.GetTypes()
                .Where(c => c.IsClass && !c.IsAbstract && !c.ContainsGenericParameters)
                .ToArray();
            foreach (var type in types)
            {
                // use type.Namespace to filter by namespace if necessary
                foreach (var iface in type.GetInterfaces())
                {
                    // if type implements interface IEntityTypeConfiguration<SomeEntity>
                    if (iface.IsConstructedGenericType && iface.GetGenericTypeDefinition() == typeof(IEntityTypeConfiguration<>))
                    {
                        //// make concrete ApplyConfiguration<SomeEntity> method
                        //var applyConcreteMethod = applyGenericMethod.MakeGenericMethod(iface.GenericTypeArguments[0]);
                        //// and invoke that with fresh instance of your configuration type
                        //applyConcreteMethod.Invoke(modelBuilder, new object[] { Activator.CreateInstance(type) });
                        dynamic instance = Activator.CreateInstance(type);
                        modelBuilder.ApplyConfiguration(instance);
                        break;
                    }
                }
            }
        }
    }
}
