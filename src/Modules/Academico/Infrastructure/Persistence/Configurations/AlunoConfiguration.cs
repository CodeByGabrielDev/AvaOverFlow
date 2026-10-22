using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modules.Academico.Domain.Entities;

namespace Modules.Academico.Infrastructure.Persistence.Configurations;


public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
{
    public void Configure(EntityTypeBuilder<Aluno> builder)
    {
        builder.ToTable("ALUNOS");
        builder.HasKey(aluno=>aluno.Id);

        builder.HasOne(aluno=>aluno.Usuario)
               .WithMany(usuarios=>usuarios.Alunos)
               .HasForeignKey(aluno=>aluno.IdUsuario)
               .IsRequired()
               .OnDelete(DeleteBehavior.Restrict);
    }
}
