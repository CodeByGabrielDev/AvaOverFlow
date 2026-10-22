using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modules.Academico.Domain.Entities;

namespace Modules.Academico.Infrastructure.Persistence.Configurations;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("USUARIOS");
        builder.HasKey(user=>user.Id);

        builder.Property(user=>user.Nome)
               .HasMaxLength(150)
               .IsRequired();

        builder.Property(user=>user.Email)
               .HasMaxLength(254)
               .IsRequired();

        // Login é feito por e-mail (regras-de-negocio.md, item 5).
        builder.HasIndex(user=>user.Email)
               .IsUnique();

        builder.Property(user=>user.SenhaHash)
               .HasMaxLength(255)
               .IsRequired();

        builder.Property(user=>user.PapelUsuario)
               .HasConversion<string>()
               .HasMaxLength(20)
               .IsRequired();

        builder.Property(user=>user.CriadoEm)
               .IsRequired();

        builder.Property(user=>user.Ativo)
               .IsRequired();

        // Os relacionamentos com Aluno e Coordenacao são configurados no lado dependente.
    }
}
