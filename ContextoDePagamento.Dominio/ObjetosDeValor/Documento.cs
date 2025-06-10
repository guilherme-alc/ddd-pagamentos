using ContextoDePagamento.Dominio.Enums;

namespace ContextoDePagamento.Dominio.ObjetosDeValor
{
    public class Documento
    {
        public Documento(string numero, EDocumentoTipo tipo)
        {
            Numero = numero;
            Tipo = tipo;
        }

        public string Numero { get; private set; }
        public EDocumentoTipo Tipo { get; private set; }

        public override string ToString()
        {
            return $"{Tipo}: {Numero}";
        }
    }
}