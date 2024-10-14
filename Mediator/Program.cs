using Mediator;

FacebookGroupMediator facebookMediator = new ConcreteFacebookGroupMediator();

User vini = new ConcreteUser(facebookMediator, "Vini");
User morais = new ConcreteUser(facebookMediator, "Morais");
User fabio = new ConcreteUser(facebookMediator, "Fabio");
User otavio = new ConcreteUser(facebookMediator, "Otavio");

facebookMediator.RegisterUser(vini);
facebookMediator.RegisterUser(morais);
facebookMediator.RegisterUser(fabio);
facebookMediator.RegisterUser(otavio);

vini.Send("Aula sobre padrão Mediator");
morais.Send("qual o tutor?");
vini.Send("Macoratti");

Console.Read();