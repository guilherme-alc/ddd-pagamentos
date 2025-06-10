namespace ContextoDePagamento.Dominio.Entidades
{
    public class Estudante
    {
        private IList<Assinatura> _assinaturas;
        public Estudante(string nome, string sobrenome, string documento, string email)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Documento = documento;
            Email = email;
            _assinaturas = new List<Assinatura>();
        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Documento { get; private set; }
        public string Email { get; private set; }
        public string Endereco { get; private set; }
        public IReadOnlyCollection<Assinatura> Assinaturas { get { return _assinaturas.ToArray(); } }
        public void AdicionarAssinatura(Assinatura assinatura)
        {
            foreach (var item in Assinaturas)
            {
                item.AlterarStatus(false);
            }
            _assinaturas.Add(assinatura);
        }
    }
}