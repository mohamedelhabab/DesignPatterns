using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Specification_Pattern.Classes
{
   public class AndSpecification<T> : ISpecification<T>
   {
       private ISpecification<T> firstSpec, secondSpec;

       public AndSpecification(ISpecification<T> firstSpec, ISpecification<T> secondSpec)
       {
           this.firstSpec = firstSpec;
           this.secondSpec = secondSpec;    
       }
        public bool IsSatisfied(T t)
        {
            return firstSpec.IsSatisfied(t) && secondSpec.IsSatisfied(t);
        }
    }
}
