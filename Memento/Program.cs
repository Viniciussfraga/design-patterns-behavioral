using Memento;

ICalculadora calculadora = new Calculadora();

calculadora.SetPrimeiroNumero(10);
calculadora.SetSegundoNumero(100);

Console.WriteLine($"### Estado 1 : {calculadora.GetCalculoResultado()}");

// Armazena o resultado caso ocorra um erro
ICareTaker memento = calculadora.BackupUltimoCalculo();
Console.ReadKey();

Console.WriteLine("\nCalcula uma nova soma de dois numeros\n");

calculadora.SetPrimeiroNumero(17);

calculadora.SetSegundoNumero(-290); //atribui um segundo incorreto e calcula

Console.WriteLine($"Estado 2 : {calculadora.GetCalculoResultado()}");

Console.WriteLine("\nRestaura o resultado da soma anterior\n");

//Realização operação para desfazer a ultima operação (CTRL + Z, Undo, etc..)
calculadora.RestauraUltimoCalculo(memento);

//Restaura o resultado do estado armazenado
Console.WriteLine($"### Estado 1 : {calculadora.GetCalculoResultado()}");

Console.ReadKey();