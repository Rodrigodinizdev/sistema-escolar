using Escola.DTOs;
using Escola.Models;
namespace Escola.Interfaces.Services;

    public interface IProfessorService
    {
        string AdicionarProfessor(ProfessorDto dto);
        List<Professor> ListarProfessor();
        Professor BuscarProfessorPeloNome(string nome);
        Professor BuscarProfessorPeloId(Guid id);
    }
