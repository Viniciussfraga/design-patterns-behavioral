namespace ChainOfResponsability;

public class GerenteProjeto : Autorizador
{
    private int ALCADA_DIAS = 5;
    public override void AutorizarLicenca(string nome, int dias)
    {
        if (dias <= ALCADA_DIAS)
        {
            AprovarLicenca(nome, dias);
        }
        else
        {
            _autorizador.AutorizarLicenca(nome, dias);
        }
    }
    private void AprovarLicenca(string nome, int dias)
    {
        Console.WriteLine($"O Gerente de projeto aprovou {dias} dias de licença remunerada para : {nome}\n");
    }
}