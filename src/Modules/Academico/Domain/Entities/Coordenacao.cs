namespace Modules.Academico.Domain.Entities;


public class Coordenacao
{
    public Guid Id{get;private set;}
    public Guid UsuarioId{get;private set;}
    public Usuario Usuario{get;private set;} = null!;

    public Coordenacao()
    {
        this.Id = Guid.NewGuid();
    }
}