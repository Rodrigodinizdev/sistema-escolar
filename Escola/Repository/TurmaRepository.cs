using Escola.Interfaces.Repositories;
using Escola.Models;

namespace Escola.Repository;

public class TurmaRepository : ITurmaRepository
{
    private List<Turma> _turmas = [];

    public void AdicionarTurma(Turma turma) => _turmas.Add(turma);

    public Turma BuscarTurmaPeloId(Guid id) => _turmas.FirstOrDefault(t => t.Id == id);

    public List<Turma> ListarTurmas() => _turmas;

    public Turma BuscarTurmaPeloNome(string nome) => _turmas.FirstOrDefault(t => t.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

}
