
namespace ContextoDePagamento.Dominio.Entidades
{
    public class PagamentoCartaoCredito : Pagamento
    {
        public PagamentoCartaoCredito(
            DateTime dataPagamento,
            DateTime dataExpiracao,
            decimal total,
            decimal totalPago,
            string endereco,
            string documento,
            string pagador,
            string email,
            string nomeTitular,
            string numeroCartao,
            string numeroUltimaTransacao) 
            : base(dataPagamento, dataExpiracao, total, totalPago, endereco, documento, pagador, email)
        {
            NomeTitular = nomeTitular;
            NumeroCartao = numeroCartao;
            NumeroUltimaTransacao = numeroUltimaTransacao;
        }

        public string NomeTitular { get; private set; }
        public string NumeroCartao { get; private set; }
        public string NumeroUltimaTransacao { get; private set; }
    }
}
