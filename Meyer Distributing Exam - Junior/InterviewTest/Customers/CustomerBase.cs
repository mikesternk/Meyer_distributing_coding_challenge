using System;
using System.Collections.Generic;
using System.Linq;
using InterviewTest.Orders;
using InterviewTest.Returns;

namespace InterviewTest.Customers
{
    public abstract class CustomerBase : ICustomer
    {
        private readonly OrderRepository _orderRepository;
        private readonly ReturnRepository _returnRepository;

        protected CustomerBase(OrderRepository orderRepo, ReturnRepository returnRepo)
        {
            _orderRepository = orderRepo;
            _returnRepository = returnRepo;
        }

        public abstract string GetName();
        
        public void CreateOrder(IOrder order)
        {
            _orderRepository.Add(order);
        }

        public List<IOrder> GetOrders()
        {
            return _orderRepository.Get();
        }

        public void CreateReturn(IReturn rga)
        {
            _returnRepository.Add(rga);
        }

        public List<IReturn> GetReturns()
        {
            return _returnRepository.Get();
        }

        public float GetTotalSales()
        {
            // throw new NotImplementedException();
            // Get the sum of all the sales in each order
            return GetOrders().Sum(order => order.Products.Sum(product => product.Product.GetSellingPrice()));
        }

        public float GetTotalReturns()
        {
            // throw new NotImplementedException();
            // Get the total returns 
            return GetReturns().Sum(returnItem => returnItem.ReturnedProducts.Sum(returnedProduct => returnedProduct.OrderProduct.Product.GetSellingPrice()));

        }

        public float GetTotalProfit()
        {
            throw new NotImplementedException();
        }
    }
}
