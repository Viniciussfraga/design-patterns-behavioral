namespace Observer;

public class ConcreteObserver : IObserver
{
    public string Usuario { get; set; }
    public ConcreteObserver(string usuario, ISubject subject)
    {
        Usuario = usuario;
        subject.RegistrarObserver(this);
    }

    public void Atualiza(string disponibilidade)
    {
        Console.WriteLine($"Olá {Usuario}, o Produto que você deseja agora está {disponibilidade} em nosso site.");
    }
}