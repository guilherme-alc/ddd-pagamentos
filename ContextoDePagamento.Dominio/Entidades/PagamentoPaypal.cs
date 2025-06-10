
namespace ContextoDePagamento.Dominio.Entidades
{
    public class PagamentoPaypal : Pagamento
    {
        public PagamentoPaypal(
            DateTime dataPagamento,
            DateTime dataExpiracao,
            decimal total,
            decimal totalPago,
            string endereco,
            string documento,
            string pagador,
            string email,
            string codigoTransacao) 
            : base(dataPagamento, dataExpiracao, total, totalPago, endereco, documento, pagador, email)
        {
            CodigoTransacao = codigoTransacao;
        }

        public string CodigoTransacao { get; private set; }
    }
}
