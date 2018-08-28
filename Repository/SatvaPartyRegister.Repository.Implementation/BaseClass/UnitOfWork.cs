using SatvaPartyRegister.Data.Contract;
using SatvaPartyRegister.Repository.Contract.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SatvaPartyRegister.Repository.Implementation.BaseClass
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDataContext _dataContext;

        public UnitOfWork(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public int SaveChanges()
        {
            return _dataContext.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return _dataContext.SaveChangesAsync(); 
        }
    }
}
