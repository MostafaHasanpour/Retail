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

        public Customer Get(int customerId)
        {
            return _customerRepository.GetCustomerById(customerId);
        }

        public List<Customer> GetAll(int retailerId)
        {
            return _customerRepository.GetCustomersByRetailer(retailerId);
        }

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

        public ReturnBackMessage Remove([FromBody]int customerId)
        {
            var message = "";
            var customer = _customerRepository.GetCustomerById(customerId);
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