using Retail.Contracts.Customers;
using Retail.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retail.Datas.EF.Repositories.Customers
{
    public class CustomerRepository : ICustomerRepository
    {
        public bool AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public ICollection<Customer> GetCustomersById(int customerId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Customer> GetCustomersByRetailer(int retailerId)
        {
            throw new NotImplementedException();
        }

        public bool RemoveCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
