namespace Strategy;

public class CompressaoContext(ICompressao compressao)
{
    private ICompressao Compressao = compressao;
    public void CriarArquivoCompactado(string nomeArquivo) => Compressao.ComprimirArquivo(nomeArquivo);
    public void DefineStrategy(ICompressao compressao) => Compressao = compressao;
}