using NorthWind.Entity.Dto;
using NorthWind.Entity.Models;
using NorthWind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Bll
{
    public class CustomerManager : GenericManager<Customer, DtoCustomer>, ICustomerService
    {
        //ICustomerRepository
        public IQueryable<DtoCustomer> GetTotalReport()
        {
            throw new NotImplementedException();
        }
    }
}
