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
    public class ProductsAboveAveragePriceRepository : GenericRepository<ProductsAboveAveragePrice>, IProductsAboveAveragePriceRepository
    {
        public ProductsAboveAveragePriceRepository(DbContext context) : base(context)
        {
        }
    }
}
