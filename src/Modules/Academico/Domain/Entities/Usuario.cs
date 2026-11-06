using Modules.Academico.Domain.Enums;
using Modules.Academico.Domain.Exceptions;

namespace Modules.Academico.Domain.Entities;


public sealed class Usuario
{
    public Guid Id { get; private set; }
    public string Nome { get; private set; } = null!;
    public string Cpf { get; private set; } = null!;
    public string? Telefone { get; private set; } = null!;
    public string Email { get; private set; } = null!;
    public string SenhaHash { get; private set; } = null!;
    public List<Aluno> Alunos { get; private set; } = [];
    public List<Coordenacao> Coordenacaos { get; private set; } = [];
    public List<Professor> Professores { get; private set; } = [];
    public PapelUsuario PapelUsuario { get; private set; }
    public DateTime CriadoEm { get; private set; }
    public bool Ativo { get; private set; }

    public Usuario()
    {
    }

    public Usuario(string nome, string email, string cpf, string telefone)
    {
        this.Id = Guid.NewGuid();
        this.Ativo = true;
        this.CriadoEm = DateTime.UtcNow;
        this.Nome = nome;
        this.Cpf = cpf;
        this.Telefone = telefone;
        this.Email = email;
    }



    public PapelUsuario RetornarTipoDePapelUsuario(PapelUsuario papelUsuario)
    {
        if (papelUsuario == PapelUsuario.ALUNO) return PapelUsuario.ALUNO;
        if (papelUsuario == PapelUsuario.COORDENACAO) return PapelUsuario.COORDENACAO;
        if (papelUsuario == PapelUsuario.PROFESSOR) return PapelUsuario.PROFESSOR;
        throw new DomainException("Enum invalido");
    }

    public void DefinirPapelDoUsuario(PapelUsuario papelUsuarioEntradaDto)
    {
        if (papelUsuarioEntradaDto == PapelUsuario.ALUNO) this.PapelUsuario = papelUsuarioEntradaDto;
        if (papelUsuarioEntradaDto == PapelUsuario.COORDENACAO) this.PapelUsuario = papelUsuarioEntradaDto;
        if (papelUsuarioEntradaDto == PapelUsuario.PROFESSOR) this.PapelUsuario = papelUsuarioEntradaDto;
        throw new DomainException("Papel de usuario não encontrado na base.");
    }
    public void DefinirSenha(string senha)
    {
        this.SenhaHash = senha;
    }

    public void CriarVinculoAcademico()
    {
        if (this.PapelUsuario == PapelUsuario.ALUNO) this.Alunos.Add(new Aluno(this.Id));
        if (this.PapelUsuario == PapelUsuario.COORDENACAO) this.Coordenacaos.Add(new Coordenacao(this.Id));
        if (this.PapelUsuario == PapelUsuario.PROFESSOR) this.Professores.Add(new Professor(this.Id));
    }
}