using NorthWind.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthWind.Entity.Models
{
    public partial class CategorySalesFor1997: EntityBase
    {
        public string CategoryName { get; set; }
        public decimal? CategorySales { get; set; }
    }
}
