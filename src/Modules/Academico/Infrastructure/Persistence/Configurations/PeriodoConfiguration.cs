using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modules.Academico.Domain.Entities;

namespace Modules.Academico.Infrastructure.Persistence.Configurations;

public class PeriodoConfiguration : IEntityTypeConfiguration<Periodo>
{
    public void Configure(EntityTypeBuilder<Periodo> builder)
    {
        builder.ToTable("PERIODOS");
        builder.HasKey(periodo=>periodo.Id);

        builder.Property(periodo=>periodo.Nome)
               .HasMaxLength(100)
               .IsRequired();

        builder.Property(periodo=>periodo.DataInicio)
               .IsRequired();

        builder.Property(periodo=>periodo.DataFim)
               .IsRequired(false);

        builder.Property(periodo=>periodo.StatusPeriodo)
               .HasConversion<string>()
               .HasMaxLength(20)
               .IsRequired();

        builder.Property(periodo=>periodo.CriadoEm)
               .IsRequired();
    }
}
