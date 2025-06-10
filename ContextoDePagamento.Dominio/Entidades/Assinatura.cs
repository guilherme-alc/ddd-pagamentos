using ContextoDePagamento.Compartilhado.Entidades;

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
            if (pagamento == null)
                //throw new ArgumentNullException(nameof(pagamento), "Pagamento não pode ser nulo.");

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