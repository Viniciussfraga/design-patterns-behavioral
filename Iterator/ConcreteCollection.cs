namespace Iterator;

public class ConcreteCollection : IAbstractCollection
{
    private List<Cliente> clientes = new();
    public int Count => clientes.Count;
    public Cliente GetCliente(int index) => clientes[index];
    public void AddCliente(Cliente cliente) => clientes.Add(cliente);
    public ConcreteIterator CreateIterator() =>  new (this);    
}