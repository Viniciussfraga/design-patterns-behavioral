using State;

CaixaEletronico caixaEletronico = new();
Console.WriteLine($"Estado atual do caixa eletrônico: {caixaEletronico.CaixaEletronicoState.GetType().Name}");
Console.WriteLine();
caixaEletronico.InformarSenha();
caixaEletronico.SacarDinheiro();
caixaEletronico.EjetarCartao();
caixaEletronico.InserirCartao();
Console.WriteLine();

Console.WriteLine($"Estado atual do caixa eletrônico: {caixaEletronico.CaixaEletronicoState.GetType().Name}");
Console.WriteLine();
caixaEletronico.InformarSenha();
caixaEletronico.SacarDinheiro();
caixaEletronico.EjetarCartao();
Console.WriteLine("");

Console.WriteLine($"Estado atual do caixa eletrônico: {caixaEletronico.CaixaEletronicoState.GetType().Name}");
Console.Read();