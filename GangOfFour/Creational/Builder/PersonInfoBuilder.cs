using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creational.Builder
{
    public class PersonInfoBuilder
    {
        Person person = new Person();

        public PersonInfoBuilder Called(string name)
        {
            person.Name = name;

            return this;
        }

        public override string ToString()
        {
            return person.ToString();
        }

    }
}
