using NorthWind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Entity.Dto
{
    public class DtoOrderSubtotal : DtoBase 
    {
        public int OrderId { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
