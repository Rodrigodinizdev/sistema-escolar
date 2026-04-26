using Escola.DTOs;
using Escola.Interfaces.Services;
namespace Escola.Ui;

public class MenuEscola(IAlunoService alunoService, IProfessorService professorService)
{
    private readonly IAlunoService _alunoService = alunoService;
    private readonly IProfessorService _professorService = professorService;
   
    public void Menu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA ESCOLAR ===");
            Console.WriteLine("1 - Cadastrar Professor");
            Console.WriteLine("2 - Cadastrar Aluno");
            Console.WriteLine("3 - Criar Turma");
            Console.WriteLine("5 - Realizar Avaliação");
            Console.WriteLine("6 - Listar Professores");
            Console.WriteLine("7 - Listar Alunos");
            Console.WriteLine("8 - Listar Turmas");
            Console.WriteLine("9 - Exibir Boletim");
            Console.WriteLine("0 - Sair");

            Console.Write("Escolha a opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    CadastrarProfessor();
                    break;

                case "2":
                    CadastrarAluno();
                    break;

                case "3":
                    break;

                case "4":
                    break;

                case "5":
                    break;

                case "6":
                    ListarProfessores();
                    break;

                case "7":
                    ListarAlunos();
                    break;

                case "8":
                    break;

                case "9":
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Opção inválida");
                    break;

            }

            Console.WriteLine("\nPressione qualquer tecla: ");
            Console.ReadKey();
        }
    }

    private void CadastrarAluno()
    {
        Console.Clear();

        Console.WriteLine("\n=== MATRÍCULA DE ALUNOS ===");

        Console.WriteLine();
        Console.Write("Digite o nome completo do Aluno: ");
        string nome = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome não pode ser vazio");
            nome = Console.ReadLine();
        }

        Console.WriteLine();
        Console.Write("Digite o cpf do Aluno: ");
        string cpf = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(cpf) || cpf.Length != 11)
        {
            Console.WriteLine("ERRO! CPF Inválido");
            cpf = Console.ReadLine();
        }

        Console.WriteLine();
        Console.Write("Digite a data de nascimento do Aluno dd/MM/yyyy: ");
        DateTime dataNascimento;
        while (!DateTime.TryParse(Console.ReadLine(), out dataNascimento))
        {
            Console.WriteLine("ERRO! Data de Nascimento Inválido");
            Console.Write("Digite a data de nascimento do Aluno dd/MM/yyyy: ");
        }

        Console.WriteLine();
        Console.WriteLine(_alunoService.AdicionarAluno(new AlunoDto(nome, cpf, dataNascimento, DateTime.Now)));
    }

    private void ListarAlunos()
    {
        var alunos = _alunoService.ListarAlunos();

        if (!alunos.Any())
        {
            Console.WriteLine("Nenhum Aluno Cadastrado");
            return;
        }

        foreach (var aluno in alunos)
            Console.WriteLine(aluno);
    }

    private void CadastrarProfessor()
    {
        Console.Clear();

        Console.WriteLine("\n=== ADMISSÃO DE PROFESSORES ===");

        Console.WriteLine();
        Console.Write("Digite o nome completo do professor: ");
        string nome = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome não pode ser vazio");
            nome = Console.ReadLine();
        }

        Console.WriteLine();
        Console.Write("Digite o cpf do professor: ");
        string cpf = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(cpf) || cpf.Length != 11)
        {
            Console.WriteLine("ERRO! CPF Inválido");
            cpf = Console.ReadLine();
        }

        Console.WriteLine();
        Console.Write("Digite a data de nascimento do professor dd/MM/yyyy: ");
        DateTime dataNascimento;
        while (!DateTime.TryParse(Console.ReadLine(), out dataNascimento))
        {
            Console.WriteLine("ERRO! Data de Nascimento Inválido");
            Console.Write("Digite a data de nascimento do professor dd/MM/yyyy: ");
        }

        Console.WriteLine();
        Console.Write("Digite a disciplina do professor: ");
        string disciplina = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(disciplina))
        {
            Console.WriteLine("ERRO! disciplina inválida");
            disciplina = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine(_professorService.AdicionarProfessor(new ProfessorDto(nome, cpf, dataNascimento, disciplina)));
    }

     private void ListarProfessores()
    {
        var professores = _professorService.ListarProfessor();

        if (!professores.Any())
        {
            Console.WriteLine("Nenhum professor Cadastrado");
            return;
        }

        foreach (var professor in professores)
            Console.WriteLine(professor);
    }

}
