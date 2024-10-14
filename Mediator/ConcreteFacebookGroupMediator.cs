namespace Mediator;

//ConcreteMediator
public class ConcreteFacebookGroupMediator : FacebookGroupMediator
{
    public List<User> Users { get; set; } = new();
    public void RegisterUser(User user) => Users.Add(user);

    public void SendMessage(string msg, User user)
    {
        Users.ForEach(u =>
        {
            if (u != user)
                u.Receive(msg);
        });
    }
}