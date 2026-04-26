using Escola.DTOs;
using Escola.Models;
namespace Escola.Interfaces.Services;

    public interface ITurmaService
    {
        string AdicionarProfessor(TurmaDto dto);
        List<Turma> ListarTurmas();
        Turma BuscarTurmaPeloId(Guid id);
    }
