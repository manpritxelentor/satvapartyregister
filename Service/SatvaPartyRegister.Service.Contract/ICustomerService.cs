using SatvaPartyRegister.Model;
using System.Linq;

namespace SatvaPartyRegister.Service.Contract
{
    public interface ICustomerService
    {
        IQueryable<CustomerListModel> GetAll();
    }
}
