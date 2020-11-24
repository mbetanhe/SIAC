using SIAC.CORE.Entities.Premisas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAC.CORE.DTOs
{
    public class PremisasOffDTO : BasePremOffDTO
    {
        public string TipoTrabajo { get; set; }
        public string Producto { get; set; }
        public string TecnologiaHomologada { get; set; }
        public string Proceso { get; set; }
        public string Auditor { get; set; }
        public string SegmentoBd { get; set; }
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
