using Strategy;

Console.WriteLine("### Padrão Strategy ###");
CompressaoContext context = new(new CompressaoRar());

Console.WriteLine("Informe o nome do arquivo a comprimir");
var nomeArquivo = Console.ReadLine();

Console.WriteLine("\nInforme o tipo de impressão a ser usada");
Console.WriteLine("1-Rar(Padrão) 2-Zip 3-GZip\n");
var opcao = Convert.ToInt32(Console.ReadLine());

if (opcao == 2)
    context.DefineStrategy(new CompressaoZip());
else if (opcao == 3)
    context.DefineStrategy(new CompressaoGzip());

context.CriarArquivoCompactado(nomeArquivo);

Console.Read();



