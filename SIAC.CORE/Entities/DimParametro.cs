using System;
using System.Collections.Generic;

#nullable disable

namespace SIAC.CORE.Entities
{ 
    public partial class DimParametro
    {
        public int KeyParametro { get; set; }
        public string IdParametroTipo { get; set; }
        public string IdParametro { get; set; }
        public string NombreParametro { get; set; }
        public string IdClassParametro { get; set; }
        public string ClassParametro { get; set; }
        public string TipoAuditoria { get; set; }
        public string Proceso { get; set; }
        public string EstadoParam { get; set; }
        public string Observacion { get; set; }
    }
}
