using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAC.CORE.Entities
{
    public abstract class BaseEntity
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
