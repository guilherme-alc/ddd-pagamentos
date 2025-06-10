using ContextoDePagamento.Compartilhado.Entidades;
using ContextoDePagamento.Dominio.ObjetosDeValor;

namespace ContextoDePagamento.Dominio.Entidades
{
    public class Estudante : Entidade
    {
        private IList<Assinatura> _assinaturas;
        public Estudante(Nome nome, Documento documento, Email email)
        {
            Nome = nome;
            Documento = documento;
            Email = email;
            _assinaturas = new List<Assinatura>();
        }

        public Nome Nome { get; private set; }
        public Documento Documento { get; private set; }
        public Email Email { get; private set; }
        public Endereco Endereco { get; private set; }
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