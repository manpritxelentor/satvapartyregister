using SatvaPartyRegister.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatvaPartyRegister.Service.Contract
{
    public interface IAccountantAdvocateService
    {
        IQueryable<AccountantAdvocateListModel> GetAll();
        Task<AddUpdateAccountantAdvocateModel> GetByIdAsync(int id);
        Task<int> InsertAsync(int userId, AddUpdateAccountantAdvocateModel model);
        Task<int> UpdateAsync(int id, int userId, AddUpdateAccountantAdvocateModel model);
        Task<int> DeleteAsync(int id, int userId);
    }
}
