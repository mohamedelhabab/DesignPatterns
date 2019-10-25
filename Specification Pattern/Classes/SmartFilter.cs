using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Models;

namespace DesignPatterns.Specification_Pattern.Classes
{
    public class SmartFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> specification)
        {
            foreach (var p in items)
                if (specification.IsSatisfied(p))
                    yield return p;
                
            
        }
    }
}
