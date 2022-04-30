using Northwind.Bll;
using NorthWind.Dal.Abstract;
using NorthWind.Entity.Dto;
using NorthWind.Entity.Models;
using NorthWind.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using NorthWind.Entity.IBase;
using NorthWind.Entity.Base;
using Microsoft.AspNetCore.Http;

namespace NorthWind.Bll
{
    public class CustomerManager : GenericManager<Customer, DtoCustomer>, ICustomerService
    {
        public readonly ICustomerRepository customerRepository;

        public CustomerManager(IServiceProvider service) : base(service)
        {
            customerRepository = service.GetService<ICustomerRepository>();
        }

        public IResponse<IQueryable<DtoCustomer>> GetTotalReport()
        {
            try
            {
                var list = customerRepository.GetTotalReport();
                var listDto = list.Select(x => ObjectMapper.Mapper.Map<DtoCustomer>(x));
                return new Response<IQueryable<DtoCustomer>>
                {
                    StatusCode = StatusCodes.Status200OK,
                    Message = "Success",
                    Data = listDto
                };
            }
            catch (Exception ex)
            {
                return new Response<IQueryable<DtoCustomer>>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }
public IResponse<DtoCustomer> Find(string id)
    {
        try
        {
            var entity = ObjectMapper.Mapper.Map<DtoCustomer>(customerRepository.Find(id));
            return new Response<DtoCustomer>
            {
                StatusCode = StatusCodes.Status200OK,
                Message = "success",
                Data = entity
            };
        }
        catch (Exception ex)
        {

            return new Response<DtoCustomer>
            {
                StatusCode = StatusCodes.Status500InternalServerError,
                Message = $"error:{ex.Message}",
                Data = null
            };
        }

    }
       
    }
    
}
