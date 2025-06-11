using ContextoDePagamento.Compartilhado.ObjetosDeValor;
using Flunt.Validations;

namespace ContextoDePagamento.Dominio.ObjetosDeValor
{
    public class Email : ObjetoDeValor
    {
        public Email(string endereco)
        {
            Endereco = endereco;

            AddNotifications(new Contract<Email>()      
                .Requires()
                .IsEmail(Endereco, "Email.Endereco", "O e-mail informado não é válido.")
            );
        }

        public string Endereco { get; private set; }
    }
}