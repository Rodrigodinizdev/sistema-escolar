using Escola.Interfaces.Repositories;
using Escola.Models;

namespace Escola.Repository;

public class ProfessorRepository : IProfessorRepository
{
    private List<Professor> _professor = [];

    public void AdicionarProfessor(Professor professor) => _professor.Add(professor);

    public Professor BuscarPeloCpf(string cpf) => _professor.FirstOrDefault(p => p.CPF.Trim().Equals(cpf, StringComparison.OrdinalIgnoreCase));
   
    public Professor BuscarProfessorPeloId(Guid id) => _professor.FirstOrDefault(p => p.Id == id);
    
    public Professor BuscarProfessorPeloNome(string nome) => _professor.FirstOrDefault(p => p.NomeCompleto.Equals(nome, StringComparison.OrdinalIgnoreCase));

    public List<Professor> ListarProfessor() => _professor;

}
