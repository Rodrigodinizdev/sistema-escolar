using Escola.Enums;

namespace Escola.DTOs;

    public record TurmaDto(string Nome, TurnoTurmaEnum Turno, Guid ProfessorId);
    
