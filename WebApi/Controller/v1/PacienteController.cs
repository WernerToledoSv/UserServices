using Application.Feature.Mision.Commands;
using Application.Feature.Paciente.Commands;
using Application.Feature.Paciente.Queries;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Lugar;
using Domain.Entities.Services.Mision;
using Domain.Entities.Services.Paciente;
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

        [HttpGet("Listado-ByLugar")]
        [ProducesResponseType(typeof(ListResponse<PacienteResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> ObtenerPacienteByLugar([FromQuery] ObtenerPacienteByLugarQuery rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
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
        public async Task<IActionResult> BuscarPacienteByNombre([FromQuery] ObtenerPacienteByNombreQuery rq)
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

        [HttpPost("Agregar")]
        [ProducesResponseType(typeof(GenericResponse), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> AgregarPacietne([FromBody] CrearPacienteCommand rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la inserción del paciente. {ex.Message}";
                _logger.LogError(ex, "{Message} -> {EMessage}", message, ex.Message);
                var rs = new GenericResponse()
                {
                    Code = 0,
                    Message = message
                };

                return StatusCode(500, rs);
            }
        }

        [HttpPut("Editar")]
        [ProducesResponseType(typeof(GenericResponse), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> EditarPaciente([FromBody] EditarPacienteCommand rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la Edición del paciente. {ex.Message}";
                _logger.LogError(ex, "{Message} -> {EMessage}", message, ex.Message);
                var rs = new GenericResponse()
                {
                    Code = 0,
                    Message = message
                };

                return StatusCode(500, rs);
            }
        }

        [HttpPut("CambiarEstado")]
        [ProducesResponseType(typeof(GenericResponse), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> EstadoAtendido([FromBody] EstadoAtendidoCommand rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en el cambio de estado del paciente. {ex.Message}";
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
