using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creational.Factory
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class PersonFactory
    {
        int personCreatedFactories = 0;

        public Person CreatePerson(string name)
        {
            Person person = new Person()
            {
                Id = personCreatedFactories,
                Name = name
            };

            personCreatedFactories++;

            return person;
        }

    }
}
