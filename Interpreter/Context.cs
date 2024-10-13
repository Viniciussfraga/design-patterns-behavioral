namespace Interpreter;

public class Context(DateTime data)
{
    public string Expressao { get; set; }
    public DateTime Data { get; set; } = data;
}