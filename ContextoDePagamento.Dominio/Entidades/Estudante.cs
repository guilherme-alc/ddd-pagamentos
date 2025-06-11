using ContextoDePagamento.Compartilhado.Entidades;
using ContextoDePagamento.Dominio.ObjetosDeValor;
using Flunt.Validations;

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

            AddNotifications(nome, documento, email);
        }

        public Nome Nome { get; private set; }
        public Documento Documento { get; private set; }
        public Email Email { get; private set; }
        public Endereco Endereco { get; private set; }
        public IReadOnlyCollection<Assinatura> Assinaturas { get { return _assinaturas.ToArray(); } }
        public void AdicionarAssinatura(Assinatura assinatura)
        {
            var temAssinaturaAtiva = _assinaturas.Any(a => a.Ativo);

            AddNotifications(new Contract<Estudante>()
                .Requires()
                .IsFalse(temAssinaturaAtiva, "Estudante.Assinatura", "O estudante já possui uma assinatura ativa.")
                .IsTrue(assinatura.Pagamentos.Any(), "Estudante.Assinatura.Pagamentos", "Assinatura deve ter pelo menos um pagamento")
            );

            if (IsValid)
                _assinaturas.Add(assinatura);
        }
    }
}