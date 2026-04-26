using Escola.Models;

namespace Escola.Interfaces.Repositories;

    public interface IProfessorRepository
    {
        void AdicionarProfessor(Professor professor);
        List<Professor> ListarProfessor();
        Professor BuscarProfessorPeloNome(string nome);
        Professor BuscarProfessorPeloId(Guid id);
        Professor BuscarPeloCpf(string cpf);
    }
