using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.GangOfFour.Creational.Builder
{
    public class PersonJobBuilder<SELF> : PersonInfoBuilder<PersonJobBuilder<SELF>>
                            where SELF  : PersonJobBuilder<SELF>
    {
        public SELF WorksAsA(string job)
        {
            person.Job = job;
            return (SELF)this;
        }
    }
}
