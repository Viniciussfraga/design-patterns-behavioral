namespace Iterator;

public interface IAbstractCollection
{
    ConcreteIterator CreateIterator();
}