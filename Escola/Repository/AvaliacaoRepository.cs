using Escola.Interfaces.Repositories;
using Escola.Models;

namespace Escola.Repository;

public class AvaliacaoRepository : IAvaliacaoRepository
{
    private List<Avaliacao> _avaliacoes = [];

    public void AdicionarAvaliacao(Avaliacao avaliacao) => _avaliacoes.Add(avaliacao);
  
    public Avaliacao BuscarAvaliacaoPeloId(Guid id) => _avaliacoes.FirstOrDefault(a => a.Id == id);
    
    public List<Avaliacao> ListarAvaliacoes() => _avaliacoes; 
}
