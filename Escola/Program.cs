using Escola.Repository;
using Escola.Service;
using Escola.Ui;

var alunoRepository = new AlunoRepository();
var professorRepository = new ProfessorRepository();

var alunoService = new AlunoService(alunoRepository);
var professorService = new ProfessorService(professorRepository);

var ui = new MenuEscola(alunoService, professorService);

ui.Menu();