using Escola.Interfaces.Repositories;
using Escola.Models;

namespace Escola.Repository;

public class AlunoRepository : IAlunoRepository
{
    private List<Aluno> _alunos = [];

    public void AdicionarAluno(Aluno aluno) => _alunos.Add(aluno);

    public Aluno BuscarAlunoPeloId(Guid id) => _alunos.FirstOrDefault(a => a.Id == id);
  
    public Aluno BuscarAlunoPeloNome(string nome) => _alunos.FirstOrDefault(a => a.NomeCompleto.Equals(nome, StringComparison.OrdinalIgnoreCase));

    public Aluno BuscarPeloCpf(string cpf) => _alunos.FirstOrDefault(a => a.CPF.Trim().Equals(cpf, StringComparison.OrdinalIgnoreCase));
   
    public List<Aluno> ListarAlunos() => _alunos;

}
