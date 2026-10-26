using Microsoft.EntityFrameworkCore;
using Modules.Academico.Application.Interfaces;
using Modules.Academico.Domain.Entities;
using Modules.Academico.Infrastructure.Persistence.Context;

namespace Modules.Infrastructure.Repositories;


public class UsuarioRepository : IUsuarioRepository
{
    /*Task AddAsync(Usuario usuario);
    Task<Usuario> FindById(Guid Id);
    Task<List<Usuario>> FindAllUsers();*/

    private readonly AcademicoDbContext _academicoDbContext;

    public UsuarioRepository(AcademicoDbContext _academicoDbContext)
    {
        this._academicoDbContext = _academicoDbContext;
    }
    public async Task AddAsync(Usuario? usuario)
    {
        await this._academicoDbContext.Usuarios.AddAsync(usuario);
    }

    public async Task<Usuario?> FindById(Guid IdUsuario)
    {
        return await this._academicoDbContext.Usuarios.FindAsync(IdUsuario);

    }
    public async Task<List<Usuario?>> FindAllUsers()
    {
        return await this._academicoDbContext.Usuarios.ToListAsync();
    }


}