using Retail.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retail.Contracts.Customers
{
    public interface ICustomerRepository
    {
        bool AddCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool RemoveCustomer(Customer customer);

        ICollection<Customer> GetCustomersByRetailer(int retailerId);
        ICollection<Customer> GetCustomersById(int customerId);
    }
}
