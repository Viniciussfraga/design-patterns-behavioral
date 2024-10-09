using Command;

Chef chef = new();

Pedido pedido = new(chef, "Prato");
Garcom garcom = new(pedido);
garcom.Executar();

pedido = new(chef, "Sobremesa");
garcom = new(pedido);
garcom.Executar();

Console.ReadKey();