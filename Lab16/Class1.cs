using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Product
    {
        private string name;
        private double price;
        private double code;

        public string Name { get { return name; } set { name = value; } } 
        public double Price { get { return price; } set { price = value; } }
        public double Code { get { return code; } set { code = value; } }

        public Product(string name, double price, double code)
        { 
            Name = name;
            Price = price;  
            Code = code;    
        }
    }
}
