namespace Modules.Academico.Domain.Entities;


public sealed class Professor
{
    public Guid Id{get;private set;}
    public Guid UsuarioId{get;private set;}
    public Usuario Usuario{get;private set;} = null!;

    public Professor(Guid UsuarioId)
    {
        this.Id = Guid.NewGuid();
        this.UsuarioId = UsuarioId;
    }

}