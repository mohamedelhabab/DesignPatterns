using DesignPatterns.GangOfFour.Creational.Factory.Abstract.Interfaces;
using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creational.Factory.Abstract.Classes
{
    public class HotDrinkMachine
    {
        //available drinks and its corresponding factory objects
        private Dictionary<AvailableDrinks, IHotDrinkFactory>
        factories = new Dictionary<AvailableDrinks, IHotDrinkFactory>();

        string factoriesNameSpace;

        public HotDrinkMachine()
        {
            factoriesNameSpace = "DesignPatterns.GangOfFour.Creational.Factory.Abstract.Classes";

            //initialize the dicionary with the available drinks and its corresponding factory objects 
            //at the runtime using reflection

            foreach (AvailableDrinks drink in Enum.GetValues(typeof(AvailableDrinks)))
            {
                IHotDrinkFactory factory = (IHotDrinkFactory)Activator
                    .CreateInstance(Type.GetType($"{factoriesNameSpace}." +
                    $"{Enum.GetName(typeof(AvailableDrinks),drink)}" +
                    $"Factory"));

                factories.Add(drink,factory);
            }

        }

        public IHotDrink MakeDrink(AvailableDrinks drink, int amount)
        {
            return factories[drink].Prepare(amount);
        }

    }
}
