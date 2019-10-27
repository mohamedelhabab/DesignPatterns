using DesignPatterns.GangOfFour.Creational.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class Person
    {
        public string Name;
        public string Job;

            public class Builder : PersonJobBuilder<Builder>
            {
            }

        public static Builder Instance  => new Builder();

        public override string ToString()
        {
            return $"{nameof(Name)} : {Name} , {nameof(Job)} : {Job}";
        }
    }
}
