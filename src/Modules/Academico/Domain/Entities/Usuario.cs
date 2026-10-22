using Modules.Academico.Domain.Enums;

namespace Modules.Academico.Domain.Entities;


public sealed class Usuario
{
    public Guid Id{get;private set;}
    public string Nome{get;private set;} = null!;
    public string Email{get;private set;} = null!;
    public string SenhaHash{get;private set;} = null!;
    public List<Aluno> Alunos{get;private set;} = [];
    public List<Coordenacao> Coordenacaos{get;private set;} = [];
    public PapelUsuario PapelUsuario{get;private set;}
    public DateTime CriadoEm{get;private set;}
    public bool Ativo{get;private set;}

    public Usuario()
    {
    }

    public Usuario(string nome,string email,string senhaHash,PapelUsuario papelUsuario)
    {
        this.Id = Guid.NewGuid();
        this.Ativo = true;
        this.CriadoEm = DateTime.UtcNow;
        this.Nome = nome;
        this.Email = email;
        this.SenhaHash = senhaHash;
        this.PapelUsuario = papelUsuario;
    }
}