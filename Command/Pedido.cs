namespace Command;
//ConcreteCommand
public class Pedido(Chef chef, string acao) : Command
{
    private Chef Chef { get; } = chef;
    private string Acao { get; } = acao;

    public override void Execute()
    {
       if(Acao.Equals("Prato"))
        Chef.PreparandoPrato();
       else
        Chef.PreparandoSobremesa();
    }
}