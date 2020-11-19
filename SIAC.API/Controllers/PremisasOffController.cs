using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SIAC.API.Responses;
using SIAC.CORE.DTOs;
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
        private readonly IPremOffService _premOffService;
        private readonly IMapper _mapper;

        //private readonly IUnitOfWork _unitOfWork;


        //public PremisasOffController(IUnitOfWork UnitOfWork) => _unitOfWork = UnitOfWork;

        public PremisasOffController(IPremOffService premOffService, IMapper mapper)
        {
            _premOffService = premOffService;
            _mapper = mapper;
        }


        /// <summary>
        /// Retorna todos los registros de las premisas.
        /// </summary>
        /// <returns>Premisas Offilne</returns>
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(IEnumerable<FacPremisasOffline>))]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            //Obtenemos la data.
            var result = await _premOffService.GetAll();

            return Ok(result);
        }


        /// <summary>
        /// Retorna todos los registros de las premisas.
        /// </summary>
        /// <returns>Premisas Offilne</returns>
        [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(PremisasOffDTO))]
        [HttpGet("{PedidoID}")]
        public async Task<IActionResult> GetByPedido(string PedidoID)
        {

            //Obtenemos la data.
            var result = new ApiResponse<PremisasOffDTO>( _mapper.Map<PremisasOffDTO>(await _premOffService.GetByPedido(PedidoID)), 1);

            return Ok(result);
        }

    }


}
