using lesson_10.Business;
using System;
using System.Collections.Generic;

namespace lesson_10.DataAccess
{
    public class ProductRepository
    {
        public List<Product> Retrieve()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("produktas1", "nuostabus produktas", 12.99m));
            products.Add(new Product("produktas2", "prastesnis produktas", 3.99m));

            return products;
        }
    }
}
