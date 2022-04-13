using NorthWind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Entity.Dto
{
    public class DtoCurrentProductList:DtoBase
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
