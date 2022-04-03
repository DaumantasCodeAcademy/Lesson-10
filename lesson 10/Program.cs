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
            //Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Turimų prekių sąrašas:");
            Console.ResetColor();
            Console.WriteLine();
            for (int i = 0; i < productsList.Count; i++)
            {
                Console.Write($"{productsList[i].Name}, {productsList[i].Description}, {productsList[i].CurrentPrice}\r\n");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------------------------------");
            Console.ResetColor();
            //--------------------------------------------------------------------
            // sukurti nauja uzsakyma ir atvaizduoti jo informacija su produktais
            //--------------------------------------------------------------------
            OrderRepository ordRep = new OrderRepository();
            List<OrderProduct> orderedProducts = ordRep.Retrieve();

            Order newOrder1 = new Order(DateTime.Now, "Miesto r., Kaimas km., Isgalvota g. 4", orderedProducts);

            Console.WriteLine($"Užsakymo data: {newOrder1.OrderDate}");
            Console.WriteLine($"Užsakymo adresas: {newOrder1.ShippingAdress}");
            Console.WriteLine($"Užsakyti produktai:");
            for (int i = 0; i < orderedProducts.Count; i++)
            {
                Console.Write($"- {orderedProducts[i].Product.Name}, kiekis: {orderedProducts[i].Quantity}, kaina/vnt.: {orderedProducts[i].Product.CurrentPrice}, kaina/viso: {orderedProducts[i].Quantity * orderedProducts[i].Product.CurrentPrice}\r\n");
            }
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Viso mokėti: ");
            Console.ResetColor();

            Console.WriteLine(ordRep.CountPrice());
            Console.WriteLine();
            Console.WriteLine("Programa pasibaigia...");
            Console.ReadLine();
        }
    }
}
