using lesson_10.Business;
using lesson_10.DataAccess;
using System;
using System.Collections.Generic;

namespace lesson_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa pasileidžia...");

            ProductRepository prodRep = new ProductRepository();
            List<Product> productsList = prodRep.Retrieve();
            Console.WriteLine();
            Console.WriteLine("Turimų prekių sąrašas:");
            Console.WriteLine();
            for (int i = 0; i < productsList.Count; i++)
            {
                Console.Write($"{productsList[i].Name}, {productsList[i].Description}, {productsList[i].CurrentPrice}\r\n");
            }
            //--------------------------------------------------------------------
            // sukurti nauja uzsakyma ir atvaizduoti jo informacija su produktais
            //--------------------------------------------------------------------
            List<OrderProduct> orderProduct = new List<OrderProduct>();
            
            OrderProduct orderedProduct1 = new OrderProduct(productsList[0], 3);
            OrderProduct orderedProduct2 = new OrderProduct(productsList[2], 1);
            OrderProduct orderedProduct3 = new OrderProduct(productsList[productsList.Count - 1], 2);

            orderProduct.Add(orderedProduct1);
            orderProduct.Add(orderedProduct2);
            orderProduct.Add(orderedProduct3);

            Order newOrder1 = new Order(DateTime.Now, "Miesto r., Kaimas km., Isgalvota g. 4", orderProduct);

            Console.WriteLine();
            Console.WriteLine($"Užsakymo data: {newOrder1.OrderDate}");
            Console.WriteLine($"Užsakymo adresas: {newOrder1.ShippingAdress}");
            Console.WriteLine($"Užsakyti produktai:");
            for (int i = 0; i < orderProduct.Count; i++)
            {
                Console.Write($"Produktas: {orderProduct[i].Product.Name}, kiekis: {orderProduct[i].Quantity}, kaina: {orderProduct[i].Product.CurrentPrice}\r\n");
            }
            Console.WriteLine();
            Console.Write("Viso mokėti: ");

            decimal price = 0;
            for (int i = 0; i < orderProduct.Count; i++)
            {
                price += orderProduct[i].Product.CurrentPrice * orderProduct[i].Quantity;
            }
            Console.Write(price);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Programa pasibaigia...");
            Console.ReadLine();
        }
    }
}
