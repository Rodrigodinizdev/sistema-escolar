using Escola.Enums;

namespace Escola.Models;

public class Avaliacao
{
    public Avaliacao(Turma turma, Aluno aluno, TipoAvaliacaoEnum tipo, string titulo, DateTime dataAvaliacao, decimal nota)
    {
        Id = Guid.NewGuid();
        Turma = turma;
        Aluno = aluno;
        Tipo = tipo;
        Titulo = titulo;
        DataAvaliacao = dataAvaliacao;
        Nota = nota;
    }
    public Guid Id { get; }
    public Turma Turma { get; }
    public Aluno Aluno { get; }
    public TipoAvaliacaoEnum Tipo { get; private set; }
    public string Titulo { get; }
    public DateTime DataAvaliacao { get; }
    public decimal Nota { get; private set; }
    public const int PesoProva = 7;
    public const int PesoTrabalho = 3;

    public override string ToString() => $"Avaliação: {Titulo} | Data Avaliação: {DataAvaliacao} | Tipo: {Tipo} | Aluno: {Aluno} | Turma: {Turma} | Nota: {Nota}";

}
