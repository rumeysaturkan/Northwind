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
    public class CategoryManager : GenericManager<Category, DtoCategory>, ICategoryService
    {
        public CategoryManager(IServiceProvider service) : base(service)
        {
        }
    }
}
