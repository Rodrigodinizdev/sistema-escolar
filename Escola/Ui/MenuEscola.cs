using Escola.DTOs;
using Escola.Interfaces.Services;
namespace Escola.Ui;

public class MenuEscola(IAlunoService alunoService, IProfessorService professorService, ITurmaService turmaService)
{
    private readonly IAlunoService _alunoService = alunoService;
    private readonly IProfessorService _professorService = professorService;
    private readonly ITurmaService _turmaService = turmaService;

    public void Menu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== SISTEMA ESCOLAR ===");
            Console.WriteLine("1 - Cadastrar Professor");
            Console.WriteLine("2 - Cadastrar Aluno");
            Console.WriteLine("3 - Criar Turma");
            Console.WriteLine("4 - Realizar Avaliação");
            Console.WriteLine("5 - Listar Professores");
            Console.WriteLine("6 - Listar Alunos");
            Console.WriteLine("7 - Listar Turmas");
            Console.WriteLine("8 - Exibir Boletim");
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
                    CriarTurma();
                    break;

                case "4":
                    break;

                case "5":
                    ListarProfessores();
                    break;

                case "6":
                    ListarAlunos();
                    break;

                case "7":
                    ListarTurmas();
                    break;

                case "8":
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

    private void CriarTurma()
    {
        Console.Clear();

        Console.WriteLine("\n=== CRIAR TURMA ===");

        Console.WriteLine();
        Console.Write("Digite o nome da Turma: ");
        string nome = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(nome))
        {
            Console.WriteLine("Nome não pode ser vazio");
            nome = Console.ReadLine();
        }

        Console.WriteLine();
        Console.Write("Escolha o Turno da Turma, 1 para Manhã e 2 para Tarde: ");
        int turno;
        while (!int.TryParse(Console.ReadLine(), out turno) || turno < 1 || turno > 2)
            Console.WriteLine("ERRO: Digite 1(manhã) ou 2(tarde)");

        switch (turno)
        {
            case 1:
                turno = (int)Enums.TurnoTurmaEnum.Manha;
                break;

            case 2:
                turno = (int)Enums.TurnoTurmaEnum.Tarde;
                break;

            default:
                Console.WriteLine("ERRO: Digite 1(manhã) ou 2(tarde): ");
                break;

        }

        Console.WriteLine();

        var professores = _professorService.ListarProfessor();
        foreach (var professor in professores)
            Console.WriteLine($"Id: {professor.Id} | Nome: {professor.NomeCompleto} | Disciplina: {professor.Disciplina}");

        Console.Write("Digite o Id do Professor responsável pela turma: ");
        Guid idProfessor;
        while (!Guid.TryParse(Console.ReadLine(), out idProfessor))
            Console.WriteLine("ERRO: Id do Professor inválido");

        Console.WriteLine();
        Console.WriteLine(_turmaService.AdicionarTurma(new TurmaDto(nome, (Enums.TurnoTurmaEnum)turno, idProfessor)));

    }

    private void ListarTurmas()
    {
        var turmas = _turmaService.ListarTurmas();

        if (!turmas.Any())
        {
            Console.WriteLine("Não existe turmas");
            return;
        }

        foreach (var turma in turmas)
            Console.WriteLine(turma);
    }
}
