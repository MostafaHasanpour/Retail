using Retail.Entities;
using System;

namespace Retail.Contracts.Retailers
{
    public interface IRetailerRepository
    {
        bool AddRetailer(Retailer retailer);
        Retailer GetRetailer(int id);

    }
}
