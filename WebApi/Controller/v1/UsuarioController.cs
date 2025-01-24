using Application.Feature.User.Queries;
using Application.Feature.Usuario.Commands;
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

    [HttpGet("Listado-Usuario")]
    [ProducesResponseType(typeof(ListResponse<UsuarioResponse>), 200)]
    [ProducesResponseType(typeof(GenericResponse), 500)]
    public async Task<IActionResult> ObtenerUsuario()
    {
        try
        {
            var rs = await Mediator.Send(new ObtenerUsuarioQuery());
            return Ok(rs);
        }
        catch (Exception ex) {

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

    [HttpPost("Agregar-Usuario")]
    [ProducesResponseType(typeof(ListResponse<UsuarioResponse>), 200)]
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
}