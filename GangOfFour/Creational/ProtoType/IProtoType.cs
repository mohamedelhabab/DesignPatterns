namespace DesignPatterns.GangOfFour.Creational.ProtoType
{
    public interface IProtoType<T>
    {
        T DeepCopy();
    }
}