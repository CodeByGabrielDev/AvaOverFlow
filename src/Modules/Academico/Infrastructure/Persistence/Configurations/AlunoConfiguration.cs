using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modules.Academico.Domain.Entities;

namespace Modules.Academico.Infrastructure.Persistence.Configurations;


public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
{
    public void Configure(EntityTypeBuilder<Aluno> builder)
    {
        /* public Guid Id{get;private set;}
           public Guid IdUsuario{get;private set;}
           public Usuario Usuario{get; private set;}*/
        builder.ToTable("ALUNOS");
        builder.HasKey(aluno=>aluno.Id);
        builder.HasOne(aluno=>aluno.Usuario)
               .WithMany(usuarios=>usuarios.Alunos)
               .HasForeignKey(aluno=>aluno.IdUsuario)
               .IsRequired();
               
    }
}