using Modules.Academico.Domain.Enums;

namespace Modules.Academico.Domain.Entities;


public class Matricula
{
    public Guid Id{get; private set;}
    public Guid AlunoId{get;private set;}
    public Guid TurmaId{get; private set;}
    public StatusMatricula StatusMatricula{get;private set;} 
    public DateTime DataMatricula{get;private set;}
    public DateTime? DataTrancamento{get;private set;} = null;
    public DateTime? DataConclusao{get; private set;} = null;

    public Matricula()
    {
    }
    public Matricula(Guid alunoId,Guid turmaId,StatusMatricula statusMatricula)
    {
        this.Id = Guid.NewGuid();
        this.AlunoId = alunoId;
        this.TurmaId = turmaId;
        this.StatusMatricula = statusMatricula;
        this.DataMatricula = DateTime.UtcNow;

    }
}