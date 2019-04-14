using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Retail.Entities;
using System;
using System.Collections.Generic;

namespace Retail.Datas.EF.Commons
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Retailer> Retailers { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public ApplicationDbContext( DbContextOptions options) : base(options)
        {
        }

        protected ApplicationDbContext()
        {
        }
    }
}
