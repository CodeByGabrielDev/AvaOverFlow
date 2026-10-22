using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modules.Academico.Domain.Entities;

namespace Modules.Academico.Infrastructure.Persistence.Configurations;

public class TurmaConfiguration : IEntityTypeConfiguration<Turma>
{
    public void Configure(EntityTypeBuilder<Turma> builder)
    {
        builder.ToTable("TURMAS");
        builder.HasKey(turma=>turma.Id);

        builder.Property(turma=>turma.Codigo)
               .HasMaxLength(50)
               .IsRequired();

        builder.Property(turma=>turma.Status)
               .HasConversion<string>()
               .HasMaxLength(20)
               .IsRequired();

        builder.HasOne(turma=>turma.Periodo)
               .WithMany()
               .HasForeignKey(turma=>turma.PeriodoId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(turma=>turma.Disciplina)
               .WithMany()
               .HasForeignKey(turma=>turma.DisciplinaId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(turma=>turma.Professor)
               .WithMany()
               .HasForeignKey(turma=>turma.ProfessorId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);
    }
}
