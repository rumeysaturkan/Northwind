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
    public class RegionRepository : GenericRepository<Region>, IRegionRepository
    {
        public RegionRepository(DbContext context) : base(context)
        {
        }
    }
}
