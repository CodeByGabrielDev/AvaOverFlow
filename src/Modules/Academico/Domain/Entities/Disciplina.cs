namespace Modules.Academico.Domain.Entities;


public class Disciplina
{
    public Guid Id{get;private set;}
    public int Codigo{get;private set;}
    public string Nome{get;private set;}

    public Disciplina(int codigo,string nome)
    {
        this.Codigo = codigo;
        this.Nome = nome;
    }
}