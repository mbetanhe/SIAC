using SIAC.CORE.Entities.Premisas;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SIAC.CORE.Interfaces
{
    public interface IPremOffService
    {
        Task<IEnumerable<FacPremisasOffline>> GetAll();
        Task<FacPremisasOffline> GetByPedido(string PedidoID);
    }
}