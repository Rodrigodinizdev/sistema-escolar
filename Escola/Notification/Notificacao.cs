using Escola.Enums;
using Escola.Interfaces.Notification;

namespace Escola.Notification;

public class Notificacao : INotificacao
{
    internal class Mensagem
    {
        public Mensagem(string texto, TipoNotificacaoEnum tipo)
        {
            Texto = texto;
            Tipo = tipo;
        }
        public string Texto { get; private set; }
        public TipoNotificacaoEnum Tipo { get; private set; } 
    }

    private List<Mensagem> _mensagens = [];

    public void AdicionarNotificacoes(string mensagem, TipoNotificacaoEnum tipo) => _mensagens.Add(new Mensagem(mensagem, tipo));
    
    public bool TemNotificacao() => _mensagens.Any();
   
    public void Limpar() => _mensagens.Clear();
  
    public IReadOnlyCollection<object> ExibirNotificacoes() => _mensagens;

}
