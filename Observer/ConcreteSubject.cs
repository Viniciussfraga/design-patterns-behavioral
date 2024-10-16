namespace Observer;

public class ConcreteSubject(string produto, int preco, string disponibilidade) : ISubject
{
    private List<IObserver> Observers = new();
    private string Produto { get; } = produto;
    private int Preco { get; } = preco;
    private string Disponibilidade { get; set; } = disponibilidade;
    
    public string GetDisponibilidade() => Disponibilidade;
    public void AdicionarObservers(IObserver observer) => Observers.Add(observer);
    public void RemoverObserver(IObserver observer) => Observers.Remove(observer);
    public void SetDisponibilidade(string status)
    {
        Disponibilidade = status;
        Console.WriteLine("A disponibilidade mudou de 'Sem Estoque' para 'Disponivel'.");
        NotificarObservers();
    }

    public void NotificarObservers()
    {
        Console.WriteLine($"O produto :{Produto} no valor de R$ {Preco} agora está {Disponibilidade}\n### Notificando todos os observers registrados ###");
        Console.WriteLine();

        Observers.ForEach(o => o.Atualiza(Disponibilidade));
    }

    public void RegistrarObserver(IObserver observer)
    {
        Console.WriteLine($"Observer Adicionado : {((ConcreteObserver)observer).Usuario}");
        Observers.Add(observer);
    }
}