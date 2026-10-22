using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modules.Academico.Domain.Entities;

namespace Modules.Academico.Infrastructure.Persistence.Configurations;

public class MatriculaConfiguration : IEntityTypeConfiguration<Matricula>
{
    public void Configure(EntityTypeBuilder<Matricula> builder)
    {
        builder.ToTable("MATRICULAS");
        builder.HasKey(matricula=>matricula.Id);

        builder.Property(matricula=>matricula.StatusMatricula)
               .HasConversion<string>()
               .HasMaxLength(20)
               .IsRequired();

        builder.Property(matricula=>matricula.DataMatricula)
               .IsRequired();

        builder.Property(matricula=>matricula.DataTrancamento)
               .IsRequired(false);

        builder.Property(matricula=>matricula.DataConclusao)
               .IsRequired(false);

        // Matricula expõe apenas as chaves estrangeiras: relacionamentos sem navegação.
        builder.HasOne<Aluno>()
               .WithMany()
               .HasForeignKey(matricula=>matricula.AlunoId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne<Turma>()
               .WithMany()
               .HasForeignKey(matricula=>matricula.TurmaId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);
    }
}
