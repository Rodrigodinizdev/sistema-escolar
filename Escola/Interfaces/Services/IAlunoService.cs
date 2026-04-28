using Escola.DTOs;
using Escola.Models;
namespace Escola.Interfaces.Services;

    public interface IAlunoService
    {
        string AdicionarAluno(AlunoDto dto);
        List<Aluno> ListarAlunos();
    
    }
