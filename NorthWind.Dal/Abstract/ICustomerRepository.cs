using NorthWind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Dal.Abstract
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> GetTotalReport();
        Customer Find(string id);
    }
}
