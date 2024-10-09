namespace Command;
//Invoker
public class Garcom(Pedido pedido)
{
    private Pedido Pedido { get; } = pedido;

    public void Executar()
    {
        Pedido.Execute();
    }
}