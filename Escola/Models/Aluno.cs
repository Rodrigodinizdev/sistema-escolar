namespace Escola.Models;

public class Aluno
{
    public Aluno(string nomeCompleto, string cpf, DateTime dataNascimento)
    {
        Id = Guid.NewGuid();
        NomeCompleto = nomeCompleto;
        CPF = cpf;
        DataNascimento = dataNascimento;
        DataMatricula = DateTime.Now;
    }
    
    public Guid Id { get; }
    public string NomeCompleto { get; }
    public string CPF { get; }
    public DateTime DataNascimento { get; }
    public DateTime DataMatricula { get; }

    public override string ToString() => $"Matrícula: [{Id}] | Aluno: {NomeCompleto} | CPF: {CPF} | Data Matrícula: {DataMatricula}";
    
}
