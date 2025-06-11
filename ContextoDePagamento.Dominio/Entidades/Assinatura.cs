using ContextoDePagamento.Compartilhado.Entidades;
using Flunt.Validations;

namespace ContextoDePagamento.Dominio.Entidades
{
    public class Assinatura : Entidade
    {
        private IList<Pagamento> _pagamentos;
        public Assinatura(DateTime? dataVencimento)
        {
            DataCriacao = DateTime.Now;
            DataUltimaAtualizacao = DateTime.Now;
            DataVencimento = dataVencimento;
            Ativo = true;
            _pagamentos = new List<Pagamento>();
        }

        public DateTime DataCriacao { get; private set; }
        public DateTime DataUltimaAtualizacao { get; private set; }
        public DateTime? DataVencimento { get; private set; }
        public bool Ativo { get; private set; }
        public List<Pagamento> Pagamentos { get; private set; }

        public void AdicionarPagamento(Pagamento pagamento)
        {
            var contrato = new Contract<Assinatura>()
                .Requires()
                .IsNotNull(pagamento, "Assinatura.Pagamento", "Pagamento não pode ser nulo.")
                .IsGreaterOrEqualsThan(pagamento.DataPagamento, DataCriacao, "Assinatura.Pagamento.DataPagamento", "Data do pagamento não pode ser anterior à data de criação da assinatura.")
                .IsTrue(pagamento.IsValid, "Assinatura.Pagamento", "Pagamento inválido.");

            if (DataVencimento.HasValue)
            {
                contrato.IsLowerOrEqualsThan(
                    pagamento.DataPagamento,
                    DataVencimento.Value,
                    "Assinatura.Pagamento.DataPagamento",
                    "Data do pagamento não pode ser posterior à data de vencimento da assinatura.");
            }

            AddNotifications(contrato);

            if (IsValid)
                _pagamentos.Add(pagamento);

            DataUltimaAtualizacao = DateTime.Now;
        }

        public void AlterarStatus(bool ativo)
        {
            Ativo = ativo;
            DataUltimaAtualizacao = DateTime.Now;
        }
    }
}