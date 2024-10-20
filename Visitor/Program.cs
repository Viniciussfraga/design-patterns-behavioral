using Visitor;

List<Carro> carros = new()
{
    new Carro { Nome = "A1", Preco = 2000M, Modelo = "Mercedes"},
    new Carro { Nome = "458", Preco = 3500M, Modelo = "Ferrari"},
    new Carro { Nome = "718 GTS", Preco = 2800M, Modelo = "Porsche"},
};

List<ILoja> lojas = new();

Console.WriteLine("Preços normais dos carros\n");

carros.ForEach(carro => { 
    Console.WriteLine($"{carro.Modelo} {carro.Nome} : ${carro.Preco}"); 
    lojas.Add(carro); 
});    

Console.WriteLine("\nPreços dos carros com desconto");
Console.WriteLine("Aplicando padrão visitor");
Console.WriteLine("Novos preços com desconto de 12%\n");

PrecoVisitor precoVisitor = new();
lojas.ForEach(l => l.Visit(precoVisitor));