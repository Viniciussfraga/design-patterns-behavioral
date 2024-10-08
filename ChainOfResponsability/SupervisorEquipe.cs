namespace ChainOfResponsability;

public class SupervisorEquipe : Autorizador
{
    private int ALCADA_DIAS = 15;
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
        Console.WriteLine($"O supervisor de equipe aprovou {dias} dias de licença remunerada para : {nome}\n");
    }
}