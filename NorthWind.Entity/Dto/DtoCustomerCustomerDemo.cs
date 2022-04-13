using NorthWind.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Entity.Dto
{
    public class DtoCustomerCustomerDemo:DtoBase
    {
        public string CustomerId { get; set; }
        public string CustomerTypeId { get; set; }
    }
}
