using System;
using System.Collections.Generic;

namespace lesson_10.Business
{
    public class Order
    {
        public DateTime OrderDate { get; }
        public string ShippingAdress { get; }
        public List<List<OrderProduct>> OrderProducts { get; }
        
        public Order(DateTime orderDate, string shippingAdress, List<List<OrderProduct>> orderProducts)
        {
            OrderDate = orderDate;
            ShippingAdress = shippingAdress;
            OrderProducts = orderProducts;
        }

        public void Validate()
        {

        }

        //public decimal CountPrice()
        //{

        //    decimal price = 0;
        //    for (int i = 0; i < orderedProducts.Count; i++)
        //    {
        //        price += orderedProducts[i].Product.CurrentPrice * orderedProducts[i].Quantity;
        //    }
        //    return price;
        //}
    }
}
