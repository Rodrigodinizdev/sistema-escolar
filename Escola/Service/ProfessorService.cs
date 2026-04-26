using Escola.DTOs;
using Escola.Interfaces.Repositories;
using Escola.Interfaces.Services;
using Escola.Models;
using Escola.Repository;

namespace Escola.Service;

    public class ProfessorService(IProfessorRepository professorRepository) : IProfessorService
    {
        private readonly IProfessorRepository _professorRepository = professorRepository;

    public string AdicionarProfessor(ProfessorDto dto)
    {
        if(_professorRepository.BuscarPeloCpf(dto.CPF.Trim()) != null)
            return $"CPF já Cadastrado";

        var professor = new Professor(dto.NomeCompleto, dto.CPF, dto.DataNascimento, dto.Disciplina);
        _professorRepository.AdicionarProfessor(professor);
        return $"{professor} Adicionado com sucesso!";
    }

    public Professor BuscarProfessorPeloId(Guid id)
    {
        throw new NotImplementedException();
    }

    public Professor BuscarProfessorPeloNome(string nome)
    {
        throw new NotImplementedException();
    }

    public List<Professor> ListarProfessor()
    {
        return _professorRepository.ListarProfessor();
    }
}
