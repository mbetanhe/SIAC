using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIAC.CORE.Entities.Premisas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAC.INFRASTRUCTURE.Configurations
{
    public class ParamAuditPremOffConfiguration : IEntityTypeConfiguration<ParamAuditPremOff>
    {
        public void Configure(EntityTypeBuilder<ParamAuditPremOff> entity)
        {
            entity.ToTable("ParamAuditPremOff");

            entity.Property(e => e.ID).HasColumnName("ID");

            entity.Property(e => e.CalDescripcion)
                .HasMaxLength(255)
                .HasColumnName("CAL_DESCRIPCION");

            entity.Ignore(e => e.Premisa);

            entity.Property(e => e.CalFoto1).HasColumnName("CAL_FOTO1");

            entity.Property(e => e.CalFoto2).HasColumnName("CAL_FOTO2");

            entity.Property(e => e.CalFoto3).HasColumnName("CAL_FOTO3");

            entity.Property(e => e.CalGeneral).HasColumnName("CAL_GENERAL");

            entity.Property(e => e.CantError).HasColumnName("CANT_ERROR");

            entity.Property(e => e.CantFotos).HasColumnName("CANT_FOTOS");

            entity.Property(e => e.CantFotosVal).HasColumnName("CANT_FOTOS_VAL");

            entity.Property(e => e.DatalleHallazgo).HasColumnName("DATALLE_HALLAZGO");

            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("FECHA");

            entity.Property(e => e.FechaAuditoria)
                .HasColumnType("date")
                .HasColumnName("FECHA_AUDITORIA");

            entity.Property(e => e.FechaCarga)
                .HasColumnType("date")
                .HasColumnName("FECHA_CARGA");

            entity.Property(e => e.FechaVerfMes)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_VERF_MESA");

            entity.Property(e => e.Foto1)
                .HasMaxLength(255)
                .HasColumnName("FOTO1");

            entity.Property(e => e.Foto2)
                .HasMaxLength(255)
                .HasColumnName("FOTO2");

            entity.Property(e => e.Foto3)
                .HasMaxLength(255)
                .HasColumnName("FOTO3");

            entity.Property(e => e.Hallazgo)
                .HasMaxLength(55)
                .HasColumnName("HALLAZGO");

            entity.Property(e => e.IdParametro)
                .HasMaxLength(255)
                .HasColumnName("ID_PARAMETRO");

            entity.Property(e => e.IdParametroTipo)
                .HasMaxLength(10)
                .HasColumnName("ID_PARAMETRO_TIPO");

            entity.Property(e => e.Observaciones).HasColumnName("OBSERVACIONES");

            entity.Property(e => e.PedidoID)
                .HasMaxLength(55)
                .HasColumnName("PEDIDO_ID");
        }
    }
}
