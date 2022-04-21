using NorthWind.Entity.Dto;
using NorthWind.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Interface
{
    public interface IProductsAboveAveragePriceService:IGenericService<ProductsAboveAveragePrice, DtoProductsAboveAveragePrice>
    {
    }
}
