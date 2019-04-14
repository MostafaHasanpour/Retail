using Retail.Contracts.Retailers;
using Retail.Datas.EF.Commons;
using Retail.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Retail.Datas.EF.Repositories.Retailers
{
    public class RetailerRepository : BaseEfRepository, IRetailerRepository
    {
        public RetailerRepository(ApplicationDbContext context) : base(context)
        {
        }

        public bool AddRetailer(Retailer retailer)
        {
            try
            {
                _context.Retailers.Add(retailer);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public Retailer GetRetailer(int id)
        {
            try
            {
                return _context.Retailers.FirstOrDefault(x => x.RetailerId == id);
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
