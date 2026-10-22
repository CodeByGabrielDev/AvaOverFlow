namespace Modules.Academico.Domain.Entities;


public class Aluno
{
    public Guid Id{get;private set;}
    public Guid IdUsuario{get;private set;}
    public Usuario Usuario{get; private set;} = null!;


    public Aluno()
    {
        this.Id = Guid.NewGuid();

    }
}
