using NorthWind.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthWind.Entity.Models
{
    public partial class SalesByCategory:EntityBase
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal? ProductSales { get; set; }
    }
}
