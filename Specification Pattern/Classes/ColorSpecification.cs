using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Models;

namespace DesignPatterns.Specification_Pattern.Classes
{
    public class ColorSpecification : ISpecification<Product>
    {
        private Color color ;

        public ColorSpecification(Color color)
        {
            this.color = color; 
        }
        public bool IsSatisfied(Product t)
        {
            return t.Color == color;
        }
    }
}
