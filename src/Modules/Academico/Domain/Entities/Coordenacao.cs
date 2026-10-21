namespace Modules.Academico.Domain.Entities;


public class Coordenacao
{
    public Guid Id{get;private set;}
    public Guid UsuarioId{get;private set;}
    public Usuario Usuario{get;private set;}

    public Coordenacao()
    {
        this.Id = new Guid();
    }
}