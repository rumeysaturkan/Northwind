using Northwind.Bll;
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
    public class ShipperManager : GenericManager<Shipper, DtoShipper>, IShipperService
    {
        public ShipperManager(IServiceProvider service) : base(service)
        {
        }
    }
}
