using SIAC.CORE.Entities.Premisas;
using System.Threading.Tasks;

namespace SIAC.CORE.Interfaces
{
    public interface IPremisasOfflineRepository : IRepository<FacPremisasOffline>
    {
        Task<FacPremisasOffline> GetByPedido(string PedidoID);
    }
}