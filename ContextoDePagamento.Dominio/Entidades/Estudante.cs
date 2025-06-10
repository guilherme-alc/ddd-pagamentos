namespace ContextoDePagamento.Dominio.Entidades
{
    public class Estudante
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public List<Assinatura> Assinaturas { get; set; }
    }
}