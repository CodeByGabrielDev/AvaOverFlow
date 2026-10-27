using Modules.Academico.Domain.Enums;

namespace Modules.Academico.Application.DTOs;


public record UsuarioDto(string? Nome,string? Email, string? SenhaHash,PapelUsuario PapelUsuario,string? Telefone, string? Cpf);


/*public Guid Id{get;private set;}
    public string Nome{get;private set;} = null!;
    public string Email{get;private set;} = null!;
    public string SenhaHash{get;private set;} = null!;
    public List<Aluno> Alunos{get;private set;} = [];
    public List<Coordenacao> Coordenacaos{get;private set;} = [];
    public PapelUsuario PapelUsuario{get;private set;}
    public DateTime CriadoEm{get;private set;}
    public bool Ativo{get;private set;}
*/