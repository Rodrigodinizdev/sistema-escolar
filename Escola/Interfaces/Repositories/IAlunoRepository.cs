using Escola.Models;

namespace Escola.Interfaces.Repositories;

    public interface IAlunoRepository
    {
        void AdicionarAluno(Aluno aluno);
        List<Aluno> ListarAlunos();
        Aluno BuscarAlunoPeloNome(string nome);
        Aluno BuscarAlunoPeloId(Guid id);
        Aluno BuscarPeloCpf (string cpf);
    }
