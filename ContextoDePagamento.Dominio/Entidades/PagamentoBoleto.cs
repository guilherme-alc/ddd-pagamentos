
namespace ContextoDePagamento.Dominio.Entidades
{
    public class PagamentoBoleto : Pagamento
    {
        public PagamentoBoleto(
            DateTime dataPagamento,
            DateTime dataExpiracao,
            decimal total,
            decimal totalPago,
            string endereco,
            string documento,
            string pagador,
            string email,
            string codigoBarras,
            string numeroBoleto) 
            : base(dataPagamento, dataExpiracao, total, totalPago, endereco, documento, pagador, email)
        {
            CodigoBarras = codigoBarras;
            NumeroBoleto = numeroBoleto;
        }

        public string CodigoBarras { get; private set; }
        public string NumeroBoleto { get; private set; }
    }
}
