using Application.Feature.Rol.Commands;
using Application.Feature.UnionMisionLugar.Commands;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controller.v1
{
    public class UnionMisionLugarController : BaseApiController
    {
        private readonly ILogger<UnionMisionLugarController> _logger;

        public UnionMisionLugarController(ILogger<UnionMisionLugarController> logger)
        {
            _logger = logger;
        }

        [HttpPost("Agregar")]
        [ProducesResponseType(typeof(GenericResponse), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> AgregarUnion([FromBody] AgregarUnionCommand rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la inserción de la unión. {ex.Message}";
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
        [ProducesResponseType(typeof(GenericResponse), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> ActualizarUnion([FromBody] ActualizarUnionCommand rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la actualización de la unión. {ex.Message}";
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
        [ProducesResponseType(typeof(GenericResponse), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> EliminarRol([FromBody] EliminarUnionCommand rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la eliminacion de la unión. {ex.Message}";
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
