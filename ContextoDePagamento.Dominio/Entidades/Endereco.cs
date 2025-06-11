using ContextoDePagamento.Compartilhado.Entidades;

namespace ContextoDePagamento.Dominio.Entidades
{
    public class Endereco : Entidade
    {
        public Endereco(string rua, string numero, string bairro, string cidade, string estado, string cep)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;

            AddNotifications(new Flunt.Validations.Contract<Endereco>()
                .Requires()
                .IsNotNullOrEmpty(Rua, "Endereco.Rua", "A rua não pode ser vazia.")
                .IsNotNullOrEmpty(Numero, "Endereco.Numero", "O número não pode ser vazio.")
                .IsNotNullOrEmpty(Bairro, "Endereco.Bairro", "O bairro não pode ser vazio.")
                .IsNotNullOrEmpty(Cidade, "Endereco.Cidade", "A cidade não pode ser vazia.")
                .IsNotNullOrEmpty(Estado, "Endereco.Estado", "O estado não pode ser vazio.")
                .IsNotNullOrEmpty(Cep, "Endereco.Cep", "O CEP não pode ser vazio.")
            );
        }

        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Cep { get; private set; }
    }
}