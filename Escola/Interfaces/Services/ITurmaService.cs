using Escola.DTOs;
using Escola.Models;
namespace Escola.Interfaces.Services;

    public interface ITurmaService
    {
        string AdicionarTurma(TurmaDto dto);
        List<Turma> ListarTurmas();
        Turma BuscarTurmaPeloId(Guid id);
    }
