namespace Mediator;

//Colleague
public abstract class User(FacebookGroupMediator mediator, string name)
{
    protected FacebookGroupMediator Mediator { get; } = mediator;
    protected string Name { get; } = name;
    public abstract void Receive(string msg);
    public abstract void Send(string msg);
}