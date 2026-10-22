using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modules.Academico.Domain.Entities;

namespace Modules.Academico.Infrastructure.Persistence.Configurations;

public class DisciplinaConfiguration : IEntityTypeConfiguration<Disciplina>
{
    public void Configure(EntityTypeBuilder<Disciplina> builder)
    {
        builder.ToTable("DISCIPLINAS");
        builder.HasKey(disciplina=>disciplina.Id);

        builder.Property(disciplina=>disciplina.Codigo)
               .IsRequired();

        // Codigo é o identificador de negócio da disciplina.
        builder.HasIndex(disciplina=>disciplina.Codigo)
               .IsUnique();

        builder.Property(disciplina=>disciplina.Nome)
               .HasMaxLength(150)
               .IsRequired();

        builder.Property(disciplina=>disciplina.CargaHoraria)
               .IsRequired();
    }
}
