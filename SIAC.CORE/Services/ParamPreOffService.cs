using SIAC.CORE.Interfaces;
using SIAC.CORE.Entities.Premisas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAC.CORE.Services
{
    public class ParamPreOffService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ParamPreOffService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<ParamAuditPremOff> GetByID(int id)
        {
            //Obtenemos la info del parametro
            ParamAuditPremOff currentParametro = await _unitOfWork.ParamRepository.GetByID(id);

            /*//Obtenemos la premisa del parametro.
            var premisa = await _unitOfWork.PremOffRepository.GetByPedido(currentParametro.PedidoID);

            //Relacionamos los objetos
            currentParametro.Premisa = premisa;*/

            //Retornamos la información.
            return currentParametro;
        }

        public async Task<IEnumerable<ParamAuditPremOff>> GetByPedido(string PedidoID)
        {
            //Obtenemos los parametros.
            return await _unitOfWork.ParamRepository.GetByPedido(PedidoID);
        }

    }
}
