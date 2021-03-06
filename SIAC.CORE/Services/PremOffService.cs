﻿using SIAC.CORE.Entities.Premisas;
using SIAC.CORE.Exceptions;
using SIAC.CORE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SIAC.CORE.Services
{
    public class PremOffService : IPremOffService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PremOffService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<FacPremisasOffline>> GetAll()
        {
            var res = await _unitOfWork.PremOffRepository.GetAll();
            return res.Take(10);
        }

        public async Task<FacPremisasOffline> GetByPedido(string PedidoID)
        {
            //Obtenemos la info de la premisa
            FacPremisasOffline currentPremisa = await _unitOfWork.PremOffRepository.GetByPedido(PedidoID);

            //Validamos si viene nula
            if (currentPremisa == null || currentPremisa.PedidoID == null)
                throw new GlobalException("Data not found in database", (int)HttpStatusCode.NotFound);

            
            //Obtenemos los parametros de la premisa.
            var Parametros = await _unitOfWork.ParamRepository.GetByPedido(PedidoID);

            //Relacionamos parametros con premisa
            currentPremisa.Parametros = Parametros.ToList();

            return currentPremisa;

        }


    }
}
