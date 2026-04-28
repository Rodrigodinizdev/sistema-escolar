using Escola.Enums;
namespace Escola.DTOs;

 public record AvaliacaoDto(Guid AlunoId, Guid TurmaId, TipoAvaliacaoEnum Tipo, string Titulo, DateTime DataAvaliacao, decimal Nota);
