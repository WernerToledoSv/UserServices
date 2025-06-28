using Application.Feature.User.Queries;
using Application.Feature.Usuario.Commands;
using Application.Feature.Usuario.Queries;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Usuario;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controller.v1;

public class UsuarioController : BaseApiController
{
    private readonly ILogger<UsuarioController> _logger;

    public UsuarioController(ILogger<UsuarioController> logger)
    {
        _logger = logger;
    }

    [HttpGet("Listado")]
    [ProducesResponseType(typeof(ListResponse<UsuarioResponse>), 200)]
    [ProducesResponseType(typeof(GenericResponse), 500)]
    public async Task<IActionResult> ObtenerUsuario()
    {
        try
        {
            var rs = await Mediator.Send(new ObtenerUsuarioQuery());
            return Ok(rs);
        }
        catch (Exception ex)
        {

            string message = $"Error fatal en obtencion del listado de usuario.{ex.Message}";
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
    [ProducesResponseType(typeof(ObjectResponse<UsuarioResponse>), 200)]
    [ProducesResponseType(typeof(GenericResponse), 500)]
    public async Task<IActionResult> BuscarId([FromQuery] BuscarUsuarioByIdQuery rq)
    {
        try
        {
            var rs = await Mediator.Send(rq);
            return Ok(rs);
        }
        catch (Exception ex)
        {

            string message = $"Error fatal en obtencion del listado de usuario por id.{ex.Message}";
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
    [ProducesResponseType(typeof(ListResponse<UsuarioResponse>), 200)]
    [ProducesResponseType(typeof(GenericResponse), 500)]
    public async Task<IActionResult> BuscarNombre([FromQuery] BuscarUsuarioByNombreQuery rq)
    {
        try
        {
            var rs = await Mediator.Send(rq);
            return Ok(rs);
        }
        catch (Exception ex)
        {

            string message = $"Error fatal en obtencion del listado de usuario por nombre.{ex.Message}";
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
    [ProducesResponseType(typeof(ObjectResponse<UsuarioResponse>), 200)]
    [ProducesResponseType(typeof(GenericResponse), 500)]
    public async Task<IActionResult> AgregarUsuario([FromBody] IngresarUsuarioCommand rq)
    {
        try
        {
            var rs = await Mediator.Send(rq);
            return Ok(rs);
        }
        catch (Exception ex)
        {
            string message = $"Error fatal al ingresar el usuario. {ex.Message}";
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
    [ProducesResponseType(typeof(ObjectResponse<UsuarioResponse>), 200)]
    [ProducesResponseType(typeof(GenericResponse), 500)]
    public async Task<IActionResult> ActualizarUsuario([FromBody] ActualizarUsuarioCommand rq)
    {
        try
        {
            var rs = await Mediator.Send(rq);
            return Ok(rs);
        }
        catch (Exception ex)
        {
            string message = $"Error fatal al actualizar el usuario. {ex.Message}";
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
    [ProducesResponseType(typeof(ObjectResponse<UsuarioResponse>), 200)]
    [ProducesResponseType(typeof(GenericResponse), 500)]
    public async Task<IActionResult> EliminarUsuario([FromBody] EliminarUsuarioCommand rq)
    {
        try
        {
            var rs = await Mediator.Send(rq);
            return Ok(rs);
        }
        catch (Exception ex)
        {
            string message = $"Error fatal al eliminar el usuario. {ex.Message}";
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
    [ProducesResponseType(typeof(ObjectResponse<UsuarioResponse>), 200)]
    [ProducesResponseType(typeof(GenericResponse), 500)]
    public async Task<IActionResult> ActivarUsuario([FromBody] ActivarUsuarioCommand rq)
    {
        try
        {
            var rs = await Mediator.Send(rq);
            return Ok(rs);
        }
        catch (Exception ex)
        {
            string message = $"Error fatal al activar el usuario. {ex.Message}";
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