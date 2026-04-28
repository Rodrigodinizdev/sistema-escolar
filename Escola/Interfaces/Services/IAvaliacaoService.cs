using Escola.DTOs;
using Escola.Models;
namespace Escola.Interfaces.Services;

    public interface IAvaliacaoService
    {
        string AdicionarAvaliacao(AvaliacaoDto dto);
        List<Avaliacao> ListarAvaliacoes();
        
    }
