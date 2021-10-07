﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            System.Globalization.CultureInfo.CurrentCulture = new System.Globalization.CultureInfo("en-US");

            try
            {
                Product product1 = new Product("Apple", 5.50, 0.120, 5, new DateTime(2021, 9, 30));
                Product product2 = new Product("Sugar", 30, 1, 10, new DateTime(2021, 7, 31));
                Product product3 = new Product("Bread", 15, 0.5, 7, new DateTime(2021, 10, 6));

                List<Product> list = new List<Product>() { product1, product2, product3 };
                Buy buy = new Buy(list, list.Count);

                Check check = new Check();
                Console.WriteLine(check.PrintBuy(buy));
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            try
            {
                Storage storage = new Storage();
                storage.ReadInput();
                Console.Write("Enter path to output removed dairy products: ");
                storage.RemoveDairyProduct(Console.ReadLine());
                Console.WriteLine(storage.Print());
            }
            catch (FileNotFoundException exception)
            {
                Console.WriteLine("Error in Storage: " + exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error in Storage: " + exception.Message);
            }
        }
    }
}
