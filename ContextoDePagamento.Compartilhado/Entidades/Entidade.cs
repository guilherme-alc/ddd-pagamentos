using Flunt.Notifications;

namespace ContextoDePagamento.Compartilhado.Entidades
{
    public abstract class Entidade : Notifiable<Notification>
    {
        public Entidade()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; private set; }
    }
}