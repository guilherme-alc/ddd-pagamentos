using ContextoDePagamento.Compartilhado.ObjetosDeValor;
using ContextoDePagamento.Dominio.Enums;
using Flunt.Validations;

namespace ContextoDePagamento.Dominio.ObjetosDeValor
{
    public class Documento : ObjetoDeValor
    {
        public Documento(string numero, EDocumentoTipo tipo)
        {
            Numero = numero;
            Tipo = tipo;

            AddNotifications(new Contract<Documento>()
                .Requires()
                .IsNotNullOrEmpty(Numero, "Documento.Numero", "O número do documento não pode ser vazio.")
                .IsTrue(Validar(), "Documento.Numero", "O número do documento informado é inválido.")
            );
        }

        public string Numero { get; private set; }
        public EDocumentoTipo Tipo { get; private set; }

        public override string ToString()
        {
            return $"{Tipo}: {Numero}";
        }

        private bool Validar()
        {
            var numero = Numero.Replace(".", "").Replace("-", "").Replace("/", "");

            if (Tipo == EDocumentoTipo.CPF)
                return ValidarCPF(numero);
            else if (Tipo == EDocumentoTipo.CNPJ)
                return ValidarCNPJ(numero);

            return false;
        }

        private static bool ValidarCPF(string cpf)
        {
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11 || cpf.All(c => c == cpf[0]))
                return false;

            var numeros = cpf.Select(c => int.Parse(c.ToString())).ToArray();

            int soma = 0;
            for (int i = 0; i < 9; i++)
                soma += numeros[i] * (10 - i);

            int digito1 = soma % 11;
            digito1 = digito1 < 2 ? 0 : 11 - digito1;

            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += numeros[i] * (11 - i);

            int digito2 = soma % 11;
            digito2 = digito2 < 2 ? 0 : 11 - digito2;

            return numeros[9] == digito1 && numeros[10] == digito2;
        }

        private static bool ValidarCNPJ(string cnpj)
        {
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14 || cnpj.All(c => c == cnpj[0]))
                return false;

            var numeros = cnpj.Select(c => int.Parse(c.ToString())).ToArray();
            int[] multiplicador1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma = 0;
            for (int i = 0; i < 12; i++)
                soma += numeros[i] * multiplicador1[i];

            int digito1 = soma % 11;
            digito1 = digito1 < 2 ? 0 : 11 - digito1;

            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += numeros[i] * multiplicador2[i];

            int digito2 = soma % 11;
            digito2 = digito2 < 2 ? 0 : 11 - digito2;

            return numeros[12] == digito1 && numeros[13] == digito2;
        }

    }
}