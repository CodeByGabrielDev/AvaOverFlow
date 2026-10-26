using Modules.Academico.Application.Interfaces;
using Modules.Academico.Infrastructure.Persistence.Context;

namespace Modules.Infrastructure.Persistence.Repositories;


public class UnitOfWork : IUnitOfWork
{
    private readonly AcademicoDbContext _academicoDbContext;

    public UnitOfWork(AcademicoDbContext _academicoDbContext)
    {
        this._academicoDbContext = _academicoDbContext;
    }
    public async Task SaveChangesAsync()
    {
        await this._academicoDbContext.SaveChangesAsync();
    }
}