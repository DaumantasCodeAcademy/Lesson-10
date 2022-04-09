using lesson_10.Business;
using System.Collections.Generic;


namespace lesson_10.DataAccess
{
    public class OrderProductRepository
    {
        public ProductRepository ProductRepository { get; }
        private List<List<OrderProduct>> OrdersList { get; }

        public OrderProductRepository()
        {
            ProductRepository = new ProductRepository();
            OrdersList = new List<List<OrderProduct>>();

            List<OrderProduct> uniqueOrder1 = new List<OrderProduct>();
            uniqueOrder1.Add(new OrderProduct(ProductRepository.Retrieve(0), 3));
            uniqueOrder1.Add(new OrderProduct(ProductRepository.Retrieve(2), 1));
            uniqueOrder1.Add(new OrderProduct(ProductRepository.Retrieve(4), 2));
            OrdersList.Add(uniqueOrder1);

            List<OrderProduct> uniqueOrder2 = new List<OrderProduct>();
            uniqueOrder2.Add(new OrderProduct(ProductRepository.Retrieve(1), 1));
            uniqueOrder2.Add(new OrderProduct(ProductRepository.Retrieve(2), 2));
            uniqueOrder2.Add(new OrderProduct(ProductRepository.Retrieve(3), 1));
            OrdersList.Add(uniqueOrder2);

            List<OrderProduct> uniqueOrder3 = new List<OrderProduct>();
            uniqueOrder3.Add(new OrderProduct(ProductRepository.Retrieve(4), 2));
            uniqueOrder3.Add(new OrderProduct(ProductRepository.Retrieve(0), 1));
            uniqueOrder3.Add(new OrderProduct(ProductRepository.Retrieve(2), 4));
            OrdersList.Add(uniqueOrder3);
        }

        public List<List<OrderProduct>> Retrieve()
        {
            return OrdersList;
        }

        public List<OrderProduct> Retrieve(int uniqueOrderListId)
        {
            return OrdersList[uniqueOrderListId];
        }

        public OrderProduct Retrieve(int uniqueOrderNumber, int orderedProductNumber)
        {
            return OrdersList[uniqueOrderNumber][orderedProductNumber];
        }
    }
}
