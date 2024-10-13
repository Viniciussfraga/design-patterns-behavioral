namespace Interpreter;

public class ExpressaoSeparador : IAbstractExpression
{
    public void Avaliar(Context context)
    {
       string expressao = context.Expressao;
       context.Expressao = expressao.Replace(" ", "-");
    }
}