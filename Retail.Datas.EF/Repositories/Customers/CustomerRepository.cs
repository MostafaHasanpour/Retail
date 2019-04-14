using Microsoft.EntityFrameworkCore;
using Retail.Contracts.Customers;
using Retail.Datas.EF.Commons;
using Retail.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
            try
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false; ;
            }
        }

        public Customer GetCustomerById(int customerId)
        {
            try
            {
                return _context.Customers.FirstOrDefault(x => x.CustomerId == customerId);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public ICollection<Customer> GetCustomersByRetailer(int retailerId)
        {
            try
            {
                return _context.Customers.Where(x => x.RetailerId == retailerId).ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool RemoveCustomer(Customer customer)
        {
            try
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                
                _context.Customers.Update(customer);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
