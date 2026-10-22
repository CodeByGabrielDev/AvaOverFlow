namespace Modules.Academico.Domain.Entities;


public sealed class Professor
{
    public Guid Id{get;private set;}
    public Guid UsuarioId{get;private set;}
    public Usuario Usuario{get;private set;} = null!;

    public Professor()
    {
        this.Id = Guid.NewGuid();
    }

}