using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10.Business
{
    public class OrderProduct
    {
        public Product Product { get; }
        public int Quantity { get; }

        public OrderProduct(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
