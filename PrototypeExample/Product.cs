using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeExample
{
    public class Product : IPrototype<Product>
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Product Clone()
        {
            return new Product(Name, Price);
        }

        public override string ToString()
        {
            return $"Product: {Name}, Price: {Price:C}";
        }
    }
}
