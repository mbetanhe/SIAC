using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIAC.CORE.Entities;

namespace SIAC.INFRASTRUCTURE.Configurations
{
    public class DimParametroConfiguration : IEntityTypeConfiguration<DimParametro>
    {
        public void Configure(EntityTypeBuilder<DimParametro> entity)
        {
            entity.HasKey(e => e.KeyParametro);

            entity.Property(e => e.KeyParametro).HasColumnName("KEY_PARAMETRO");

            entity.Property(e => e.ClassParametro)
                .HasMaxLength(55)
                .HasColumnName("CLASS_PARAMETRO");

            entity.Property(e => e.EstadoParam)
                .HasMaxLength(55)
                .HasColumnName("ESTADO_PARAM");

            entity.Property(e => e.IdClassParametro)
                .HasMaxLength(55)
                .HasColumnName("ID_CLASS_PARAMETRO");

            entity.Property(e => e.IdParametro)
                .HasMaxLength(50)
                .HasColumnName("ID_PARAMETRO");

            entity.Property(e => e.IdParametroTipo)
                .HasMaxLength(10)
                .HasColumnName("ID_PARAMETRO_TIPO");

            entity.Property(e => e.NombreParametro)
                .HasMaxLength(55)
                .HasColumnName("NOMBRE_PARAMETRO");

            entity.Property(e => e.Observacion)
                .HasMaxLength(255)
                .HasColumnName("OBSERVACION");

            entity.Property(e => e.Proceso)
                .HasMaxLength(55)
                .HasColumnName("PROCESO");

            entity.Property(e => e.TipoAuditoria)
                .HasMaxLength(55)
                .HasColumnName("TIPO_AUDITORIA");
        }
    }
}
