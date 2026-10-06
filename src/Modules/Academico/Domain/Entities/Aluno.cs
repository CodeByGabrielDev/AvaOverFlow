namespace Modules.Academico.Application.Domain.Entities;


public class Aluno
{
    public Guid Id{get;private set;}
    public Guid IdUsuario{get;private set;}
    public Usuario Usuario{get; private set;}

    public Aluno()
    {
        this.Id = new Guid();
    }
}