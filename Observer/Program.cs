using Observer;

ConcreteSubject IPhone11 = new("IPhone 11", 4900, "Sem Estoque");
Console.WriteLine($"IPhone11 - estado atual : {IPhone11.GetDisponibilidade()}");

Console.WriteLine($"\nObservers inscritos para receber notificações sobre o produto IPhone 11\n");

ConcreteObserver vini = new ("Vini", IPhone11);
ConcreteObserver ayla = new ("Ayla", IPhone11);
ConcreteObserver bethania = new ("Bethania", IPhone11);

Console.WriteLine($"\nPressione algo para alterar a disponilidade e notificar os observers\n");
Console.Read();

IPhone11.SetDisponibilidade("Disponivel");

Console.Read();
