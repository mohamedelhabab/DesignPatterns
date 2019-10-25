using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Models;
using DesignPatterns.Specification_Pattern;
using DesignPatterns.Specification_Pattern.Classes;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Product apple = new Product("Apple", Color.Red, Size.Medium);
            Product tree = new Product("Tree",Color.Green,Size.Large);
            Product house = new Product("House", Color.Blue , Size.Large);

            Product[] products = {apple, tree, house};


            //old
            //  ProductFilter pf = new ProductFilter();

            //  Console.WriteLine("Large Products (old):");

            //foreach (var p in pf.FilterBySize(products, Size.Large))
            //{
            //    Console.WriteLine(p.Name);
            //}
            //    Console.WriteLine("Green Products (old):");
            //new 

            IFilter<Product> filter = new SmartFilter();

            Console.WriteLine("Green Products (new):");
            foreach (var p in filter.Filter(products,new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($"{p.Name} is {p.Color}");
            }

            Console.WriteLine("Large Products (new):");
            foreach (var p in filter.Filter(products, new SizeSpecification(Size.Large)))
            {
                Console.WriteLine($"{p.Name} is {p.Size}");
            }


            //color and size
            foreach (var p in filter.Filter(products,
                new AndSpecification<Product>(new ColorSpecification(Color.Blue),new SizeSpecification(Size.Large) )))
            {
                Console.WriteLine($"{p.Name} Size is {p.Size} And Color Is {p.Color}");
            }
            Console.Read();
        }
    }
}
