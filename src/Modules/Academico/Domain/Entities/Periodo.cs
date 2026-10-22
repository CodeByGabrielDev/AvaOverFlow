using Modules.Academico.Domain.Enums;

namespace Modules.Academico.Domain.Entities;


public class Periodo
{
    public Guid Id{get;private set;}

    public string Nome{get;private set;} = null!;
    public DateTime DataInicio{get;private set;}
    public DateTime? DataFim{get;private set;}
    public StatusPeriodo StatusPeriodo{get;private set;}
    public DateTime CriadoEm{get;private set;}
}