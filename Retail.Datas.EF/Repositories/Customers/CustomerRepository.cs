using Retail.Contracts.Customers;
using Retail.Datas.EF.Commons;
using Retail.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Retail.Datas.EF.Repositories.Customers
{
    public class CustomerRepository : BaseEfRepository, ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext context) : base(context)
        {
        }

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
