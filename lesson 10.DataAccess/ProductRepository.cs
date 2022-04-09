using lesson_10.Business;
using System.Collections.Generic;

namespace lesson_10.DataAccess
{
    public class ProductRepository
    {
        private List<Product> Products { get; }

        public ProductRepository()
        {
            Products = new List<Product>();

            Products.Add(new Product("jautiena", "nuostabus produktas", 12.99m));
            Products.Add(new Product("kede", "prastesnis produktas", 68.99m));
            Products.Add(new Product("kamuolys", "brangus produktas", 201.99m));
            Products.Add(new Product("stalas", "nuostabus produktas", 100.99m));
            Products.Add(new Product("vynuoges", "skanus produktas", 7.99m));
            Products.Add(new Product("duona", "pigus produktas", 3.99m));
        }

        public List<Product> Retrieve()
        {
            return Products;
        }

        public Product Retrieve(int productId)
        {
            return Products[productId];
        }
    }
}
