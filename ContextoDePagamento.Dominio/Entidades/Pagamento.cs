using ContextoDePagamento.Compartilhado.Entidades;
using ContextoDePagamento.Dominio.ObjetosDeValor;
using Flunt.Validations;

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

            AddNotifications(new Contract<Pagamento>()
                .Requires()
                .IsNotNullOrEmpty(Numero, "Pagamento.Numero", "O número do pagamento não pode ser vazio.")
                .IsGreaterThan(Total, 0, "Pagamento.Total", "O total do pagamento deve ser maior que zero.")
                .IsGreaterThan(TotalPago, 0, "Pagamento.TotalPago", "O total pago deve ser maior que zero.")
                .IsNotNull(Endereco, "Pagamento.Endereco", "O endereço do pagamento não pode ser nulo.")
                .IsNotNull(Documento, "Pagamento.Documento", "O documento do pagador não pode ser nulo.")
                .IsNotNullOrEmpty(Pagador, "Pagamento.Pagador", "O nome do pagador não pode ser vazio.")
                .IsNotNull(Email, "Pagamento.Email", "O e-mail do pagador não pode ser nulo.")
            );
            AddNotifications(Endereco, Documento, Email);
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