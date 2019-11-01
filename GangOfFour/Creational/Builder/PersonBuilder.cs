using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creational.Builder
{
    public class PersonBuilder
    {
       protected Person person = new Person();

        public Person Build()
        {
            return person;
        }
    }
}
