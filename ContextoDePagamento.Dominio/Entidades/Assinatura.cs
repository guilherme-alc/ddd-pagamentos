namespace ContextoDePagamento.Dominio.Entidades
{
    public class Assinatura
    {
        public DateTime DataCriacao { get; set; }
        public DateTime DataUltimaAtualizacao { get; set; }
        public DateTime DataVencimento { get; set; }
        public bool Active { get; set; }
        public List<Pagamento> Pagamentos { get; set; }
    }
}