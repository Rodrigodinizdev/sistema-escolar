namespace Escola.Models;

public class Professor
{
    public Professor(string nomeCompleto, string cpf, DateTime dataNascimento, string disciplina)
    {
        Id = Guid.NewGuid();
        NomeCompleto = nomeCompleto;
        CPF = cpf;
        DataNascimento = dataNascimento;
        Disciplina = disciplina;
    }
    public Guid Id { get; }
    public string NomeCompleto { get; }
    public string CPF { get; }
    public DateTime DataNascimento { get; }
    public string Disciplina { get; }

    public override string ToString() => $"Registro: [{Id}] | Professor: {NomeCompleto} | Disciplina: {Disciplina}";
   
}
