
using ContextoDePagamento.Dominio.ObjetosDeValor;

namespace ContextoDePagamento.Dominio.Entidades
{
    public class PagamentoPaypal : Pagamento
    {
        public PagamentoPaypal(
            DateTime dataPagamento,
            DateTime dataExpiracao,
            decimal total,
            decimal totalPago,
            Endereco endereco,
            Documento documento,
            string pagador,
            Email email,
            string codigoTransacao) 
            : base(dataPagamento, dataExpiracao, total, totalPago, endereco, documento, pagador, email)
        {
            CodigoTransacao = codigoTransacao;
        }

        public string CodigoTransacao { get; private set; }
    }
}
