using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creational.Factory.Abstract.Interfaces
{
    //Second :- Build This Interface And Implement It Using Drinks Factories
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}
