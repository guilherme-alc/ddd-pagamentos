using ContextoDePagamento.Compartilhado.ObjetosDeValor;
using Flunt.Validations;

namespace ContextoDePagamento.Dominio.ObjetosDeValor
{
    public class Nome : ObjetoDeValor
    {
        public Nome(string primeiroNome, string sobrenome)
        {
            NomeCompleto = $"{primeiroNome} {sobrenome}";
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
            
            AddNotifications(new Contract<Nome>()
                .Requires()
                .IsGreaterOrEqualsThan(PrimeiroNome.Length, 3, "Nome.PrimeiroNome", "O primeiro nome deve ter pelo menos 3 caracteres.")
                .IsLowerOrEqualsThan(PrimeiroNome.Length, 40, "Nome.PrimeiroNome", "O primeiro nome deve ter no máximo 40 caracteres.")
                .IsGreaterOrEqualsThan(Sobrenome.Length, 3, "Nome.Sobrenome", "O sobrenome deve ter pelo menos 3 caracteres.")
                .IsLowerOrEqualsThan(Sobrenome.Length, 40, "Nome.Sobrenome", "O sobrenome deve ter no máximo 40 caracteres.")
            );
        }

        public string NomeCompleto { get; private set; }
        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }
    }
}