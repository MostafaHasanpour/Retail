using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Retail.Entities;
using System;
using System.Collections.Generic;

namespace Retail.Datas.EF
{
    public class ApplicationDbContext : DbContext
    {
        public ISet<Retailer> Retailers { get; set; }
        public ISet<Customer> Customers { get; set; }

        public ApplicationDbContext( DbContextOptions options) : base(options)
        {
        }

        protected ApplicationDbContext()
        {
        }
    }
}
