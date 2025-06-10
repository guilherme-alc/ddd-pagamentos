namespace ContextoDePagamento.Dominio.Entidades
{
    public class PagamentoPaypal : Pagamento
    {
        public string CodigoTransacao { get; set; }
    }
}
