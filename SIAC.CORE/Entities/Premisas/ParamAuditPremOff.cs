#nullable disable

using System.ComponentModel.DataAnnotations.Schema;

namespace SIAC.CORE.Entities.Premisas
{
    public partial class ParamAuditPremOff : BaseEntity
    {
        public string Hallazgo { get; set; }
        public string IdParametro { get; set; }
        public string IdParametroTipo { get; set; }
        public string Foto1 { get; set; }
        public bool? CalFoto1 { get; set; }
        public string Foto2 { get; set; }
        public bool? CalFoto2 { get; set; }
        public string Foto3 { get; set; }
        public bool? CalFoto3 { get; set; }
        public string DatalleHallazgo { get; set; }
        public int? CantFotos { get; set; }
        public int? CantFotosVal { get; set; }
        public bool? CalGeneral { get; set; }
        public string CalDescripcion { get; set; }
        public int? CantError { get; set; }
        public virtual FacPremisasOffline Premisa { get; set; }
    }
}
