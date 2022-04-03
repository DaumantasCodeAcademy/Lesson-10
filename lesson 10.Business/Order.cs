using System;
using System.Collections.Generic;

namespace lesson_10.Business
{
    public class Order
    {
        public DateTime OrderDate { get; }
        public string ShippingAdress { get; }
        public List<OrderProduct> OrderProducts { get; }
        
        public Order(DateTime orderDate, string shippingAdress, List<OrderProduct> orderProducts)
        {
            OrderDate = orderDate;
            ShippingAdress = shippingAdress;
            OrderProducts = orderProducts;
        }

        public void Validate()
        {

        }
    }
}
