using lesson_10.Business;
using System;
using System.Collections.Generic;

namespace lesson_10.DataAccess
{
    public class OrderRepository
    {
        public OrderProductRepository OrdProdRep { get; }
        public ProductRepository ProdRep { get; }
        private List<Order> OrdersList { get; }

        public OrderRepository()
        {
            OrdProdRep = new OrderProductRepository();
            OrdersList = new List<Order>();
            ProdRep = new ProductRepository();
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

        public decimal CountPrice()
        {
            List<List<OrderProduct>> listas = OrdProdRep.Retrieve();
            decimal price = 0;
            for (int i = 0; i < listas.Count; i++)
            {
                for (int j = 0; j < listas[i].Count; j++)
                {
                    price += listas[i][j].Product.CurrentPrice * listas[i][j].Quantity;
                }
            }
            return price;
        }
    }
}
