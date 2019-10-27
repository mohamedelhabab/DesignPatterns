using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.GangOfFour.Creational;
using DesignPatterns.GangOfFour.Creational.Builder;
using DesignPatterns.Models;

using DesignPatterns.Specification_Pattern;
using DesignPatterns.Specification_Pattern.Classes;
using static System.Console;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Open Closed Principle And Specification Pattern
            //Product apple = new Product("Apple", Color.Red, Size.Medium);
            //Product tree = new Product("Tree",Color.Green,Size.Large);
            //Product house = new Product("House", Color.Blue , Size.Large);

            //Product[] products = {apple, tree, house};


            ////old
            ////  ProductFilter pf = new ProductFilter();

            ////  Console.WriteLine("Large Products (old):");

            ////foreach (var p in pf.FilterBySize(products, Size.Large))
            ////{
            ////    Console.WriteLine(p.Name);
            ////}
            ////    Console.WriteLine("Green Products (old):");
            ////new 

            //IFilter<Product> filter = new SmartFilter();

            //Console.WriteLine("Green Products (new):");
            //foreach (var p in filter.Filter(products,new ColorSpecification(Color.Green)))
            //{
            //    Console.WriteLine($"{p.Name} is {p.Color}");
            //}

            //Console.WriteLine("Large Products (new):");
            //foreach (var p in filter.Filter(products, new SizeSpecification(Size.Large)))
            //{
            //    Console.WriteLine($"{p.Name} is {p.Size}");
            //}


            ////color and size
            //foreach (var p in filter.Filter(products,
            //    new AndSpecification<Product>(new ColorSpecification(Color.Blue),new SizeSpecification(Size.Large) )))
            //{
            //    Console.WriteLine($"{p.Name} Size is {p.Size} And Color Is {p.Color}");
            //} 
            #endregion


            #region Builder and simple fluent api Pattern
            // var words = new[] { "Hello", "World" };

            //Without Builder

            //var hello = "Hello";

            //var sp = new StringBuilder();

            //sp.Append("<p>");
            //sp.Append(hello);
            //sp.Append("</p>");
            //WriteLine(sp);

            //sp.Clear();
            //sp.Append("<ul>");

            //foreach (var item in words)
            //{
            //    sp.Append($"<li>{item}</li>");
            //}
            //sp.Append("<ul/>");

            //WriteLine(sp);

            //With Builder

            // HtmlBuilder htmlBuilder = new HtmlBuilder("ul", string.Empty);

            //Without Fluent Api (Builder)
            //foreach (var text in words)
            //{
            //    htmlBuilder.AddChild("li", text);

            //}

            //With Fluent Api (Builder) (returning an instance of the method Class)

            //htmlBuilder.AddChild("li", "Hello").AddChild("li","World");

            //WriteLine(htmlBuilder); 
            #endregion

            #region Fluent Builder Inhertiance With Recursive Generics

            // PersonJobBuilder personBuilder = new PersonJobBuilder();

            //WorksAsA() doesn't exist because the instance returned from called method 
            //is for the base class which doesn't know anything about child classes methods

            //  WriteLine(personBuilder.Called("Mohamed Elhabbab").WorksAsA());

            // WriteLine(personBuilder.Called("Mohamed").WorksAsA("Software Developer"));

            //var person = Person
            //                   .Instance
            //                   .Called("Mohamed")
            //                   .WorksAsA("Software Developer")
            //                   .Build();

            //CodeBuilder codeBuilder = new CodeBuilder("Person");

            //codeBuilder
            //    .AddField("Name", "string")
            //    .AddField("Age","int");



            //WriteLine(codeBuilder);
            #endregion

            #region Facated Builder For Employee

            EmployeeBuilder empBuilder = new EmployeeBuilder();

            Employee emp = empBuilder
                .Address
                .SetAddress("160 , 26 july St")
                .SetCity("Giza")
                .SetPostCode("12654")
                .Employement
                .WorksAt("ARPUPLUS")
                .WorksAs("Software Developer")
                .SetAnnualSalary(500000);

            WriteLine(emp);
                
            #endregion
            Console.Read();
        }
    }
}
