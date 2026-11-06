namespace Modules.Academico.Domain.Entities;


public class Aluno
{
    public Guid Id{get;private set;}
    public Guid IdUsuario{get;private set;}
    public Usuario Usuario{get; private set;} = null!;


    public Aluno(Guid IdUsuario)
    {
        this.Id = Guid.NewGuid();
        this.IdUsuario = IdUsuario;
    }
}
