﻿using System;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Product[] products = new Product[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите имя товара");
                string name = Console.ReadLine();
                Console.WriteLine("Введите цену товара");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите код товара");
                double code = Convert.ToDouble(Console.ReadLine());

                products[i] = new Product(name, price, code);

            }

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true,
            };


            string jsonString =  JsonSerializer.Serialize(products,options);
            using (StreamWriter sw = new StreamWriter("Products.json")) 
            {
                sw.WriteLine(jsonString);
            }
        }
    }
}
