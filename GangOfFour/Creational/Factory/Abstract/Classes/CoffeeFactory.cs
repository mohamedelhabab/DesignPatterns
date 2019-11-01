using DesignPatterns.GangOfFour.Creational.Factory.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creational.Factory.Abstract.Classes
{
    internal class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine("Preparing Coffee Right Now !");

            return new Coffee();
        }
    }
}
