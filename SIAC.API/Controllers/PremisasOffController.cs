using Microsoft.AspNetCore.Mvc;
using SIAC.API.Responses;
using SIAC.CORE.Entities.Premisas;
using SIAC.CORE.Interfaces;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace SIAC.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PremisasOffController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PremisasOffController(IUnitOfWork UnitOfWork) => _unitOfWork = UnitOfWork;


        /// <summary>
        /// Retorna todos los registros de las premisas.
        /// </summary>
        /// <returns>Premisas Offilne</returns>
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<FacPremisasOffline>))]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            //Obtenemos la data.
            var result = await _unitOfWork.PremOffRepository.GetAll();

            return Ok(result);
        }


        /// <summary>
        /// Retorna todos los registros de las premisas.
        /// </summary>
        /// <returns>Premisas Offilne</returns>
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(FacPremisasOffline))]
        [HttpGet("{PedidoID}")]
        public async Task<IActionResult> GetByPedido(string PedidoID)
        {

            //Obtenemos la data.
            var result = new ApiResponse<FacPremisasOffline>(await _unitOfWork.PremOffRepository.GetByPedido(PedidoID), 1);

            return Ok(result);
        }

    }


}
