using DesignPatterns.GangOfFour.Creational.Factory.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creational.Factory.Abstract.Classes
{
    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("Tchhh , Tea Is Served To You Now :)");
        }
    }
}
