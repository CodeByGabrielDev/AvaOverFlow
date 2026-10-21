using Modules.Academico.Domain.Enums;

namespace Modules.Academico.Domain.Entities;


public sealed class Turma
{
    public Guid Id{get;private set;}
    public string Codigo{get;private set;}
    public Guid PeriodoId{get;private set;}
    public Periodo Periodo{get;private set;}
    public Guid DisciplinaId{get;private set;}
    public Disciplina Disciplina{get;private set;}

    public Guid ProfessorId{get;private set;}
    public Professor Professor{get;private set;}
    public StatusTurma Status{get;private set;}

    
}