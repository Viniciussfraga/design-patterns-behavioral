namespace ChainOfResponsability;

public class SetorRh : Autorizador
{
    private int ALCADA_DIAS = 30;
    public override void AutorizarLicenca(string nome, int dias)
    {
        if (dias <= ALCADA_DIAS)
        {
            AprovarLicenca(nome, dias);
        }
        else
        {
            Console.WriteLine($"\n Não foi possivel autorizar a licença de {dias} dias para {nome}. \n ***Comunique a diretoria***\n");
        }
    }
    private void AprovarLicenca(string nome, int dias)
    {
        Console.WriteLine($"O setor de RH aprovou {dias} dias de licença remunerada para : {nome}\n");
    }
}