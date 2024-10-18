namespace State;
//Context
public class CaixaEletronico : ICaixaEletronicoState
{
    public ICaixaEletronicoState CaixaEletronicoState { get; set; } = new CartaoNaoInseridoState();
    
    public void InformarSenha() => CaixaEletronicoState.InformarSenha();
    public void SacarDinheiro() => CaixaEletronicoState.SacarDinheiro();
    public void EjetarCartao()
    {
        CaixaEletronicoState.EjetarCartao();

        if(CaixaEletronicoState is CartaoInseridoState)
        {
            CaixaEletronicoState = new CartaoNaoInseridoState();
            Console.WriteLine($"O estado interno do caixa eletrônico foi alterado para: {CaixaEletronicoState.GetType().Name}");
        }
    }

    public void InserirCartao()
    {
        CaixaEletronicoState.InserirCartao();

        if(CaixaEletronicoState is CartaoNaoInseridoState)
        {
            CaixaEletronicoState = new CartaoInseridoState();
            Console.WriteLine($"O estado interno do caixa eletrônico foi alterado para: {CaixaEletronicoState.GetType().Name}");
        }
    }

}