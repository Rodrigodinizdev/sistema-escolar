using Escola.Models;

namespace Escola.Interfaces.Repositories;

    public interface ITurmaRepository
    {
        void AdicionarProfessor(Turma turma);
        List<Turma> ListarTurmas();
        Turma BuscarTurmaPeloId(Guid id);
    }
