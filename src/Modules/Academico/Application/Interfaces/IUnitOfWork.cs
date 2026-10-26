namespace Modules.Academico.Application.Interfaces;


public interface IUnitOfWork
{
    Task SaveChangesAsync();
}