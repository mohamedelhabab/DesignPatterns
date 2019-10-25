namespace DesignPatterns.Specification_Pattern
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}