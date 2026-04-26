using Escola.Enums;
namespace Escola.Interfaces.Notification;

    public interface INotificacao
    {
        void AdicionarNotificacoes(string mensagem, TipoNotificacaoEnum tipo);
        bool TemNotificacao();
        void Limpar();
        public string ExibirNotificacoes();
    }
