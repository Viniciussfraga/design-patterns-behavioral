namespace Memento;

public class Memento(int primeiroNumero, int segundoNumero) : ICareTaker, IOriginator
{
    private int PrimeiroNumero { get ;} = primeiroNumero;
    private int SegundoNumero { get ;} = segundoNumero;
    public int GetPrimeiroNumero() => PrimeiroNumero;
    public int GetSegundoNumero() => SegundoNumero;
}