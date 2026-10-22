using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modules.Academico.Domain.Entities;

namespace Modules.Academico.Infrastructure.Persistence.Configurations;

public class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
{
    public void Configure(EntityTypeBuilder<Professor> builder)
    {
        builder.ToTable("PROFESSORES");
        builder.HasKey(professor=>professor.Id);

        // Usuario não expõe uma coleção de Professores: relacionamento sem navegação inversa.
        builder.HasOne(professor=>professor.Usuario)
               .WithMany()
               .HasForeignKey(professor=>professor.UsuarioId)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);
    }
}
