using Application.Feature.User.Queries;
using Application.Feature.Usuario.Commands;
using Domain.Entities.BaseResponse;
using Domain.Entities.Services.Queries.UserEntities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controller.v1;

public class UsuarioController : BaseApiController
{

    [HttpGet("ListadoUsuario")]
    [ProducesResponseType(typeof(ListResponse<UsuarioEntity>), 200)]
    [ProducesResponseType(typeof(GenericResponse), 500)]
    public async Task<IActionResult> ObtenerUsuario()
    {
        try
        {
            var rs = await Mediator.Send(new ObtenerUsuarioQuery());
            return Ok(rs);
        }
        catch (Exception ex) {
            var rs = new GenericResponse()
            {
                Code = 0,
                Message = "Error fatal en obtencion del listado de usuario."
            };

            return StatusCode(500, rs);
        }
        
    }

    [HttpPost("AgregarUsuario")]
    [ProducesResponseType(typeof(ListResponse<UsuarioEntity>), 200)]
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
            var rs = new GenericResponse()
            {
                Code = 0,
                Message = "Error fatal al ingresar el usuario."
            };

            return StatusCode(500, rs);
        }
    }
}