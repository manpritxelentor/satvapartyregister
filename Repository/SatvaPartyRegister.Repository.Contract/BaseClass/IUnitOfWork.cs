using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SatvaPartyRegister.Repository.Contract.BaseClass
{
    public interface IUnitOfWork
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}
