using NorthWind.Entity.Dto;
using NorthWind.Entity.IBase;
using NorthWind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Interface
{
    public interface ICustomerService : IGenericService<Customer, DtoCustomer>
    {
        IResponse<IQueryable<DtoCustomer>> GetTotalReport();
        IResponse<DtoCustomer> Find(string id);


    }
}
