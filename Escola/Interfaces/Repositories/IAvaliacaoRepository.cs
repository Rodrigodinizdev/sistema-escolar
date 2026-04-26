using Escola.Models;

namespace Escola.Interfaces.Repositories;

    public interface IAvaliacaoRepository
    {
        void AdicionarAvaliacao(Avaliacao avaliacao);
        List<Avaliacao> ListarAvaliacoes();
        Avaliacao BuscarAvaliacaoPeloId(Guid id);
        
    }
