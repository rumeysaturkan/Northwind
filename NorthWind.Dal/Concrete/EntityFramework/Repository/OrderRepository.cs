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
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(DbContext context) : base(context)
        {
        }
    }
}
