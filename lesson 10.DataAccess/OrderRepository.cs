using lesson_10.Business;
using System;
using System.Collections.Generic;

namespace lesson_10.DataAccess
{
    public class OrderRepository
    {
        public OrderProductRepository ordProdRep { get; }
        private List<Order> ordersList { get; }

        public OrderRepository()
        {
            ordProdRep = new OrderProductRepository();
            ordersList = new List<Order>();

            ordersList.Add(new Order(DateTime.Now, "abc", ordProdRep.Retrieve()));
        }

        public List<Order> Retrieve()
        {
            return ordersList;
        }

        public Order Retrieve(int ordersListUniqueOrderId)
        {
            return ordersList[ordersListUniqueOrderId];
        }
    }
}
