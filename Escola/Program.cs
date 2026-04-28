using Escola.Repository;
using Escola.Service;
using Escola.Ui;

var alunoRepository = new AlunoRepository();
var professorRepository = new ProfessorRepository();
var turmaRepository = new TurmaRepository();
var avaliacaoRepository = new AvaliacaoRepository();

var alunoService = new AlunoService(alunoRepository);
var professorService = new ProfessorService(professorRepository);
var turmaService = new TurmaService(turmaRepository, professorRepository);
var avaliacaoService = new AvaliacaoService(avaliacaoRepository,alunoRepository, turmaRepository);

var ui = new MenuEscola(alunoService, professorService, turmaService, avaliacaoService);

ui.Menu();