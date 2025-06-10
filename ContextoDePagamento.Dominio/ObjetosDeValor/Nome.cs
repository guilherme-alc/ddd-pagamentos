namespace ContextoDePagamento.Dominio.ObjetosDeValor
{
    public class Nome
    {
        public Nome(string primeiroNome, string sobrenome)
        {
            NomeCompleto = $"{primeiroNome} {sobrenome}";
            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
        }

        public string NomeCompleto { get; private set; }
        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }
    }
}