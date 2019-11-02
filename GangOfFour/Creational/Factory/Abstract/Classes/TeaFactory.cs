using DesignPatterns.GangOfFour.Creational.Factory.Abstract.Classes;
using DesignPatterns.GangOfFour.Creational.Factory.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creational.Factory.Abstract.Classes
{
    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine("Preparing Tea Right Now !");

            return new Tea();
        }
    }
}
