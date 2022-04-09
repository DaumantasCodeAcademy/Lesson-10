using lesson_10.Business;
using System;
using System.Collections.Generic;

namespace lesson_10.DataAccess
{
    public class OrderRepository
    {
        public OrderProductRepository OrdProdRep { get; }
        private List<Order> OrdersList { get; }

        public OrderRepository()
        {
            OrdProdRep = new OrderProductRepository();
            OrdersList = new List<Order>();

            OrdersList.Add(new Order(DateTime.Now, "abc", OrdProdRep.Retrieve()));
        }

        public List<Order> Retrieve()
        {
            return OrdersList;
        }

        public Order Retrieve(int ordersListUniqueOrderId)
        {
            return OrdersList[ordersListUniqueOrderId];
        }
    }
}
