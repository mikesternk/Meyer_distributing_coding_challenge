using System;
using InterviewTest.Products;

namespace InterviewTest.Orders
{
    public class OrderedProduct
    {
        public OrderedProduct(IProduct product)
        {
            Product = product;
            PurchaseDate = DateTime.Now;
        }

        public IProduct Product { get; set; }

        // Creating a property to store the date of the purchase
        public DateTime PurchaseDate {get;}
    }
}
