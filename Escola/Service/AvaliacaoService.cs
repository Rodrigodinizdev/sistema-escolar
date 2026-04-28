using Escola.DTOs;
using Escola.Interfaces.Repositories;
using Escola.Interfaces.Services;
using Escola.Models;
using Escola.Repository;

namespace Escola.Service;

public class AvaliacaoService(IAvaliacaoRepository avaliacaoRepository, IAlunoRepository alunoRepository, ITurmaRepository turmaRepository) : IAvaliacaoService
{
    private readonly IAvaliacaoRepository _avaliacaoRepository = avaliacaoRepository;
    private readonly IAlunoRepository _alunoRepository = alunoRepository;
    private readonly ITurmaRepository _turmaRepository = turmaRepository;
    public string AdicionarAvaliacao(AvaliacaoDto dto)
    {
        // 1. buscar o aluno e a turma pelo Id
        var aluno = _alunoRepository.BuscarAlunoPeloId(dto.AlunoId);
        if (aluno == null)
            return "Aluno não encontrado.";

        var turma = _turmaRepository.BuscarTurmaPeloId(dto.TurmaId);
        if (turma == null)
            return "Turma não encontrada.";

        var avaliacao = new Avaliacao(turma, aluno, dto.Tipo, dto.Titulo, dto.DataAvaliacao, dto.Nota);
        _avaliacaoRepository.AdicionarAvaliacao(avaliacao);
        return "Avaliação cadastrada com sucesso!";
    }

    public List<Avaliacao> ListarAvaliacoes()
    {
        return _avaliacaoRepository.ListarAvaliacoes();
    }
}
