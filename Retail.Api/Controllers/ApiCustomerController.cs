using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Retail.Api.Infrastructures;
using Retail.Contracts.Customers;
using Retail.Entities;

namespace Retail.Api.Controllers
{
    [Route("api/Customer")]
    [ApiController]
    public class ApiCustomerController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public ApiCustomerController(ICustomerRepository customerRepository)
        {
            this._customerRepository = customerRepository;
        }

        [HttpPost("Get")]
        public Customer GetCustomer([FromBody]CustomerRequest customer)
        {
            return _customerRepository.GetCustomerById(customer.CustomerId);
        }

        [HttpPost("GetAll")]
        public List<Customer> GetAllCustomer([FromBody]CustomerListRequest customer)
        {
            return _customerRepository.GetCustomersByRetailer(customer.RetailerId);
        }

        [HttpPost("Add")]
        public ReturnBackMessage Add([FromBody]Customer customer)
        {
            var message = "";
            if (_customerRepository.AddCustomer(customer))
            {
                message = "Successfully";
            }
            else
                message = "Failure";
            return new ReturnBackMessage(message);
        }

        [HttpPost("Update")]
        public ReturnBackMessage Update([FromBody]Customer customer)
        {
            var message = "";
            if (_customerRepository.UpdateCustomer(customer))
            {
                message = "Successfully";
            }
            else
                message = "Failure";
            return new ReturnBackMessage(message);
        }

        [HttpPost("Remove")]
        public ReturnBackMessage Remove([FromBody]CustomerRequest customerrequest)
        {
            var message = "";
            var customer = _customerRepository.GetCustomerById(customerrequest.CustomerId);
            if (_customerRepository.RemoveCustomer(customer))
            {
                message = "Successfully";
            }
            else
                message = "Failure";
            return new ReturnBackMessage(message);
        }
    }
}