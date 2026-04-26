using Escola.DTOs;
using Escola.Interfaces.Repositories;
using Escola.Interfaces.Services;
using Escola.Models;

namespace Escola.Service;

    public class TurmaService(ITurmaRepository turmaRepository, IProfessorRepository professorRepository) : ITurmaService
    {
        private readonly ITurmaRepository _turmaRepository = turmaRepository;     
        private readonly IProfessorRepository _professorRepository = professorRepository;

    public string AdicionarTurma(TurmaDto dto)
    {
        var professor = _professorRepository.BuscarProfessorPeloId(dto.IdProfessor);

        if (professor == null)
        {
            return "ERRO: Professor não encontrado";
        }

        var turmas = new Turma(dto.Nome, dto.Turno, professor);
        _turmaRepository.AdicionarTurma(turmas);
        return "Turma cadastrada com sucesso";
    }

    public Turma BuscarTurmaPeloId(Guid id)
    {
        throw new NotImplementedException();
    }

    public List<Turma> ListarTurmas()
    {
        return _turmaRepository.ListarTurmas();
    }
}
