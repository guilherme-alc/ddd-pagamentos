namespace ContextoDePagamento.Dominio.Entidades
{
    public class Pagamento
    {
        public Pagamento(DateTime dataPagamento, DateTime dataExpiracao, decimal total, decimal totalPago, string endereco, string documento, string pagador, string email)
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
        public string Endereco { get; private set; }
        public string Documento { get; private set; }
        public string Pagador { get; private set; }
        public string Email { get; private set; }
    }
}