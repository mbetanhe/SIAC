using SIAC.CORE.Entities.Premisas;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SIAC.CORE.Interfaces
{
    public interface IParamPreOffRepository : IRepository<ParamAuditPremOff>
    {
        Task<IEnumerable<ParamAuditPremOff>> GetByPedido(string PedidoID);
    }
}