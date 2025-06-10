namespace ContextoDePagamento.Dominio.Entidades
{
    public class Pagamento
    {
        public string Numero { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataExpiracao { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPago { get; set; }
        public string Endereco { get; set; }
        public string Documento { get; set; }
        public string Pagador { get; set; }
        public string Email { get; set; }
    }
}