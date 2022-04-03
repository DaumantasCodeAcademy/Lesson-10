using lesson_10.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_10.DataAccess
{
    public class OrderRepository
    {
        public List<OrderProduct> Retrieve()
        {
            ProductRepository getProducts = new ProductRepository();
            List<Product> products = getProducts.Retrieve();


            List<OrderProduct> orderedProducts = new List<OrderProduct>();
            orderedProducts.Add(new OrderProduct(products[0], 2));
            orderedProducts.Add(new OrderProduct(products[2], 3));
            orderedProducts.Add(new OrderProduct(products[4], 1));
            orderedProducts.Add(new OrderProduct(products[5], 1));

            return orderedProducts;
        }

        public decimal CountPrice()
        {
            List<OrderProduct> orderedProducts = Retrieve();
            decimal price = 0;
            for (int i = 0; i < orderedProducts.Count; i++)
            {
                price += orderedProducts[i].Product.CurrentPrice * orderedProducts[i].Quantity;
            }
            return price;
        }
    }
}
