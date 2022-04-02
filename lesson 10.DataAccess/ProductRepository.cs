﻿using lesson_10.Business;
using System;
using System.Collections.Generic;

namespace lesson_10.DataAccess
{
    public class ProductRepository
    {
        public List<Product> Retrieve()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product("jautiena", "nuostabus produktas", 12.99m));
            products.Add(new Product("kede", "prastesnis produktas", 68.99m));
            products.Add(new Product("kamuolys", "brangus produktas", 201.99m));
            products.Add(new Product("stalas", "nuostabus produktas", 100.99m));
            products.Add(new Product("vynuoges", "skanus produktas", 7.99m));
            products.Add(new Product("duona", "pigus produktas", 3.99m));

            return products;
        }
    }
}
