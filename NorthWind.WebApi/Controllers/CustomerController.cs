using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthWind.Entity.Base;
using NorthWind.Entity.Dto;
using NorthWind.Entity.IBase;
using NorthWind.Entity.Models;
using NorthWind.Interface;
using NorthWind.WebApi.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthWind.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ApiBaseController<ICustomerService, Customer, DtoCustomer>
    {
        private readonly ICustomerService customerService;
        public CustomerController(ICustomerService customerService) : base(customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet("GetTotalReport")] //abc.com/api/customer/GetTotalReport
        public IResponse<IQueryable<DtoCustomer>> GetTotalReport()
        {
            try
            {
                return customerService.GetTotalReport();
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
        [HttpGet("FindString")]
        public IResponse<DtoCustomer> Find(string id)
        {
            try
            {
                return customerService.Find(id);
            }
            catch (Exception ex)
            {
                return new Response<DtoCustomer>
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
        }
    }
}
