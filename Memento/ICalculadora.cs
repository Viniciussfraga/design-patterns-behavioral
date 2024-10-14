namespace Memento;

//Define a interface para a implementação do originator
public interface ICalculadora
{
    //CreateMemento
    ICareTaker BackupUltimoCalculo();

    //SetMemento
    void RestauraUltimoCalculo(ICareTaker memento);

    //servicos do originator
    int GetCalculoResultado();
    void SetPrimeiroNumero(int num);
    void SetSegundoNumero(int num);
}