

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modules.Academico.Domain.Entities;

namespace Modules.Academico.Infrastructure.Persistence.Configurations;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        /*public Guid Id{get;private set;}
          public Guid IdUsuario{get;private set;}
          public Usuario Usuario{get; private set;}*/
        builder.ToTable("USUARIOS");
        builder.HasKey(user=>user.Id);
        // TODO: linha incompleta comentada para o projeto compilar — completar o relacionamento.
        // builder.HasOne(user=>user.)
    }
}