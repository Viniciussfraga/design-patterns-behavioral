namespace Strategy;

public class CompressaoZip : ICompressao
{
    public void ComprimirArquivo(string nomeArquivo) => Console.WriteLine($"\nO arquivo '{nomeArquivo}' foi compactado usando Zip. \nUm arquivo com extensão .zip foi criado.");

}