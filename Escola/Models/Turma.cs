using Escola.Enums;

namespace Escola.Models;

public class Turma
{
    public Turma(string nome, TurnoTurmaEnum turno, Professor professor)
    {
        Id = Guid.NewGuid();
        Nome = nome;
        Turno = turno;
        Professor = professor;
    }
    public Guid Id { get; }
    public string Nome { get; }
    public TurnoTurmaEnum Turno { get; }
    public Professor Professor { get; }

    public override string ToString() => $"Turma: {Nome} | Turno: {Turno} | Professor Responsável {Professor}";
   
}
