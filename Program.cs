using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace использование_дженериков
{
    public class Product<T>
    { 
        public T Price { get; set; }
        public string Name { get; set; }

        public Product(string name, T price)
        {
            Name = name;
            Price = price;
        }

        public void sell() 
        {
            Console.WriteLine("Вы продали " + Name + " за " + Price);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product<double> cheese = new Product<double>("Чедер", 150.34);
            cheese.sell();
            Console.ReadLine();
        }
    }
}
