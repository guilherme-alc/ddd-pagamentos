using ContextoDePagamento.Compartilhado.Entidades;
using ContextoDePagamento.Dominio.ObjetosDeValor;

namespace ContextoDePagamento.Dominio.Entidades
{
    public class Pagamento : Entidade
    {
        public Pagamento(DateTime dataPagamento, DateTime dataExpiracao, decimal total, decimal totalPago, Endereco endereco, Documento documento, string pagador, Email email)
        {
            Numero = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            DataPagamento = dataPagamento;
            DataExpiracao = dataExpiracao;
            Total = total;
            TotalPago = totalPago;
            Endereco = endereco;
            Documento = documento;
            Pagador = pagador;
            Email = email;
        }

        public string Numero { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public DateTime DataExpiracao { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPago { get; private set; }
        public Endereco Endereco { get; private set; }
        public Documento Documento { get; private set; }
        public string Pagador { get; private set; }
        public Email Email { get; private set; }
    }
}