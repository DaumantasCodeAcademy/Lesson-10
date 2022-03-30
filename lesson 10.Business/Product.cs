using System;

namespace lesson_10.Business
{
    public class Product
    {
        public string Name { get; }
        public string Description { get; }
        public decimal CurrentPrice { get; }

        public Product(string name, string description, decimal currentPrice)
        {
            Name = name;
            Description = description;
            CurrentPrice = currentPrice;
        }

        public void Validate()
        {

        }
    }
}
