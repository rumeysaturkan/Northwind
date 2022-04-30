using Microsoft.EntityFrameworkCore;
using NorthWind.Dal.Abstract;
using NorthWind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Dal.Concrete.EntityFramework.Repository
{
    public class CustomerRepository: GenericRepository<Customer>,ICustomerRepository
    {

        public CustomerRepository(DbContext context): base(context)
        {

        }

        public IQueryable<Customer> GetTotalReport()
        {
            return dbset.AsQueryable<Customer>();
        }
        public Customer Find(string id)
        {
            return dbset.Find(id);
        }
    }
}
