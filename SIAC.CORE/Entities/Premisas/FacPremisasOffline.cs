using System;
using System.Collections.Generic;

#nullable disable

namespace SIAC.CORE.Entities.Premisas
{
    public partial class FacPremisasOffline : BaseEntity
    {
        public int Numero_De_Auditoria  {get; set; }
        public DateTime? FechaCargaXls { get; set; }
        public string NombreEmpresa { get; set; }
        public string TipoTrabajo { get; set; }
        public string NombreFuncionario { get; set; }
        public string CodFuncionario { get; set; }
        public string Segmento { get; set; }
        public string Producto { get; set; }
        public string ProductoHomologado { get; set; }
        public string TecnologiaHomologada { get; set; }
        public string Proceso { get; set; }
        public DateTime? FechaPedido { get; set; }
        public string TipoDireccion { get; set; }
        public string Reiterativo { get; set; }
        public string ClienteId { get; set; }
        public string ServicioInstalados { get; set; }
        public string Reparacion { get; set; }
        public string ServiciosInsta { get; set; }
        public string EstadoPedido { get; set; }
        public string MunicipioDane { get; set; }
        public string DepartamentoDane { get; set; }
        public string Direccion { get; set; }
        public string NombreCliente { get; set; }
        public string TelContacto { get; set; }
        public string CelContacto { get; set; }
        public string Microzona { get; set; }
        public string ObservacionTecnico { get; set; }
        public string ObservacionCambioCantidad { get; set; }
        public string Barrio { get; set; }
        public string LatitudLongitudPredio { get; set; }
        public string Naturaleza { get; set; }
        public string ObservaciónCliente { get; set; }
        public string Auditor { get; set; }
        public string Mesa { get; set; }
        public string MesaAsig { get; set; }
        public string Supervisor { get; set; }
        public string Lider { get; set; }
        public string Administrador { get; set; }
        public string Analista { get; set; }
        public string Regional { get; set; }
        public double? HoraInicio { get; set; }
        public string LatitudLongitud { get; set; }
        public string A1 { get; set; }
        public string A1Foto1 { get; set; }
        public string A1Foto2 { get; set; }
        public string A1Foto3 { get; set; }
        public string DetallesA1 { get; set; }
        public string A2 { get; set; }
        public string A2Foto1 { get; set; }
        public string A2Foto2 { get; set; }
        public string A2Foto3 { get; set; }
        public string DetallesA2 { get; set; }
        public string A3 { get; set; }
        public string A3Foto1 { get; set; }
        public string A3Foto2 { get; set; }
        public string A3Foto3 { get; set; }
        public string DetallesA3 { get; set; }
        public string A4 { get; set; }
        public string A4Foto1 { get; set; }
        public string A4Foto2 { get; set; }
        public string A4Foto3 { get; set; }
        public string DetallesA4 { get; set; }
        public string A5 { get; set; }
        public string A5Foto1 { get; set; }
        public string A5Foto2 { get; set; }
        public string A5Foto3 { get; set; }
        public string DetallesA5 { get; set; }
        public string A6 { get; set; }
        public string A6Foto1 { get; set; }
        public string A6Foto2 { get; set; }
        public string A6Foto3 { get; set; }
        public string DetallesA6 { get; set; }
        public string A7 { get; set; }
        public string A7Foto1 { get; set; }
        public string A7Foto2 { get; set; }
        public string A7Foto3 { get; set; }
        public string DetallesA7 { get; set; }
        public string A8 { get; set; }
        public string A8Foto1 { get; set; }
        public string A8Foto2 { get; set; }
        public string A8Foto3 { get; set; }
        public string DetallesA8 { get; set; }
        public string Mat { get; set; }
        public string MatFoto1 { get; set; }
        public string MatFoto2 { get; set; }
        public string MatFoto3 { get; set; }
        public string DetallesMat { get; set; }
        public string SerialMac1 { get; set; }
        public string SerialMac2 { get; set; }
        public string SerialMac3 { get; set; }
        public string SerialMac4 { get; set; }
        public string SerialMac5 { get; set; }
        public string SerialMac6 { get; set; }
        public string OObservacion { get; set; }
        public string OFoto1 { get; set; }
        public string OFoto2 { get; set; }
        public string OFoto3 { get; set; }
        public string DetallesO { get; set; }
        public double? HoraFinalizacion { get; set; }
        public DateTime? Timestamp { get; set; }
        public bool? Enviar { get; set; }
        public string SegmentoBd { get; set; }
        public string ProcesoBd { get; set; }
        public string EmpresaBd { get; set; }
        public string Fuente { get; set; }
        public double? TDespla { get; set; }
        public double? TiempoEnMin { get; set; }
        public bool? TiempoVal { get; set; }
        public int? Mes { get; set; }
        public int? Nombremes { get; set; }
        public int? Año { get; set; }
        public string EstadoGeneral { get; set; }
        public string CalidadData { get; set; }
        public bool? VerfAudit { get; set; }
        public string ErrorDescripcion { get; set; }
        public int? CuentaError { get; set; }
        public bool? ImputAuditor { get; set; }
        public bool? ImputMesa { get; set; }
        public bool? HallazgoGeneral { get; set; }
        public bool? Conciliacion { get; set; }
        public string ResultadoC { get; set; }
        public string DescC { get; set; }
        public string ImputC { get; set; }

        public virtual ICollection<ParamAuditPremOff> Parametros { get; set; }
    }
}
