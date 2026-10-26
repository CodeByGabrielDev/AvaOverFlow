using Microsoft.EntityFrameworkCore;
using Modules.Academico.Domain.Entities;
using Modules.Academico.Infrastructure.Persistence.Context;
using Modules.Academico.Application.Interfaces;

namespace Modules.Infrastructure.Repositories;



public class AlunoRepository : IAlunoRepository
{   

    private readonly AcademicoDbContext _academicoContext;

    public AlunoRepository(AcademicoDbContext _academicoContext)
    {
        this._academicoContext = _academicoContext;
    }

    /*Task AddAsync(Usuario usuario);
    Task<Usuario> FindById(Guid Id);
    Task<List<Usuario>> FindAllUsers();*/

    public async Task AddAsync(Aluno usuario)
    {
        await this._academicoContext.Alunos.AddAsync(usuario);
    }
    public async Task<Aluno?> FindById(Guid Id)
    {
        return await this._academicoContext.Alunos.FindAsync(Id);
    }

    public async Task<List<Aluno?>> FindAllUsers()
    {
        return await this._academicoContext.Alunos.ToListAsync();
    }
}