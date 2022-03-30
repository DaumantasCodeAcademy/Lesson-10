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
            Console.WriteLine("Programa pasileidzia...");

            ProductRepository prodRep = new ProductRepository();
            List<Product> productsList = prodRep.Retrieve();

            for (int i = 0; i < productsList.Count; i++)
            {
                Console.Write($"{productsList[i].Name}, {productsList[i].Description}, {productsList[i].CurrentPrice}\r\n");
            }
            //--------------------------------------------------------------------
            // sukurti nauja uzsakyma ir atvaizduoti jo informacija su produktais
            //--------------------------------------------------------------------

            List<OrderProduct> products = new List<OrderProduct>();
            Order newOrder = new Order(DateTime.Now, "Klaipedos r., Slengiu km., Isgalvota g. 4", products);
            



            Console.WriteLine("Programa pasibaigia...");
        }
    }
}
