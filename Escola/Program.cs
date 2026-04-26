using Escola.Repository;
using Escola.Service;
using Escola.Ui;

var alunoRepository = new AlunoRepository();
var professorRepository = new ProfessorRepository();
var turmaRepository = new TurmaRepository();

var alunoService = new AlunoService(alunoRepository);
var professorService = new ProfessorService(professorRepository);
var turmaService = new TurmaService(turmaRepository, professorRepository);

var ui = new MenuEscola(alunoService, professorService, turmaService);

ui.Menu();