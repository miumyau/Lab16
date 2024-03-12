
using System.Text.Json;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;

            using (StreamReader sr = new StreamReader("../../../../Products.json"))
            {
                 jsonString = sr.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);
            Console.WriteLine(  );
            Product maxprice = products[0];
            foreach (Product product in products) 
            {
                if (product.Price > maxprice.Price)
                { maxprice = product; }

            }
            Console.WriteLine($"Цена самoго дорогого товара {maxprice.Price}");
            Console.ReadKey();

        }
    }

    
}
