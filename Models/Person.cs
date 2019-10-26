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

        public override string ToString()
        {
            return $"{nameof(Name)} : {Name} , {nameof(Job)} : {Job}";
        }
    }
}
