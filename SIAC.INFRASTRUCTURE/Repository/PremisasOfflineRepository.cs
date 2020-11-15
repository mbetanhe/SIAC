using SIAC.INFRASTRUCTURE.Data;
using SIAC.CORE.Entities.Premisas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIAC.CORE.Interfaces;

namespace SIAC.INFRASTRUCTURE.Repository
{
    public class PremisasOfflineRepository : BaseRepository<FacPremisasOffline>,  IPremisasOfflineRepository
    {

        public PremisasOfflineRepository(AuditoriaDeCampoContext context) : base(context)
        {

        }

        /// <summary>
        /// Obtenemos pedidos por ID de pedido
        /// </summary>
        /// <param name="PedidoID">ID del pedido</param>
        /// <returns></returns>
        public async Task<FacPremisasOffline> GetByPedido(string PedidoID)
        {
            FacPremisasOffline current = await Task.Run(() => {
                return _entity.Where(x => x.PedidoID.ToLower().Equals(PedidoID.ToLower())).FirstOrDefault();
             });

            return current;
        }
    }
}
