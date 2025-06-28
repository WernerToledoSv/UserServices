using Application.Feature.Lugar.Queries;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Lugar;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controller.v1
{
    public class PacienteController : BaseApiController
    {
        private readonly ILogger<PacienteController> _logger;

        public PacienteController(ILogger<PacienteController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Listado")]
        [ProducesResponseType(typeof(ObjectResponse<LugarResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> ObtenerPacienteByLugar()
        {
            try
            {
                var rs = await Mediator.Send(new ObtenerLugarQuery());
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en el listado de pacientes. {ex.Message}";
                _logger.LogError(ex, "{Message} -> {EMessage}", message, ex.Message);
                var rs = new GenericResponse()
                {
                    Code = 0,
                    Message = message
                };

                return StatusCode(500, rs);
            }

        }

        [HttpGet("Buscar-ByNombre")]
        [ProducesResponseType(typeof(ObjectResponse<LugarResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> BuscarPacienteByNombre([FromQuery] BuscarLugarByIdQuery rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la busqueda por nombre del paciente. {ex.Message}";
                _logger.LogError(ex, "{Message} -> {EMessage}", message, ex.Message);
                var rs = new GenericResponse()
                {
                    Code = 0,
                    Message = message
                };

                return StatusCode(500, rs);
            }
        }
    }
}
