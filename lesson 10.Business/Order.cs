using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10.Business
{
    public class Order
    {
        public List<OrderProduct> OrderProducts { get; }
        public DateTime OrderDate { get; }
        public string ShippingAdress { get; }
        
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
