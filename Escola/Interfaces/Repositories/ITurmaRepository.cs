using Escola.Models;

namespace Escola.Interfaces.Repositories;

    public interface ITurmaRepository
    {
        void AdicionarTurma(Turma turma);
        List<Turma> ListarTurmas();
        Turma BuscarTurmaPeloId(Guid id);
    }
