using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modules.Academico.Domain.Entities;

namespace Modules.Academico.Infrastructure.Persistence.Configurations;

public class CoordenacaoConfiguration : IEntityTypeConfiguration<Coordenacao>
{
    public void Configure(EntityTypeBuilder<Coordenacao> builder)
    {
        builder.ToTable("COORDENACAO");
        builder.HasKey(coor=>coor.Id);
        builder.HasOne(coor=>coor.Usuario)
               .WithMany(usuario=>usuario.Coordenacaos)
               .HasForeignKey(coor=>coor.UsuarioId)
               .IsRequired();
    }
}