
namespace TemplateMethod;
public abstract class VideoPlayer
{
    //Template Method
    public void ExecutarVideo()
    {
        CarregarArquivo();
        DecodeVideoFormato();
        IniciarExecucao();
    }
    //procedimento que será sobrescrito
    public abstract void DecodeVideoFormato();
    //procedimento padrão
    public void IniciarExecucao() => Console.WriteLine("O video iniciou a execução...\n");
    //procedimento padrão
    public void CarregarArquivo() => Console.WriteLine("Arquivo de video carregado...\n");
}