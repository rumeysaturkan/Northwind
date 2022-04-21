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
    public class OrdersQryRepository : GenericRepository<OrdersQry>, IOrdersQryRepository
    {
        public OrdersQryRepository(DbContext context) : base(context)
        {
        }
    }
}
