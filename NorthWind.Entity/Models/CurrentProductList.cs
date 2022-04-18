using NorthWind.Entity.Base;
using System;
using System.Collections.Generic;

#nullable disable

namespace NorthWind.Entity.Models
{
    public partial class CurrentProductList:EntityBase
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
