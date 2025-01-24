using Application.Feature.Lugar.Commands;
using Application.Feature.Lugar.Queries;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Lugar;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controller.v1
{
    public class LugarController : BaseApiController
    {
        private readonly ILogger<RolController> _logger;

        public LugarController(ILogger<RolController> logger)
        {
            _logger = logger;
        }


        [HttpGet("Listado")]
        [ProducesResponseType(typeof(ObjectResponse<LugarResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> ObtenerLugar()
        {
            try
            {
                var rs = await Mediator.Send(new ObtenerLugarQuery());
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en el listado de lugares. {ex.Message}";
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
        [ProducesResponseType(typeof(ObjectResponse<LugarResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> AgregarLugar([FromBody] AgregarLugarCommand rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la inserción del lugar. {ex.Message}";
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
        [ProducesResponseType(typeof(ObjectResponse<LugarResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> ActualizarLugar([FromBody] ActualizarLugarCommand rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la actualización del lugar. {ex.Message}";
                _logger.LogError(ex, "{Message} -> {EMessage}", message, ex.Message);
                var rs = new GenericResponse()
                {
                    Code = 0,
                    Message = message
                };

                return StatusCode(500, rs);
            }
        }

        [HttpDelete("Eliminar")]
        [ProducesResponseType(typeof(ObjectResponse<LugarResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> EliminarLugar([FromBody] EliminarLugarCommand rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la eliminación del lugar. {ex.Message}";
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
        [ProducesResponseType(typeof(ObjectResponse<LugarResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> ActivarLugar([FromBody] ActivarLugarCommand rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la activación del lugar. {ex.Message}";
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
