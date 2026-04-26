using Escola.DTOs;
using Escola.Interfaces.Repositories;
using Escola.Interfaces.Services;
using Escola.Models;
using Escola.Notification;

namespace Escola.Service;

public class AlunoService(IAlunoRepository alunoRepository) : IAlunoService
{
    private readonly IAlunoRepository _alunoRepository = alunoRepository;

    public string AdicionarAluno(AlunoDto dto)
    {
        if (_alunoRepository.BuscarPeloCpf(dto.CPF.Trim()) != null)
            return $"CPF já cadastrado";

        var aluno = new Aluno(dto.NomeCompleto, dto.CPF, dto.DataNascimento);
        _alunoRepository.AdicionarAluno(aluno);
        return $"{aluno} Matriculado com sucesso!";
    }

    public Aluno BuscarAlunoPeloId(Guid id)
    {
        throw new NotImplementedException();
    }

    public Aluno BuscarAlunoPeloNome(string nome)
    {
        throw new NotImplementedException();
    }

    public List<Aluno> ListarAlunos()
    {
        return _alunoRepository.ListarAlunos();
    }
}
