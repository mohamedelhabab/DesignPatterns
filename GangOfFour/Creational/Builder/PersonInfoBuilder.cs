using DesignPatterns.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creational.Builder
{
    public class PersonInfoBuilder<SELF> : PersonBuilder 
                             where SELF  : PersonInfoBuilder<SELF>
    {
        public SELF Called(string name)
        {
            person.Name = name;

            return (SELF) this;
        }

        public override string ToString()
        {
            return person.ToString();
        }

    }
}
