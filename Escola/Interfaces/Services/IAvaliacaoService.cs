using Escola.Models;
namespace Escola.Interfaces.Services;

    public interface IAvaliacaoService
    {
        string AdicionarAvaliacao(Avaliacao avaliacao);
        List<Avaliacao> ListarAvaliacoes();
        Avaliacao BuscarAvaliacaoPeloId(Guid id);
    }
