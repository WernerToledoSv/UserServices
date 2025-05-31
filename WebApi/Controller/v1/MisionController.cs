using Application.Feature.Mision.Commands;
using Application.Feature.Mision.Queries;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Mision;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controller.v1
{
    public class MisionController : BaseApiController
    {
        private readonly ILogger<MisionController> _logger;

        public MisionController(ILogger<MisionController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Listado")]
        [ProducesResponseType(typeof(ListResponse<MisionResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> ObtenerMision()
        {
            try
            {
                var rs = await Mediator.Send(new ListadoMisionQuery());
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en el listado de Misiones. {ex.Message}";
                _logger.LogError(ex, "{Message} -> {EMessage}", message, ex.Message);
                var rs = new GenericResponse()
                {
                    Code = 0,
                    Message = message
                };

                return StatusCode(500, rs);
            }

        }

        [HttpGet("Buscar-Id")]
        [ProducesResponseType(typeof(ObjectResponse<MisionResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> BuscarMisionById([FromQuery] BuscarMisionByIdQuery rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la busqueda por id del mision. {ex.Message}";
                _logger.LogError(ex, "{Message} -> {EMessage}", message, ex.Message);
                var rs = new GenericResponse()
                {
                    Code = 0,
                    Message = message
                };

                return StatusCode(500, rs);
            }
        }

        [HttpGet("Buscar-Nombre")]
        [ProducesResponseType(typeof(ListResponse<MisionResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> BuscarMisionByNombre([FromQuery] BuscarMisionByNombreQuery rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la busqueda de mision por nombre. {ex.Message}";
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
        [ProducesResponseType(typeof(ObjectResponse<MisionResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> AgregarMision([FromBody] AgregarMisionCommand rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la inserción del mision. {ex.Message}";
                _logger.LogError(ex, "{Message} -> {EMessage}", message, ex.Message);
                var rs = new GenericResponse()
                {
                    Code = 0,
                    Message = message
                };

                return StatusCode(500, rs);
            }

        }

        [HttpPut("Actualizar")]
        [ProducesResponseType(typeof(ObjectResponse<MisionResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> ActualizarMision([FromBody] ActualizarMisionCommand rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la actualización del mision. {ex.Message}";
                _logger.LogError(ex, "{Message} -> {EMessage}", message, ex.Message);
                var rs = new GenericResponse()
                {
                    Code = 0,
                    Message = message
                };

                return StatusCode(500, rs);
            }
        }

        [HttpDelete("Cancelar")]
        [ProducesResponseType(typeof(ObjectResponse<MisionResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> EliminarMision([FromBody] CancelarMisionCommand rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la eliminación del mision. {ex.Message}";
                _logger.LogError(ex, "{Message} -> {EMessage}", message, ex.Message);
                var rs = new GenericResponse()
                {
                    Code = 0,
                    Message = message
                };

                return StatusCode(500, rs);
            }
        }

        [HttpPost("Activar")]
        [ProducesResponseType(typeof(ObjectResponse<MisionResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> ActivarMision([FromBody] ActivarMisionCommand rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la activación del mision. {ex.Message}";
                _logger.LogError(ex, "{Message} -> {EMessage}", message, ex.Message);
                var rs = new GenericResponse()
                {
                    Code = 0,
                    Message = message
                };

                return StatusCode(500, rs);
            }
        }

        [HttpPost("CambiarEstado")]
        [ProducesResponseType(typeof(ObjectResponse<MisionResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> ActivarMision([FromBody] CambiarEstadoMisionCommand rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la activación del mision. {ex.Message}";
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
