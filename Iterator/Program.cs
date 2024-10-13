using Iterator;

ConcreteCollection colecao = new();

colecao.AddCliente(new Cliente("Morais", 10));
colecao.AddCliente(new Cliente("Otavio", 11));
colecao.AddCliente(new Cliente("Fabio", 12));
colecao.AddCliente(new Cliente("Vini", 13));
colecao.AddCliente(new Cliente("Pedro", 14));

ConcreteIterator iterator = colecao.CreateIterator();

Console.WriteLine("### Usando o padrão Iterator ###\n");
Console.WriteLine("Pressione algo para iniciar");
Console.Read();

Console.WriteLine("Iterando sobre a coleção de Clientes :\n");

for (Cliente cliente = iterator.First(); !iterator.IsDone; cliente = iterator.Next())
    Console.WriteLine($"ID : {cliente.Id} & Nome : {cliente.Nome}");

Console.Read();