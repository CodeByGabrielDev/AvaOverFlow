using Modules.Academico.Domain.Entities;

namespace Modules.Academico.Application.Interfaces;

public interface IAlunoRepository
{
    Task AddAsync(Aluno usuario);
    Task<Aluno> FindById(Guid Id);
    Task<List<Aluno>> FindAllUsers();
}