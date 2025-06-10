namespace ContextoDePagamento.Dominio.Entidades
{
    public class PagamentoBoleto : Pagamento
    {
        public string CodigoBarras { get; set; }
        public string NumeroBoleto { get; set; }
    }
}
