using System;

namespace SIAC.CORE.DTOs
{
    public abstract class BasePremOffDTO 
    {
        public long ID { get; set; }

        public string PedidoID { get; set; }

        public DateTime? FechaAuditoria { get; set; }

        public DateTime? Fecha { get; set; }

        public DateTime? FechaCarga { get; set; }

        public DateTime? FechaVerfMes { get; set; }

        public string Observaciones { get; set; }
    }
}
