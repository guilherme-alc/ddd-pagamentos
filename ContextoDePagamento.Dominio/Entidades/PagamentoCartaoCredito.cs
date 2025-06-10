namespace ContextoDePagamento.Dominio.Entidades
{
    public class PagamentoCartaoCredito : Pagamento
    {
        public string NomeTitular { get; set; }
        public string NumeroCartao { get; set; }
        public string NumeroUltimaTransacao { get; set; }
    }
}
