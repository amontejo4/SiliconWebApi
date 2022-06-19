using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiliconApi.API.BasicResponses;
using SiliconApi.Common.DTO.Request;
using SiliconApi.Common.DTO.Response;
using SiliconApi.Services;
using System;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SiliconApi.Controllers
{

    [Route("api/activity")]
    public class ActivityController : Controller
    {
        private readonly IActivityService _actService;
        private readonly IMapper _mapper;

        public ActivityController(IActivityService actService, IMapper mapper)
        {
            _actService = actService ?? throw new ArgumentNullException(nameof(actService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }



        /// <summary>
        /// Actividades. Requires authentication.
        /// </summary>
        /// <param name="filtro">filtro</param>
        [HttpGet()]
        [Authorize]
        [Route("getActividades")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ApiResponse), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Actividades([FromBody] ComentarioRequest filtro)
        {
            var result = await _actService.GetActividades(filtro);

            return Ok(new ApiOkResponse(result));
        }


        /// <summary>
        /// Get Actividad Deatalles. Requires authentication.
        /// </summary>
        /// <param name="actividad">actividad</param>
        [HttpGet()]
        [Authorize]
        [Route("getActividadDeatalles")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ApiResponse), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> ActividadDeatalles([FromBody]  ActividadRequest actividad)
        {
            var result = await _actService.GetActividadDetalles(actividad);

            return Ok(new ApiOkResponse(result));
        }

        /// <summary>
        /// insert valoracion y o comentarios. Requires authentication.
        /// </summary>
        /// <param name="feed">comentario-valoracion</param>
        [HttpPost()]
        [Authorize]
        [Route("comeentarioValoracion")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ApiResponse), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> ComeentarioValoracion([FromBody] ComentarioRequest feed)
        {
            await _actService.InsertComentarioValoracion(feed);

            return Created("", true);
        }

        //Reserva(idactividad, fecha)
        /// <summary>
        /// Reserva de actividad. Requires authentication.
        /// </summary>
        /// <param name="reserva">reserva de actividad</param>
        [HttpPost()]
        [Authorize]
        [Route("reservarActividad")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ApiResponse), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> ReservarActividad([FromBody] InsertReservaRequest reserva)
        {
            await _actService.InsertComentarioValoracion(reserva);

            return Created("", true);
        }

      
        /// <summary>
        /// Obtener reservas 
        /// /// </summary>
        /// <param name="dato">idUsuario</param>
        [HttpGet()]
        [Authorize]
        [Route("getReservas")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ApiResponse), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Reservas([FromBody] GetReservasByUSerRequest dato)
        {
            var result = await _actService.GetReservas(dato);

            return Ok(new ApiOkResponse(result));
        } 

        /// <summary>
        /// Obtener reservas 
        /// /// </summary>
        /// <param name="reserva">idUsuario</param>
        /// 
        [HttpPost()]
        [Authorize]
        [Route("Reservar")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ApiResponse), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> Reservar(InsertReservaRequest reserva)
        {
            await _actService.InsertReserva(reserva);

            return Created("", true);
        }

    }
}