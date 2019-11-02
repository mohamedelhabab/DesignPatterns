using DesignPatterns.GangOfFour.Creational.Factory.Abstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creational.Factory.Abstract.Classes
{
    //The class fix the violation of the open closed princible which caused by the HotDrinkMachine class.
    //it will search for the newly added factories using reflection then added them to the factories list.
    public class HotDrinkMachine_OCP
    {
        private List<Tuple<string, IHotDrinkFactory>> 
        factories  = new List<Tuple<string, IHotDrinkFactory>>();

        public HotDrinkMachine_OCP()
        {
            //change this according to where the factories exist
            // it's configured right now to search in the current assembly only
            var currentAssemblyTypes = typeof(HotDrinkMachine_OCP).Assembly.GetTypes();

            foreach (var type in currentAssemblyTypes)
            {
                //if this type implement IHotDrinkFactory and not an interface
                //it is considered as a valid factory then add it to factories list

                if (typeof(IHotDrinkFactory).IsAssignableFrom(type)
                    && !type.IsInterface)
                {
                    factories.Add(Tuple.Create(type.Name.Replace("Factory", string.Empty),
                                              (IHotDrinkFactory)Activator.CreateInstance(type)));
                }
            }

        }

        public IHotDrink MakeDrink()
        {
            //Display available drinks
            Console.WriteLine("Available Drinks :");
            for (int i = 0; i < factories.Count; i++)
            {
                Console.WriteLine($"{i} : {factories[i].Item1}");
            }

            Console.WriteLine("Please Choose A Drink ! ");

            while (true)
            {
                int drinkIndex;                

                if (int.TryParse(Console.ReadLine(), out drinkIndex) 
                    && drinkIndex >= 0
                    && drinkIndex < factories.Count)
                {
                    Console.WriteLine("Spicify The Needed Amount To Be Prepared :");

                    int amount;

                    if (int.TryParse(Console.ReadLine(), out amount) && amount > 0)
                        return factories[drinkIndex].Item2.Prepare(amount);
                }
            }
        }
    }
}
