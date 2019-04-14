namespace Retail.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int RetailerId { get; set; }
        public Retailer Retailer { get; set; }
    }
}
