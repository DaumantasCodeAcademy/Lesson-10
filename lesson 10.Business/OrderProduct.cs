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
