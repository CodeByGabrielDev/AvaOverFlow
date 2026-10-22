using Microsoft.EntityFrameworkCore;
using Modules.Academico.Domain.Entities;

namespace Modules.Academico.Infrastructure.Persistence.Context;

public class AcademicoDbContext : DbContext
{
    public const string Schema = "academico";

    public AcademicoDbContext(
        DbContextOptions<AcademicoDbContext> options)
        : base(options)
    {
    }

    public DbSet<Usuario> Usuarios => Set<Usuario>();
    public DbSet<Aluno> Alunos => Set<Aluno>();
    public DbSet<Professor> Professores => Set<Professor>();
    public DbSet<Coordenacao> Coordenacoes => Set<Coordenacao>();
    public DbSet<Periodo> Periodos => Set<Periodo>();
    public DbSet<Disciplina> Disciplinas => Set<Disciplina>();
    public DbSet<Turma> Turmas => Set<Turma>();
    public DbSet<Matricula> Matriculas => Set<Matricula>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Cada módulo do monólito tem suas próprias tabelas (ADR 001).
        modelBuilder.HasDefaultSchema(Schema);

        modelBuilder.ApplyConfigurationsFromAssembly(
            typeof(AcademicoDbContext).Assembly);
    }
}
