using Modules.Academico.Domain.Entities;

namespace Modules.Academico.Application.Interfaces;

public interface IUsuarioRepository
{
    Task AddAsync(Usuario usuario);
    Task<Usuario> FindById(Guid Id);
    Task<List<Usuario>> FindAllUsers();

    Task<Usuario?> FindByCpf(string? cpf);
}