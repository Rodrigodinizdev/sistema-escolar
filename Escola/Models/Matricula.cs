namespace Escola.Models;

public class Matricula
{
    public Matricula(Aluno aluno, Turma turma)
    {
        Id = Guid.NewGuid();
        Aluno = aluno;
        Turma = turma;
        DataMatricula = DateTime.Now;
    }
    public Guid Id { get; }
    public Aluno Aluno { get; }
    public Turma Turma { get; }
    public DateTime DataMatricula { get; }
}
