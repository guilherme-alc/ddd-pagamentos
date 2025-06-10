namespace ContextoDePagamento.Compartilhado.Entidades
{
    public abstract class Entidade
    {
        public Entidade()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
    }
}