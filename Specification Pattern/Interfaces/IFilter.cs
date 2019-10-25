using System.Collections.Generic;

namespace DesignPatterns.Specification_Pattern
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specification);
    }
}