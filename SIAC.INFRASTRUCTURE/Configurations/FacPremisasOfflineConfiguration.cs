using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SIAC.CORE.Entities.Premisas;

namespace SIAC.INFRASTRUCTURE.Configurations
{
    public class FacPremisasOfflineConfiguration : IEntityTypeConfiguration<FacPremisasOffline>
    {
        public void Configure(EntityTypeBuilder<FacPremisasOffline> entity)
        {
            entity.ToTable("FacPremisasOffline");

            entity.Property(e => e.ID).HasColumnName("ID");

            entity.Property(e => e.A1).HasMaxLength(255);

            entity.Property(e => e.A1Foto1)
                .HasMaxLength(255)
                .HasColumnName("A1_Foto1");

            entity.Property(e => e.A1Foto2)
                .HasMaxLength(255)
                .HasColumnName("A1_Foto2");

            entity.Property(e => e.A1Foto3)
                .HasMaxLength(255)
                .HasColumnName("A1_Foto3");

            entity.Property(e => e.A2).HasMaxLength(255);

            entity.Property(e => e.A2Foto1)
                .HasMaxLength(255)
                .HasColumnName("A2_Foto1");

            entity.Property(e => e.A2Foto2)
                .HasMaxLength(255)
                .HasColumnName("A2_Foto2");

            entity.Property(e => e.A2Foto3)
                .HasMaxLength(255)
                .HasColumnName("A2_Foto3");

            entity.Property(e => e.A3).HasMaxLength(255);

            entity.Property(e => e.A3Foto1)
                .HasMaxLength(255)
                .HasColumnName("A3_Foto1");

            entity.Property(e => e.A3Foto2)
                .HasMaxLength(255)
                .HasColumnName("A3_Foto2");

            entity.Property(e => e.A3Foto3)
                .HasMaxLength(255)
                .HasColumnName("A3_Foto3");

            entity.Property(e => e.A4).HasMaxLength(255);

            entity.Property(e => e.A4Foto1)
                .HasMaxLength(255)
                .HasColumnName("A4_Foto1");

            entity.Property(e => e.A4Foto2)
                .HasMaxLength(255)
                .HasColumnName("A4_Foto2");

            entity.Property(e => e.A4Foto3)
                .HasMaxLength(255)
                .HasColumnName("A4_Foto3");

            entity.Property(e => e.A5).HasMaxLength(255);

            entity.Property(e => e.A5Foto1)
                .HasMaxLength(255)
                .HasColumnName("A5_Foto1");

            entity.Property(e => e.A5Foto2)
                .HasMaxLength(255)
                .HasColumnName("A5_Foto2");

            entity.Property(e => e.A5Foto3)
                .HasMaxLength(255)
                .HasColumnName("A5_Foto3");

            entity.Property(e => e.A6).HasMaxLength(255);

            entity.Property(e => e.A6Foto1)
                .HasMaxLength(255)
                .HasColumnName("A6_Foto1");

            entity.Property(e => e.A6Foto2)
                .HasMaxLength(255)
                .HasColumnName("A6_Foto2");

            entity.Property(e => e.A6Foto3)
                .HasMaxLength(255)
                .HasColumnName("A6_Foto3");

            entity.Property(e => e.A7).HasMaxLength(255);

            entity.Property(e => e.A7Foto1)
                .HasMaxLength(255)
                .HasColumnName("A7_Foto1");

            entity.Property(e => e.A7Foto2)
                .HasMaxLength(255)
                .HasColumnName("A7_Foto2");

            entity.Property(e => e.A7Foto3)
                .HasMaxLength(255)
                .HasColumnName("A7_Foto3");

            entity.Property(e => e.A8).HasMaxLength(255);

            entity.Property(e => e.A8Foto1)
                .HasMaxLength(255)
                .HasColumnName("A8_Foto1");

            entity.Property(e => e.A8Foto2)
                .HasMaxLength(255)
                .HasColumnName("A8_Foto2");

            entity.Property(e => e.A8Foto3)
                .HasMaxLength(255)
                .HasColumnName("A8_Foto3");

            entity.Property(e => e.Administrador)
                .HasMaxLength(255)
                .HasColumnName("ADMINISTRADOR");

            entity.Property(e => e.Analista)
                .HasMaxLength(255)
                .HasColumnName("ANALISTA");

            entity.Property(e => e.Auditor)
                .HasMaxLength(255)
                .HasColumnName("AUDITOR");

            entity.Property(e => e.Año).HasColumnName("AÑO");

            entity.Property(e => e.Barrio)
                .HasMaxLength(255)
                .HasColumnName("BARRIO");

            entity.Property(e => e.CalidadData)
                .HasMaxLength(255)
                .HasColumnName("CALIDAD_DATA");

            entity.Property(e => e.CelContacto)
                .HasMaxLength(255)
                .HasColumnName("CEL_CONTACTO");

            entity.Property(e => e.ClienteId)
                .HasMaxLength(255)
                .HasColumnName("CLIENTE_ID");

            entity.Property(e => e.CodFuncionario)
                .HasMaxLength(255)
                .HasColumnName("COD_FUNCIONARIO");

            entity.Property(e => e.Conciliacion).HasColumnName("CONCILIACION");

            entity.Property(e => e.CuentaError).HasColumnName("CUENTA_ERROR");

            entity.Property(e => e.DepartamentoDane)
                .HasMaxLength(255)
                .HasColumnName("DEPARTAMENTO_DANE");

            entity.Property(e => e.DescC).HasColumnName("DESC_C");

            entity.Property(e => e.DetallesA1).HasColumnName("DETALLES_A1");

            entity.Property(e => e.DetallesA2).HasColumnName("DETALLES_A2");

            entity.Property(e => e.DetallesA3).HasColumnName("DETALLES_A3");

            entity.Property(e => e.DetallesA4).HasColumnName("DETALLES_A4");

            entity.Property(e => e.DetallesA5).HasColumnName("DETALLES_A5");

            entity.Property(e => e.DetallesA6).HasColumnName("DETALLES_A6");

            entity.Property(e => e.DetallesA7).HasColumnName("DETALLES_A7");

            entity.Property(e => e.DetallesA8).HasColumnName("DETALLES_A8");

            entity.Property(e => e.DetallesMat).HasColumnName("DETALLES_MAT");

            entity.Property(e => e.DetallesO).HasColumnName("DETALLES_O");

            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .HasColumnName("DIRECCION");

            entity.Property(e => e.EmpresaBd)
                .HasMaxLength(255)
                .HasColumnName("EMPRESA_BD");

            entity.Property(e => e.Enviar).HasColumnName("ENVIAR");

            entity.Property(e => e.ErrorDescripcion)
                .HasMaxLength(255)
                .HasColumnName("ERROR_DESCRIPCION");

            entity.Property(e => e.EstadoGeneral)
                .HasMaxLength(255)
                .HasColumnName("ESTADO_GENERAL");

            entity.Property(e => e.EstadoPedido)
                .HasMaxLength(255)
                .HasColumnName("ESTADO_PEDIDO");

            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("FECHA");

            entity.Property(e => e.FechaAuditoria)
                .HasColumnType("date")
                .HasColumnName("FECHA_AUDITORIA");

            entity.Property(e => e.FechaCarga)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_CARGA");

            entity.Property(e => e.FechaCargaXls)
                .HasColumnType("date")
                .HasColumnName("FECHA_CARGA_XLS");

            entity.Property(e => e.FechaPedido)
                .HasColumnType("date")
                .HasColumnName("FECHA_PEDIDO");

            entity.Property(e => e.FechaVerfMes)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_VERF_MES");

            entity.Property(e => e.Fuente)
                .HasMaxLength(255)
                .HasColumnName("FUENTE");

            entity.Property(e => e.HallazgoGeneral).HasColumnName("HALLAZGO_GENERAL");

            entity.Property(e => e.HoraFinalizacion).HasColumnName("HORA_FINALIZACION");

            entity.Property(e => e.HoraInicio).HasColumnName("HORA_INICIO");

            entity.Property(e => e.ImputAuditor).HasColumnName("IMPUT_AUDITOR");

            entity.Property(e => e.ImputC)
                .HasMaxLength(255)
                .HasColumnName("IMPUT_C");

            entity.Property(e => e.ImputMesa).HasColumnName("IMPUT_MESA");

            entity.Property(e => e.LatitudLongitud)
                .HasMaxLength(255)
                .HasColumnName("LATITUD_LONGITUD");

            entity.Property(e => e.LatitudLongitudPredio)
                .HasMaxLength(255)
                .HasColumnName("LATITUD_LONGITUD_PREDIO");

            entity.Property(e => e.Lider)
                .HasMaxLength(255)
                .HasColumnName("LIDER");

            entity.Property(e => e.Mat)
                .HasMaxLength(255)
                .HasColumnName("MAT");

            entity.Property(e => e.MatFoto1)
                .HasMaxLength(255)
                .HasColumnName("MAT_Foto1");

            entity.Property(e => e.MatFoto2)
                .HasMaxLength(255)
                .HasColumnName("MAT_Foto2");

            entity.Property(e => e.MatFoto3)
                .HasMaxLength(255)
                .HasColumnName("MAT_Foto3");

            entity.Property(e => e.Mes).HasColumnName("MES");

            entity.Property(e => e.Mesa)
                .HasMaxLength(255)
                .HasColumnName("MESA");

            entity.Property(e => e.MesaAsig)
                .HasMaxLength(255)
                .HasColumnName("MESA_ASIG");

            entity.Property(e => e.Microzona)
                .HasMaxLength(255)
                .HasColumnName("MICROZONA");

            entity.Property(e => e.MunicipioDane)
                .HasMaxLength(255)
                .HasColumnName("MUNICIPIO_DANE");

            entity.Property(e => e.Naturaleza)
                .HasMaxLength(255)
                .HasColumnName("NATURALEZA");

            entity.Property(e => e.NombreCliente)
                .HasMaxLength(255)
                .HasColumnName("NOMBRE_CLIENTE");

            entity.Property(e => e.NombreEmpresa)
                .HasMaxLength(255)
                .HasColumnName("NOMBRE_EMPRESA");

            entity.Property(e => e.NombreFuncionario)
                .HasMaxLength(255)
                .HasColumnName("NOMBRE_FUNCIONARIO");

            entity.Property(e => e.Nombremes).HasColumnName("NOMBREMES");

            entity.Property(e => e.Numero_De_Auditoria).HasColumnName("NUMERO_DE_AUDITORIA");

            entity.Property(e => e.OFoto1)
                .HasMaxLength(255)
                .HasColumnName("O_Foto1");

            entity.Property(e => e.OFoto2)
                .HasMaxLength(255)
                .HasColumnName("O_Foto2");

            entity.Property(e => e.OFoto3)
                .HasMaxLength(255)
                .HasColumnName("O_Foto3");

            entity.Property(e => e.OObservacion)
                .HasMaxLength(255)
                .HasColumnName("O_OBSERVACION");

            entity.Property(e => e.Observaciones).HasColumnName("OBS_VERF");

            entity.Property(e => e.ObservacionCambioCantidad).HasColumnName("OBSERVACION_CAMBIO_CANTIDAD");

            entity.Property(e => e.ObservacionTecnico).HasColumnName("OBSERVACION_TECNICO");

            entity.Property(e => e.ObservaciónCliente).HasColumnName("OBSERVACIÓN_CLIENTE");

            entity.Property(e => e.PedidoID)
                .HasMaxLength(255)
                .HasColumnName("PEDIDO_ID");

            entity.Property(e => e.Proceso)
                .HasMaxLength(255)
                .HasColumnName("PROCESO");

            entity.Property(e => e.ProcesoBd)
                .HasMaxLength(255)
                .HasColumnName("PROCESO_BD");

            entity.Property(e => e.Producto)
                .HasMaxLength(255)
                .HasColumnName("PRODUCTO");

            entity.Property(e => e.ProductoHomologado)
                .HasMaxLength(255)
                .HasColumnName("PRODUCTO_HOMOLOGADO");

            entity.Property(e => e.Regional)
                .HasMaxLength(255)
                .HasColumnName("REGIONAL");

            entity.Property(e => e.Reiterativo)
                .HasMaxLength(255)
                .HasColumnName("REITERATIVO");

            entity.Property(e => e.Reparacion)
                .HasMaxLength(255)
                .HasColumnName("REPARACION");

            entity.Property(e => e.ResultadoC).HasColumnName("RESULTADO_C");

            entity.Property(e => e.Segmento)
                .HasMaxLength(255)
                .HasColumnName("SEGMENTO");

            entity.Property(e => e.SegmentoBd)
                .HasMaxLength(255)
                .HasColumnName("SEGMENTO_BD");

            entity.Property(e => e.SerialMac1)
                .HasMaxLength(255)
                .HasColumnName("SERIAL_MAC_1");

            entity.Property(e => e.SerialMac2)
                .HasMaxLength(255)
                .HasColumnName("SERIAL_MAC_2");

            entity.Property(e => e.SerialMac3)
                .HasMaxLength(255)
                .HasColumnName("SERIAL_MAC_3");

            entity.Property(e => e.SerialMac4)
                .HasMaxLength(255)
                .HasColumnName("SERIAL_MAC_4");

            entity.Property(e => e.SerialMac5)
                .HasMaxLength(255)
                .HasColumnName("SERIAL_MAC_5");

            entity.Property(e => e.SerialMac6)
                .HasMaxLength(255)
                .HasColumnName("SERIAL_MAC_6");

            entity.Property(e => e.ServicioInstalados).HasColumnName("SERVICIO_INSTALADOS");

            entity.Property(e => e.ServiciosInsta)
                .HasMaxLength(255)
                .HasColumnName("SERVICIOS_INSTA");

            entity.Property(e => e.Supervisor)
                .HasMaxLength(255)
                .HasColumnName("SUPERVISOR");

            entity.Property(e => e.TDespla).HasColumnName("T_DESPLA");

            entity.Property(e => e.TecnologiaHomologada)
                .HasMaxLength(255)
                .HasColumnName("TECNOLOGIA_HOMOLOGADA");

            entity.Property(e => e.TelContacto)
                .HasMaxLength(255)
                .HasColumnName("TEL_CONTACTO");

            entity.Property(e => e.TiempoEnMin).HasColumnName("TIEMPO_EN_MIN");

            entity.Property(e => e.TiempoVal).HasColumnName("TIEMPO_VAL");

            entity.Property(e => e.Timestamp)
                .HasColumnType("datetime")
                .HasColumnName("TIMESTAMP");

            entity.Property(e => e.TipoDireccion)
                .HasMaxLength(255)
                .HasColumnName("TIPO_DIRECCION");

            entity.Property(e => e.TipoTrabajo)
                .HasMaxLength(255)
                .HasColumnName("TIPO_TRABAJO");

            entity.Property(e => e.VerfAudit).HasColumnName("VERF_AUDIT");
        }
    }
}
