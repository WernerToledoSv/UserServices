using Application.Feature.Rol.Commands;
using Application.Feature.Rol.Queries;
using Application.Feature.User.Queries;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Rol;
using Domain.Entities.Services.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controller.v1
{
    public class RolController : BaseApiController
    {
        private readonly ILogger<RolController> _logger;

        public RolController(ILogger<RolController> logger)
        {
            _logger = logger;
        }

        [HttpGet("Listado")]
        [ProducesResponseType(typeof(ListResponse<RolResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> ObtenerUsuario()
        {
            try
            {
                var rs = await Mediator.Send(new ObtenerRolQuery());
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en obtencion del listado de Roles. {ex.Message}";
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
        [ProducesResponseType(typeof(ObjectResponse<RolResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> AgregarRol([FromBody] AgregarRolCommand rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la inserción del rol. {ex.Message}";
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
        [ProducesResponseType(typeof(ObjectResponse<RolResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> ActualizarRol([FromBody] ActualizarRolCommand rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la actualización del rol. {ex.Message}";
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
        [ProducesResponseType(typeof(ObjectResponse<RolResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> EliminarRol([FromBody] EliminarRolCommand rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la eliminacion del rol. {ex.Message}";
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
        [ProducesResponseType(typeof(ObjectResponse<RolResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> ActivarRol([FromBody] ActivarRolCommand rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la activación del rol. {ex.Message}";
                _logger.LogError(ex, "{Message} -> {EMessage}", message, ex.Message);
                var rs = new GenericResponse()
                {
                    Code = 0,
                    Message = message
                };

                return StatusCode(500, rs);
            }
        }

        [HttpGet("Burcar-Nombre")]
        [ProducesResponseType(typeof(ListResponse<RolResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> BuscarRolByNombre([FromQuery] BuscarRolByNombreQuery rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la busqueda por nombre del rol. {ex.Message}";
                _logger.LogError(ex, "{Message} -> {EMessage}", message, ex.Message);
                var rs = new GenericResponse()
                {
                    Code = 0,
                    Message = message
                };

                return StatusCode(500, rs);
            }
        }

        [HttpGet("Burcar-Id")]
        [ProducesResponseType(typeof(ObjectResponse<RolResponse>), 200)]
        [ProducesResponseType(typeof(GenericResponse), 500)]
        public async Task<IActionResult> BuscarRolById([FromQuery] BuscarRolByIdQuery rq)
        {
            try
            {
                var rs = await Mediator.Send(rq);
                return Ok(rs);
            }
            catch (Exception ex)
            {

                string message = $"Error fatal en la busqueda por id del rol. {ex.Message}";
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
