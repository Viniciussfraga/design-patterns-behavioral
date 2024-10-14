namespace Memento;

public class Calculadora : ICalculadora
{
    private int PrimeiroNumero;
    private int SegundoNumero;

    //Corresponde ao metodo CreateMemento();
    public ICareTaker BackupUltimoCalculo() => new Memento(PrimeiroNumero, SegundoNumero); //cria um obj memento usado para restaurar os dois numeros
    public int GetCalculoResultado() => PrimeiroNumero + SegundoNumero;

    //Corresponde ao metodo SetMemento();
    //Executa a lógica para restaurar o estado anterior
    public void RestauraUltimoCalculo(ICareTaker memento)
    {
        PrimeiroNumero = ((IOriginator)memento).GetPrimeiroNumero();
        SegundoNumero = ((IOriginator)memento).GetSegundoNumero();
    }

    public void SetPrimeiroNumero(int num) => PrimeiroNumero = num;
    public void SetSegundoNumero(int num) => SegundoNumero = num;
}