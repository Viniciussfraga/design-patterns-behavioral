namespace Iterator;

public class ConcreteIterator(ConcreteCollection collection) : IAbstractIterator
{
    private int Current = 0;
    private int Step = 1;

    private ConcreteCollection Collection { get; } = collection;
    public bool IsDone { get { return Current >= Collection.Count; }}

    public Cliente First()
    {
        Current = 0;
        return Collection.GetCliente(Current);
    }

    public Cliente Next()
    {
        Current += Step;

        if(!IsDone)
            return Collection.GetCliente(Current);
        else
            return null;
    }
}