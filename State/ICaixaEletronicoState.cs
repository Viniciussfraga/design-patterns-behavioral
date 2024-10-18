namespace State;
//state
public interface ICaixaEletronicoState
{
    void InserirCartao();
    void EjetarCartao();
    void InformarSenha();
    void SacarDinheiro();
}