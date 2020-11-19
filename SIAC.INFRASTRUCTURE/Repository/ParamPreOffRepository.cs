using SIAC.CORE.Entities.Premisas;
using SIAC.CORE.Interfaces;
using SIAC.INFRASTRUCTURE.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAC.INFRASTRUCTURE.Repository
{
    public class ParamPreOffRepository : BaseRepository<ParamAuditPremOff>, IParamPreOffRepository
    {

        public ParamPreOffRepository(AuditoriaDeCampoContext context) : base(context)
        {
        }

        public async Task<IEnumerable<ParamAuditPremOff>> GetByPedido(string PedidoID)
        {
            return await Task.Run(() =>
            {
                return _entity.Where(x => x.PedidoID == (PedidoID)).ToList();
            });

        }

    }
}
