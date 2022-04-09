using lesson_10.Business;
using System.Collections.Generic;


namespace lesson_10.DataAccess
{
    public class OrderProductRepository
    {
        public ProductRepository productRepository { get; }
        public OrderRepository orderRepository { get; }
        private List<List<OrderProduct>> ordersList { get; }

        public OrderProductRepository()
        {
            productRepository = new ProductRepository();
            orderRepository = new OrderRepository();
            ordersList = new List<List<OrderProduct>>();

            List<OrderProduct> uniqueOrder1 = new List<OrderProduct>();
            uniqueOrder1.Add(new OrderProduct(productRepository.Retrieve(0), 3));
            uniqueOrder1.Add(new OrderProduct(productRepository.Retrieve(2), 1));
            uniqueOrder1.Add(new OrderProduct(productRepository.Retrieve(4), 2));
            ordersList.Add(uniqueOrder1);

            List<OrderProduct> uniqueOrder2 = new List<OrderProduct>();
            uniqueOrder1.Add(new OrderProduct(productRepository.Retrieve(1), 1));
            uniqueOrder1.Add(new OrderProduct(productRepository.Retrieve(2), 2));
            uniqueOrder1.Add(new OrderProduct(productRepository.Retrieve(3), 1));
            ordersList.Add(uniqueOrder2);
        }

        public List<List<OrderProduct>> Retrieve()
        {
            return ordersList;
        }

        public List<OrderProduct> Retrieve(int uniqueOrderListId)
        {
            return ordersList[uniqueOrderListId];
        }

        public OrderProduct Retrieve(int uniqueOrderNumber, int orderedProductNumber)
        {
            return ordersList[uniqueOrderNumber][orderedProductNumber];
        }
    }
}
