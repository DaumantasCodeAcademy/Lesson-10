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
            Console.WriteLine();
            ProductRepository prodRep = new ProductRepository();
            List<Product> productsList = prodRep.Retrieve();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Turimų prekių sąrašas:");
            Console.ResetColor();
            Console.WriteLine();
            for (int i = 0; i < productsList.Count; i++)
            {
                Console.Write($"- {productsList[i].Name}, {productsList[i].Description}, {productsList[i].CurrentPrice}\r\n");
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------------------------------");
            Console.ResetColor();
            //--------------------------------------------------------------------
            // sukurti nauja uzsakyma ir atvaizduoti jo informacija su produktais
            //--------------------------------------------------------------------
            OrderRepository orderRepository = new OrderRepository();
            //List<Order> order = orderRepository.Retrieve();

            


            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Viso mokėti: ");
            Console.ResetColor();

            //Console.WriteLine(ordRep.CountPrice());
            Console.WriteLine();
            Console.WriteLine("Programa pasibaigia...");
            Console.ReadLine();
        }
    }
}
