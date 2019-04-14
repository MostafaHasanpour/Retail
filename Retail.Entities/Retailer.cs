using System;
using System.Collections.Generic;

namespace Retail.Entities
{
    public class Retailer
    {
        public int RetailerId { get; set; }
        public string RetailerName { get; set; }
        public bool HypassRestriction { get; set; }
        public ICollection<Customer> Customers { get; set; }
    }
}
