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
            List<Order> orders = orderRepository.Retrieve();
            Console.WriteLine($"Viso uzsakymu rinkiniu: {orders.Count}");

            OrderProductRepository orderProductRepository = new OrderProductRepository();
            List<List<OrderProduct>> listas = orderProductRepository.Retrieve();
            for (int i = 0; i < listas.Count; i++)
            {
                Console.WriteLine($"Uzsakymo nr.{i+1} duomenys:");
                for (int j = 0; j < listas[i].Count; j++)
                {
                    Console.WriteLine($"    Produktas: {listas[i][j].Product.Name}, Produkto aprašymas: {listas[i][j].Product.Description}, Produkto kaina/vnt.: {listas[i][j].Product.CurrentPrice}, Užsakytas kiekis: {listas[i][j].Quantity}");
                }
            }

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
