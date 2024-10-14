///ConcreteColleague
namespace Mediator;

public class ConcreteUser(FacebookGroupMediator mediator, string name) : User(mediator, name)
{
    public override void Receive(string msg)
    {
        Console.WriteLine($"{Name} : recebida <= { msg }");
    }

    public override void Send(string msg)
    {
        Console.WriteLine($"{Name} : enviada => { msg }\n");
        Mediator.SendMessage(msg, this);
    }
}